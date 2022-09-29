using System.Drawing;
using System.Windows.Forms;

namespace Drawing.Services
{
    internal class Rectangle
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int Size { get; set; }

        public int SensorValue { get; set; }

        private PictureBox _pictureBox;

        public Rectangle(int size, int x, int y, int sensorValue, PictureBox pictureBox)
        {
            Size = size;
            X = x;
            Y = y;
            SensorValue = sensorValue;
            _pictureBox = pictureBox;

            Draw();
        }

        private void Draw()
        {
            using (var pen = new Pen(Color.Black))
            {
                using (var brush = new SolidBrush(Color.Red))
                {
                    using (var graphics = Graphics.FromImage(_pictureBox.Image))
                    {
                        graphics.FillRectangle(brush, X, Y, Size, Size);
                        graphics.DrawRectangle(pen, X, Y, Size - 1, Size - 1);

                        using (var font = new Font("Verdana", 9, FontStyle.Regular, GraphicsUnit.Point))
                        {
                            var width = SensorValue.ToString().Length;
                            var flags = TextFormatFlags.WordBreak;
                            var centerOfRectangle = new Point((int)(X + Size / 2 - width * (font.Size / 2)), (int)(Y + Size / 2 - font.Size / 2));
                            TextRenderer.DrawText(graphics, $"{SensorValue}", font, centerOfRectangle, Color.Black, Color.Transparent, flags);
                        }
                    }
                }
            }
        }
    }
}
