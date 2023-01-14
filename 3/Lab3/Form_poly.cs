using System;
using System.Drawing;
using System.Windows.Forms;
using Figures;

namespace Lab3
{
    public partial class Form_poly : Form
    {
        int i;
        int numPoints;
        bool flag;
        Point[] points;
        Form1 form_1;
        
        public Form_poly(Form1 form_1)
        {
            InitializeComponent();
            this.form_1 = form_1;
            flag = false;
            i = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.flag == false)
            {
                try
                {
                    this.numPoints = int.Parse(dots_count.Text);
                    if (this.numPoints <= 2)
                    {
                        MessageBox.Show("Ошибка ввода.");
                        this.numPoints = 0;
                    }
                    else
                    {
                        this.points = new Point[numPoints];
                        this.flag = true;
                        dots_count.Enabled = false;
                        dot_x.Enabled = true;
                        dot_y.Enabled = true;
                        label3.Text = $"Введите координаты {i + 1} точки:";
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка ввода.");
                }
            }
            else
            {
                try
                {
                    int x = int.Parse(dot_x.Text);
                    int y = int.Parse(dot_y.Text);
                    if (i < numPoints - 1)
                    {
                        this.points[i].X = x;
                        this.points[i].Y = y;
                        i += 1;
                        label3.Text = $"Введите координаты {i + 1} точки:";
                    }
                    else
                    {
                        this.points[i].X = x;
                        this.points[i].Y = y;
                        btnAdd.Enabled = false;
                        btnDraw.Enabled = true;
                        this.flag = false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка ввода.");
                }
            }
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            if (Init.Coords_check(points, 0, 0))
            {
                form_1.poly_count += 1;
                Polygon polygon = new Polygon(form_1.poly_count, points);
                ShapeContainer.AddFigure(polygon);
                form_1.bs.ResetBindings(false);
                polygon.Draw();
                this.Close();
            }
            else
            {
                MessageBox.Show("Фигура вышла за границы.");
                this.Close();
            }
        }
    }
}
