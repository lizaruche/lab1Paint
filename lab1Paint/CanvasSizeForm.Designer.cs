using System;

namespace lab1Paint
{
    partial class CanvasSizeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelHight = new System.Windows.Forms.Label();
            this.boxWidth = new System.Windows.Forms.TextBox();
            this.boxHight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(285, 98);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(389, 98);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(54, 35);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(49, 13);
            this.labelWidth.TabIndex = 2;
            this.labelWidth.Text = "Ширина:";
            this.labelWidth.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelHight
            // 
            this.labelHight.AutoSize = true;
            this.labelHight.Location = new System.Drawing.Point(268, 35);
            this.labelHight.Name = "labelHight";
            this.labelHight.Size = new System.Drawing.Size(48, 13);
            this.labelHight.TabIndex = 3;
            this.labelHight.Text = "Высота:";
            this.labelHight.Click += new System.EventHandler(this.label2_Click);
            // 
            // boxWidth
            // 
            this.boxWidth.Location = new System.Drawing.Point(109, 32);
            this.boxWidth.Name = "boxWidth";
            this.boxWidth.Size = new System.Drawing.Size(100, 20);
            this.boxWidth.TabIndex = 4;
            // 
            // boxHight
            // 
            this.boxHight.Location = new System.Drawing.Point(320, 32);
            this.boxHight.Name = "boxHight";
            this.boxHight.Size = new System.Drawing.Size(100, 20);
            this.boxHight.TabIndex = 5;
            // 
            // CanvasSizeForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(481, 138);
            this.Controls.Add(this.boxHight);
            this.Controls.Add(this.boxWidth);
            this.Controls.Add(this.labelHight);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CanvasSizeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CanvasSizeForm";
            this.Load += new System.EventHandler(this.CanvasSizeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelHight;
        private System.Windows.Forms.TextBox boxWidth;
        private System.Windows.Forms.TextBox boxHight;
    }
}