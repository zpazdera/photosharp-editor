namespace Photosharp_Editor
{
    public class AppModel
    {
        public List<(string Name, Bitmap bmp)> Images = new();
        public int SelectedIndex = 0;
        public EditSettings EditingOptions = new();
    }
}
