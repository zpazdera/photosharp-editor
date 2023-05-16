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
			ProgressBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			ProgressBar.Location = new Point(22, 177);
			ProgressBar.Margin = new Padding(6);
			ProgressBar.Name = "ProgressBar";
			ProgressBar.Size = new Size(729, 49);
			ProgressBar.TabIndex = 0;
			// 
			// ProgressLabel
			// 
			ProgressLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			ProgressLabel.AutoSize = true;
			ProgressLabel.Location = new Point(22, 139);
			ProgressLabel.Margin = new Padding(6, 0, 6, 0);
			ProgressLabel.Name = "ProgressLabel";
			ProgressLabel.Size = new Size(160, 32);
			ProgressLabel.TabIndex = 2;
			ProgressLabel.Text = "ProgressLabel";
			// 
			// ProgressTitle
			// 
			ProgressTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			ProgressTitle.AutoSize = true;
			ProgressTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			ProgressTitle.Location = new Point(22, 26);
			ProgressTitle.Margin = new Padding(6, 0, 6, 0);
			ProgressTitle.Name = "ProgressTitle";
			ProgressTitle.Size = new Size(123, 45);
			ProgressTitle.TabIndex = 3;
			ProgressTitle.Text = "Header";
			// 
			// ProgressCancelButton
			// 
			ProgressCancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			ProgressCancelButton.Location = new Point(612, 294);
			ProgressCancelButton.Margin = new Padding(6);
			ProgressCancelButton.Name = "ProgressCancelButton";
			ProgressCancelButton.Size = new Size(139, 49);
			ProgressCancelButton.TabIndex = 4;
			ProgressCancelButton.Text = "Cancel";
			ProgressCancelButton.UseVisualStyleBackColor = true;
			// 
			// ProgressForm
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(774, 369);
			Controls.Add(ProgressCancelButton);
			Controls.Add(ProgressTitle);
			Controls.Add(ProgressLabel);
			Controls.Add(ProgressBar);
			Margin = new Padding(6);
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