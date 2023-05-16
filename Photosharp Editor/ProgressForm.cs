using System;
using System.ComponentModel;

namespace Photosharp_Editor
{
	public partial class ProgressForm : Form
	{
		private readonly Func<int, string> _itemNameForIndex;

		public ProgressForm(string title, int countToProcess, DoWorkEventHandler? doWork, Func<int, string> itemNameForIndex)
		{
			InitializeComponent();
			ProgressTitle.Text = title;
			ProgressBar.Maximum = countToProcess;
			_itemNameForIndex = itemNameForIndex;

			BackgroundWorker.DoWork += doWork;
			BackgroundWorker.ProgressChanged += ExportWorker_ProgressChanged;
			BackgroundWorker.RunWorkerCompleted += ExportWorker_RunWorkerCompleted;
			BackgroundWorker.WorkerSupportsCancellation = true;
			BackgroundWorker.WorkerReportsProgress = true;

			CancelButton = ProgressCancelButton;
		}

		protected override void OnShown(EventArgs e)
		{
			base.OnShown(e);
			BackgroundWorker.RunWorkerAsync();
		}

		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			base.OnFormClosing(e);
			BackgroundWorker.CancelAsync();
		}

		// This code runs on the UI thread when the worker reports progress
		private void ExportWorker_ProgressChanged(object? sender, ProgressChangedEventArgs e)
		{
			ProgressLabel.Text = $"Processing {_itemNameForIndex(e.ProgressPercentage - 1)}... ({e.ProgressPercentage}/{ProgressBar.Maximum})";
			ProgressBar.Value = e.ProgressPercentage;
		}

		// This code runs on the UI thread when the worker completes
		private void ExportWorker_RunWorkerCompleted(object? sender, RunWorkerCompletedEventArgs e)
		{
			Close();
		}
	}
}
