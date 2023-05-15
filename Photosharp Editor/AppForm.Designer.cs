namespace Photosharp_Editor
{
    partial class AppForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ImagePreview = new PictureBox();
            EnableRotationCheckbox = new CheckBox();
            BrightnessTrackBar = new TrackBar();
            BrightnessLabel = new Label();
            GrayscaleCheckbox = new CheckBox();
            RotateNinetyCheckbox = new CheckBox();
            RotateOneEightyCheckbox = new CheckBox();
            RotateLeftCheckbox = new CheckBox();
            RotateRightCheckbox = new CheckBox();
            RotationControlBox = new GroupBox();
            ExportButton = new Button();
            RemoveFileButton = new Button();
            EditingImageList = new ListBox();
            AddFilesButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ImagePreview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BrightnessTrackBar).BeginInit();
            RotationControlBox.SuspendLayout();
            SuspendLayout();
            // 
            // ImagePreview
            // 
            ImagePreview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ImagePreview.BackColor = SystemColors.ControlLightLight;
            ImagePreview.BorderStyle = BorderStyle.Fixed3D;
            ImagePreview.Location = new Point(12, 12);
            ImagePreview.Name = "ImagePreview";
            ImagePreview.Size = new Size(484, 207);
            ImagePreview.TabIndex = 1;
            ImagePreview.TabStop = false;
            // 
            // EnableRotationCheckbox
            // 
            EnableRotationCheckbox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            EnableRotationCheckbox.AutoSize = true;
            EnableRotationCheckbox.Location = new Point(154, 225);
            EnableRotationCheckbox.Name = "EnableRotationCheckbox";
            EnableRotationCheckbox.Size = new Size(60, 19);
            EnableRotationCheckbox.TabIndex = 17;
            EnableRotationCheckbox.Text = "Rotate";
            EnableRotationCheckbox.UseVisualStyleBackColor = true;
            EnableRotationCheckbox.CheckedChanged += EnableRotationCheckbox_CheckedChanged;
            // 
            // BrightnessTrackBar
            // 
            BrightnessTrackBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BrightnessTrackBar.Location = new Point(24, 249);
            BrightnessTrackBar.Maximum = 25;
            BrightnessTrackBar.Name = "BrightnessTrackBar";
            BrightnessTrackBar.Size = new Size(104, 45);
            BrightnessTrackBar.TabIndex = 16;
            BrightnessTrackBar.Scroll += BrightnessTrackBar_Scroll;
            // 
            // BrightnessLabel
            // 
            BrightnessLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BrightnessLabel.AutoSize = true;
            BrightnessLabel.Location = new Point(28, 225);
            BrightnessLabel.Name = "BrightnessLabel";
            BrightnessLabel.Size = new Size(62, 15);
            BrightnessLabel.TabIndex = 15;
            BrightnessLabel.Text = "Brightness";
            // 
            // GrayscaleCheckbox
            // 
            GrayscaleCheckbox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            GrayscaleCheckbox.AutoSize = true;
            GrayscaleCheckbox.Location = new Point(316, 225);
            GrayscaleCheckbox.Name = "GrayscaleCheckbox";
            GrayscaleCheckbox.Size = new Size(76, 19);
            GrayscaleCheckbox.TabIndex = 12;
            GrayscaleCheckbox.Text = "Grayscale";
            GrayscaleCheckbox.UseVisualStyleBackColor = true;
            GrayscaleCheckbox.CheckedChanged += GrayscaleCheckbox_CheckedChanged;
            // 
            // RotateNinetyCheckbox
            // 
            RotateNinetyCheckbox.AutoSize = true;
            RotateNinetyCheckbox.Location = new Point(16, 22);
            RotateNinetyCheckbox.Name = "RotateNinetyCheckbox";
            RotateNinetyCheckbox.Size = new Size(43, 19);
            RotateNinetyCheckbox.TabIndex = 13;
            RotateNinetyCheckbox.Text = "90°";
            RotateNinetyCheckbox.UseVisualStyleBackColor = true;
            RotateNinetyCheckbox.CheckedChanged += RotateNinetyCheckbox_CheckedChanged;
            // 
            // RotateOneEightyCheckbox
            // 
            RotateOneEightyCheckbox.AutoSize = true;
            RotateOneEightyCheckbox.Location = new Point(16, 47);
            RotateOneEightyCheckbox.Name = "RotateOneEightyCheckbox";
            RotateOneEightyCheckbox.Size = new Size(49, 19);
            RotateOneEightyCheckbox.TabIndex = 14;
            RotateOneEightyCheckbox.Text = "180°";
            RotateOneEightyCheckbox.UseVisualStyleBackColor = true;
            RotateOneEightyCheckbox.CheckedChanged += RotateOneEightyCheckbox_CheckedChanged;
            // 
            // RotateLeftCheckbox
            // 
            RotateLeftCheckbox.AutoSize = true;
            RotateLeftCheckbox.Location = new Point(70, 22);
            RotateLeftCheckbox.Name = "RotateLeftCheckbox";
            RotateLeftCheckbox.Size = new Size(46, 19);
            RotateLeftCheckbox.TabIndex = 15;
            RotateLeftCheckbox.Text = "Left";
            RotateLeftCheckbox.UseVisualStyleBackColor = true;
            RotateLeftCheckbox.CheckedChanged += RotateLeftCheckbox_CheckedChanged;
            // 
            // RotateRightCheckbox
            // 
            RotateRightCheckbox.AutoSize = true;
            RotateRightCheckbox.Location = new Point(70, 47);
            RotateRightCheckbox.Name = "RotateRightCheckbox";
            RotateRightCheckbox.Size = new Size(54, 19);
            RotateRightCheckbox.TabIndex = 16;
            RotateRightCheckbox.Text = "Right";
            RotateRightCheckbox.UseVisualStyleBackColor = true;
            RotateRightCheckbox.CheckedChanged += RotateRightCheckbox_CheckedChanged;
            // 
            // RotationControlBox
            // 
            RotationControlBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RotationControlBox.Controls.Add(RotateRightCheckbox);
            RotationControlBox.Controls.Add(RotateLeftCheckbox);
            RotationControlBox.Controls.Add(RotateOneEightyCheckbox);
            RotationControlBox.Controls.Add(RotateNinetyCheckbox);
            RotationControlBox.Enabled = false;
            RotationControlBox.Location = new Point(154, 250);
            RotationControlBox.Name = "RotationControlBox";
            RotationControlBox.Size = new Size(140, 76);
            RotationControlBox.TabIndex = 11;
            RotationControlBox.TabStop = false;
            RotationControlBox.Text = "Rotation";
            // 
            // ExportButton
            // 
            ExportButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ExportButton.Location = new Point(502, 290);
            ExportButton.Name = "ExportButton";
            ExportButton.Size = new Size(214, 36);
            ExportButton.TabIndex = 4;
            ExportButton.Text = "Export";
            ExportButton.UseVisualStyleBackColor = true;
            ExportButton.Click += ExportButton_Click;
            // 
            // RemoveFileButton
            // 
            RemoveFileButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RemoveFileButton.Location = new Point(612, 232);
            RemoveFileButton.Name = "RemoveFileButton";
            RemoveFileButton.Size = new Size(104, 36);
            RemoveFileButton.TabIndex = 3;
            RemoveFileButton.Text = "Remove File";
            RemoveFileButton.UseVisualStyleBackColor = true;
            RemoveFileButton.Click += RemoveFileButton_Click;
            // 
            // EditingImageList
            // 
            EditingImageList.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EditingImageList.FormattingEnabled = true;
            EditingImageList.ItemHeight = 15;
            EditingImageList.Location = new Point(502, 12);
            EditingImageList.Name = "EditingImageList";
            EditingImageList.Size = new Size(214, 214);
            EditingImageList.TabIndex = 2;
            EditingImageList.SelectedIndexChanged += EditingImageList_SelectedIndexChanged;
            // 
            // AddFilesButton
            // 
            AddFilesButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddFilesButton.Location = new Point(502, 232);
            AddFilesButton.Name = "AddFilesButton";
            AddFilesButton.Size = new Size(104, 36);
            AddFilesButton.TabIndex = 0;
            AddFilesButton.Text = "Add File(s)";
            AddFilesButton.UseVisualStyleBackColor = true;
            AddFilesButton.Click += AddFilesButton_Click;
            // 
            // AppForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(728, 341);
            Controls.Add(EnableRotationCheckbox);
            Controls.Add(BrightnessTrackBar);
            Controls.Add(BrightnessLabel);
            Controls.Add(GrayscaleCheckbox);
            Controls.Add(RotationControlBox);
            Controls.Add(ExportButton);
            Controls.Add(RemoveFileButton);
            Controls.Add(EditingImageList);
            Controls.Add(ImagePreview);
            Controls.Add(AddFilesButton);
            MinimumSize = new Size(640, 380);
            Name = "AppForm";
            Text = "Photosharp Editor";
            ((System.ComponentModel.ISupportInitialize)ImagePreview).EndInit();
            ((System.ComponentModel.ISupportInitialize)BrightnessTrackBar).EndInit();
            RotationControlBox.ResumeLayout(false);
            RotationControlBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ImagePreview;
        private CheckBox EnableRotationCheckbox;
        private TrackBar BrightnessTrackBar;
        private Label BrightnessLabel;
        private CheckBox GrayscaleCheckbox;
        private CheckBox RotateNinetyCheckbox;
        private CheckBox RotateOneEightyCheckbox;
        private CheckBox RotateLeftCheckbox;
        private CheckBox RotateRightCheckbox;
        private GroupBox RotationControlBox;
        private Button ExportButton;
        private Button RemoveFileButton;
        private ListBox EditingImageList;
        private Button AddFilesButton;
    }
}