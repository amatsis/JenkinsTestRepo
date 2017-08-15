using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JenkinsGitRepoTestProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_HelloWorld_Click(object sender, EventArgs e)
        {
            txt_HelloWorld.Text = "Whats up PCR testing out a pull?";
            lbl_HelloWorld.Text = "i guess this is a change";
        }
    }
}
