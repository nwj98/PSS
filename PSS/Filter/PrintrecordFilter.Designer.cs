
namespace PSS.Filter
{
    partial class PrintrecordFilter
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbloglast = new System.Windows.Forms.DateTimePicker();
            this.tblogfirst = new System.Windows.Forms.DateTimePicker();
            this.tbcolor = new System.Windows.Forms.TextBox();
            this.tbpagesize = new System.Windows.Forms.TextBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 473);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(521, 410);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 38);
            this.button2.TabIndex = 9;
            this.button2.Text = "확인";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(27, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(588, 351);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.tbloglast);
            this.panel3.Controls.Add(this.tblogfirst);
            this.panel3.Controls.Add(this.tbcolor);
            this.panel3.Controls.Add(this.tbpagesize);
            this.panel3.Controls.Add(this.tbname);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(581, 345);
            this.panel3.TabIndex = 1;
            // 
            // tbloglast
            // 
            this.tbloglast.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tbloglast.Location = new System.Drawing.Point(389, 41);
            this.tbloglast.Name = "tbloglast";
            this.tbloglast.Size = new System.Drawing.Size(125, 27);
            this.tbloglast.TabIndex = 24;
            // 
            // tblogfirst
            // 
            this.tblogfirst.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tblogfirst.Location = new System.Drawing.Point(192, 41);
            this.tblogfirst.Name = "tblogfirst";
            this.tblogfirst.Size = new System.Drawing.Size(125, 27);
            this.tblogfirst.TabIndex = 23;
            // 
            // tbcolor
            // 
            this.tbcolor.Location = new System.Drawing.Point(192, 220);
            this.tbcolor.Name = "tbcolor";
            this.tbcolor.Size = new System.Drawing.Size(125, 27);
            this.tbcolor.TabIndex = 22;
            // 
            // tbpagesize
            // 
            this.tbpagesize.Location = new System.Drawing.Point(192, 163);
            this.tbpagesize.Name = "tbpagesize";
            this.tbpagesize.Size = new System.Drawing.Size(125, 27);
            this.tbpagesize.TabIndex = 20;
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(192, 104);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(125, 27);
            this.tbname.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(347, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "끝";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(147, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "시작";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "컬러여부 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "용지크기 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "이름  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "로그기간 :";
            // 
            // PrintrecordFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 473);
            this.Controls.Add(this.panel1);
            this.Name = "PrintrecordFilter";
            this.Text = "PrintrecordFilter";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker tbloglast;
        private System.Windows.Forms.DateTimePicker tblogfirst;
        private System.Windows.Forms.TextBox tbcolor;
        private System.Windows.Forms.TextBox tbpagesize;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}