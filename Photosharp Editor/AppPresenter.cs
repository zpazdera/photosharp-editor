using System;
using System.ComponentModel;

namespace Photosharp_Editor
{
    public class AppPresenter
    {
        private static readonly string _exportPath = "export/";

        private readonly AppForm _mainWindow = new();

        private readonly AppModel _model = new();

        public AppPresenter()
        {
            _mainWindow.FilesSelected = AddFiles;
            _mainWindow.EditingImageSelected = SelectImageAt;
            _mainWindow.RemoveImageAt = RemoveImageAt;
            _mainWindow.ExportImages = EditAndExportImages;
            _mainWindow.RotationAngleSet = EditingRotationAngleSet;
            _mainWindow.RotationDirectionSet = EditingRotationDirectionSet;
            _mainWindow.BrightnessLevelSet = EditingBrightnessSet;
			_mainWindow.GrayscaleFilterSet = GrayscaleFilterSet;

        }

        public void Run()
        {
            Application.Run(_mainWindow);
		}

		private void EditAndExportImages()
		{
			new ProgressForm("Exporting images", _model.Images.Count, ExportWorker_DoWork, index => _model.Images[index].Name).ShowDialog(_mainWindow);
		}

		// This code runs on a background thread when the worker is started
		private void ExportWorker_DoWork(object? sender, DoWorkEventArgs e)
        {
            BackgroundWorker? bw = sender as BackgroundWorker;

            Directory.CreateDirectory(_exportPath);

            for (int i = 0; i < _model.Images.Count; i++)
            {
                bw?.ReportProgress(i + 1);

                (string name, Bitmap bmp) = _model.Images[i];
                string filePath = _exportPath + name;
                int fileIndex = 2;
                while (File.Exists(filePath))
                {
                    filePath = $"{_exportPath}{Path.GetFileNameWithoutExtension(filePath)} ({fileIndex}){Path.GetExtension(filePath)}";
                }

                Bitmap editedBitmap = BitmapEditor.ProcessImage(bmp, _model.EditingOptions);
                editedBitmap.Save(filePath, bmp.RawFormat);

                if (bw?.CancellationPending == true)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void UpdateImagePreview()
        {
            if (_model.Images.Count == 0)
            {
                _mainWindow.UpdateImagePreview(null);
                return;
            }
            Cursor.Current = Cursors.WaitCursor;
            _mainWindow.UpdateImagePreview(BitmapEditor.ProcessImage(_model.Images[_model.SelectedIndex].bmp, _model.EditingOptions));
            Cursor.Current = Cursors.Default;
        }

        private void AddFiles(string[] filePaths)
		{
			Cursor.Current = Cursors.WaitCursor;
			foreach (string path in filePaths)
            {
                string fileName = Path.GetFileName(path);

                try
                {
                    Bitmap bitmap = new(path);
                    _model.Images.Add((fileName, bitmap));
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Provided file type is not supported.", fileName);
                }
                catch
                {
                    MessageBox.Show("Unexpected error ocurred. Please check that the path to file represents a valid image.", fileName);
                }
            }

            if (_model.Images.Count > 0)
            {
                UpdateImagePreview();
                _mainWindow.UpdateEditingImageList(_model.Images.Select(pair => pair.Name).ToList(), _model.SelectedIndex);
            }
			Cursor.Current = Cursors.Default;
		}

        private void RemoveImageAt(int index)
        {
            _model.Images.RemoveAt(index);
            if (_model.Images.Count > 0 && _model.Images.Count <= _model.SelectedIndex)
            {
                _model.SelectedIndex = _model.Images.Count - 1;
            }
            _mainWindow.UpdateEditingImageList(_model.Images.Select(pair => pair.Name).ToList(), _model.SelectedIndex);
            UpdateImagePreview();
        }

        private void SelectImageAt(int index)
        {
            _model.SelectedIndex = index;
            UpdateImagePreview();
        }

        private void EditingRotationAngleSet(EditingRotationAngle? angle)
        {
            _model.EditingOptions.RotationAngle = angle;
            UpdateImagePreview();
        }

        private void EditingRotationDirectionSet(EditingRotationDirection? direction)
        {
            _model.EditingOptions.RotationDirection = direction;
            UpdateImagePreview();
        }

        private void EditingBrightnessSet(byte brightnessLevel) 
        { 
            _model.EditingOptions.BrightnessLevel = brightnessLevel;
            UpdateImagePreview();
        }

        private void GrayscaleFilterSet(bool grayscaleEnabled)
        {
            _model.EditingOptions.ApplyGrayscale = grayscaleEnabled;
            UpdateImagePreview();
        }
    }
}
