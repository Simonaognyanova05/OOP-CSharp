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
        private Shape selectedShape; // Променлива за съхранение на избраната фигура
        private bool isDragging = false;
        private Point offset; // За изместване на фигурата с мишката
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
            double a = double.Parse(txtA.Text);
            double b = txtB.Text != "" ? double.Parse(txtB.Text) : 0;
            float x = float.Parse(txtX.Text);
            float y = float.Parse(txtY.Text);

            Shape shape = null;
            Rectangle rect = new Rectangle{ Width = a, Height = b, X = x, Y = y};
            Circle circle = new Circle { Radius = a, X = x, Y = y };
            Square square = new Square { A = a, X = x, Y = y };
            Triangle triangle = new Triangle { A = a, H = b, X = x, Y = y };
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

            lblA.Visible = false;
            lblB.Visible = false;
            txtA.Visible = false;
            txtB.Visible = false;
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
                    txtA.Visible = true;
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
                    txtB.Visible = true;
                    lblB.Visible = true;
                    lblB.Text = "H: ";
                    btnAdd.Visible = true;
                    lblX.Visible = true;
                    lblY.Visible = true;
                    txtX.Visible = true;
                    txtY.Visible = true;
                    break;
                case "Circle":
                    txtA.Visible = true;
                    lblA.Visible = true;
                    lblA.Text = "R: ";
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
            selectedShape = lstFigures.SelectedItem as Shape;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}

