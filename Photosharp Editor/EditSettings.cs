namespace Photosharp_Editor
{
    public class EditSettings
    {
        public byte? BrightnessLevel;
        public bool ApplyGrayscale = false;
        public EditingRotationAngle? RotationAngle;
        public EditingRotationDirection? RotationDirection;
    }

    public enum EditingRotationAngle
    {
        Ninety,
        OneEighty
    }

    public enum EditingRotationDirection 
    { 
        Left,
        Right
    }
}
