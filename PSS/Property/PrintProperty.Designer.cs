
namespace PSS.Property
{
    partial class PrintProperty
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lbllog = new System.Windows.Forms.Label();
            this.lblsize = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblnum = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(536, 425);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "닫기";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(42, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 351);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lbllog);
            this.panel2.Controls.Add(this.lblsize);
            this.panel2.Controls.Add(this.lblname);
            this.panel2.Controls.Add(this.lblnum);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(581, 345);
            this.panel2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "날짜 및 시간 :";
            // 
            // lbllog
            // 
            this.lbllog.AutoSize = true;
            this.lbllog.Location = new System.Drawing.Point(158, 224);
            this.lbllog.Name = "lbllog";
            this.lbllog.Size = new System.Drawing.Size(58, 20);
            this.lbllog.TabIndex = 14;
            this.lbllog.Text = "label10";
            // 
            // lblsize
            // 
            this.lblsize.AutoSize = true;
            this.lblsize.Location = new System.Drawing.Point(142, 168);
            this.lblsize.Name = "lblsize";
            this.lblsize.Size = new System.Drawing.Size(58, 20);
            this.lblsize.TabIndex = 10;
            this.lblsize.Text = "label11";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(115, 105);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(50, 20);
            this.lblname.TabIndex = 7;
            this.lblname.Text = "label8";
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Location = new System.Drawing.Point(142, 46);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(50, 20);
            this.lblnum.TabIndex = 6;
            this.lblnum.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "파일크기 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "이름 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "인쇄번호 :";
            // 
            // PrintProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Name = "PrintProperty";
            this.Size = new System.Drawing.Size(666, 520);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblsize;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbllog;
    }
}
