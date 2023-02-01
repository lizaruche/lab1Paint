using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab1Paint
{
    public partial class CanvasSizeForm : Form
    {
        public int userWidth;
        public int userHeight;
        public CanvasSizeForm()
        {
            InitializeComponent();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(this.boxHight.Text, @"^\d+$") || 
                !Regex.IsMatch(this.boxWidth.Text, @"^\d+$")) 
                    MessageBox.Show("Введите целые числа!");
            else
            {
                userHeight = Convert.ToInt32(this.boxHight.Text);
                userWidth = Convert.ToInt32(this.boxWidth.Text);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
