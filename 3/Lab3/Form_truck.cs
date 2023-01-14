using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Figures;

namespace Lab3
{
    public partial class Form_truck : Form
    {
        Form1 form_1;
        public Form_truck(Form1 form_1)
        {
            InitializeComponent();
            this.form_1 = form_1;
        }

        private void BtnDraw_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(truck_x.Text);
                int y = int.Parse(truck_y.Text);
                if (Init.Coords_check(x, y, 212, 175))
                {
                    form_1.truck_count += 1;
                    Truck truck = new Truck(form_1.truck_count, x, y, 212, 178);
                    ShapeContainer.AddFigure(truck);
                    form_1.bs.ResetBindings(false);
                    truck.Draw();
                }
                else
                {
                    MessageBox.Show("Фигура вышла за границы.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода.");
            }
        }
    }
}
