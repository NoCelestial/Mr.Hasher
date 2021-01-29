using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mr.Hasher.WinApp
{
    public partial class ShowHashfrm : Form
    {
        public ShowHashfrm(List<string> Hasheds)
        {
            InitializeComponent();
            foreach (string hashed in Hasheds)
            {
                richTextBox1.AppendText(hashed+"\n");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
