using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1Paint
{
    public partial class DocumentForm : Form
    {
        private int x, y;
        private Bitmap bitmap;
        private Bitmap bmpTemp;
        public string path;
        private static int counter = 0;

        public DocumentForm(string path="", int width=300, int higth=300)
        {
            InitializeComponent();
            this.path = path;
            if (this.path == "") this.bitmap = new Bitmap(width, higth);
            else this.bitmap = new Bitmap(Image.FromFile(path));
            this.Size = this.bitmap.Size;
            if (this.path == "")
            {
                counter++;
                this.Text = "Paint_" + counter;
            }
            else
            {
                this.Text = path;
            }
            this.picture.Image = this.bitmap;
        }
        private void DocumentForm_Closing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show($"Сохранить файл '{this.Text}'?", "Сохранение измененного файла", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Save();
            }
            counter--;
        }
        public void Save(bool saveAsFlag = false)
        {
            string tmpPath = this.path;
            if (saveAsFlag)
            {
                this.path = "";
            }
            if (this.path == "")
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Filter = "Файлы JPEG (*.jpeg, *.jpg)|*.jpeg;*.jpg| Файлы PNG (*.png)|*.png| Windows Bitmap (*.bmp)|*.bmp|Все файлы ()*.*|*.*";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    this.path = dlg.FileName;
                }
                else
                {
                    this.path = tmpPath;
                }
            }
            this.bitmap.Save(this.path);
            this.Text = this.path;
            counter--;
        }
        public void CropImage(Size destSize)
        {
            if (destSize.Width < bitmap.Width)
                bitmap = bitmap.Clone(new Rectangle(Point.Empty, new Size(destSize.Width, bitmap.Height)), bitmap.PixelFormat);
            else if (destSize.Width > bitmap.Width)
            {
                bmpTemp = (Bitmap)bitmap.Clone();
                bitmap = new Bitmap(destSize.Width, bitmap.Height);
                var g = Graphics.FromImage(bitmap);
                g.FillRectangle(new SolidBrush(Color.White), new Rectangle(Point.Empty, bitmap.Size));
                g.DrawImage(bmpTemp, Point.Empty);
            }
            if (destSize.Height < bitmap.Height)
                bitmap = bitmap.Clone(new Rectangle(Point.Empty, new Size(bitmap.Width, destSize.Height)), bitmap.PixelFormat);
            else if (destSize.Height > bitmap.Height)
            {
                bmpTemp = (Bitmap)bitmap.Clone();
                bitmap = new Bitmap(bitmap.Width, destSize.Height);
                var g = Graphics.FromImage(bitmap);
                g.FillRectangle(new SolidBrush(Color.White), new Rectangle(Point.Empty, bitmap.Size));
                g.DrawImage(bmpTemp, Point.Empty);
            }
            picture.Image = bitmap;
            picture.Invalidate();
            this.Size = bitmap.Size;
        }
        public void ResizeImage(int div)
        {
            if (bitmap.Width + div <= 0 || bitmap.Height + div <= 0)
                MessageBox.Show("Достигнут минимальный размер!");
            else
            {
                bitmap = new Bitmap(bitmap, bitmap.Width + div, bitmap.Height + div);
                picture.Image = bitmap;
                picture.Invalidate();
                this.Size = bitmap.Size;
            }
        }
        private void DocumentForm_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void DocumentForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var pen = new Pen(MainForm.CurrentColor, MainForm.CurrentWidth);
                switch (MainForm.Tool)
                {
                    case Tools.Eraser:
                    case Tools.Pen:
                        var g = Graphics.FromImage(this.bitmap);
                        g.DrawLine(pen, x, y, e.X, e.Y);
                        x = e.X;
                        y = e.Y;
                        break;
                    case Tools.Circle:
                        this.bmpTemp = (Bitmap)this.bitmap.Clone();
                        g = Graphics.FromImage(bmpTemp);
                        g.DrawEllipse(pen, new Rectangle(x, y, e.X - x, e.Y - y));
                        picture.Image = bmpTemp;
                        break;
                    case Tools.Line:
                        this.bmpTemp = (Bitmap)this.bitmap.Clone();
                        g = Graphics.FromImage(bmpTemp);
                        g.DrawLine(pen, new PointF(this.x, this.y), new PointF(e.X, e.Y));
                        picture.Image = bmpTemp;
                        break;

                }
                picture.Invalidate();
            }
        }
        private PointF[] DrawStar(Point currPos)
        {
            int n = MainForm.CurrentRayNum;
            float R = MainForm.CurrentOuterRad;
            float r = MainForm.CurrentInnerRad;

            PointF[] points = new PointF[2 * n + 1];
            float rotateVal = (float)Math.PI / n;

            float angle;
            if (n % 4 == 0)
                angle = 0;
            else if (n % 4 == 1)
                angle = (float)1.5 * rotateVal;
            else if (n % 4 == 2)
                angle = rotateVal;
            else
                angle = (float)(1.5 * rotateVal - Math.PI);

            for (int i = 0; i < points.Length; i++)
            {
                double currRad = i % 2 == 0 ? R : r;

                points[i] = new PointF((float)(currPos.X + currRad * Math.Cos(angle)), (float)(currPos.Y + currRad * Math.Cos(angle)));
                angle += rotateVal;
            }
            return points;

        }
        private void picture_MouseUp(object sender, MouseEventArgs e)
        {
            switch (MainForm.Tool)
            {
                case Tools.Line:
                case Tools.Circle:
                    bitmap = bmpTemp;
                    break;
            }
        }

        private void picture_Click(object sender, EventArgs e)
        {
            if (MainForm.Tool == Tools.Star)
                using (Graphics g = Graphics.FromImage(this.bitmap))
                {
                    using (Pen pen = new Pen(MainForm.CurrentColor))
                    {
                        g.DrawPolygon(pen, DrawStar(Cursor.Position));
                    }
                }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}
