using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using TestExercise.Configuration;
using TestExercise.PanelItem;
using TestExercise.Data;
using System.Threading.Tasks;

namespace TestExercise
{
    public partial class MainForm : Form
    {
        public List<Profile> ProfileList { get; private set; }
        public List<string> FileNameList { get; private set; }

        private readonly WorkWithDir workWithDir;
        private FileSystemWatcher fileSystemWatcher;
        private Task updateInfoTask;
        private int tmpCount = 1; ///Для помощи в отслеживании файлов

        #region CtorAndInit
        public MainForm()
        {
            fileSystemWatcher = null;
            workWithDir = new WorkWithDir();
            FileNameList = new List<string>();
            ProfileList = new List<Profile>();

            InitializeComponent();

            this.Icon = SystemIcons.Shield;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pathTextBox.Text = Config.ImageSrcPath;
            Config.MaxCountItem = decimal.ToInt32(ribbonNumericUpDown.Value);
            SetColorSettings();
            if (!Directory.Exists(Config.ImageSrcPath))
                ClearMonitorAndOutputText("Неверно заданы настойки!");
            else
            {
                InitFileSystemWatcher();
                updateInfoTask = Task.Run(UpdateInfo, workWithDir.cts.Token);
            }
        }

        private void InitFileSystemWatcher()
        {
            fileSystemWatcher = new FileSystemWatcher
            {
                Path = Config.ImageSrcPath,
                Filter = "*.jpg",
                IncludeSubdirectories = true,
                EnableRaisingEvents = true,
                SynchronizingObject = monitorPanel,
                InternalBufferSize = 0,
                NotifyFilter = NotifyFilters.Attributes
                                 | NotifyFilters.CreationTime
                                 | NotifyFilters.DirectoryName
                                 | NotifyFilters.FileName
                                 | NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.Security
                                 | NotifyFilters.Size
            };

            fileSystemWatcher.Created += OnCreated;
            fileSystemWatcher.Error += OnError;

        }
        #endregion

        /// <summary>
        /// Полностью очищает FileNameList и ProfileList и заполняет новыми данными
        /// </summary>
        public void UpdateInfo()
        {
            ClearMonitorAndOutputText("Идет загрузка!");
            Config.ImageSrcPath = pathTextBox.Text;
            Config.TemperatureThreshold = decimal.ToSingle(temperatureNumericUpDown.Value);
            workWithDir.UpdateInfo(FileNameList, ProfileList);
            this.Invoke((Action)UpdateMonitor);
            SetColorSettings();
        }

        #region Implementation
        /// <summary>
        /// Логируем ошибки при отслеживании папки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnError(object sender, ErrorEventArgs e) =>
            File.WriteAllText(Config.logPath, e.GetException().Message + $"\nDate: {DateTime.Now}\n");

        /// <summary>
        /// Отслеживаем появление новых файлов в папке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            int tmp;
            if (!updateInfoTask.IsCompleted)
                updateInfoTask.Wait();

            monitorPanel.SuspendLayout();

            monitorPanel.VerticalScroll.Value = 0;
            if (monitorPanel.Controls.Count >= Config.MaxCountItem)
            {
                if (tmpCount > monitorPanel.Controls.Count)
                    tmp = monitorPanel.Controls.Count;
                else
                    tmp = tmpCount;
                monitorPanel.Controls.RemoveAt(monitorPanel.Controls.Count - tmp);
                if (tmpCount == int.MaxValue)
                    tmpCount = 0;
                tmpCount++;
            }

            FileNameList.Add(e.FullPath);
            workWithDir.UpdateProfileList(FileNameList[FileNameList.Count - 1], ProfileList);

            PanelItemControl user = new PanelItemControl(ProfileList[ProfileList.Count - 1])
            {
                Size = new Size(monitorPanel.ClientSize.Width, 70),
                Location = new Point(0, 0)
            };

            for (int i = 0; i < monitorPanel.Controls.Count; i++)    
                monitorPanel.Controls[i].Location = new Point(0, monitorPanel.Controls[i].Location.Y + 70);
            monitorPanel.Controls.Add(user);
            user.InvokeResizeEvent();
            monitorPanel.ResumeLayout();
        }

