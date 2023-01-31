﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace lab1Paint
{
    public partial class MainForm : Form
    {
        public static Color CurrentColor { get; set; }
        private static Color TmpColor { get; set; }
        public static Tools Tool { get; set; }
        public static float CurrentWidth { get; set; }
        public static int CurrentInnerRad { get; set; }
        public static int CurrentOuterRad { get; set; }
        public static int CurrentRayNum { get; set; }

        public MainForm()
        {
            InitializeComponent();
            CurrentColor = Color.Black;
            CurrentWidth = 3;
            CurrentOuterRad = 3;
            CurrentInnerRad = 2;
            CurrentRayNum = 7;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Файлы JPEG (*.jpeg, *.jpg)|*.jpeg;*.jpg| Файлы PNG (*.png)|*.png| Windows Bitmap (*.bmp)|*.bmp|Все файлы ()*.*|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                foreach (string name in dlg.FileNames)
                {
                    DocumentForm newPaint = new DocumentForm(name);
                    newPaint.MdiParent = this;
                    newPaint.Show();
                }
            }

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void размерХолстаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CanvasSizeForm sizeForm = new CanvasSizeForm();
            sizeForm.ShowDialog();

        }
        private void рисунокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            размерХолстаToolStripMenuItem.Enabled = !(ActiveMdiChild == null);
        }
        private void красныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentColor = Color.Red;
        }

        private void синийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentColor = Color.Blue;
        }

        private void зеленыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentColor = Color.Green;
        }

        private void другойToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
                CurrentColor = cd.Color;
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            сохранитьКакToolStripMenuItem.Enabled = !(ActiveMdiChild == null);
            сохранитьToolStripMenuItem.Enabled = !(ActiveMdiChild == null);
        }

        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocumentForm newPaint = new DocumentForm("");
            newPaint.MdiParent = this;
            newPaint.Show();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var d = ActiveMdiChild as DocumentForm;
            if (d != null)
            {
                if (d.path != "") d.Save();
                else
                {
                    SaveFileDialog dlg = new SaveFileDialog();
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        d.path = dlg.FileName;
                        d.Save();
                    }
                }
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var d = ActiveMdiChild as DocumentForm;
            if (d != null)
            {
                SaveFileDialog dlg = new SaveFileDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    d.path = dlg.FileName;
                    d.Save();
                }
            }
        }

        private void пероToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tool == Tools.Eraser)
            {
                CurrentColor = TmpColor;
                this.dropDownColor.Enabled = true;
            }
            Tool = Tools.Pen;
        }

        private void линияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tool == Tools.Eraser)
            {
                CurrentColor = TmpColor;
                this.dropDownColor.Enabled = true;
            }
            Tool = Tools.Line;
        }

        private void эллипсToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tool == Tools.Eraser)
            {
                CurrentColor = TmpColor;
                this.dropDownColor.Enabled = true;
            }
            Tool = Tools.Circle;
        }

        private void ластикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TmpColor = CurrentColor;
            Tool = Tools.Eraser;
            CurrentColor = Color.White;
            this.dropDownColor.Enabled = false;
        }

        private void звездаToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Tool == Tools.Eraser)
            {
                CurrentColor = TmpColor;
                this.dropDownColor.Enabled = true;
            }
            Tool = Tools.Star;
        }

        private void btnParams_Click(object sender, EventArgs e)
        {
            ToolSettingsForm dlg = new ToolSettingsForm();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                CurrentWidth = dlg.GetWidth();
                CurrentRayNum = dlg.GetRayNum();
                CurrentInnerRad = dlg.GetInnerRad();
                CurrentOuterRad = dlg.GetOuterRad();
                dlg.Close();
            }
        }
    }
}