
namespace TestExercise
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.monitorTab = new System.Windows.Forms.TabPage();
            this.monitorPanel = new System.Windows.Forms.Panel();
            this.configTab = new System.Windows.Forms.TabPage();
            this.ribbonGroupBox = new System.Windows.Forms.GroupBox();
            this.ribbonNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ribbonHelpLabel = new System.Windows.Forms.Label();
            this.countPhotoLabel = new System.Windows.Forms.Label();
            this.temperatureGroupBox = new System.Windows.Forms.GroupBox();
            this.temperatureNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.temperatureHelpLabel = new System.Windows.Forms.Label();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.photoGroupBox = new System.Windows.Forms.GroupBox();
            this.photoHelpLabel = new System.Windows.Forms.Label();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.openBrowserDialogBtn = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl.SuspendLayout();
            this.monitorTab.SuspendLayout();
            this.configTab.SuspendLayout();
            this.ribbonGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonNumericUpDown)).BeginInit();
            this.temperatureGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureNumericUpDown)).BeginInit();
            this.photoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.monitorTab);
            this.tabControl.Controls.Add(this.configTab);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(483, 416);
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // monitorTab
            // 
            this.monitorTab.Controls.Add(this.monitorPanel);
            this.monitorTab.Location = new System.Drawing.Point(4, 25);
            this.monitorTab.Name = "monitorTab";
            this.monitorTab.Padding = new System.Windows.Forms.Padding(3);
            this.monitorTab.Size = new System.Drawing.Size(475, 387);
            this.monitorTab.TabIndex = 0;
            this.monitorTab.Text = "Монитор";
            this.monitorTab.UseVisualStyleBackColor = true;
            // 
            // monitorPanel
            // 
            this.monitorPanel.AutoScroll = true;
            this.monitorPanel.AutoScrollMargin = new System.Drawing.Size(3, 3);
            this.monitorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monitorPanel.Location = new System.Drawing.Point(3, 3);
            this.monitorPanel.Name = "monitorPanel";
            this.monitorPanel.Size = new System.Drawing.Size(469, 381);
            this.monitorPanel.TabIndex = 1;
            // 
            // configTab
            // 
            this.configTab.BackColor = System.Drawing.Color.Transparent;
            this.configTab.Controls.Add(this.ribbonGroupBox);
            this.configTab.Controls.Add(this.temperatureGroupBox);
            this.configTab.Controls.Add(this.photoGroupBox);
            this.configTab.Location = new System.Drawing.Point(4, 25);
            this.configTab.Name = "configTab";
            this.configTab.Padding = new System.Windows.Forms.Padding(3);
            this.configTab.Size = new System.Drawing.Size(475, 387);
            this.configTab.TabIndex = 1;
            this.configTab.Text = "Настройки";
            // 
            // ribbonGroupBox
            // 
            this.ribbonGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ribbonGroupBox.Controls.Add(this.ribbonNumericUpDown);
            this.ribbonGroupBox.Controls.Add(this.ribbonHelpLabel);
            this.ribbonGroupBox.Controls.Add(this.countPhotoLabel);
            this.ribbonGroupBox.Location = new System.Drawing.Point(6, 235);
            this.ribbonGroupBox.Name = "ribbonGroupBox";
            this.ribbonGroupBox.Size = new System.Drawing.Size(460, 106);
            this.ribbonGroupBox.TabIndex = 10;
            this.ribbonGroupBox.TabStop = false;
            this.ribbonGroupBox.Tag = "TemperatureTag";
            this.ribbonGroupBox.Text = "Лента";
            // 
            // ribbonNumericUpDown
            // 
            this.ribbonNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ribbonNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ribbonNumericUpDown.Location = new System.Drawing.Point(112, 65);
            this.ribbonNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ribbonNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ribbonNumericUpDown.Name = "ribbonNumericUpDown";
            this.ribbonNumericUpDown.Size = new System.Drawing.Size(334, 22);
            this.ribbonNumericUpDown.TabIndex = 8;
            this.ribbonNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ribbonNumericUpDown.ValueChanged += new System.EventHandler(this.RibbonNumericUpDown_ValueChanged);
            // 
            // ribbonHelpLabel
            // 
            this.ribbonHelpLabel.AutoSize = true;
            this.ribbonHelpLabel.Location = new System.Drawing.Point(16, 27);
            this.ribbonHelpLabel.Name = "ribbonHelpLabel";
            this.ribbonHelpLabel.Size = new System.Drawing.Size(275, 17);
            this.ribbonHelpLabel.TabIndex = 6;
            this.ribbonHelpLabel.Text = "Укажите количество элементов в ленте!";
            // 
            // countPhotoLabel
            // 
            this.countPhotoLabel.AutoSize = true;
            this.countPhotoLabel.Location = new System.Drawing.Point(16, 65);
            this.countPhotoLabel.Name = "countPhotoLabel";
            this.countPhotoLabel.Size = new System.Drawing.Size(90, 17);
            this.countPhotoLabel.TabIndex = 2;
            this.countPhotoLabel.Text = "Количество:";
            // 
            // temperatureGroupBox
            // 
            this.temperatureGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.temperatureGroupBox.Controls.Add(this.temperatureNumericUpDown);
            this.temperatureGroupBox.Controls.Add(this.temperatureHelpLabel);
            this.temperatureGroupBox.Controls.Add(this.temperatureLabel);
            this.temperatureGroupBox.Location = new System.Drawing.Point(6, 123);
            this.temperatureGroupBox.Name = "temperatureGroupBox";
            this.temperatureGroupBox.Size = new System.Drawing.Size(460, 106);
            this.temperatureGroupBox.TabIndex = 9;
            this.temperatureGroupBox.TabStop = false;
            this.temperatureGroupBox.Tag = "TemperatureTag";
            this.temperatureGroupBox.Text = "Температура";
            // 
            // temperatureNumericUpDown
            // 
            this.temperatureNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.temperatureNumericUpDown.DecimalPlaces = 2;
            this.temperatureNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.temperatureNumericUpDown.Location = new System.Drawing.Point(122, 65);
            this.temperatureNumericUpDown.Maximum = new decimal(new int[] {
            44,
            0,
            0,
            0});
            this.temperatureNumericUpDown.Minimum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.temperatureNumericUpDown.Name = "temperatureNumericUpDown";
            this.temperatureNumericUpDown.Size = new System.Drawing.Size(324, 22);
            this.temperatureNumericUpDown.TabIndex = 7;
            this.temperatureNumericUpDown.Value = new decimal(new int[] {
            370,
            0,
            0,
            65536});
            this.temperatureNumericUpDown.ValueChanged += new System.EventHandler(this.TemperatureNumericUpDown_ValueChanged);
            // 
            // temperatureHelpLabel
            // 
            this.temperatureHelpLabel.AutoSize = true;
            this.temperatureHelpLabel.Location = new System.Drawing.Point(16, 27);
            this.temperatureHelpLabel.Name = "temperatureHelpLabel";
            this.temperatureHelpLabel.Size = new System.Drawing.Size(298, 17);
            this.temperatureHelpLabel.TabIndex = 6;
            this.temperatureHelpLabel.Text = "Укажите пороговое значение температуры!";
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Location = new System.Drawing.Point(16, 65);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(100, 17);
            this.temperatureLabel.TabIndex = 2;
            this.temperatureLabel.Text = "Температура:";
            // 
            // photoGroupBox
            // 
            this.photoGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.photoGroupBox.Controls.Add(this.photoHelpLabel);
            this.photoGroupBox.Controls.Add(this.pathTextBox);
            this.photoGroupBox.Controls.Add(this.pathLabel);
            this.photoGroupBox.Controls.Add(this.openBrowserDialogBtn);
            this.photoGroupBox.Location = new System.Drawing.Point(6, 6);
            this.photoGroupBox.Name = "photoGroupBox";
            this.photoGroupBox.Size = new System.Drawing.Size(460, 111);
            this.photoGroupBox.TabIndex = 8;
            this.photoGroupBox.TabStop = false;
            this.photoGroupBox.Tag = "PhotosPathTag";
            this.photoGroupBox.Text = "Фотографии";
            // 
            // photoHelpLabel
            // 
            this.photoHelpLabel.AutoSize = true;
            this.photoHelpLabel.Location = new System.Drawing.Point(16, 27);
            this.photoHelpLabel.Name = "photoHelpLabel";
            this.photoHelpLabel.Size = new System.Drawing.Size(297, 17);
            this.photoHelpLabel.TabIndex = 6;
            this.photoHelpLabel.Text = "Укажите путь до каталога с фотографиями!";
            // 
            // pathTextBox
            // 
            this.pathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathTextBox.Location = new System.Drawing.Point(65, 71);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(347, 22);
            this.pathTextBox.TabIndex = 4;
            this.pathTextBox.TextChanged += new System.EventHandler(this.PathTextBox_TextChanged);
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(16, 71);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(43, 17);
            this.pathLabel.TabIndex = 2;
            this.pathLabel.Text = "Путь:";
            // 
            // openBrowserDialogBtn
            // 
            this.openBrowserDialogBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openBrowserDialogBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.openBrowserDialogBtn.Location = new System.Drawing.Point(418, 71);
            this.openBrowserDialogBtn.Name = "openBrowserDialogBtn";
            this.openBrowserDialogBtn.Size = new System.Drawing.Size(28, 23);
            this.openBrowserDialogBtn.TabIndex = 5;
            this.openBrowserDialogBtn.UseVisualStyleBackColor = false;
            this.openBrowserDialogBtn.Click += new System.EventHandler(this.OpenBrowserDialogBtn_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Выберите папку с фотографиями";
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 440);
            this.Controls.Add(this.tabControl);
            this.MinimumSize = new System.Drawing.Size(524, 487);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OnlineMonitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.monitorTab.ResumeLayout(false);
            this.configTab.ResumeLayout(false);
            this.ribbonGroupBox.ResumeLayout(false);
            this.ribbonGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonNumericUpDown)).EndInit();
            this.temperatureGroupBox.ResumeLayout(false);
            this.temperatureGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureNumericUpDown)).EndInit();
            this.photoGroupBox.ResumeLayout(false);
            this.photoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage monitorTab;
        private System.Windows.Forms.TabPage configTab;
        private System.Windows.Forms.GroupBox photoGroupBox;
        private System.Windows.Forms.Label photoHelpLabel;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Button openBrowserDialogBtn;
        private System.Windows.Forms.GroupBox temperatureGroupBox;
        private System.Windows.Forms.NumericUpDown temperatureNumericUpDown;
        private System.Windows.Forms.Label temperatureHelpLabel;
        private System.Windows.Forms.Label temperatureLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.GroupBox ribbonGroupBox;
        private System.Windows.Forms.NumericUpDown ribbonNumericUpDown;
        private System.Windows.Forms.Label ribbonHelpLabel;
        private System.Windows.Forms.Label countPhotoLabel;
        private System.Windows.Forms.Panel monitorPanel;
    }
}

