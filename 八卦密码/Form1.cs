using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 八卦密码
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.btnEncode.Click += new System.EventHandler(delegate (object sender1, EventArgs e1)
            {
                this.rtboxCipher.Text = Coder.encode(rtboxText.Text);
            });
            this.btnDecode.Click += new System.EventHandler(delegate (object sender1, EventArgs e1)
            {
                this.rtboxText.Text = Coder.decode(rtboxCipher.Text);
            });
        }
    }
}
