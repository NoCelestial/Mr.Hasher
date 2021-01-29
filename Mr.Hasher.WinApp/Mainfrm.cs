using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mr.Hasher.Bussines.API;

namespace Mr.Hasher.WinApp
{
    public partial class Mainfrm : Form
    {
        private string FilePath;
        public Mainfrm()
        {
            InitializeComponent();
            richTextBox1.MaxLength = 300;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Mainfrm_Load(object sender, EventArgs e)
        {
            rdbTextinput_Click(rdbTextinput, null);
        }

        private void rdbTextinput_Click(object sender, EventArgs e)
        {
            switch (((Control)sender).Text)
            {
                case "From Text":
                    richTextBox1.Enabled = true;
                    textBox1.Enabled = false;
                    btnopenfile.Enabled = false;
                    break;
                case "From File (.txt)":
                    richTextBox1.Enabled = false;
                    textBox1.Enabled = true;
                    btnopenfile.Enabled = true;
                    break;
            }
        }

        private void btnopenfile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            openFileDialog1.FileName = String.Empty;
            openFileDialog1.ShowDialog(this);
            FilePath = openFileDialog1.FileName;
            textBox1.Text = FilePath;
        }

        private void btnabout_Click(object sender, EventArgs e)
        {
            Aboutfrm aboutfrm = new Aboutfrm();
            aboutfrm.ShowDialog();
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            Hashing hashing = new Hashing();
            List<string> Hashed = new List<string>();
            string Value = GetInputRTB();
            Hashed.Add("Your Text Is : \n             "+Value+"\n\n");
            if (chbmd5.Checked)
            {
                string Hash = hashing.HashByMD5(Value);
                Hashed.Add("MD5 :\n"+Hash+"\n");

            }
            if (chbsha160.Checked)
            {
                string Hash = hashing.HashBySHA160(Value);
                Hashed.Add("SHA160 Bit :\n" + Hash + "\n");
            }
            if (chbsha256.Checked)
            {
                string Hash = hashing.HashBySHA256(Value);
                Hashed.Add("SHA256 Bit :\n" + Hash + "\n");
            }
            if (chbsha384.Checked)
            {
                string Hash = hashing.HashBySHA384(Value);
                Hashed.Add("SHA384 Bit :\n" + Hash + "\n");
            }
            if (chbsha512.Checked)
            {
                string Hash = hashing.HashBySHA512(Value);
                Hashed.Add("SHA512 Bit :\n" + Hash + "\n");
            }
            if (chbripemd160.Checked)
            {
                string Hash = hashing.HashByRIPEMD160(Value);
                Hashed.Add("RIPEMD160 Bit Bit :\n" + Hash + "\n");
            }
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 100;
            lblprogress.Text = "100%";
            ShowHashfrm showHashfrm = new ShowHashfrm(Hashed);
            showHashfrm.ShowDialog();
            progressBar1.Value = 0;
            lblprogress.Text = "0%";
        }


        private string GetInputRTB()
        {
            if (richTextBox1.Text != "")
            {
                return richTextBox1.Text;
            }
            else
            {
                MessageBox.Show("The Text Box Can't Be Null ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                GetInputRTB();
                return null;
            }
        }

        private List<string> GetInputFile()
        {
            if (!File.Exists(FilePath) || textBox1.Text == "")
            {
                MessageBox.Show("Error Can't Load Your File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return File.ReadAllLines(FilePath).ToList();
        }
    }
}
