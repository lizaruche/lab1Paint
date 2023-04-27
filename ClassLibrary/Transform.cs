using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PluginInterface;
using System.Drawing;
using System.Device.Location;
using System.Windows.Forms;

namespace ClassLibrary
{
    [Version(1, 0)]
    public class AddMetaData : IPlugin
    {
        private GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();
        static private int fontSize = 10;
        private int minWidth = 80;
        private int minHeight = 2 * fontSize + 8;
        public string Name
        {
            get
            {
                return "Добавление даты и геолакации";
            }
        }

        public string Author
        {
            get
            {
                return "Arsenii";
            }
        }

        public void Transform(Bitmap bitmap)
        {
            if (bitmap.Width >= minWidth && bitmap.Height >= minHeight)
            {
                watcher.TryStart(false, TimeSpan.FromMilliseconds(100));
                GeoCoordinate coordinate = new GeoCoordinate();
                if (coordinate.IsUnknown != true)
                {
                    using (Graphics gr = Graphics.FromImage(bitmap))
                    {
                        string l = Math.Round(coordinate.Longitude, 2).ToString();
                        string a = Math.Round(coordinate.Altitude, 2).ToString();
                        string date = DateTime.Now.ToString("dd.MM.yyyy");
                        string data = date + "\n" + l + " " + a;
                        gr.DrawString(data, new Font("Arial", fontSize, FontStyle.Regular), new SolidBrush(Color.Yellow), bitmap.Width - 80, bitmap.Height - 2 * fontSize - 8);
                    }
                }
                else
                {
                    using (Graphics gr = Graphics.FromImage(bitmap))
                    {
                        string date = DateTime.Now.ToString("dd.MM.yyyy");
                        gr.DrawString(date, new Font("Arial", fontSize, FontStyle.Regular), new SolidBrush(Color.Yellow), bitmap.Width - 80, bitmap.Height - fontSize - 8);
                    }
                }
            }
            else
            {
                MessageBox.Show($"Слишком маленький размер картинки. Минимальные размеры:\n Ширина - {minWidth}\n Высота - {minHeight}");
            }
        }
    }

    [Version(1, 0)]
    public class Mix : IPlugin
    {
        public string Name
        {
            get
            {
                return "Перемешивание";
            }
        }

        public string Author
        {
            get
            {
                return "Arsenii";
            }
        }

        public void Transform(Bitmap bitmap)
        {
            Random rnd = new Random();
            Bitmap copy= new Bitmap(bitmap.Width, bitmap.Height);
            List<Point> points = new List<Point>(9);
            int i = 0;
            for (int y = 0; y < bitmap.Height-1; y += bitmap.Height / 3)
            {
                for (int x = 0; x < bitmap.Width-1; x += bitmap.Width / 3)
                {
                    points.Add(new Point(x, y));
                    i++;
                }
            }
            List<Point> cPoints= new List<Point>(points);    
            
            using (Graphics gr = Graphics.FromImage(copy))
            {
                //for (int i = 0; i < 9; i++)
                //{
                //    int from = rnd.Next(cPoints.Count);
                //    int to = rnd.Next(cPoints.Count);
                //    gr.DrawImage(bitmap, cPoints[to], );
                //}
                

            }
        }
    }
}
