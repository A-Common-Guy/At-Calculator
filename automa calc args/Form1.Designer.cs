namespace automa_calc_args
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.comma = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.per = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.clean = new System.Windows.Forms.Button();
            this.txtDsp = new System.Windows.Forms.TextBox();
            this.b0 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pow = new System.Windows.Forms.Button();
            this.sign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comma
            // 
            this.comma.Location = new System.Drawing.Point(348, 370);
            this.comma.Name = "comma";
            this.comma.Size = new System.Drawing.Size(75, 56);
            this.comma.TabIndex = 59;
            this.comma.Text = ",";
            this.comma.UseVisualStyleBackColor = true;
            this.comma.Click += new System.EventHandler(this.comma_Click);
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(510, 370);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(75, 56);
            this.equal.TabIndex = 58;
            this.equal.Tag = "eq";
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(591, 370);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(58, 56);
            this.div.TabIndex = 57;
            this.div.Tag = "OP";
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.btnDGT_Click);
            // 
            // per
            // 
            this.per.Location = new System.Drawing.Point(591, 308);
            this.per.Name = "per";
            this.per.Size = new System.Drawing.Size(58, 56);
            this.per.TabIndex = 56;
            this.per.Tag = "OP";
            this.per.Text = "*";
            this.per.UseVisualStyleBackColor = true;
            this.per.Click += new System.EventHandler(this.btnDGT_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(591, 246);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(58, 56);
            this.minus.TabIndex = 55;
            this.minus.Tag = "OP";
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.btnDGT_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(591, 184);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(58, 56);
            this.plus.TabIndex = 54;
            this.plus.Tag = "OP";
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.btnDGT_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(510, 143);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(75, 35);
            this.del.TabIndex = 53;
            this.del.Text = "DEL";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // clean
            // 
            this.clean.Location = new System.Drawing.Point(591, 143);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(58, 35);
            this.clean.TabIndex = 52;
            this.clean.Text = "C";
            this.clean.UseVisualStyleBackColor = true;
            this.clean.Click += new System.EventHandler(this.clean_Click);
            // 
            // txtDsp
            // 
            this.txtDsp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtDsp.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDsp.Location = new System.Drawing.Point(143, 29);
            this.txtDsp.Multiline = true;
            this.txtDsp.Name = "txtDsp";
            this.txtDsp.Size = new System.Drawing.Size(506, 84);
            this.txtDsp.TabIndex = 51;
            this.txtDsp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(429, 370);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(75, 56);
            this.b0.TabIndex = 50;
            this.b0.Tag = "DGT";
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.btnDGT_Click);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(510, 308);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(75, 56);
            this.b9.TabIndex = 49;
            this.b9.Tag = "DGT";
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.btnDGT_Click);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(429, 308);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(75, 56);
            this.b8.TabIndex = 48;
            this.b8.Tag = "DGT";
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.btnDGT_Click);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(348, 308);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(75, 56);
            this.b7.TabIndex = 47;
            this.b7.Tag = "DGT";
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.btnDGT_Click);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(510, 246);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(75, 56);
            this.b6.TabIndex = 46;
            this.b6.Tag = "DGT";
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.btnDGT_Click);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(429, 246);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(75, 56);
            this.b5.TabIndex = 45;
            this.b5.Tag = "DGT";
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.btnDGT_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(348, 246);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(75, 56);
            this.b4.TabIndex = 44;
            this.b4.Tag = "DGT";
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.btnDGT_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(510, 184);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(75, 56);
            this.b3.TabIndex = 43;
            this.b3.Tag = "DGT";
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.btnDGT_Click);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(348, 184);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 56);
            this.b1.TabIndex = 42;
            this.b1.Tag = "DGT";
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.btnDGT_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(429, 184);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(75, 56);
            this.b2.TabIndex = 41;
            this.b2.Tag = "DGT";
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.btnDGT_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(429, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 60;
            this.button1.Tag = "2";
            this.button1.Text = "root^2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.rootClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(348, 143);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 35);
            this.button4.TabIndex = 63;
            this.button4.Tag = "3";
            this.button4.Text = "root^3";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.rootClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(267, 143);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 35);
            this.button5.TabIndex = 64;
            this.button5.Tag = "e";
            this.button5.Text = "ln";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(267, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 56);
            this.button2.TabIndex = 67;
            this.button2.Tag = "b";
            this.button2.Text = "log";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(267, 308);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 56);
            this.button3.TabIndex = 66;
            this.button3.Tag = "3";
            this.button3.Text = "x^3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.pow_Click);
            // 
            // pow
            // 
            this.pow.Location = new System.Drawing.Point(267, 246);
            this.pow.Name = "pow";
            this.pow.Size = new System.Drawing.Size(75, 56);
            this.pow.TabIndex = 65;
            this.pow.Tag = "2";
            this.pow.Text = "x^2";
            this.pow.UseVisualStyleBackColor = true;
            this.pow.Click += new System.EventHandler(this.pow_Click);
            // 
            // sign
            // 
            this.sign.Location = new System.Drawing.Point(267, 370);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(75, 56);
            this.sign.TabIndex = 68;
            this.sign.Text = "+/-";
            this.sign.UseVisualStyleBackColor = true;
            this.sign.Click += new System.EventHandler(this.sign_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pow);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comma);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.div);
            this.Controls.Add(this.per);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.del);
            this.Controls.Add(this.clean);
            this.Controls.Add(this.txtDsp);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button comma;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button per;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button clean;
        private System.Windows.Forms.TextBox txtDsp;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button pow;
        private System.Windows.Forms.Button sign;
    }
}

