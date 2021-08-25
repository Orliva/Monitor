using System;
using System.Drawing;
using System.Windows.Forms;
using TestExercise.Data;

namespace TestExercise.PanelItem
{
    public partial class PanelItemControl : UserControl
    {
        public Profile Profile { get; }
        private readonly Color borderColor;
        private readonly Color backColor;

        public PanelItemControl(Profile profile)
        {
            Profile = profile;
            borderColor = Profile.GetColor().Item1;
            backColor = Profile.GetColor().Item2;
            InitializeComponent();
        }

        public void InvokeResizeEvent() => PanelItemControl_Resize(this, new EventArgs());

        private void PanelItemControl_Load(object sender, EventArgs e)
        {
            SuspendLayout();

            ///PanelItemControl
            this.Resize += PanelItemControl_Resize;
            this.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            ///FlowLayoutPanel
            baseFlowLayoutPanel.BackColor = borderColor;

            ///PictureBox
            photoPictureBox.Image = Profile.Photo;
            photoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            photoPictureBox.Size = new Size(photoPictureBox.Width, photoPictureBox.Parent.Height - 1);

            ResumeLayout();
        }

        /// <summary>
        /// Resize используется для применения стилей и получения текущих размеров формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelItemControl_Resize(object sender, EventArgs e)
        {
            ///FlowLayoutPanel
            baseFlowLayoutPanel.Size = new Size(baseFlowLayoutPanel.Width, baseFlowLayoutPanel.Parent.Height - 1);

            ///Panel
            infoPanel.Size = new Size(infoPanel.Parent.Width - photoPictureBox.Width - 90, infoPanel.Parent.Height - 6);
            infoPanel.BackColor = backColor;

            temperaturePanel.Size = new Size(temperaturePanel.Parent.Width - infoPanel.Width - photoPictureBox.Width - 9, temperaturePanel.Parent.Height - 6);
            temperaturePanel.BackColor = backColor;

            ///Label
            FIOLabel.AutoSize = false;
            FIOLabel.Size = new Size(FIOLabel.Parent.Width, FIOLabel.Parent.Height / 2);
            FIOLabel.Location = new Point(0, 0);
            FIOLabel.TextAlign = ContentAlignment.MiddleCenter;
            FIOLabel.Text = Profile.GetFullNameStr();

            DateCreationLabel.AutoSize = false;
            DateCreationLabel.Size = new Size(DateCreationLabel.Parent.Width, DateCreationLabel.Parent.Height / 2);
            DateCreationLabel.Location = new Point(0, DateCreationLabel.Parent.Height / 2);
            DateCreationLabel.TextAlign = ContentAlignment.MiddleCenter;
            DateCreationLabel.Text = Profile.DateCreation.ToString();

            celsiusLabel.Size = new Size(celsiusLabel.Parent.Width / 2 - 20, celsiusLabel.Parent.Height / 2);
            celsiusLabel.Location = new Point(celsiusLabel.Parent.Width / 2 + 7, celsiusLabel.Parent.Height / 2 - 10 );

            temperatureValueLabel.Size = new Size(temperatureValueLabel.Parent.Width / 2 - 5, temperatureValueLabel.Parent.Height / 2);
            temperatureValueLabel.Location = new Point(7, temperatureValueLabel.Parent.Height / 2 - 10);
            temperatureValueLabel.TextAlign = ContentAlignment.TopRight;
            temperatureValueLabel.Text = Profile.Temperature.ToString();
        }
    }
}
