namespace progAssig1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.digit1 = new System.Windows.Forms.Button();
            this.digit0 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.asterisk = new System.Windows.Forms.Button();
            this.slash = new System.Windows.Forms.Button();
            this.calculate = new System.Windows.Forms.Button();
            this.decimalPoint = new System.Windows.Forms.Button();
            this.openP = new System.Windows.Forms.Button();
            this.closeP = new System.Windows.Forms.Button();
            this.digit2 = new System.Windows.Forms.Button();
            this.digit3 = new System.Windows.Forms.Button();
            this.digit4 = new System.Windows.Forms.Button();
            this.digit5 = new System.Windows.Forms.Button();
            this.digit6 = new System.Windows.Forms.Button();
            this.digit7 = new System.Windows.Forms.Button();
            this.digit8 = new System.Windows.Forms.Button();
            this.digit9 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // digit1
            // 
            this.digit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.digit1.FlatAppearance.BorderSize = 0;
            this.digit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.digit1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit1.ForeColor = System.Drawing.Color.White;
            this.digit1.Location = new System.Drawing.Point(40, 425);
            this.digit1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.digit1.Name = "digit1";
            this.digit1.Size = new System.Drawing.Size(58, 62);
            this.digit1.TabIndex = 0;
            this.digit1.Text = "1";
            this.digit1.UseVisualStyleBackColor = false;
            this.digit1.Click += new System.EventHandler(this.digit1_Click);
            // 
            // digit0
            // 
            this.digit0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.digit0.FlatAppearance.BorderSize = 0;
            this.digit0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.digit0.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit0.ForeColor = System.Drawing.Color.White;
            this.digit0.Location = new System.Drawing.Point(40, 507);
            this.digit0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.digit0.Name = "digit0";
            this.digit0.Size = new System.Drawing.Size(167, 62);
            this.digit0.TabIndex = 1;
            this.digit0.Text = "0";
            this.digit0.UseVisualStyleBackColor = false;
            this.digit0.Click += new System.EventHandler(this.digit0_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(40, 28);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(442, 169);
            this.textBox1.TabIndex = 2;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Clic);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.plus.FlatAppearance.BorderSize = 0;
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.ForeColor = System.Drawing.Color.White;
            this.plus.Location = new System.Drawing.Point(424, 352);
            this.plus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(58, 62);
            this.plus.TabIndex = 3;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.minus.FlatAppearance.BorderSize = 0;
            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minus.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.ForeColor = System.Drawing.Color.White;
            this.minus.Location = new System.Drawing.Point(346, 352);
            this.minus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(58, 62);
            this.minus.TabIndex = 4;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // asterisk
            // 
            this.asterisk.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.asterisk.FlatAppearance.BorderSize = 0;
            this.asterisk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.asterisk.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asterisk.ForeColor = System.Drawing.Color.White;
            this.asterisk.Location = new System.Drawing.Point(424, 280);
            this.asterisk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.asterisk.Name = "asterisk";
            this.asterisk.Size = new System.Drawing.Size(58, 62);
            this.asterisk.TabIndex = 5;
            this.asterisk.Text = "x";
            this.asterisk.UseVisualStyleBackColor = false;
            this.asterisk.Click += new System.EventHandler(this.asterisk_Click);
            // 
            // slash
            // 
            this.slash.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.slash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.slash.FlatAppearance.BorderSize = 0;
            this.slash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.slash.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slash.ForeColor = System.Drawing.Color.White;
            this.slash.Location = new System.Drawing.Point(346, 280);
            this.slash.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.slash.Name = "slash";
            this.slash.Size = new System.Drawing.Size(58, 62);
            this.slash.TabIndex = 6;
            this.slash.Text = "/";
            this.slash.UseVisualStyleBackColor = false;
            this.slash.Click += new System.EventHandler(this.slash_Click);
            // 
            // calculate
            // 
            this.calculate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.calculate.FlatAppearance.BorderSize = 0;
            this.calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculate.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate.ForeColor = System.Drawing.Color.White;
            this.calculate.Location = new System.Drawing.Point(346, 506);
            this.calculate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(136, 62);
            this.calculate.TabIndex = 7;
            this.calculate.Text = "=";
            this.calculate.UseVisualStyleBackColor = false;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // decimalPoint
            // 
            this.decimalPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.decimalPoint.FlatAppearance.BorderSize = 0;
            this.decimalPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decimalPoint.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalPoint.ForeColor = System.Drawing.Color.White;
            this.decimalPoint.Location = new System.Drawing.Point(252, 507);
            this.decimalPoint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.decimalPoint.Name = "decimalPoint";
            this.decimalPoint.Size = new System.Drawing.Size(58, 62);
            this.decimalPoint.TabIndex = 11;
            this.decimalPoint.Text = ".";
            this.decimalPoint.UseVisualStyleBackColor = false;
            this.decimalPoint.Click += new System.EventHandler(this.decimalPoint_Click);
            // 
            // openP
            // 
            this.openP.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.openP.FlatAppearance.BorderSize = 0;
            this.openP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openP.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openP.ForeColor = System.Drawing.Color.White;
            this.openP.Location = new System.Drawing.Point(346, 424);
            this.openP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.openP.Name = "openP";
            this.openP.Size = new System.Drawing.Size(58, 62);
            this.openP.TabIndex = 12;
            this.openP.Text = "(";
            this.openP.UseVisualStyleBackColor = false;
            this.openP.Click += new System.EventHandler(this.openP_Click);
            // 
            // closeP
            // 
            this.closeP.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.closeP.FlatAppearance.BorderSize = 0;
            this.closeP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeP.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeP.ForeColor = System.Drawing.Color.White;
            this.closeP.Location = new System.Drawing.Point(424, 424);
            this.closeP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.closeP.Name = "closeP";
            this.closeP.Size = new System.Drawing.Size(58, 62);
            this.closeP.TabIndex = 13;
            this.closeP.Text = ")";
            this.closeP.UseVisualStyleBackColor = false;
            this.closeP.Click += new System.EventHandler(this.closeP_Click);
            // 
            // digit2
            // 
            this.digit2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.digit2.FlatAppearance.BorderSize = 0;
            this.digit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.digit2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit2.ForeColor = System.Drawing.Color.White;
            this.digit2.Location = new System.Drawing.Point(149, 425);
            this.digit2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.digit2.Name = "digit2";
            this.digit2.Size = new System.Drawing.Size(58, 62);
            this.digit2.TabIndex = 14;
            this.digit2.Text = "2";
            this.digit2.UseVisualStyleBackColor = false;
            this.digit2.Click += new System.EventHandler(this.digit2_Click);
            // 
            // digit3
            // 
            this.digit3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.digit3.FlatAppearance.BorderSize = 0;
            this.digit3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.digit3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit3.ForeColor = System.Drawing.Color.White;
            this.digit3.Location = new System.Drawing.Point(252, 425);
            this.digit3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.digit3.Name = "digit3";
            this.digit3.Size = new System.Drawing.Size(58, 62);
            this.digit3.TabIndex = 15;
            this.digit3.Text = "3";
            this.digit3.UseVisualStyleBackColor = false;
            this.digit3.Click += new System.EventHandler(this.digit3_Click);
            // 
            // digit4
            // 
            this.digit4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.digit4.FlatAppearance.BorderSize = 0;
            this.digit4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.digit4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit4.ForeColor = System.Drawing.Color.White;
            this.digit4.Location = new System.Drawing.Point(40, 352);
            this.digit4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.digit4.Name = "digit4";
            this.digit4.Size = new System.Drawing.Size(58, 62);
            this.digit4.TabIndex = 16;
            this.digit4.Text = "4";
            this.digit4.UseVisualStyleBackColor = false;
            this.digit4.Click += new System.EventHandler(this.digit4_Click);
            // 
            // digit5
            // 
            this.digit5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.digit5.FlatAppearance.BorderSize = 0;
            this.digit5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.digit5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit5.ForeColor = System.Drawing.Color.White;
            this.digit5.Location = new System.Drawing.Point(149, 352);
            this.digit5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.digit5.Name = "digit5";
            this.digit5.Size = new System.Drawing.Size(58, 62);
            this.digit5.TabIndex = 17;
            this.digit5.Text = "5";
            this.digit5.UseVisualStyleBackColor = false;
            this.digit5.Click += new System.EventHandler(this.digit5_Click);
            // 
            // digit6
            // 
            this.digit6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.digit6.FlatAppearance.BorderSize = 0;
            this.digit6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.digit6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit6.ForeColor = System.Drawing.Color.White;
            this.digit6.Location = new System.Drawing.Point(252, 352);
            this.digit6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.digit6.Name = "digit6";
            this.digit6.Size = new System.Drawing.Size(58, 62);
            this.digit6.TabIndex = 18;
            this.digit6.Text = "6";
            this.digit6.UseVisualStyleBackColor = false;
            this.digit6.Click += new System.EventHandler(this.digit6_Click);
            // 
            // digit7
            // 
            this.digit7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.digit7.FlatAppearance.BorderSize = 0;
            this.digit7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.digit7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit7.ForeColor = System.Drawing.Color.White;
            this.digit7.Location = new System.Drawing.Point(40, 280);
            this.digit7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.digit7.Name = "digit7";
            this.digit7.Size = new System.Drawing.Size(58, 62);
            this.digit7.TabIndex = 19;
            this.digit7.Text = "7";
            this.digit7.UseVisualStyleBackColor = false;
            this.digit7.Click += new System.EventHandler(this.digit7_Click);
            // 
            // digit8
            // 
            this.digit8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.digit8.FlatAppearance.BorderSize = 0;
            this.digit8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.digit8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit8.ForeColor = System.Drawing.Color.White;
            this.digit8.Location = new System.Drawing.Point(149, 280);
            this.digit8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.digit8.Name = "digit8";
            this.digit8.Size = new System.Drawing.Size(58, 62);
            this.digit8.TabIndex = 20;
            this.digit8.Text = "8";
            this.digit8.UseVisualStyleBackColor = false;
            this.digit8.Click += new System.EventHandler(this.digit8_Click);
            // 
            // digit9
            // 
            this.digit9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.digit9.FlatAppearance.BorderSize = 0;
            this.digit9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.digit9.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit9.ForeColor = System.Drawing.Color.White;
            this.digit9.Location = new System.Drawing.Point(252, 280);
            this.digit9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.digit9.Name = "digit9";
            this.digit9.Size = new System.Drawing.Size(58, 62);
            this.digit9.TabIndex = 21;
            this.digit9.Text = "9";
            this.digit9.UseVisualStyleBackColor = false;
            this.digit9.Click += new System.EventHandler(this.digit9_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(42, 207);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(440, 62);
            this.button1.TabIndex = 22;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(534, 609);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.digit9);
            this.Controls.Add(this.digit8);
            this.Controls.Add(this.digit7);
            this.Controls.Add(this.digit6);
            this.Controls.Add(this.digit5);
            this.Controls.Add(this.digit4);
            this.Controls.Add(this.digit3);
            this.Controls.Add(this.digit2);
            this.Controls.Add(this.closeP);
            this.Controls.Add(this.openP);
            this.Controls.Add(this.decimalPoint);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.slash);
            this.Controls.Add(this.asterisk);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.digit0);
            this.Controls.Add(this.digit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.form1_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button digit1;
        private System.Windows.Forms.Button digit0;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button asterisk;
        private System.Windows.Forms.Button slash;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button decimalPoint;
        private System.Windows.Forms.Button openP;
        private System.Windows.Forms.Button closeP;
        private System.Windows.Forms.Button digit2;
        private System.Windows.Forms.Button digit3;
        private System.Windows.Forms.Button digit4;
        private System.Windows.Forms.Button digit5;
        private System.Windows.Forms.Button digit6;
        private System.Windows.Forms.Button digit7;
        private System.Windows.Forms.Button digit8;
        private System.Windows.Forms.Button digit9;
        private System.Windows.Forms.Button button1;
    }
}

