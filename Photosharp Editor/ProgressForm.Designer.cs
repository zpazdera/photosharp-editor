namespace Photosharp_Editor
{
    partial class ProgressForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ProgressBar = new ProgressBar();
            ProgressLabel = new Label();
            ProgressTitle = new Label();
            BackgroundWorker = new System.ComponentModel.BackgroundWorker();
            ProgressCancelButton = new Button();
            SuspendLayout();
            // 
            // ProgressBar
            // 
            ProgressBar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ProgressBar.Location = new Point(12, 83);
            ProgressBar.Name = "ProgressBar";
            ProgressBar.Size = new Size(307, 23);
            ProgressBar.TabIndex = 0;
            // 
            // ProgressLabel
            // 
            ProgressLabel.AutoSize = true;
            ProgressLabel.Location = new Point(12, 65);
            ProgressLabel.Name = "ProgressLabel";
            ProgressLabel.Size = new Size(80, 15);
            ProgressLabel.TabIndex = 2;
            ProgressLabel.Text = "ProgressLabel";
            // 
            // ProgressTitle
            // 
            ProgressTitle.AutoSize = true;
            ProgressTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ProgressTitle.Location = new Point(12, 12);
            ProgressTitle.Name = "ProgressTitle";
            ProgressTitle.Size = new Size(60, 21);
            ProgressTitle.TabIndex = 3;
            ProgressTitle.Text = "Header";
            // 
            // ProgressCancelButton
            // 
            ProgressCancelButton.Location = new Point(244, 136);
            ProgressCancelButton.Name = "ProgressCancelButton";
            ProgressCancelButton.Size = new Size(75, 23);
            ProgressCancelButton.TabIndex = 4;
            ProgressCancelButton.Text = "Cancel";
            ProgressCancelButton.UseVisualStyleBackColor = true;
            // 
            // ProgressForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 171);
            Controls.Add(ProgressCancelButton);
            Controls.Add(ProgressTitle);
            Controls.Add(ProgressLabel);
            Controls.Add(ProgressBar);
            Name = "ProgressForm";
            Text = "ProgressForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar ProgressBar;
        private Label ProgressLabel;
        private Label ProgressTitle;
        private System.ComponentModel.BackgroundWorker BackgroundWorker;
        private Button ProgressCancelButton;
    }
}