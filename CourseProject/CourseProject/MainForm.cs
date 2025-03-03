using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class MainForm : Form
    {
        List<Shape> shapes = new List<Shape>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string type = txtType.Text;
            int x = int.Parse(txtX.Text);
            int y = int.Parse(txtY.Text);

            shapes.Add(new Shape { Type = type, X = x, Y = y });
            lstFigures.Items.Add($"{type} - X: {x}; Y: {y}");

            txtType.Text = "";
            txtX.Text = "";
            txtY.Text = "";
        }

        private void btnView_Click(object sender, EventArgs e)
        {
        }
    }
}
