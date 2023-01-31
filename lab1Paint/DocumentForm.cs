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

        public DocumentForm(string path)
        {
            InitializeComponent();
            this.path = path;
            if (this.path == "") this.bitmap = new Bitmap(300, 300);
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
            
        }
        public void Save()
        { 
            this.bitmap.Save(this.path);
            this.Text = this.path;
            counter--;
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
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            counter--;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}
