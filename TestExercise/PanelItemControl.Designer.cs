

namespace TestExercise.PanelItem
{
    partial class PanelItemControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.baseFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.DateCreationLabel = new System.Windows.Forms.Label();
            this.FIOLabel = new System.Windows.Forms.Label();
            this.temperaturePanel = new System.Windows.Forms.Panel();
            this.temperatureValueLabel = new System.Windows.Forms.Label();
            this.celsiusLabel = new System.Windows.Forms.Label();
            this.baseFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.infoPanel.SuspendLayout();
            this.temperaturePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // baseFlowLayoutPanel
            // 
            this.baseFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.baseFlowLayoutPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.baseFlowLayoutPanel.Controls.Add(this.photoPictureBox);
            this.baseFlowLayoutPanel.Controls.Add(this.infoPanel);
            this.baseFlowLayoutPanel.Controls.Add(this.temperaturePanel);
            this.baseFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.baseFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.baseFlowLayoutPanel.Name = "baseFlowLayoutPanel";
            this.baseFlowLayoutPanel.Size = new System.Drawing.Size(526, 64);
            this.baseFlowLayoutPanel.TabIndex = 0;
            this.baseFlowLayoutPanel.WrapContents = false;
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.photoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.photoPictureBox.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(100, 61);
            this.photoPictureBox.TabIndex = 0;
            this.photoPictureBox.TabStop = false;
            // 
            // infoPanel
            // 
            this.infoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoPanel.Controls.Add(this.DateCreationLabel);
            this.infoPanel.Controls.Add(this.FIOLabel);
            this.infoPanel.Location = new System.Drawing.Point(105, 3);
            this.infoPanel.Margin = new System.Windows.Forms.Padding(0, 3, 2, 3);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(225, 61);
            this.infoPanel.TabIndex = 2;
            // 
            // DateCreationLabel
            // 
            this.DateCreationLabel.AutoSize = true;
            this.DateCreationLabel.Location = new System.Drawing.Point(8, 33);
            this.DateCreationLabel.Name = "DateCreationLabel";
            this.DateCreationLabel.Size = new System.Drawing.Size(46, 17);
            this.DateCreationLabel.TabIndex = 1;
            this.DateCreationLabel.Text = "label2";
            // 
            // FIOLabel
            // 
            this.FIOLabel.AutoSize = true;
            this.FIOLabel.Location = new System.Drawing.Point(8, 6);
            this.FIOLabel.Name = "FIOLabel";
            this.FIOLabel.Size = new System.Drawing.Size(142, 17);
            this.FIOLabel.TabIndex = 0;
            this.FIOLabel.Text = "Ivanov Ivan Ivanovich";
            // 
            // temperaturePanel
            // 
            this.temperaturePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.temperaturePanel.Controls.Add(this.temperatureValueLabel);
            this.temperaturePanel.Controls.Add(this.celsiusLabel);
            this.temperaturePanel.Location = new System.Drawing.Point(332, 3);
            this.temperaturePanel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.temperaturePanel.Name = "temperaturePanel";
            this.temperaturePanel.Size = new System.Drawing.Size(93, 61);
            this.temperaturePanel.TabIndex = 3;
            // 
            // temperatureValueLabel
            // 
            this.temperatureValueLabel.Location = new System.Drawing.Point(21, 14);
            this.temperatureValueLabel.Name = "temperatureValueLabel";
            this.temperatureValueLabel.Size = new System.Drawing.Size(36, 17);
            this.temperatureValueLabel.TabIndex = 3;
            this.temperatureValueLabel.Text = "36.6";
            // 
            // celsiusLabel
            // 
            this.celsiusLabel.Location = new System.Drawing.Point(63, 14);
            this.celsiusLabel.Name = "celsiusLabel";
            this.celsiusLabel.Size = new System.Drawing.Size(23, 17);
            this.celsiusLabel.TabIndex = 2;
            this.celsiusLabel.Text = "°C";
            // 
            // PanelItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.baseFlowLayoutPanel);
            this.Name = "PanelItemControl";
            this.Size = new System.Drawing.Size(530, 70);
            this.Load += new System.EventHandler(this.PanelItemControl_Load);
            this.baseFlowLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.temperaturePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel baseFlowLayoutPanel;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.Label FIOLabel;
        private System.Windows.Forms.Label DateCreationLabel;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Panel temperaturePanel;
        private System.Windows.Forms.Label temperatureValueLabel;
        private System.Windows.Forms.Label celsiusLabel;
    }
}
