using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace KNN
{
    public partial class Form1 : Form
    {
        private List<(float, float)> MO_1 = new List<(float, float)>();
        private List<(float, float)> MO_2 = new List<(float, float)>();
        private List<(float, float)> MExam = new List<(float, float)>();
        private List<(int, double)> distances;
        private List<(int, List<(int, double)>)> sequences;
        private List<(double, int[], int[], double, double)> result_list;
        Random rand_num = new Random();
        int caption_exam;

        public Form1()
        {
            InitializeComponent();
            dataGridView_weight.Rows.Add(textBox_weight_num.Text);
            comboBox_distances.Text = comboBox_distances.Items[0].ToString();
        }

        private void button_solve_Click(object sender, EventArgs e)
        {
            if (MO_1.Count == 0 || MO_2.Count == 0 || MExam.Count == 0)
            {
                MessageBox.Show("Введите все объекты.");
            }
            else if (MO_1.Count < Convert.ToInt32(textBox_neighbours.Text) || MO_2.Count < Convert.ToInt32(textBox_neighbours.Text))
            {
                MessageBox.Show("Количество соседей не может быть больше количества объектов любого материала обучения.");
            }
            else
            {
                textBox_result.Clear();
                distances = new List<(int, double)>();
                sequences = new List<(int, List<(int, double)>)>();
                result_list = new List<(double, int[], int[], double, double)>();
                for (int i = 0; i < MExam.Count; i++)
                {
                    for (int j = 0; j < MO_1.Count + MO_2.Count; j++)
                    {
                        if (j < MO_1.Count)
                        {
                            distances.Add((0, Metrick_calculate(comboBox_distances.SelectedIndex, MO_1[j].Item1, MO_1[j].Item2, MExam[i].Item1, MExam[i].Item2, Convert.ToInt32(textBox_p.Text))));
                        }
                        else
                        {
                            distances.Add((1, Metrick_calculate(comboBox_distances.SelectedIndex, MO_2[j - MO_1.Count].Item1, MO_2[j - MO_1.Count].Item2, MExam[i].Item1, MExam[i].Item2, Convert.ToInt32(textBox_p.Text))));
                        }
                    }
                    Sort(ref distances);
                    sequences.Add((i, new List<(int, double)>(distances)));
                    distances.Clear();
                }
                int[] tmp_1 = new int[Convert.ToInt32(textBox_neighbours.Text)];
                int[] tmp_2 = new int[Convert.ToInt32(textBox_neighbours.Text)];
                foreach ((int, List<(int, double)>) elem in sequences)
                {
                    for (int i = 0; i < Convert.ToInt32(textBox_neighbours.Text); i++)
                    {
                        if (elem.Item2[i].Item1 == 0)
                        {
                            tmp_1[i] = 1;
                            tmp_2[i] = 0;
                        }
                        else
                        {
                            tmp_1[i] = 0;
                            tmp_2[i] = 1;
                        }
                    }

                    double num_1 = 0;
                    double num_2 = 0;
                    if (radioButton_weight_same.Checked)
                    {
                        for (int i = 0; i < Convert.ToInt32(textBox_neighbours.Text); i++)
                        {
                            num_1 += tmp_1[i] * Convert.ToDouble(textBox_weight_num.Text.Replace('.', ','));
                            num_2 += tmp_2[i] * Convert.ToDouble(textBox_weight_num.Text.Replace('.', ','));
                        }
                    }
                    else
                    {
                        for (int i = 0; i < Convert.ToInt32(textBox_neighbours.Text); i++)
                        {
                            try
                            {
                                num_1 += tmp_1[i] * Convert.ToDouble(Convert.ToString(dataGridView_weight[0, i].Value).Replace('.', ','));
                                num_2 += tmp_2[i] * Convert.ToDouble(Convert.ToString(dataGridView_weight[0, i].Value).Replace('.', ','));
                            }
                            catch
                            {
                                num_1 += tmp_1[i] * Convert.ToDouble(Convert.ToString(dataGridView_weight[0, i].Value));
                                num_2 += tmp_2[i] * Convert.ToDouble(Convert.ToString(dataGridView_weight[0, i].Value));
                            }
                        }
                    }
                    result_list.Add((elem.Item1, (int[])tmp_1.Clone(), (int[])tmp_2.Clone(), num_1, num_2));
                }

                foreach (var elem in result_list)
                {
                    if (elem.Item4 > elem.Item5)
                    {
                        textBox_result.Text += $"Элемент {elem.Item1 + 1} принадлежит группе 1\r\n";
                    }
                    else
                    {
                        textBox_result.Text += $"Элемент {elem.Item1 + 1} принадлежит группе 2\r\n";
                    }
                }
                button_excel_graph.Enabled = true;
                button_excel_graph.Visible = true;
            }
        }

        private void button_graph_Click(object sender, EventArgs e)
        {
            MO_1.Clear();
            MO_2.Clear();
            MExam.Clear();
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
            caption_exam = 1;

            groupBox_excel.Enabled = false;
            groupBox_excel.Visible = false;
            button_random.Enabled = false;
            button_random.Visible = false;
            groupBox_rand_input.Enabled = false;
            groupBox_rand_input.Visible = false;

            pictureBox_graph.Visible = true;
            pictureBox_graph.Enabled = true;
            groupBox_graph.Visible = true;
            groupBox_graph.Enabled = true;
            label_X.Visible = true;
            label_Y.Visible = true;
            label_coord_X.Visible = true;
            label_coord_Y.Visible = true;
        }

        private void button_excel_Click(object sender, EventArgs e)
        {
            MO_1.Clear();
            MO_2.Clear();
            MExam.Clear();

            pictureBox_graph.Visible = false;
            pictureBox_graph.Enabled = false;
            groupBox_graph.Visible = false;
            groupBox_graph.Enabled = false;
            label_X.Visible = false;
            label_Y.Visible = false;
            label_coord_X.Visible = false;
            label_coord_Y.Visible = false;

            groupBox_excel.Enabled = true;
            groupBox_excel.Visible = true;
            button_random.Enabled = true;
            button_random.Visible = true;
        }

        private void pictureBox_graph_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g = pictureBox_graph.CreateGraphics();
            Pen my_pen = new Pen(Color.Black);
            SolidBrush red_brush = new SolidBrush(Color.Red);
            SolidBrush blue_brush = new SolidBrush(Color.Blue);
            SolidBrush green_brush = new SolidBrush(Color.YellowGreen);

            if (radioButton1.Checked)
            {
                g.FillEllipse(red_brush, e.X - 6, e.Y - 6, 10, 10);
                MO_1.Add((e.X, 364 - e.Y));
            }
            else if (radioButton2.Checked)
            {
                g.FillEllipse(blue_brush, e.X - 6, e.Y - 6, 10, 10);
                MO_2.Add((e.X, 364 - e.Y));
            }
            else
            {
                g.FillEllipse(green_brush, e.X - 6, e.Y - 6, 10, 10);
                MExam.Add((e.X, 364 - e.Y));
                g.DrawString($"{caption_exam}", new Font("Calibri", 10, FontStyle.Bold), new SolidBrush(Color.Black), e.X, e.Y);
                caption_exam++;
            }
            g.DrawEllipse(my_pen, e.X - 6, e.Y - 6, 10, 10);
        }

        private void button_excel_input_Click(object sender, EventArgs e)
        {
            MO_1.Clear();
            MO_2.Clear();
            MExam.Clear();
            var flag = true;

            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                if (dataGridView1[0, i].Value != null && dataGridView1[1, i].Value != null)
                {
                    MO_1.Add((float.Parse(dataGridView1[0, i].Value.ToString()), float.Parse(dataGridView1[1, i].Value.ToString())));
                }
                else
                {
                    if (flag)
                    {
                        MessageBox.Show("Заполните все ячейки.");
                        flag = false;
                        break;
                    }
                }
            }

            for (int i = 0; i < dataGridView2.RowCount - 1; i++)
            {
                if (dataGridView2[0, i].Value != null && dataGridView2[1, i].Value != null)
                {
                    MO_2.Add((float.Parse(dataGridView2[0, i].Value.ToString()), float.Parse(dataGridView2[1, i].Value.ToString())));
                }
                else
                {
                    if (flag)
                    {
                        MessageBox.Show("Заполните все ячейки.");
                        flag = false;
                        break;
                    }
                }
            }

            for (int i = 0; i < dataGridView3.RowCount - 1; i++)
            {
                if (dataGridView3[0, i].Value != null && dataGridView3[1, i].Value != null)
                {
                    MExam.Add((float.Parse(dataGridView3[0, i].Value.ToString()), float.Parse(dataGridView3[1, i].Value.ToString())));
                }
                else
                {
                    if (flag)
                    {
                        MessageBox.Show("Заполните все ячейки.");
                        flag = false;
                        break;
                    }
                }
            }
        }

        private float normal_distribution(float mean, float sigma)
        {
            return (float)(mean + sigma * rand_num.Next(-1, 2));
        }

        private void button_random_Click(object sender, EventArgs e)
        {
            groupBox_rand_input.Enabled = true;
            groupBox_rand_input.Visible = true;
        }

        private void button_random_gen_Click(object sender, EventArgs e)
        {
            float x;
            float y;

            MO_1.Clear();
            MO_2.Clear();
            MExam.Clear();
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();

            if (
                textBox_mean_X_1.Text != "" && textBox_mean_Y_1.Text != "" && textBox_sigma_1.Text != "" && textBox_count_1.Text != "" &&
                textBox_mean_X_2.Text != "" && textBox_mean_Y_2.Text != "" && textBox_sigma_2.Text != "" && textBox_count_2.Text != "" &&
                textBox_mean_X_exam.Text != "" && textBox_mean_Y_exam.Text != "" && textBox_sigma_exam.Text != "" && textBox_count_exam.Text != ""
                )
            {
                for (int i = 0; i < Convert.ToInt32(textBox_count_1.Text); i++)
                {
                    x = normal_distribution(float.Parse(textBox_mean_X_1.Text), float.Parse(textBox_sigma_1.Text));
                    y = normal_distribution(float.Parse(textBox_mean_Y_1.Text), float.Parse(textBox_sigma_1.Text));
                    MO_1.Add((x, y));
                }

                for (int i = 0; i < Convert.ToInt32(textBox_count_2.Text); i++)
                {
                    x = normal_distribution(float.Parse(textBox_mean_X_2.Text), float.Parse(textBox_sigma_2.Text));
                    y = normal_distribution(float.Parse(textBox_mean_Y_2.Text), float.Parse(textBox_sigma_2.Text));
                    MO_2.Add((x, y));
                }

                for (int i = 0; i < Convert.ToInt32(textBox_count_exam.Text); i++)
                {
                    x = normal_distribution(float.Parse(textBox_mean_X_exam.Text), float.Parse(textBox_sigma_exam.Text));
                    y = normal_distribution(float.Parse(textBox_mean_Y_exam.Text), float.Parse(textBox_sigma_exam.Text));
                    MExam.Add((x, y));
                }

                for (int i = 0; i < MO_1.Count; i++)
                {
                    dataGridView1.Rows.Add(MO_1[i].Item1, MO_1[i].Item2);
                }

                for (int i = 0; i < MO_2.Count; i++)
                {
                    dataGridView2.Rows.Add(MO_2[i].Item1, MO_2[i].Item2);
                }

                for (int i = 0; i < MExam.Count; i++)
                {
                    dataGridView3.Rows.Add(MExam[i].Item1, MExam[i].Item2);
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля.");
            }
        }

        private void textBox_X_name_TextChanged(object sender, EventArgs e)
        {
            label_X.Text = textBox_X_name.Text;
            Column_X1.HeaderText = textBox_X_name.Text;
            Column_X2.HeaderText = textBox_X_name.Text;
            Column_Xe.HeaderText = textBox_X_name.Text;
        }

        private void textBox_Y_name_TextChanged(object sender, EventArgs e)
        {
            label_Y.Text = textBox_Y_name.Text;
            Column_Y1.HeaderText = textBox_Y_name.Text;
            Column_Y2.HeaderText = textBox_Y_name.Text;
            Column_Ye.HeaderText = textBox_Y_name.Text;
        }

        private void textBox_weight_num_TextChanged(object sender, EventArgs e)
        {
            if (MExam.Count != 0)
            {
                dataGridView_weight.Rows.Clear();
                dataGridView_weight.Rows.Add(textBox_weight_num.Text);
            }
            else
            {
                textBox_weight_num.Text = "0.5";
            }
        }

        private void radioButton_weight_same_Click(object sender, EventArgs e)
        {
            dataGridView_weight.Rows.Clear();
            dataGridView_weight.Enabled = false;
            dataGridView_weight.Visible = false;
            textBox_weight_num.Enabled = true;
            textBox_weight_num.Visible = true;
            dataGridView_weight.Rows.Add(textBox_weight_num.Text);
        }

        private void radioButton_weight_diff_Click(object sender, EventArgs e)
        {
            if (MExam.Count != 0)
            {
                dataGridView_weight.Enabled = true;
                dataGridView_weight.Visible = true;
                textBox_weight_num.Enabled = false;
                textBox_weight_num.Visible = false;
                dataGridView_weight.Rows.Clear();
                for (int i = 0; i < Convert.ToInt32(textBox_neighbours.Text); i++)
                {
                    dataGridView_weight.Rows.Add();
                }
            }
            else
            {
                radioButton_weight_same.Checked = true;
                MessageBox.Show("Введите хотя бы один материал экзамена.");
            }
        }

        private void textBox_weight_num_Click(object sender, EventArgs e)
        {
            if (MExam.Count == 0)
            {
                MessageBox.Show("Введите хотя бы один материал экзамена.");
            }
        }

        private void pictureBox_graph_MouseMove(object sender, MouseEventArgs e)
        {
            label_coord_X.Text = "X: " + Convert.ToString(e.X);
            label_coord_Y.Text = "Y: " + Convert.ToString(364 - e.Y);
        }

        private double Metrick_calculate(int choosen_metrick, float x_O, float y_O, float x_E, float y_E, int p)
        {
            if (choosen_metrick == 0) // Евклидова 
            {
                return Math.Sqrt(Math.Pow((x_O - x_E) + (y_O - y_E), 2));
            }
            else if (choosen_metrick == 1) // Минковского
            {
                return Math.Pow(Math.Pow((x_O - x_E) + (y_O - y_E), p), 1 / p);
            }
            else // Манхэттена
            {
                return Math.Abs((x_O - x_E) + (y_O - y_E));
            }
        }

        private void textBox_neighbours_TextChanged(object sender, EventArgs e)
        {
            label_neighbors_count.Text = "";
            try
            {
                if (Convert.ToInt32(textBox_neighbours.Text) <= 0)
                {
                    label_neighbors_count.Text = "Значение не может быть меньше или равным нулю";
                    button_solve.Enabled = false;
                }
                else if (Convert.ToInt32(textBox_neighbours.Text) > MO_1.Count || Convert.ToInt32(textBox_neighbours.Text) > MO_2.Count)
                {
                    label_neighbors_count.Text = "Значение не может быть больше кол-ва объектов";
                    button_solve.Enabled = false;
                }
                else if (Convert.ToInt32(textBox_neighbours.Text) % 2 == 0)
                {
                    label_neighbors_count.Text = "Значение не может быть четным";
                    button_solve.Enabled = false;
                }
                else if (Convert.ToInt32(textBox_neighbours.Text.Length) == 0)
                {
                    label_neighbors_count.Text = "Поле не может быть пустым";
                    button_solve.Enabled = false;
                }
                else
                {
                    if (MExam.Count != 0 && radioButton_weight_diff.Checked)
                    {
                        dataGridView_weight.Rows.Clear();
                        for (int i = 0; i < Convert.ToInt32(textBox_neighbours.Text); i++)
                        {
                            dataGridView_weight.Rows.Add();
                        }
                        dataGridView_weight.Enabled = true;
                        button_solve.Enabled = true;
                    }
                    else if (radioButton_weight_same.Checked)
                    {
                        button_solve.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Введите хотя бы один материал экзамена.");
                    }
                }
            }
            catch
            {
                label_neighbors_count.Text = "Неверное значение";
                button_solve.Enabled = false;
            }
        }

        private void comboBox_distances_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_distances.SelectedIndex == 1)
            {
                label_p.Visible = true;
                label_metric.Visible = true;
                textBox_p.Enabled = true;
                textBox_p.Visible = true;
            }
            else
            {
                label_p.Visible = false;
                label_metric.Visible = false;
                textBox_p.Enabled = false;
                textBox_p.Visible = false;
            }
        }

        private void textBox_p_TextChanged(object sender, EventArgs e)
        {
            label_metric.Text = "";
            try
            {
                if (Convert.ToInt32(textBox_p.Text) == 0)
                {
                    label_metric.Text = "Неверное значение";
                    button_solve.Enabled = false;
                }
                else
                {
                    button_solve.Enabled = true;
                }
            }
            catch
            {
                label_metric.Text = "Неверное значение";
                button_solve.Enabled = false;
            }
        }

        private void Sort(ref List<(int, double)> data)
        {
            for (int i = 1; i < data.Count; i++)
            {
                for (int j = 0; j < data.Count - 1; j++)
                {
                    if (data[j].Item2 > data[j + 1].Item2)
                    {
                        var tmp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = tmp;
                    }
                }
            }
        }

        private void button_excel_graph_Click(object sender, EventArgs e)
        {
            Form form = new Form_graph(ref MO_1, ref MO_2, ref MExam);
            form.Show();
        }
    }
}
