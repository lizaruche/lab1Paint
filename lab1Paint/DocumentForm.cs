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
        public string path;
        private static int counter = 0;

        public DocumentForm(string path)
        {
            InitializeComponent();
            bitmap =  new Bitmap(Image.FromFile(path));
            this.Size = bitmap.Size;
            this.path = path;
            if (this.path == "")
            {
                counter++;
                this.Text = "Paint_" + counter;
            }
            else
            {
                this.Text = path;
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
                Graphics g = Graphics.FromImage(bitmap);
                g.DrawLine(new Pen(MainForm.Color, MainForm.Width), x, y, e.X, e.Y);
                Invalidate();
                x = e.X;
                y = e.Y;
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
