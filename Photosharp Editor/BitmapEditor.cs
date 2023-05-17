using System.Drawing.Imaging;

namespace Photosharp_Editor
{
    public class BitmapEditor
    {
        // These constants are adjusted based on how humans perceive different colors and should result in an image that looks to be closer to the original than if we just used the average values
        private static readonly float _grayscaleRed = 0.299f;
        private static readonly float _grayscaleBlue = 0.587f;
        private static readonly float _grayscaleGreen = 0.114f;

        public static Bitmap ProcessImage(Bitmap image, EditSettings settings)
        {
            // Create new object so we do not modify the original
            Bitmap edited = new(image);

            if (settings.ApplyGrayscale || settings.BrightnessLevel != null)
            {
                ApplyColorMatrixProperties(edited, settings.ApplyGrayscale, settings.BrightnessLevel);
            }

            if (settings.RotationDirection != null && settings.RotationAngle != null)
            {
                Rotate(edited, (EditingRotationAngle)settings.RotationAngle, (EditingRotationDirection)settings.RotationDirection);
            }

            return edited;
        }

        private static void ApplyColorMatrixProperties(Bitmap image, bool grayscale, byte? brightnessLevel)
        {
            float brightness = (float)(brightnessLevel ?? 0) / 255;

            float red = grayscale ? _grayscaleRed : 0;
            float green = grayscale ? _grayscaleGreen : 0;
            float blue = grayscale ? _grayscaleBlue : 0;

            // Create a new ColorMatrix that adjusts both brightness and grayscale
            ColorMatrix colorMatrix = new(new float[][]
            {
                new float[] {grayscale ? red : 1, red, red, 0, 0},
                new float[] {green, grayscale ? green : 1, green, 0, 0},
                new float[] {blue, blue, grayscale ? blue : 1, 0, 0},
                new float[] {0, 0, 0, 1, 0},
                new float[] {brightness, brightness, brightness, 0, 1}
            });

            ImageAttributes attributes = new();
            attributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            // Draw the original image onto the new Bitmap using the ImageAttributes
            using Graphics graphics = Graphics.FromImage(image);
            graphics.DrawImage(image, new(0, 0, image.Width, image.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
        }

        private static void Rotate(Bitmap image, EditingRotationAngle angle, EditingRotationDirection direction)
        {
            var rotationType = angle switch
            {
                EditingRotationAngle.Ninety => (direction == EditingRotationDirection.Right) ? RotateFlipType.Rotate90FlipNone : RotateFlipType.Rotate270FlipNone,
                _ => RotateFlipType.Rotate180FlipNone,
            };
            image.RotateFlip(rotationType);
        }
    }
}
