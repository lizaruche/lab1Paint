using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void CanvasSizeForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(this.boxWidth.Text, "[^0-9]")) || 
                    !System.Text.RegularExpressions.Regex.IsMatch(this.boxHight.Text, "[^0-9]")) )
            { 
                MessageBox.Show("Введите целое число!")
                this.DialogResult = !DialogResult.No;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
