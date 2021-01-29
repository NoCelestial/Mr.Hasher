namespace Mr.Hasher.WinApp
{
    partial class Mainfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainfrm));
            this.lblmrhasher = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.grbinput = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnopenfile = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.rdbTextinput = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblprogress = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grbhash = new System.Windows.Forms.GroupBox();
            this.chbsha512 = new System.Windows.Forms.CheckBox();
            this.chbsha256 = new System.Windows.Forms.CheckBox();
            this.chbmd5 = new System.Windows.Forms.CheckBox();
            this.chbripemd160 = new System.Windows.Forms.CheckBox();
            this.chbsha384 = new System.Windows.Forms.CheckBox();
            this.chbsha160 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHash = new System.Windows.Forms.Button();
            this.btnabout = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.grbinput.SuspendLayout();
            this.grbhash.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblmrhasher
            // 
            this.lblmrhasher.AutoSize = true;
            this.lblmrhasher.Location = new System.Drawing.Point(13, 9);
            this.lblmrhasher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmrhasher.Name = "lblmrhasher";
            this.lblmrhasher.Size = new System.Drawing.Size(84, 16);
            this.lblmrhasher.TabIndex = 0;
            this.lblmrhasher.Text = "MR.HASHER";
            // 
            // btnexit
            // 
            this.btnexit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnexit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnexit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnexit.Image = global::Mr.Hasher.WinApp.Properties.Resources.exitpng;
            this.btnexit.Location = new System.Drawing.Point(986, 12);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(37, 33);
            this.btnexit.TabIndex = 2;
            this.btnexit.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.button2_Click);
            // 
            // grbinput
            // 
            this.grbinput.BackColor = System.Drawing.Color.Black;
            this.grbinput.Controls.Add(this.label1);
            this.grbinput.Controls.Add(this.btnopenfile);
            this.grbinput.Controls.Add(this.textBox1);
            this.grbinput.Controls.Add(this.richTextBox1);
            this.grbinput.Controls.Add(this.rdbTextinput);
            this.grbinput.Controls.Add(this.radioButton2);
            this.grbinput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grbinput.Location = new System.Drawing.Point(12, 45);
            this.grbinput.Name = "grbinput";
            this.grbinput.Size = new System.Drawing.Size(634, 400);
            this.grbinput.TabIndex = 3;
            this.grbinput.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "File : ";
            this.label1.Visible = false;
            // 
            // btnopenfile
            // 
            this.btnopenfile.Location = new System.Drawing.Point(526, 357);
            this.btnopenfile.Name = "btnopenfile";
            this.btnopenfile.Size = new System.Drawing.Size(91, 23);
            this.btnopenfile.TabIndex = 10;
            this.btnopenfile.Text = "Browse ...";
            this.btnopenfile.UseVisualStyleBackColor = true;
            this.btnopenfile.Visible = false;
            this.btnopenfile.Click += new System.EventHandler(this.btnopenfile_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(50, 357);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(470, 23);
            this.textBox1.TabIndex = 9;
            this.textBox1.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.ForeColor = System.Drawing.Color.Red;
            this.richTextBox1.Location = new System.Drawing.Point(26, 48);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(588, 259);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // rdbTextinput
            // 
            this.rdbTextinput.AutoSize = true;
            this.rdbTextinput.Checked = true;
            this.rdbTextinput.Location = new System.Drawing.Point(6, 22);
            this.rdbTextinput.Name = "rdbTextinput";
            this.rdbTextinput.Size = new System.Drawing.Size(89, 20);
            this.rdbTextinput.TabIndex = 6;
            this.rdbTextinput.TabStop = true;
            this.rdbTextinput.Text = "From Text";
            this.rdbTextinput.UseVisualStyleBackColor = true;
            this.rdbTextinput.Click += new System.EventHandler(this.rdbTextinput_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 313);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(120, 20);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.Text = "From File (.txt)";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Visible = false;
            this.radioButton2.Click += new System.EventHandler(this.rdbTextinput_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Red;
            this.progressBar1.Location = new System.Drawing.Point(12, 451);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(634, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // lblprogress
            // 
            this.lblprogress.AutoSize = true;
            this.lblprogress.Location = new System.Drawing.Point(652, 458);
            this.lblprogress.Name = "lblprogress";
            this.lblprogress.Size = new System.Drawing.Size(30, 16);
            this.lblprogress.TabIndex = 5;
            this.lblprogress.Text = "0%";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // grbhash
            // 
            this.grbhash.Controls.Add(this.chbsha512);
            this.grbhash.Controls.Add(this.chbsha256);
            this.grbhash.Controls.Add(this.chbmd5);
            this.grbhash.Controls.Add(this.chbripemd160);
            this.grbhash.Controls.Add(this.chbsha384);
            this.grbhash.Controls.Add(this.chbsha160);
            this.grbhash.Controls.Add(this.label2);
            this.grbhash.Location = new System.Drawing.Point(655, 45);
            this.grbhash.Name = "grbhash";
            this.grbhash.Size = new System.Drawing.Size(368, 373);
            this.grbhash.TabIndex = 6;
            this.grbhash.TabStop = false;
            // 
            // chbsha512
            // 
            this.chbsha512.AutoSize = true;
            this.chbsha512.Location = new System.Drawing.Point(133, 74);
            this.chbsha512.Name = "chbsha512";
            this.chbsha512.Size = new System.Drawing.Size(103, 20);
            this.chbsha512.TabIndex = 24;
            this.chbsha512.Text = "SHA 512 Bit";
            this.chbsha512.UseVisualStyleBackColor = true;
            // 
            // chbsha256
            // 
            this.chbsha256.AutoSize = true;
            this.chbsha256.Location = new System.Drawing.Point(259, 48);
            this.chbsha256.Name = "chbsha256";
            this.chbsha256.Size = new System.Drawing.Size(103, 20);
            this.chbsha256.TabIndex = 21;
            this.chbsha256.Text = "SHA 256 Bit";
            this.chbsha256.UseVisualStyleBackColor = true;
            // 
            // chbmd5
            // 
            this.chbmd5.AutoSize = true;
            this.chbmd5.Location = new System.Drawing.Point(9, 50);
            this.chbmd5.Name = "chbmd5";
            this.chbmd5.Size = new System.Drawing.Size(55, 20);
            this.chbmd5.TabIndex = 20;
            this.chbmd5.Text = "MD5";
            this.chbmd5.UseVisualStyleBackColor = true;
            // 
            // chbripemd160
            // 
            this.chbripemd160.AutoSize = true;
            this.chbripemd160.Location = new System.Drawing.Point(251, 74);
            this.chbripemd160.Name = "chbripemd160";
            this.chbripemd160.Size = new System.Drawing.Size(117, 20);
            this.chbripemd160.TabIndex = 14;
            this.chbripemd160.Text = "RIPEMD160Bit";
            this.chbripemd160.UseVisualStyleBackColor = true;
            // 
            // chbsha384
            // 
            this.chbsha384.AutoSize = true;
            this.chbsha384.Location = new System.Drawing.Point(9, 74);
            this.chbsha384.Name = "chbsha384";
            this.chbsha384.Size = new System.Drawing.Size(103, 20);
            this.chbsha384.TabIndex = 13;
            this.chbsha384.Text = "SHA 384 Bit";
            this.chbsha384.UseVisualStyleBackColor = true;
            // 
            // chbsha160
            // 
            this.chbsha160.AutoSize = true;
            this.chbsha160.Location = new System.Drawing.Point(133, 48);
            this.chbsha160.Name = "chbsha160";
            this.chbsha160.Size = new System.Drawing.Size(103, 20);
            this.chbsha160.TabIndex = 12;
            this.chbsha160.Text = "SHA 160 Bit";
            this.chbsha160.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hash Types";
            // 
            // btnHash
            // 
            this.btnHash.Location = new System.Drawing.Point(688, 428);
            this.btnHash.Name = "btnHash";
            this.btnHash.Size = new System.Drawing.Size(101, 59);
            this.btnHash.TabIndex = 0;
            this.btnHash.Text = "Start Hashing";
            this.btnHash.UseVisualStyleBackColor = true;
            this.btnHash.Click += new System.EventHandler(this.btnHash_Click);
            // 
            // btnabout
            // 
            this.btnabout.Location = new System.Drawing.Point(940, 428);
            this.btnabout.Name = "btnabout";
            this.btnabout.Size = new System.Drawing.Size(83, 59);
            this.btnabout.TabIndex = 9;
            this.btnabout.Text = "About Us";
            this.btnabout.UseVisualStyleBackColor = true;
            this.btnabout.Click += new System.EventHandler(this.btnabout_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(795, 428);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(139, 20);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Out From Window\r\n";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(795, 458);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(108, 20);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.Text = "Out From File";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Visible = false;
            // 
            // Mainfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1035, 499);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnabout);
            this.Controls.Add(this.btnHash);
            this.Controls.Add(this.grbhash);
            this.Controls.Add(this.lblprogress);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.grbinput);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.lblmrhasher);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.Green;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Mainfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mr.Hasher";
            this.Load += new System.EventHandler(this.Mainfrm_Load);
            this.grbinput.ResumeLayout(false);
            this.grbinput.PerformLayout();
            this.grbhash.ResumeLayout(false);
            this.grbhash.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmrhasher;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.GroupBox grbinput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnopenfile;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RadioButton rdbTextinput;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblprogress;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox grbhash;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHash;
        private System.Windows.Forms.Button btnabout;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.CheckBox chbsha512;
        private System.Windows.Forms.CheckBox chbsha256;
        private System.Windows.Forms.CheckBox chbmd5;
        private System.Windows.Forms.CheckBox chbripemd160;
        private System.Windows.Forms.CheckBox chbsha384;
        private System.Windows.Forms.CheckBox chbsha160;
    }
}