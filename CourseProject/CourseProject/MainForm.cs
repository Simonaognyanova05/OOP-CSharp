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
            double a = double.Parse(txtX.Text);
            double b = double.Parse(txtY.Text);

            Shape shape = null;
            Rectangle rect = new Rectangle{ Width = a, Height = b};
            Circle circle = new Circle { Radius = a };
            switch (type)
            {
                case "Rectangle":
                    shape = rect;
                    break;
                case "Circle":
                    shape = circle;
                    break;
                default:
                    break;
            }
            shapes.Add(shape);
            lstFigures.Items.Add(shape);
            

            txtType.Text = "";
            txtX.Text = "";
            txtY.Text = "";
        }

        private void btnView_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Shape selected = lstFigures.SelectedItem as Shape;
            string area = (selected.CalculateArea()).ToString();
            txtArea.Text = area;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string type = txtType.Text;

            switch (type)
            {
                case "Rectangle":
                    lblX.Visible = true;
                    lblY.Visible = true;
                    txtX.Visible = true;
                    txtY.Visible = true;
                    btnAdd.Visible = true;
                    break;
                case "Square":
                    txtX.Visible = true;
                    lblX.Visible = true;
                    btnAdd.Visible = true;
                    break;
                case "Triangle":
                    txtX.Visible = true;
                    lblX.Visible = true;
                    txtY.Visible = true;
                    lblY.Visible = true;
                    lblY.Text = "H: ";
                    btnAdd.Visible = true;
                    break;
                case "Circle":
                    txtX.Visible = true;
                    lblX.Visible = true;
                    lblX.Text = "R: ";
                    btnAdd.Visible = true;
                    break;
                default:
                    break;
            }
        }
    }
}