        /// <summary>
        /// Обработчик перехода по вкладкам
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    if (pathTextBox.BackColor == Config.errorBackColor
                        || temperatureNumericUpDown.BackColor == Config.errorBackColor)
                        tabControl.SelectedTab = configTab;
                    else
                    {
                        ribbonNumericUpDown.BackColor = Color.White;
                        if (fileSystemWatcher == null)
                            InitFileSystemWatcher();
                    }
                    break;
                case 1:
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Установка цвета для панелей настроек
        /// </summary>
        private void SetColorSettings()
        {
            PathTextBox_TextChanged(pathTextBox, new EventArgs());
            TemperatureNumericUpDown_ValueChanged(temperatureNumericUpDown, new EventArgs());
        }

        private void ClearMonitorAndOutputText(string text)
        {
            monitorPanel.Invoke((Action)(() => monitorPanel.Controls.Clear()));
            monitorPanel.Invoke((Action)(() => monitorPanel.VerticalScroll.Value = 0));
            monitorPanel.Invoke((Action)(() => monitorPanel.Controls.Add(new Label { Text = text, AutoSize = true })));
        }

        /// <summary>
        /// Обновляем содержимое панели "Монитор"
        /// </summary>
        private void UpdateMonitor()
        {
            monitorPanel.SuspendLayout();

            monitorPanel.Controls.Clear();
            monitorPanel.VerticalScroll.Value = 0;

            AddMonitorPanelElem(0);

            monitorPanel.ResumeLayout();
        }

        /// <summary>
        /// Обработчик изменения текста в текстбоксе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PathTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Directory.Exists(pathTextBox.Text))
                pathTextBox.BackColor = Config.errorBackColor;
            else
            {
                pathTextBox.BackColor = Config.goodBackColor;
                if (Config.ImageSrcPath != pathTextBox.Text)
                {
                    if (updateInfoTask == null || 
                        updateInfoTask.Status == TaskStatus.RanToCompletion || 
                        updateInfoTask.Status == TaskStatus.Faulted ||
                        updateInfoTask.Status == TaskStatus.Canceled)
                    {
                        updateInfoTask = Task.Run(UpdateInfo, workWithDir.cts.Token);
                    }
                    else if (updateInfoTask.Status == TaskStatus.Running ||
                        updateInfoTask.Status == TaskStatus.WaitingToRun ||
                        updateInfoTask.Status == TaskStatus.WaitingForActivation ||
                        updateInfoTask.Status == TaskStatus.Created)
                    {
                        workWithDir.cts.Cancel();
                        while (updateInfoTask.Status != TaskStatus.Faulted)
                        { }
                        updateInfoTask = Task.Run(UpdateInfo, workWithDir.cts.Token);
                    }
                }
            }
        }

        private void TemperatureNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Config.TemperatureThreshold = decimal.ToSingle(temperatureNumericUpDown.Value);
            temperatureNumericUpDown.BackColor = Config.goodBackColor;
        }

        /// <summary>
        /// Добавляем элементы на главную панель
        /// </summary>
        /// <param name="index"></param>
        private void AddMonitorPanelElem(int index)
        {
            monitorPanel.VerticalScroll.Value = 0;

            while (index < ProfileList.Count && index < Config.MaxCountItem)
            {
                PanelItemControl user = new PanelItemControl(ProfileList[index])
                {
                    Size = new Size(monitorPanel.ClientSize.Width, 70),
                    Location = new Point(0, 70 * index)
                };
                monitorPanel.Controls.Add(user);
                user.Invoke((Action)user.InvokeResizeEvent);
                index++;
            }
        }

        /// <summary>
        /// Удаляем элементы с главной панели
        /// </summary>
        /// <param name="count"></param>
        private void RemoveMonitorPanelElem()
        {
            for (int i = 0; monitorPanel.Controls.Count > Config.MaxCountItem; i++)
                monitorPanel.Controls.RemoveAt(monitorPanel.Controls.Count - 1);
        }


        /// <summary>
        /// Обработчик смены значения для кол-ва элементов в ленте
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RibbonNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int oldMaxCount = Config.MaxCountItem;
            Config.MaxCountItem = decimal.ToInt32(ribbonNumericUpDown.Value);
            ribbonNumericUpDown.BackColor = Color.Green;
            if (oldMaxCount < Config.MaxCountItem)
                AddMonitorPanelElem(oldMaxCount);
            else
                RemoveMonitorPanelElem();
        }

        /// <summary>
        /// Обработчик openBrowserDialogBtn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenBrowserDialogBtn_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog
            {
                RootFolder = Environment.SpecialFolder.Desktop,
                ShowNewFolderButton = false,
                Description = "Выберите папку с фотографиями!"
            };

            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                pathTextBox.Text = fbd.SelectedPath;
            fbd.Dispose();
        }
        #endregion
    }
}
