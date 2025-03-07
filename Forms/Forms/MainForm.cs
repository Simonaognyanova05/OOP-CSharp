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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(textBox1.Text);
                int y = int.Parse(textBox2.Text);
                int width = int.Parse(textBox3.Text);
                int height = int.Parse(textBox4.Text);

                SecondForm drawForm = new SecondForm(x, y, width, height);
                drawForm.Show();
            }
            catch (FormatException)
            {
                MessageBox.Show("Моля, въведете валидни числови стойности!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
