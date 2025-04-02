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
        private Shape selectedShape;
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
            int a = int.Parse(txtA.Text);
            int b = txtB.Text != "" ? int.Parse(txtB.Text) : 0;
            int x = int.Parse(txtX.Text);
            int y = int.Parse(txtY.Text);

            Shape shape = null;
            Rectangle rect = new Rectangle(a, b, x, y);
            Circle circle = new Circle(a, x, y);
            Square square = new Square (x, y, a);
            Triangle triangle = new Triangle (a, b, x, y);
            switch (type)
            {
                case "Rectangle":
                    shape = rect;
                    break;
                case "Square":
                    shape = square;
                    break;
                case "Triangle":
                    shape = triangle;
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
            txtA.Text = "";
            txtB.Text = "";
            txtX.Text = "";
            txtY.Text = "";

            lblA.Visible = false;
            lblB.Visible = false;
            txtA.Visible = false;
            txtB.Visible = false;
            lblX.Visible = false;
            lblY.Visible = false;
            txtX.Visible = false;
            txtY.Visible = false;
            btnAdd.Visible = false;
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
                    lblA.Text = "Enter a value for A: ";
                    lblB.Text = "Enter a value for B: ";
                    lblA.Visible = true;
                    lblB.Visible = true;
                    txtA.Visible = true;
                    txtB.Visible = true;
                    btnAdd.Visible = true;
                    lblX.Visible = true;
                    lblY.Visible = true;
                    txtX.Visible = true;
                    txtY.Visible = true;
                    break;
                case "Square":
                    lblA.Text = "Enter a value for A: ";
                    txtA.Visible = true;
                    txtB.Visible = false;
                    lblB.Visible = false;
                    lblA.Visible = true;
                    btnAdd.Visible = true;
                    lblX.Visible = true;
                    lblY.Visible = true;
                    txtX.Visible = true;
                    txtY.Visible = true;
                    break;
                case "Triangle":
                    txtA.Visible = true;
                    lblA.Visible = true;
                    lblA.Text = "Enter a value for A: ";
                    txtB.Visible = true;
                    lblB.Visible = true;
                    lblB.Text = "Enter a value for H: ";
                    btnAdd.Visible = true;
                    lblX.Visible = true;
                    lblY.Visible = true;
                    txtX.Visible = true;
                    txtY.Visible = true;
                    break;
                case "Circle":
                    lblA.Text = "Enter a value for R: ";
                    txtA.Visible = true;
                    txtB.Visible = false;
                    lblB.Visible = false;
                    lblA.Visible = true;
                    btnAdd.Visible = true;
                    lblX.Visible = true;
                    lblY.Visible = true;
                    txtX.Visible = true;
                    txtY.Visible = true;
                    break;
                default:
                    MessageBox.Show("The figure you selected does not exist!");
                    break;
            }
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            selectedShape = lstFigures.SelectedIndex >= 0 ? shapes[lstFigures.SelectedIndex] : null;

            if (selectedShape == null)
            {
                MessageBox.Show("Please select a shape to draw!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DrawingForm drawForm = new DrawingForm(selectedShape);
            drawForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstFigures.SelectedIndex;
            shapes.RemoveAt(selectedIndex); 
            lstFigures.Items.RemoveAt(selectedIndex);
            MessageBox.Show("The figure was deleted successfully!");
        }
    }
}

