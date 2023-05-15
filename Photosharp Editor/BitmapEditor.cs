using System.Drawing.Imaging;

namespace Photosharp_Editor
{
    public class BitmapEditor
    {
        public static Bitmap ProcessImage(Bitmap image, EditSettings settings)
        {
            // Create new object so we do not modify the original
            Bitmap edited = new(image);

            if (settings.ApplyGrayscale) 
            {
                ApplyGrayscale(edited);
            }

            if (settings.BrightnessLevel != null)
            {
                AdjustBrightness(edited, (byte)settings.BrightnessLevel);
            }

            if (settings.RotationDirection != null && settings.RotationAngle != null)
            {
                Rotate(edited, (EditingRotationAngle)settings.RotationAngle, (EditingRotationDirection)settings.RotationDirection);
            }

            return edited;
        }

        private static void ApplyGrayscaleSimple(Bitmap image)
        {
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color pixel = image.GetPixel(x, y);

                    // Calculate the average value of the red, green, and blue values
                    int avg = (pixel.R + pixel.G + pixel.B) / 3;
                    image.SetPixel(x, y, Color.FromArgb(avg, avg, avg));
                }
            }
        }

        private static void AdjustBrightnessSimple(Bitmap image, byte brightnessLevel)
        {
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color pixel = image.GetPixel(x, y);

                    // Calculate the new brightness level for each value
                    int newRed = (pixel.R + brightnessLevel) > 255 ? 255 : pixel.R + brightnessLevel;
                    int newGreen = (pixel.G + brightnessLevel) > 255 ? 255 : pixel.G + brightnessLevel;
                    int newBlue = (pixel.B + brightnessLevel) > 255 ? 255 : pixel.B + brightnessLevel;

                    image.SetPixel(x, y, Color.FromArgb(pixel.A, newRed, newGreen, newBlue));
                }
            }
        }

        private static void ApplyGrayscale(Bitmap image)
        {
            // Create a color matrix with the grayscale values
            ColorMatrix colorMatrix =  new(new float[][] 
            {
                new float[] {0.299f, 0.299f, 0.299f, 0, 0},
                new float[] {0.587f, 0.587f, 0.587f, 0, 0},
                new float[] {0.114f, 0.114f, 0.114f, 0, 0},
                new float[] {0, 0, 0, 1, 0},
                new float[] {0, 0, 0, 0, 1}
            });

            ImageAttributes attributes = new();
            attributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            // Draw the image onto a new Bitmap with the color matrix applied
            using Graphics graphics = Graphics.FromImage(image);
            graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
        }

        private static void AdjustBrightness(Bitmap image, byte brightnessLevel)
        {
            float brightness = (float)brightnessLevel / 255;
            // Create a new ColorMatrix that adjusts brightness
            ColorMatrix colorMatrix = new(new float[][]
            {
                new float[] {1, 0, 0, 0, 0},
                new float[] {0, 1, 0, 0, 0},
                new float[] {0, 0, 1, 0, 0},
                new float[] {0, 0, 0, 1, 0},
                new float[] {brightness, brightness, brightness, 0, 1}
            });

            ImageAttributes attributes = new();
            attributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            // Draw the original image onto the new Bitmap using the ImageAttributes
            using Graphics graphics = Graphics.FromImage(image);
            graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
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
