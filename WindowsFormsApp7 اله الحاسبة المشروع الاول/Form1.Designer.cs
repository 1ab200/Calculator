
namespace WindowsFormsApp7_اله_الحاسبة_المشروع_الاول
{
    partial class Calculator
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
            this.txt = new System.Windows.Forms.TextBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.btntt = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btndeleet = new System.Windows.Forms.Button();
            this.btncc = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btndd = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnnn = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnzz = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btndote = new System.Windows.Forms.Button();
            this.btnyy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt
            // 
            this.txt.Font = new System.Drawing.Font("Kristen ITC", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(12, 12);
            this.txt.Multiline = true;
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(446, 71);
            this.txt.TabIndex = 0;
            this.txt.Text = "0";
            this.txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Gray;
            this.btn7.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.Red;
            this.btn7.Location = new System.Drawing.Point(12, 114);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(80, 62);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.button_Click);
            // 
            // btntt
            // 
            this.btntt.BackColor = System.Drawing.Color.Gray;
            this.btntt.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntt.ForeColor = System.Drawing.Color.Red;
            this.btntt.Location = new System.Drawing.Point(291, 114);
            this.btntt.Name = "btntt";
            this.btntt.Size = new System.Drawing.Size(80, 62);
            this.btntt.TabIndex = 2;
            this.btntt.Text = "/";
            this.btntt.UseVisualStyleBackColor = false;
            this.btntt.Click += new System.EventHandler(this.operator_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Gray;
            this.btn9.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.Red;
            this.btn9.Location = new System.Drawing.Point(183, 114);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(80, 62);
            this.btn9.TabIndex = 3;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.button_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Gray;
            this.btn8.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.Red;
            this.btn8.Location = new System.Drawing.Point(97, 114);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(80, 62);
            this.btn8.TabIndex = 4;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.button_Click);
            // 
            // btndeleet
            // 
            this.btndeleet.BackColor = System.Drawing.Color.Gray;
            this.btndeleet.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleet.ForeColor = System.Drawing.Color.Red;
            this.btndeleet.Location = new System.Drawing.Point(377, 114);
            this.btndeleet.Name = "btndeleet";
            this.btndeleet.Size = new System.Drawing.Size(80, 62);
            this.btndeleet.TabIndex = 5;
            this.btndeleet.Text = "deleet";
            this.btndeleet.UseVisualStyleBackColor = false;
            this.btndeleet.Click += new System.EventHandler(this.btndeleet_Click);
            // 
            // btncc
            // 
            this.btncc.BackColor = System.Drawing.Color.Gray;
            this.btncc.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncc.ForeColor = System.Drawing.Color.Red;
            this.btncc.Location = new System.Drawing.Point(377, 182);
            this.btncc.Name = "btncc";
            this.btncc.Size = new System.Drawing.Size(80, 62);
            this.btncc.TabIndex = 10;
            this.btncc.Text = "c";
            this.btncc.UseVisualStyleBackColor = false;
            this.btncc.Click += new System.EventHandler(this.btncc_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Gray;
            this.btn5.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.Red;
            this.btn5.Location = new System.Drawing.Point(98, 182);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(80, 62);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.button_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Gray;
            this.btn6.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.Red;
            this.btn6.Location = new System.Drawing.Point(183, 182);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(80, 62);
            this.btn6.TabIndex = 8;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.button_Click);
            // 
            // btndd
            // 
            this.btndd.BackColor = System.Drawing.Color.Gray;
            this.btndd.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndd.ForeColor = System.Drawing.Color.Red;
            this.btndd.Location = new System.Drawing.Point(291, 182);
            this.btndd.Name = "btndd";
            this.btndd.Size = new System.Drawing.Size(80, 62);
            this.btndd.TabIndex = 7;
            this.btndd.Text = "*";
            this.btndd.UseVisualStyleBackColor = false;
            this.btndd.Click += new System.EventHandler(this.operator_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Gray;
            this.btn4.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.Red;
            this.btn4.Location = new System.Drawing.Point(12, 182);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(80, 62);
            this.btn4.TabIndex = 6;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.button_Click);
            // 
            // btnnn
            // 
            this.btnnn.BackColor = System.Drawing.Color.Gray;
            this.btnnn.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnn.ForeColor = System.Drawing.Color.Red;
            this.btnnn.Location = new System.Drawing.Point(378, 250);
            this.btnnn.Name = "btnnn";
            this.btnnn.Size = new System.Drawing.Size(80, 62);
            this.btnnn.TabIndex = 15;
            this.btnnn.Text = "-";
            this.btnnn.UseVisualStyleBackColor = false;
            this.btnnn.Click += new System.EventHandler(this.operator_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Gray;
            this.btn2.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.Red;
            this.btn2.Location = new System.Drawing.Point(98, 250);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(80, 62);
            this.btn2.TabIndex = 14;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.button_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Gray;
            this.btn3.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.Red;
            this.btn3.Location = new System.Drawing.Point(183, 250);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(80, 62);
            this.btn3.TabIndex = 13;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.button_Click);
            // 
            // btnzz
            // 
            this.btnzz.BackColor = System.Drawing.Color.Gray;
            this.btnzz.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnzz.ForeColor = System.Drawing.Color.Red;
            this.btnzz.Location = new System.Drawing.Point(291, 250);
            this.btnzz.Name = "btnzz";
            this.btnzz.Size = new System.Drawing.Size(80, 62);
            this.btnzz.TabIndex = 12;
            this.btnzz.Text = "+";
            this.btnzz.UseVisualStyleBackColor = false;
            this.btnzz.Click += new System.EventHandler(this.operator_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Gray;
            this.btn1.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.Red;
            this.btn1.Location = new System.Drawing.Point(12, 250);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(80, 62);
            this.btn1.TabIndex = 11;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.button_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Gray;
            this.btn0.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.Red;
            this.btn0.Location = new System.Drawing.Point(11, 318);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(166, 62);
            this.btn0.TabIndex = 16;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.button_Click);
            // 
            // btndote
            // 
            this.btndote.BackColor = System.Drawing.Color.Gray;
            this.btndote.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndote.ForeColor = System.Drawing.Color.Red;
            this.btndote.Location = new System.Drawing.Point(183, 318);
            this.btndote.Name = "btndote";
            this.btndote.Size = new System.Drawing.Size(80, 62);
            this.btndote.TabIndex = 17;
            this.btndote.Text = ".";
            this.btndote.UseVisualStyleBackColor = false;
            this.btndote.Click += new System.EventHandler(this.button_Click);
            // 
            // btnyy
            // 
            this.btnyy.BackColor = System.Drawing.Color.Gray;
            this.btnyy.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnyy.ForeColor = System.Drawing.Color.Red;
            this.btnyy.Location = new System.Drawing.Point(291, 318);
            this.btnyy.Name = "btnyy";
            this.btnyy.Size = new System.Drawing.Size(166, 62);
            this.btnyy.TabIndex = 18;
            this.btnyy.Text = "=";
            this.btnyy.UseVisualStyleBackColor = false;
            this.btnyy.Click += new System.EventHandler(this.btnyy_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(470, 426);
            this.Controls.Add(this.btnyy);
            this.Controls.Add(this.btndote);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnnn);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnzz);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btncc);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btndd);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btndeleet);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btntt);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.txt);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btntt;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btndeleet;
        private System.Windows.Forms.Button btncc;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btndd;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnnn;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnzz;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btndote;
        private System.Windows.Forms.Button btnyy;
    }
}

