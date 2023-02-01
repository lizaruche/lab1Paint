using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1Paint
{
    public partial class ToolSettingsForm : Form
    {
        public ToolSettingsForm()
        {
            InitializeComponent();
            this.textWidth.Text = MainForm.CurrentWidth.ToString();
            this.textRayNum.Text = MainForm.CurrentRayNum.ToString();
            this.textInnerRad.Text = MainForm.CurrentInnerRad.ToString();
            this.textOuterRad.Text = MainForm.CurrentOuterRad.ToString();
            this.textZoom.Text = MainForm.CurrentZoom.ToString();
        }

        public float GetWidth()
        {
            return (float)Convert.ToDouble(this.textWidth.Text.Replace('.', ','));
        }
        public int GetRayNum()
        {
            return Convert.ToInt32(this.textRayNum.Text);
        }
        public int GetInnerRad()
        {
            return Convert.ToInt32(this.textInnerRad.Text);
        }
        public int GetOuterRad()
        {
            return Convert.ToInt32(this.textOuterRad.Text);
        }

        public int GetZoom()
        {
            return Convert.ToInt32(this.textZoom.Text);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(this.textInnerRad.Text, @"^\d+$") || 
                !Regex.IsMatch(this.textOuterRad.Text, @"^\d+$") || 
                !Regex.IsMatch(this.textRayNum.Text, @"^\d+$") ||
                !Regex.IsMatch(this.textZoom.Text, @"^\d+$"))
                MessageBox.Show("Некорректные данные о радиусах, кол-ве лучейm или масштабе, введите ЦЕЛОЕ число!");
            else if (!Regex.IsMatch(this.textWidth.Text, @"^\d+[\.,]?\d+$|^\d+$"))
                MessageBox.Show("Некорректые данные о ширине, введите ВЕЩЕСТВЕННОЕ число!");
            else if (Convert.ToInt32(this.textInnerRad.Text) > Convert.ToInt32(this.textOuterRad.Text))
                MessageBox.Show("Внешний радиус не может быть меньше внутреннего!");
            else
                this.DialogResult = DialogResult.OK;
        }
    }
}
