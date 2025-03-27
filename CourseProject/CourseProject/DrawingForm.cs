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
    public partial class DrawingForm : Form
    {
        private Shape shape;
        private bool isDragging = false; 
        private bool isResizing = false;
        private Point lastMousePosition;
        private const int HandleSize = 10;

        public DrawingForm(Shape shape)
        {
            InitializeComponent();
            this.shape = shape;
            this.Text = "Draw Shape";
            this.BackColor = Color.White;
            this.Size = new Size(500, 500);

            this.MouseDown += DrawingForm_MouseDown;
            this.MouseMove += DrawingForm_MouseMove;
            this.MouseUp += DrawingForm_MouseUp;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (shape != null)
            {
                shape.Draw(e.Graphics);

                DrawResizeHandle(e.Graphics);
            }
        }

        private void DrawResizeHandle(Graphics g)
        {
            if (shape is Circle circle)
            {
                g.FillRectangle(Brushes.Red,
                    circle.X + circle.Radius - HandleSize / 2,
                    circle.Y + circle.Radius - HandleSize / 2,
                    HandleSize, HandleSize);
            }
            else if (shape is Rectangle rect)
            {
                g.FillRectangle(Brushes.Red,
                    rect.X + rect.Width - HandleSize / 2,
                    rect.Y + rect.Height - HandleSize / 2,
                    HandleSize, HandleSize);
            }
            else if (shape is Square square)
            {
                g.FillRectangle(Brushes.Red,
                    square.X + square.A - HandleSize / 2,
                    square.Y + square.A - HandleSize / 2,
                    HandleSize, HandleSize);
            }
            else if (shape is Triangle triangle)
            {
                g.FillRectangle(Brushes.Red,
                    triangle.X + triangle.BaseLength / 2 - HandleSize / 2,
                    triangle.Y - triangle.Height - HandleSize / 2,
                    HandleSize, HandleSize);
            }
        }

        private void DrawingForm_Load(object sender, EventArgs e)
        {
        }
        private void DrawingForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (IsMouseOverResizeHandle(e.Location))
            {
                isResizing = true;
                lastMousePosition = e.Location;
            }
            else if (IsMouseOverShape(e.Location))
            {
                isDragging = true;
                lastMousePosition = e.Location;
            }
        }
        private void DrawingForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isResizing && shape != null)
            {
                // Изчисляване на разликата в позициите
                int deltaX = e.X - lastMousePosition.X;
                int deltaY = e.Y - lastMousePosition.Y;

                // Актуализиране на размера на фигурата
                if (shape is Circle circle)
                {
                    circle.Radius += deltaX; // Увеличаваме радиуса
                }
                else if (shape is Rectangle rect)
                {
                    rect.Width += deltaX;
                    rect.Height += deltaY;
                }
                else if (shape is Square square)
                {
                    square.A += Math.Min(deltaX, deltaY); // Промяна на размера
                }
                else if (shape is Triangle triangle)
                {
                    triangle.BaseLength += deltaX;
                    triangle.Height += deltaY;
                }

                // Запомняме текущата позиция на мишката
                lastMousePosition = e.Location;

                // Прерисуване
                this.Invalidate();
            }
            else if (isDragging && shape != null)
            {
                // Логика за преместване на фигурата
                int deltaX = e.X - lastMousePosition.X;
                int deltaY = e.Y - lastMousePosition.Y;

                shape.X += deltaX;
                shape.Y += deltaY;

                lastMousePosition = e.Location;

                this.Invalidate();
            }
        }

        private void DrawingForm_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            isResizing = false;
        }

        private bool IsMouseOverShape(Point mousePosition)
        {

            if (shape is Circle circle)
            {
                int dx = mousePosition.X - circle.X;
                int dy = mousePosition.Y - circle.Y;
                return dx * dx + dy * dy <= circle.Radius * circle.Radius;
            }
            else if (shape is Rectangle rect)
            {
                return mousePosition.X >= rect.X && mousePosition.X <= rect.X + rect.Width &&
                       mousePosition.Y >= rect.Y && mousePosition.Y <= rect.Y + rect.Height;
            }
            else if (shape is Square square)
            {
                return mousePosition.X >= square.X && mousePosition.X <= square.X + square.A &&
                       mousePosition.Y >= square.Y && mousePosition.Y <= square.Y + square.A;
            }
            else if (shape is Triangle triangle)
            {
                int baseX = triangle.X;
                int baseY = triangle.Y;
                return mousePosition.Y <= baseY && mousePosition.Y >= baseY - triangle.Height &&
                       mousePosition.X >= baseX - triangle.BaseLength / 2 &&
                       mousePosition.X <= baseX + triangle.BaseLength / 2;
            }
            return false;
        }

        private bool IsMouseOverResizeHandle(Point mousePosition)
        {
            if (shape is Circle circle)
            {
                int handleX = circle.X + circle.Radius;
                int handleY = circle.Y + circle.Radius;
                return Math.Abs(mousePosition.X - handleX) <= HandleSize &&
                       Math.Abs(mousePosition.Y - handleY) <= HandleSize;
            }
            else if (shape is Rectangle rect)
            {
                int handleX = rect.X + rect.Width;
                int handleY = rect.Y + rect.Height;
                return Math.Abs(mousePosition.X - handleX) <= HandleSize &&
                       Math.Abs(mousePosition.Y - handleY) <= HandleSize;
            }
            else if (shape is Square square)
            {
                int handleX = square.X + square.A;
                int handleY = square.Y + square.A;
                return Math.Abs(mousePosition.X - handleX) <= HandleSize &&
                       Math.Abs(mousePosition.Y - handleY) <= HandleSize;
            }
            else if (shape is Triangle triangle)
            {
                int handleX = triangle.X + triangle.BaseLength / 2;
                int handleY = triangle.Y - triangle.Height;
                return Math.Abs(mousePosition.X - handleX) <= HandleSize &&
                       Math.Abs(mousePosition.Y - handleY) <= HandleSize;
            }
            return false;
        }
    }
}
