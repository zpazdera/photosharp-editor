namespace Photosharp_Editor
{
    public partial class AppForm : Form
    {
        public Action<string[]>? FilesSelected { get; set; }
        public Action<int>? EditingImageSelected { get; set; }
        public Action<int>? RemoveImageAt { get; set; }
        public Action? ExportImages { get; set; }

        // Editing options
        public Action<EditingRotationAngle?>? RotationAngleSet { get; set; }
        public Action<EditingRotationDirection?>? RotationDirectionSet { get; set; }
        public Action<bool>? GrayscaleFilterSet { get; set; }
        public Action<byte>? BrightnessLevelSet { get; set; }

        public AppForm()
        {
            InitializeComponent();
            ImagePreview.SizeMode = PictureBoxSizeMode.Zoom;
            RemoveFileButton.Enabled = false;
            ExportButton.Enabled = false;
        }

        public void UpdateImagePreview(Bitmap? image)
        {
            ImagePreview.Image = image;
        }

        public void UpdateEditingImageList(List<string> fileNames, int selectedIndex)
        {
            EditingImageList.DataSource = fileNames;
            bool notEmpty = fileNames.Count > 0;
            if (notEmpty)
            {
                EditingImageList.SelectedIndex = selectedIndex;
            }
            RemoveFileButton.Enabled = notEmpty;
            ExportButton.Enabled = notEmpty;
        }

        private void AddFilesButton_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new();
            ofd.RestoreDirectory = true;
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] fileNames = ofd.FileNames;
                FilesSelected?.Invoke(fileNames);
            }
        }

        private void RemoveFileButton_Click(object sender, EventArgs e)
        {
            RemoveImageAt?.Invoke(EditingImageList.SelectedIndex);
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            ExportImages?.Invoke();
        }

        private void EditingImageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            EditingImageSelected?.Invoke(EditingImageList.SelectedIndex);
        }

        private void EnableRotationCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            RotationControlBox.Enabled = EnableRotationCheckbox.Checked;
            if (RotationControlBox.Enabled)
            {
                if (RotateNinetyCheckbox.Checked)
                {
                    RotationAngleSet?.Invoke(EditingRotationAngle.Ninety);
                }

                if (RotateOneEightyCheckbox.Checked)
                {
                    RotationAngleSet?.Invoke(EditingRotationAngle.OneEighty);
                }

                if (RotateLeftCheckbox.Checked)
                {
                    RotationDirectionSet?.Invoke(EditingRotationDirection.Left);
                }

                if (RotateRightCheckbox.Checked)
                {
                    RotationDirectionSet?.Invoke(EditingRotationDirection.Right);
                }
            }
            else
            {
                RotationAngleSet?.Invoke(null);
                RotationDirectionSet?.Invoke(null);
            }
        }

        private void RotateNinetyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (RotateNinetyCheckbox.Checked)
            {
                RotateOneEightyCheckbox.Checked = false;
                RotationAngleSet?.Invoke(EditingRotationAngle.Ninety);
            }
            else
            {
                RotationAngleSet?.Invoke(null);
            }
        }

        private void RotateOneEightyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (RotateOneEightyCheckbox.Checked)
            {
                RotateNinetyCheckbox.Checked = false;
                RotationAngleSet?.Invoke(EditingRotationAngle.OneEighty);
            }
            else
            {
                RotationAngleSet?.Invoke(null);
            }
        }

        private void RotateLeftCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (RotateLeftCheckbox.Checked)
            {
                RotateRightCheckbox.Checked = false;
                RotationDirectionSet?.Invoke(EditingRotationDirection.Left);
            }
            else
            {
                RotationDirectionSet?.Invoke(null);
            }
        }

        private void RotateRightCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (RotateRightCheckbox.Checked)
            {
                RotateLeftCheckbox.Checked = false;
                RotationDirectionSet?.Invoke(EditingRotationDirection.Right);
            }
            else
            {
                RotationDirectionSet?.Invoke(null);
            }
        }

        private void BrightnessTrackBar_Scroll(object sender, EventArgs e)
        {
            BrightnessLevelSet?.Invoke((byte)(BrightnessTrackBar.Value * 10));
        }

        private void GrayscaleCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            GrayscaleFilterSet?.Invoke(GrayscaleCheckbox.Checked);
        }
    }
}