using System.Drawing;
using System.Windows.Forms;

namespace Drawing.Services
{
    internal class Ellipse
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int Size { get; set; }

        public int SensorValue { get; set; }

        private PictureBox _pictureBox;

        public Ellipse(int size, int x, int y, int sensorValue, PictureBox pictureBox)
        {
            X = x;
            Y = y;
            Size = size;
            SensorValue = sensorValue;
            _pictureBox = pictureBox;

            Draw();
        }

        private void Draw()
        {
            using (var pen = new Pen(Color.Black))
            {
                using (var brush = new SolidBrush(Color.Aqua))
                {
                    using (var graphics = Graphics.FromImage(_pictureBox.Image))
                    {
                        graphics.FillEllipse(brush, X, Y, Size, Size);
                        graphics.DrawEllipse(pen, X, Y, Size, Size);

                        using (var font = new Font("Verdana", 9, FontStyle.Regular, GraphicsUnit.Point))
                        {
                            var width = SensorValue.ToString().Length;
                            var flags = TextFormatFlags.WordBreak;
                            var centerOfEllipse = new Point((int)(X + Size / 2 - width * (font.Size / 2)), (int)(Y + Size / 2 - font.Size / 2));
                            TextRenderer.DrawText(graphics, $"{SensorValue}", font, centerOfEllipse, Color.Black, Color.Transparent, flags);
                        }
                    }
                }
            }
        }
    }
}
