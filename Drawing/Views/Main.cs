using Client.Services;
using Drawing.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rectangle = Drawing.Services.Rectangle;

namespace Drawing
{
    public partial class Main : Form
    {
        private Rectangle _rectangle;
        private Ellipse _ellipse;
        private Objects _objects;
        private string _objName = "";

        public Main()
        {
            InitializeComponent();
        }

        private void DrawRandomObjects(int randomObject, int x, int y, int size, int randomSensorValue)
        {
            if (randomObject == 1)
            {
                _rectangle = new Rectangle(size, x, y, randomSensorValue, Paint_PB);
                _objects = new Objects()
                {
                    XAxis = _rectangle.X,
                    YAxis = _rectangle.Y,
                    Size = _rectangle.Size,
                    SensorValue = _rectangle.SensorValue,
                    Name = "Прямоугольник",
                };
                _objName = "Прямоугольник";
            }
            else
            {
                _ellipse = new Ellipse(size, x, y, randomSensorValue, Paint_PB);
                _objects = new Objects()
                {
                    XAxis = _ellipse.X,
                    YAxis = _ellipse.Y,
                    Size = _ellipse.Size,
                    SensorValue = _ellipse.SensorValue,
                    Name = "Эллипс",
                };
                _objName = "Эллипс";
            }
        }

        private void ResetFields()
        {
            Size_TB.Text = string.Empty;
            X_TB.Text = string.Empty;
            Y_TB.Text = string.Empty;
            SensorValue_TB.Text = string.Empty;
        }

        private void DrawRectangle(int x, int y, int size, int sensorValue)
        {
            Paint_PB.Image = new Bitmap(Paint_PB.Width, Paint_PB.Height);
            _rectangle = new Rectangle(size, x, y, sensorValue, Paint_PB);
        }

        private void DrawEllipse(int x, int y, int size, int sensorValue)
        {
            Paint_PB.Image = new Bitmap(Paint_PB.Width, Paint_PB.Height);
            _ellipse = new Ellipse(size, x, y, sensorValue, Paint_PB);
        }

        private void ListBoxItem<T>(T item)
        {
            Data_LB.Items.Add(item);
            Data_LB.DisplayMember = "Name";
        }

        private void Paint_PB_MouseClick(object sender, MouseEventArgs e)
        {
            var randomSize = new Random().Next(5, 11);
            var size = Paint_PB.Width / randomSize;
            var randomSensorValue = new Random().Next(1, 1001);
            var randomObject = new Random().Next(1, 3);
            
            Paint_PB.Image = new Bitmap(Paint_PB.Width, Paint_PB.Height);

            DrawRandomObjects(randomObject, e.X, e.Y, size, randomSensorValue);

            X_TB.Text = e.X.ToString();
            Y_TB.Text = e.Y.ToString();
            Size_TB.Text = size.ToString();
            SensorValue_TB.Text = randomSensorValue.ToString();

            ListBoxItem(_objects);
        }

        private void Data_LB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var obj = Data_LB.SelectedItem as Objects;

            Paint_PB.Image = new Bitmap(Paint_PB.Width, Paint_PB.Height);

            switch (obj.Name)
            {
                case "Прямоугольник":
                    DrawRectangle(obj.XAxis, obj.YAxis, obj.Size, obj.SensorValue);
                    _objName = obj.Name;
                    break;
                case "Эллипс":
                    DrawEllipse(obj.XAxis, obj.YAxis, obj.Size, obj.SensorValue);
                    _objName = obj.Name;
                    break;
                default:
                    if (new Random().Next(1, 3) == 1)
                    {
                        DrawEllipse(5, 5, 5, 2);
                    }
                    else
                    {
                        DrawRectangle(2, 2, 2, 2);
                    }
                    break;
            }

            X_TB.Text = obj.XAxis.ToString();
            Y_TB.Text = obj.YAxis.ToString();
            Size_TB.Text = obj.Size.ToString();
            SensorValue_TB.Text = obj.SensorValue.ToString();
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Validation();

                int randomObj = new Random().Next(1, 3);
                int size = int.Parse(Size_TB.Text);
                int x = int.Parse(X_TB.Text);
                int y = int.Parse(Y_TB.Text);
                int sensorValue = int.Parse(SensorValue_TB.Text);

                Paint_PB.Image = new Bitmap(Paint_PB.Width, Paint_PB.Height);

                switch (_objName)
                {
                    case "Прямоугольник":
                        DrawRectangle(x, y, size, sensorValue);
                        break;
                    case "Эллипс":
                        DrawEllipse(x, y, size, sensorValue);
                        break;
                    default:
                        DrawRandomObjects(randomObj, x, y, size, sensorValue);
                        break;
                }

