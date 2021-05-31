using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KNN
{
    public partial class Form_graph : Form
    {
        public List<(float, float)> a;
        public List<(float, float)> b;
        public List<(float, float)> c;

        public Form_graph(ref List<(float, float)> materila_1, ref List<(float, float)> material_2, ref List<(float, float)> material_exam)
        {
            InitializeComponent();
            a = materila_1;
            b = material_2;
            c = material_exam;

            draw_chart();
        }

        private void draw_chart()
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();

            for (int i = 0; i < a.Count; i++)
            {
                chart1.Series[0].Points.AddXY(a[i].Item1, a[i].Item2);
            }

            for (int i = 0; i < b.Count; i++)
            {
                chart1.Series[1].Points.AddXY(b[i].Item1, b[i].Item2);
            }

            for (int i = 0; i < c.Count; i++)
            {
                chart1.Series[2].Points.AddXY(c[i].Item1, c[i].Item2);
            }
        }
    }
}
