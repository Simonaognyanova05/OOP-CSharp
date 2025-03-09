using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawFigures
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedShape = cmbShapeType.SelectedItem.ToString();

                Shape shape = null;

                int x = int.Parse(txtX.Text);
                int y = int.Parse(txtY.Text);

                if (selectedShape == "Square")
                {
                    int side = int.Parse(txtDimension1.Text);
                    shape = new Square(x, y, side);
                }
                else if (selectedShape == "Rectangle")
                {
                    int width = int.Parse(txtDimension1.Text);
                    int height = int.Parse(txtDimension2.Text);
                    shape = new RectangleShape(x, y, width, height);
                }
                else if (selectedShape == "Circle")
                {
                    int radius = int.Parse(txtDimension1.Text);
                    shape = new Circle(x, y, radius);
                }
                else if (selectedShape == "Triangle")
                {
                    int baseLength = int.Parse(txtDimension1.Text);
                    int height = int.Parse(txtDimension2.Text);
                    shape = new Triangle(x, y, baseLength, height);
                }

                if (shape != null)
                {
                    DrawForm drawForm = new DrawForm(shape);
                    drawForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка: {ex.Message}", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
