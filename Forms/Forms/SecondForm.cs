using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class SecondForm : Form
    {
        public SecondForm(string text)
        {
            InitializeComponent();
            label1.Text = text;
        }

        private void SecondForm_Load(object sender, EventArgs e)
        {

        }
    }
}