                ListBoxItem(new Objects()
                {
                    XAxis = x,
                    YAxis = y,
                    SensorValue = sensorValue,
                    Size = size,
                    Name = _objName,
                });

                ResetFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            if (Data_LB.SelectedIndex == -1)
            {
                MessageBox.Show("Выберете поле");
            }

            for (int i = 0; i < Data_LB.SelectedItems.Count; i++)
            {
                Data_LB.Items.Remove(Data_LB.SelectedItems[i]);
                Paint_PB.Image = null;
                ResetFields();
            }
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            if (Data_LB.Items.Count != 0)
            {
                var list = new List<Objects>();

                for (int i = 0; i < Data_LB.Items.Count; i++)
                {
                    list.Add((Objects)Data_LB.Items[i]);
                }

                Save_D.FileName = "";
                Save_D.Filter = "json files(*.json)|*.json";
                Save_D.FilterIndex = 1;

                if (Save_D.ShowDialog() == DialogResult.OK)
                {
                    using (var stream = File.Open(Save_D.FileName, FileMode.Create))
                    {
                        var formatter = new BinaryFormatter();
                        formatter.Serialize(stream, list);
                    }
                }
            }
            else
            {
                MessageBox.Show("Чтобы сохранить список пуст");
            }
        }

        private void Upload_Btn_Click(object sender, EventArgs e)
        {
            var objects = new List<Objects>();

            Open_D.FileName = "";
            Open_D.Filter = "json files(*.json)|*.json";
            Open_D.FilterIndex = 1;

            if (Open_D.ShowDialog() == DialogResult.OK)
            {
                using (var stream = File.Open(Open_D.FileName, FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    objects = (List<Objects>)formatter.Deserialize(stream);
                }
            }

            if (Data_LB.Items.Count != 0)
            {
                for (int i = 0; i < objects.Count; i++)
                {
                    var obj = Data_LB.Items[i] as Objects;

                    if (obj.Id == objects[i].Id)
                    {
                        obj.Id = objects[i].Id;
                        obj.XAxis = objects[i].XAxis;
                        obj.YAxis = objects[i].YAxis;
                        obj.Size = objects[i].Size;
                        obj.SensorValue = 25;
                        obj.Name = objects[i].Name;
                    }

                    Data_LB.Items[i] = obj;

                    Paint_PB.Image = null;
                    ResetFields();

                    switch (obj.Name)
                    {
                        case "Прямоугольник":
                            DrawRectangle(obj.XAxis, obj.YAxis, obj.Size, obj.SensorValue);
                            break;
                        case "Эллипс":
                            DrawEllipse(obj.XAxis, obj.YAxis, obj.Size, obj.SensorValue);
                            break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < objects.Count; i++)
                {
                    Paint_PB.Image = null;
                    ResetFields();

                    switch (objects[i].Name)
                    {
                        case "Прямоугольник":
                            DrawRectangle(objects[i].XAxis, objects[i].YAxis, objects[i].Size, objects[i].SensorValue);
                            break;
                        case "Эллипс":
                            DrawEllipse(objects[i].XAxis, objects[i].YAxis, objects[i].Size, objects[i].SensorValue);
                            break;
                    }

                    ListBoxItem(objects[i]);
                }
            }
        }

        private void Validation()
        {
            if (Size_TB.Text == string.Empty)
            {
                throw new Exception("Заполните поле Размер");
            }
            else if (X_TB.Text == string.Empty)
            {
                throw new Exception("Заполните поле X");
            }
            else if (Y_TB.Text == string.Empty)
            {
                throw new Exception("Заполните поле Y");
            }
            else if (SensorValue_TB.Text == string.Empty)
            {
                throw new Exception("Заполните поле Числовое Значение");
            }
        }

        private async void Main_Load(object sender, EventArgs e)
        {
            while (true)
            {
                var list = new TcpSender().SendObject("DrawObject");

                var objects = Data_LB.Items as dynamic;

                for (int i = 0; i < objects.Count; i++)
                {
                    objects[i].SensorValue = list[i].Value;

                    switch (objects[i].Name)
                    {
                        case "Прямоугольник":
                            DrawRectangle(objects[i].XAxis, objects[i].YAxis, objects[i].Size, objects[i].SensorValue);
                            break;
                        case "Эллипс":
                            DrawEllipse(objects[i].XAxis, objects[i].YAxis, objects[i].Size, objects[i].SensorValue);
                            break;
                    }
                }

                await Task.Delay(1000);
            }
        }
    }
}
