namespace lab1Paint
{
    partial class ToolSettingsForm
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
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelRayNum = new System.Windows.Forms.Label();
            this.labelInnerRad = new System.Windows.Forms.Label();
            this.labelOuterRad = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textInnerRad = new System.Windows.Forms.TextBox();
            this.textRayNum = new System.Windows.Forms.TextBox();
            this.textWidth = new System.Windows.Forms.TextBox();
            this.textOuterRad = new System.Windows.Forms.TextBox();
            this.labelZoom = new System.Windows.Forms.Label();
            this.textZoom = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(3, 0);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(162, 26);
            this.labelWidth.TabIndex = 0;
            this.labelWidth.Text = "Ширина линии (вещественное число):";
            // 
            // labelRayNum
            // 
            this.labelRayNum.AutoSize = true;
            this.labelRayNum.Location = new System.Drawing.Point(3, 35);
            this.labelRayNum.Name = "labelRayNum";
            this.labelRayNum.Size = new System.Drawing.Size(141, 13);
            this.labelRayNum.TabIndex = 1;
            this.labelRayNum.Text = "Количество лучей звезды:";
            // 
            // labelInnerRad
            // 
            this.labelInnerRad.AutoSize = true;
            this.labelInnerRad.Location = new System.Drawing.Point(3, 69);
            this.labelInnerRad.Name = "labelInnerRad";
            this.labelInnerRad.Size = new System.Drawing.Size(148, 13);
            this.labelInnerRad.TabIndex = 2;
            this.labelInnerRad.Text = "Внутренний радиус звезды:";
            // 
            // labelOuterRad
            // 
            this.labelOuterRad.AutoSize = true;
            this.labelOuterRad.Location = new System.Drawing.Point(3, 102);
            this.labelOuterRad.Name = "labelOuterRad";
            this.labelOuterRad.Size = new System.Drawing.Size(134, 13);
            this.labelOuterRad.TabIndex = 3;
            this.labelOuterRad.Text = "Внешний радиус звезды:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textInnerRad, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textRayNum, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelWidth, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelOuterRad, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelRayNum, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelInnerRad, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textWidth, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textOuterRad, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelZoom, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textZoom, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.74627F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.25373F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(344, 159);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // textInnerRad
            // 
            this.textInnerRad.Location = new System.Drawing.Point(175, 72);
            this.textInnerRad.Name = "textInnerRad";
            this.textInnerRad.Size = new System.Drawing.Size(100, 20);
            this.textInnerRad.TabIndex = 6;
            // 
            // textRayNum
            // 
            this.textRayNum.Location = new System.Drawing.Point(175, 38);
            this.textRayNum.Name = "textRayNum";
            this.textRayNum.Size = new System.Drawing.Size(100, 20);
            this.textRayNum.TabIndex = 5;
            // 
            // textWidth
            // 
            this.textWidth.Location = new System.Drawing.Point(175, 3);
            this.textWidth.Name = "textWidth";
            this.textWidth.Size = new System.Drawing.Size(100, 20);
            this.textWidth.TabIndex = 4;
            // 
            // textOuterRad
            // 
            this.textOuterRad.Location = new System.Drawing.Point(175, 105);
            this.textOuterRad.Name = "textOuterRad";
            this.textOuterRad.Size = new System.Drawing.Size(100, 20);
            this.textOuterRad.TabIndex = 7;
            // 
            // labelZoom
            // 
            this.labelZoom.AutoSize = true;
            this.labelZoom.Location = new System.Drawing.Point(3, 134);
            this.labelZoom.Name = "labelZoom";
            this.labelZoom.Size = new System.Drawing.Size(56, 13);
            this.labelZoom.TabIndex = 8;
            this.labelZoom.Text = "Масштаб:";
            // 
            // textZoom
            // 
            this.textZoom.Location = new System.Drawing.Point(175, 137);
            this.textZoom.Name = "textZoom";
            this.textZoom.Size = new System.Drawing.Size(100, 20);
            this.textZoom.TabIndex = 9;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(3, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(150, 37);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(175, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(154, 37);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnOk, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCancel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 159);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(344, 49);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // ToolSettingsForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(344, 208);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ToolSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Параметры инструментов";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelRayNum;
        private System.Windows.Forms.Label labelInnerRad;
        private System.Windows.Forms.Label labelOuterRad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textInnerRad;
        private System.Windows.Forms.TextBox textRayNum;
        private System.Windows.Forms.TextBox textWidth;
        private System.Windows.Forms.TextBox textOuterRad;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelZoom;
        private System.Windows.Forms.TextBox textZoom;
    }
}