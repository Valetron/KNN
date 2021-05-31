
namespace KNN
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.button_solve = new System.Windows.Forms.Button();
            this.pictureBox_graph = new System.Windows.Forms.PictureBox();
            this.label_X = new System.Windows.Forms.Label();
            this.label_Y = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_X1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Y1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column_X2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Y2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Column_Xe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Ye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_graph = new System.Windows.Forms.GroupBox();
            this.button_graph = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_excel = new System.Windows.Forms.Button();
            this.button_random = new System.Windows.Forms.Button();
            this.groupBox_excel = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button_excel_input = new System.Windows.Forms.Button();
            this.groupBox_rand_input = new System.Windows.Forms.GroupBox();
            this.textBox_mean_Y_exam = new System.Windows.Forms.TextBox();
            this.textBox_mean_Y_2 = new System.Windows.Forms.TextBox();
            this.textBox_mean_Y_1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_count_exam = new System.Windows.Forms.TextBox();
            this.textBox_count_2 = new System.Windows.Forms.TextBox();
            this.textBox_count_1 = new System.Windows.Forms.TextBox();
            this.textBox_sigma_exam = new System.Windows.Forms.TextBox();
            this.textBox_mean_X_exam = new System.Windows.Forms.TextBox();
            this.textBox_sigma_2 = new System.Windows.Forms.TextBox();
            this.textBox_mean_X_2 = new System.Windows.Forms.TextBox();
            this.textBox_sigma_1 = new System.Windows.Forms.TextBox();
            this.textBox_mean_X_1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_random_gen = new System.Windows.Forms.Button();
            this.textBox_X_name = new System.Windows.Forms.TextBox();
            this.textBox_Y_name = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_weight_num = new System.Windows.Forms.TextBox();
            this.radioButton_weight_diff = new System.Windows.Forms.RadioButton();
            this.radioButton_weight_same = new System.Windows.Forms.RadioButton();
            this.dataGridView_weight = new System.Windows.Forms.DataGridView();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_coord_X = new System.Windows.Forms.Label();
            this.label_coord_Y = new System.Windows.Forms.Label();
            this.comboBox_distances = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_neighbours = new System.Windows.Forms.TextBox();
            this.label_neighbors_count = new System.Windows.Forms.Label();
            this.textBox_p = new System.Windows.Forms.TextBox();
            this.label_p = new System.Windows.Forms.Label();
            this.label_metric = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.button_excel_graph = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_graph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox_graph.SuspendLayout();
            this.groupBox_excel.SuspendLayout();
            this.groupBox_rand_input.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_weight)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(30, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(180, 21);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1й материал обучения";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.SystemColors.Control;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton2.Location = new System.Drawing.Point(30, 54);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(180, 21);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2й материал обучения";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(30, 82);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(161, 21);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Материал экзамена";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // button_solve
            // 
            this.button_solve.Location = new System.Drawing.Point(23, 541);
            this.button_solve.Name = "button_solve";
            this.button_solve.Size = new System.Drawing.Size(121, 28);
            this.button_solve.TabIndex = 4;
            this.button_solve.Text = "Определить";
            this.button_solve.UseVisualStyleBackColor = true;
            this.button_solve.Click += new System.EventHandler(this.button_solve_Click);
            // 
            // pictureBox_graph
            // 
            this.pictureBox_graph.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox_graph.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_graph.BackgroundImage")));
            this.pictureBox_graph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_graph.Enabled = false;
            this.pictureBox_graph.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_graph.Image")));
            this.pictureBox_graph.InitialImage = null;
            this.pictureBox_graph.Location = new System.Drawing.Point(212, 29);
            this.pictureBox_graph.Name = "pictureBox_graph";
            this.pictureBox_graph.Size = new System.Drawing.Size(524, 449);
            this.pictureBox_graph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_graph.TabIndex = 5;
            this.pictureBox_graph.TabStop = false;
            this.pictureBox_graph.Visible = false;
            this.pictureBox_graph.WaitOnLoad = true;
            this.pictureBox_graph.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_graph_MouseClick);
            this.pictureBox_graph.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_graph_MouseMove);
            // 
            // label_X
            // 
            this.label_X.AutoSize = true;
            this.label_X.Location = new System.Drawing.Point(742, 461);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(82, 17);
            this.label_X.TabIndex = 6;
            this.label_X.Text = "1й признак";
            this.label_X.Visible = false;
            // 
            // label_Y
            // 
            this.label_Y.AutoSize = true;
            this.label_Y.Location = new System.Drawing.Point(209, 9);
            this.label_Y.Name = "label_Y";
            this.label_Y.Size = new System.Drawing.Size(82, 17);
            this.label_Y.TabIndex = 7;
            this.label_Y.Text = "2й признак";
            this.label_Y.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_X1,
            this.Column_Y1});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.WindowText;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dataGridView1.Location = new System.Drawing.Point(10, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(169, 145);
            this.dataGridView1.TabIndex = 8;
            // 
            // Column_X1
            // 
            this.Column_X1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_X1.HeaderText = "1й признак";
            this.Column_X1.MinimumWidth = 6;
            this.Column_X1.Name = "Column_X1";
            this.Column_X1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_X1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column_Y1
            // 
            this.Column_Y1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Y1.HeaderText = "2й признак";
            this.Column_Y1.MinimumWidth = 6;
            this.Column_Y1.Name = "Column_Y1";
            this.Column_Y1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_Y1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_X2,
            this.Column_Y2});
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.WindowText;
            this.dataGridView2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dataGridView2.Location = new System.Drawing.Point(185, 37);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 25;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView2.Size = new System.Drawing.Size(169, 145);
            this.dataGridView2.TabIndex = 10;
            // 
            // Column_X2
            // 
            this.Column_X2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_X2.HeaderText = "1й признак";
            this.Column_X2.MinimumWidth = 6;
            this.Column_X2.Name = "Column_X2";
            this.Column_X2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_X2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column_Y2
            // 
            this.Column_Y2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Y2.HeaderText = "2й признак";
            this.Column_Y2.MinimumWidth = 6;
            this.Column_Y2.Name = "Column_Y2";
            this.Column_Y2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_Y2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Xe,
            this.Column_Ye});
            this.dataGridView3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView3.EnableHeadersVisualStyles = false;
            this.dataGridView3.GridColor = System.Drawing.SystemColors.WindowText;
            this.dataGridView3.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dataGridView3.Location = new System.Drawing.Point(360, 37);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView3.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidth = 25;
            this.dataGridView3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView3.Size = new System.Drawing.Size(169, 145);
            this.dataGridView3.TabIndex = 11;
            // 
            // Column_Xe
            // 
            this.Column_Xe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Xe.HeaderText = "1й признак";
            this.Column_Xe.MinimumWidth = 6;
            this.Column_Xe.Name = "Column_Xe";
            this.Column_Xe.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_Xe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column_Ye
            // 
            this.Column_Ye.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Ye.HeaderText = "2й признак";
            this.Column_Ye.MinimumWidth = 6;
            this.Column_Ye.Name = "Column_Ye";
            this.Column_Ye.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_Ye.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox_graph
            // 
            this.groupBox_graph.Controls.Add(this.radioButton2);
            this.groupBox_graph.Controls.Add(this.radioButton1);
            this.groupBox_graph.Controls.Add(this.radioButton3);
            this.groupBox_graph.Enabled = false;
            this.groupBox_graph.Location = new System.Drawing.Point(745, 29);
            this.groupBox_graph.Name = "groupBox_graph";
            this.groupBox_graph.Size = new System.Drawing.Size(217, 124);
            this.groupBox_graph.TabIndex = 12;
            this.groupBox_graph.TabStop = false;
            this.groupBox_graph.Visible = false;
            // 
            // button_graph
            // 
            this.button_graph.Location = new System.Drawing.Point(33, 29);
            this.button_graph.Name = "button_graph";
            this.button_graph.Size = new System.Drawing.Size(111, 30);
            this.button_graph.TabIndex = 13;
            this.button_graph.Text = "Графический";
            this.button_graph.UseVisualStyleBackColor = true;
            this.button_graph.Click += new System.EventHandler(this.button_graph_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Выбор ввода значений";
            // 
            // button_excel
            // 
            this.button_excel.Location = new System.Drawing.Point(33, 66);
            this.button_excel.Name = "button_excel";
            this.button_excel.Size = new System.Drawing.Size(111, 32);
            this.button_excel.TabIndex = 15;
            this.button_excel.Text = "Табличный";
            this.button_excel.UseVisualStyleBackColor = true;
            this.button_excel.Click += new System.EventHandler(this.button_excel_Click);
            // 
            // button_random
            // 
            this.button_random.Enabled = false;
            this.button_random.Location = new System.Drawing.Point(33, 104);
            this.button_random.Name = "button_random";
            this.button_random.Size = new System.Drawing.Size(111, 46);
            this.button_random.TabIndex = 16;
            this.button_random.Text = "Случайные данные";
            this.button_random.UseVisualStyleBackColor = true;
            this.button_random.Visible = false;
            this.button_random.Click += new System.EventHandler(this.button_random_Click);
            // 
            // groupBox_excel
            // 
            this.groupBox_excel.Controls.Add(this.button_excel_graph);
            this.groupBox_excel.Controls.Add(this.label10);
            this.groupBox_excel.Controls.Add(this.label9);
            this.groupBox_excel.Controls.Add(this.label8);
            this.groupBox_excel.Controls.Add(this.button_excel_input);
            this.groupBox_excel.Controls.Add(this.dataGridView1);
            this.groupBox_excel.Controls.Add(this.dataGridView2);
            this.groupBox_excel.Controls.Add(this.dataGridView3);
            this.groupBox_excel.Enabled = false;
            this.groupBox_excel.Location = new System.Drawing.Point(215, 29);
            this.groupBox_excel.Name = "groupBox_excel";
            this.groupBox_excel.Size = new System.Drawing.Size(633, 204);
            this.groupBox_excel.TabIndex = 17;
            this.groupBox_excel.TabStop = false;
            this.groupBox_excel.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(374, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "материал экзамена";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(192, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "2й материал обучения";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "1й материал обучения";
            // 
            // button_excel_input
            // 
            this.button_excel_input.Location = new System.Drawing.Point(535, 37);
            this.button_excel_input.Name = "button_excel_input";
            this.button_excel_input.Size = new System.Drawing.Size(93, 27);
            this.button_excel_input.TabIndex = 12;
            this.button_excel_input.Text = "Ввести";
            this.button_excel_input.UseVisualStyleBackColor = true;
            this.button_excel_input.Click += new System.EventHandler(this.button_excel_input_Click);
            // 
            // groupBox_rand_input
            // 
            this.groupBox_rand_input.Controls.Add(this.textBox_mean_Y_exam);
            this.groupBox_rand_input.Controls.Add(this.textBox_mean_Y_2);
            this.groupBox_rand_input.Controls.Add(this.textBox_mean_Y_1);
            this.groupBox_rand_input.Controls.Add(this.label7);
            this.groupBox_rand_input.Controls.Add(this.textBox_count_exam);
            this.groupBox_rand_input.Controls.Add(this.textBox_count_2);
            this.groupBox_rand_input.Controls.Add(this.textBox_count_1);
            this.groupBox_rand_input.Controls.Add(this.textBox_sigma_exam);
            this.groupBox_rand_input.Controls.Add(this.textBox_mean_X_exam);
            this.groupBox_rand_input.Controls.Add(this.textBox_sigma_2);
            this.groupBox_rand_input.Controls.Add(this.textBox_mean_X_2);
            this.groupBox_rand_input.Controls.Add(this.textBox_sigma_1);
            this.groupBox_rand_input.Controls.Add(this.textBox_mean_X_1);
            this.groupBox_rand_input.Controls.Add(this.label6);
            this.groupBox_rand_input.Controls.Add(this.label5);
            this.groupBox_rand_input.Controls.Add(this.label4);
            this.groupBox_rand_input.Controls.Add(this.label3);
            this.groupBox_rand_input.Controls.Add(this.label2);
            this.groupBox_rand_input.Controls.Add(this.button_random_gen);
            this.groupBox_rand_input.Enabled = false;
            this.groupBox_rand_input.Location = new System.Drawing.Point(321, 239);
            this.groupBox_rand_input.Name = "groupBox_rand_input";
            this.groupBox_rand_input.Size = new System.Drawing.Size(423, 163);
            this.groupBox_rand_input.TabIndex = 19;
            this.groupBox_rand_input.TabStop = false;
            this.groupBox_rand_input.Visible = false;
            // 
            // textBox_mean_Y_exam
            // 
            this.textBox_mean_Y_exam.Location = new System.Drawing.Point(365, 53);
            this.textBox_mean_Y_exam.Name = "textBox_mean_Y_exam";
            this.textBox_mean_Y_exam.Size = new System.Drawing.Size(44, 22);
            this.textBox_mean_Y_exam.TabIndex = 18;
            // 
            // textBox_mean_Y_2
            // 
            this.textBox_mean_Y_2.Location = new System.Drawing.Point(256, 53);
            this.textBox_mean_Y_2.Name = "textBox_mean_Y_2";
            this.textBox_mean_Y_2.Size = new System.Drawing.Size(44, 22);
            this.textBox_mean_Y_2.TabIndex = 17;
            // 
            // textBox_mean_Y_1
            // 
            this.textBox_mean_Y_1.Location = new System.Drawing.Point(147, 53);
            this.textBox_mean_Y_1.Name = "textBox_mean_Y_1";
            this.textBox_mean_Y_1.Size = new System.Drawing.Size(44, 22);
            this.textBox_mean_Y_1.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Количество";
            // 
            // textBox_count_exam
            // 
            this.textBox_count_exam.Location = new System.Drawing.Point(343, 98);
            this.textBox_count_exam.Name = "textBox_count_exam";
            this.textBox_count_exam.Size = new System.Drawing.Size(44, 22);
            this.textBox_count_exam.TabIndex = 14;
            // 
            // textBox_count_2
            // 
            this.textBox_count_2.Location = new System.Drawing.Point(234, 98);
            this.textBox_count_2.Name = "textBox_count_2";
            this.textBox_count_2.Size = new System.Drawing.Size(44, 22);
            this.textBox_count_2.TabIndex = 13;
            // 
            // textBox_count_1
            // 
            this.textBox_count_1.Location = new System.Drawing.Point(125, 98);
            this.textBox_count_1.Name = "textBox_count_1";
            this.textBox_count_1.Size = new System.Drawing.Size(44, 22);
            this.textBox_count_1.TabIndex = 12;
            // 
            // textBox_sigma_exam
            // 
            this.textBox_sigma_exam.Location = new System.Drawing.Point(343, 76);
            this.textBox_sigma_exam.Name = "textBox_sigma_exam";
            this.textBox_sigma_exam.Size = new System.Drawing.Size(44, 22);
            this.textBox_sigma_exam.TabIndex = 11;
            // 
            // textBox_mean_X_exam
            // 
            this.textBox_mean_X_exam.Location = new System.Drawing.Point(321, 53);
            this.textBox_mean_X_exam.Name = "textBox_mean_X_exam";
            this.textBox_mean_X_exam.Size = new System.Drawing.Size(44, 22);
            this.textBox_mean_X_exam.TabIndex = 10;
            // 
            // textBox_sigma_2
            // 
            this.textBox_sigma_2.Location = new System.Drawing.Point(234, 76);
            this.textBox_sigma_2.Name = "textBox_sigma_2";
            this.textBox_sigma_2.Size = new System.Drawing.Size(44, 22);
            this.textBox_sigma_2.TabIndex = 9;
            // 
            // textBox_mean_X_2
            // 
            this.textBox_mean_X_2.Location = new System.Drawing.Point(212, 53);
            this.textBox_mean_X_2.Name = "textBox_mean_X_2";
            this.textBox_mean_X_2.Size = new System.Drawing.Size(44, 22);
            this.textBox_mean_X_2.TabIndex = 8;
            // 
            // textBox_sigma_1
            // 
            this.textBox_sigma_1.Location = new System.Drawing.Point(125, 76);
            this.textBox_sigma_1.Name = "textBox_sigma_1";
            this.textBox_sigma_1.Size = new System.Drawing.Size(44, 22);
            this.textBox_sigma_1.TabIndex = 7;
            // 
            // textBox_mean_X_1
            // 
            this.textBox_mean_X_1.Location = new System.Drawing.Point(103, 53);
            this.textBox_mean_X_1.Name = "textBox_mean_X_1";
            this.textBox_mean_X_1.Size = new System.Drawing.Size(44, 22);
            this.textBox_mean_X_1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Отклонение";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Среднее";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Экзамен";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "2й образ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "1й образ";
            // 
            // button_random_gen
            // 
            this.button_random_gen.Location = new System.Drawing.Point(212, 126);
            this.button_random_gen.Name = "button_random_gen";
            this.button_random_gen.Size = new System.Drawing.Size(88, 25);
            this.button_random_gen.TabIndex = 0;
            this.button_random_gen.Text = "Готово";
            this.button_random_gen.UseVisualStyleBackColor = true;
            this.button_random_gen.Click += new System.EventHandler(this.button_random_gen_Click);
            // 
            // textBox_X_name
            // 
            this.textBox_X_name.Location = new System.Drawing.Point(46, 403);
            this.textBox_X_name.Name = "textBox_X_name";
            this.textBox_X_name.Size = new System.Drawing.Size(85, 22);
            this.textBox_X_name.TabIndex = 20;
            this.textBox_X_name.Text = "1й признак";
            this.textBox_X_name.TextChanged += new System.EventHandler(this.textBox_X_name_TextChanged);
            // 
            // textBox_Y_name
            // 
            this.textBox_Y_name.Location = new System.Drawing.Point(46, 433);
            this.textBox_Y_name.Name = "textBox_Y_name";
            this.textBox_Y_name.Size = new System.Drawing.Size(85, 22);
            this.textBox_Y_name.TabIndex = 21;
            this.textBox_Y_name.Text = "2й признак";
            this.textBox_Y_name.TextChanged += new System.EventHandler(this.textBox_Y_name_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 381);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(175, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Задать имена признакам";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.textBox_weight_num);
            this.groupBox1.Controls.Add(this.radioButton_weight_diff);
            this.groupBox1.Controls.Add(this.radioButton_weight_same);
            this.groupBox1.Controls.Add(this.dataGridView_weight);
            this.groupBox1.Location = new System.Drawing.Point(15, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 222);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Задать веса";
            // 
            // textBox_weight_num
            // 
            this.textBox_weight_num.Location = new System.Drawing.Point(126, 22);
            this.textBox_weight_num.Name = "textBox_weight_num";
            this.textBox_weight_num.Size = new System.Drawing.Size(46, 22);
            this.textBox_weight_num.TabIndex = 3;
            this.textBox_weight_num.Text = "0.5";
            this.textBox_weight_num.Click += new System.EventHandler(this.textBox_weight_num_Click);
            this.textBox_weight_num.TextChanged += new System.EventHandler(this.textBox_weight_num_TextChanged);
            // 
            // radioButton_weight_diff
            // 
            this.radioButton_weight_diff.AutoSize = true;
            this.radioButton_weight_diff.Location = new System.Drawing.Point(7, 49);
            this.radioButton_weight_diff.Name = "radioButton_weight_diff";
            this.radioButton_weight_diff.Size = new System.Drawing.Size(79, 21);
            this.radioButton_weight_diff.TabIndex = 2;
            this.radioButton_weight_diff.Text = "Разные";
            this.radioButton_weight_diff.UseVisualStyleBackColor = true;
            this.radioButton_weight_diff.Click += new System.EventHandler(this.radioButton_weight_diff_Click);
            // 
            // radioButton_weight_same
            // 
            this.radioButton_weight_same.AutoSize = true;
            this.radioButton_weight_same.Checked = true;
            this.radioButton_weight_same.Location = new System.Drawing.Point(7, 22);
            this.radioButton_weight_same.Name = "radioButton_weight_same";
            this.radioButton_weight_same.Size = new System.Drawing.Size(112, 21);
            this.radioButton_weight_same.TabIndex = 1;
            this.radioButton_weight_same.TabStop = true;
            this.radioButton_weight_same.Text = "Одинаковые";
            this.radioButton_weight_same.UseVisualStyleBackColor = true;
            this.radioButton_weight_same.Click += new System.EventHandler(this.radioButton_weight_same_Click);
            // 
            // dataGridView_weight
            // 
            this.dataGridView_weight.AllowUserToAddRows = false;
            this.dataGridView_weight.AllowUserToResizeColumns = false;
            this.dataGridView_weight.AllowUserToResizeRows = false;
            this.dataGridView_weight.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_weight.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_weight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_weight.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_weight.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView_weight.ColumnHeadersHeight = 20;
            this.dataGridView_weight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_weight.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Weight});
            this.dataGridView_weight.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView_weight.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView_weight.Enabled = false;
            this.dataGridView_weight.EnableHeadersVisualStyles = false;
            this.dataGridView_weight.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dataGridView_weight.Location = new System.Drawing.Point(7, 76);
            this.dataGridView_weight.Name = "dataGridView_weight";
            this.dataGridView_weight.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_weight.RowHeadersVisible = false;
            this.dataGridView_weight.RowHeadersWidth = 30;
            this.dataGridView_weight.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_weight.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridView_weight.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView_weight.RowTemplate.Height = 24;
            this.dataGridView_weight.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_weight.Size = new System.Drawing.Size(110, 113);
            this.dataGridView_weight.TabIndex = 0;
            this.dataGridView_weight.Visible = false;
            // 
            // Weight
            // 
            this.Weight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Weight.HeaderText = "Вес";
            this.Weight.MinimumWidth = 6;
            this.Weight.Name = "Weight";
            this.Weight.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Weight.Width = 64;
            // 
            // label_coord_X
            // 
            this.label_coord_X.AutoSize = true;
            this.label_coord_X.Location = new System.Drawing.Point(835, 162);
            this.label_coord_X.Name = "label_coord_X";
            this.label_coord_X.Size = new System.Drawing.Size(0, 17);
            this.label_coord_X.TabIndex = 25;
            this.label_coord_X.Visible = false;
            // 
            // label_coord_Y
            // 
            this.label_coord_Y.AutoSize = true;
            this.label_coord_Y.Location = new System.Drawing.Point(835, 183);
            this.label_coord_Y.Name = "label_coord_Y";
            this.label_coord_Y.Size = new System.Drawing.Size(0, 17);
            this.label_coord_Y.TabIndex = 26;
            this.label_coord_Y.Visible = false;
            // 
            // comboBox_distances
            // 
            this.comboBox_distances.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_distances.FormattingEnabled = true;
            this.comboBox_distances.Items.AddRange(new object[] {
            "Евклидова",
            "Минковского",
            "Манхэттена"});
            this.comboBox_distances.Location = new System.Drawing.Point(23, 482);
            this.comboBox_distances.Name = "comboBox_distances";
            this.comboBox_distances.Size = new System.Drawing.Size(121, 24);
            this.comboBox_distances.TabIndex = 27;
            this.comboBox_distances.SelectedIndexChanged += new System.EventHandler(this.comboBox_distances_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(55, 461);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = "Метрика";
            // 
            // textBox_neighbours
            // 
            this.textBox_neighbours.Location = new System.Drawing.Point(97, 513);
            this.textBox_neighbours.Name = "textBox_neighbours";
            this.textBox_neighbours.Size = new System.Drawing.Size(34, 22);
            this.textBox_neighbours.TabIndex = 29;
            this.textBox_neighbours.Text = "5";
            this.textBox_neighbours.TextChanged += new System.EventHandler(this.textBox_neighbours_TextChanged);
            // 
            // label_neighbors_count
            // 
            this.label_neighbors_count.AutoSize = true;
            this.label_neighbors_count.Location = new System.Drawing.Point(137, 516);
            this.label_neighbors_count.Name = "label_neighbors_count";
            this.label_neighbors_count.Size = new System.Drawing.Size(0, 17);
            this.label_neighbors_count.TabIndex = 30;
            // 
            // textBox_p
            // 
            this.textBox_p.Enabled = false;
            this.textBox_p.Location = new System.Drawing.Point(178, 482);
            this.textBox_p.Name = "textBox_p";
            this.textBox_p.Size = new System.Drawing.Size(28, 22);
            this.textBox_p.TabIndex = 31;
            this.textBox_p.Text = "1";
            this.textBox_p.Visible = false;
            this.textBox_p.TextChanged += new System.EventHandler(this.textBox_p_TextChanged);
            // 
            // label_p
            // 
            this.label_p.AutoSize = true;
            this.label_p.Location = new System.Drawing.Point(150, 485);
            this.label_p.Name = "label_p";
            this.label_p.Size = new System.Drawing.Size(28, 17);
            this.label_p.TabIndex = 32;
            this.label_p.Text = "p =";
            this.label_p.Visible = false;
            // 
            // label_metric
            // 
            this.label_metric.AutoSize = true;
            this.label_metric.Location = new System.Drawing.Point(212, 485);
            this.label_metric.Name = "label_metric";
            this.label_metric.Size = new System.Drawing.Size(0, 17);
            this.label_metric.TabIndex = 33;
            this.label_metric.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 515);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 17);
            this.label13.TabIndex = 34;
            this.label13.Text = "Соседей:";
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(489, 487);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_result.Size = new System.Drawing.Size(258, 82);
            this.textBox_result.TabIndex = 35;
            // 
            // button_excel_graph
            // 
            this.button_excel_graph.Enabled = false;
            this.button_excel_graph.Location = new System.Drawing.Point(535, 70);
            this.button_excel_graph.Name = "button_excel_graph";
            this.button_excel_graph.Size = new System.Drawing.Size(93, 30);
            this.button_excel_graph.TabIndex = 16;
            this.button_excel_graph.Text = "График";
            this.button_excel_graph.UseVisualStyleBackColor = true;
            this.button_excel_graph.Visible = false;
            this.button_excel_graph.Click += new System.EventHandler(this.button_excel_graph_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 579);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox_excel);
            this.Controls.Add(this.label_metric);
            this.Controls.Add(this.label_p);
            this.Controls.Add(this.textBox_p);
            this.Controls.Add(this.label_neighbors_count);
            this.Controls.Add(this.textBox_neighbours);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox_graph);
            this.Controls.Add(this.comboBox_distances);
            this.Controls.Add(this.label_coord_Y);
            this.Controls.Add(this.label_coord_X);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox_Y_name);
            this.Controls.Add(this.textBox_X_name);
            this.Controls.Add(this.groupBox_rand_input);
            this.Controls.Add(this.button_random);
            this.Controls.Add(this.button_excel);
            this.Controls.Add(this.button_solve);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_graph);
            this.Controls.Add(this.label_Y);
            this.Controls.Add(this.label_X);
            this.Controls.Add(this.pictureBox_graph);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "K-nearest neighbors algorithm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_graph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox_graph.ResumeLayout(false);
            this.groupBox_graph.PerformLayout();
            this.groupBox_excel.ResumeLayout(false);
            this.groupBox_excel.PerformLayout();
            this.groupBox_rand_input.ResumeLayout(false);
            this.groupBox_rand_input.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_weight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button button_solve;
        private System.Windows.Forms.PictureBox pictureBox_graph;
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.Label label_Y;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.GroupBox groupBox_graph;
        private System.Windows.Forms.Button button_graph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_excel;
        private System.Windows.Forms.Button button_random;
        private System.Windows.Forms.GroupBox groupBox_excel;
        private System.Windows.Forms.Button button_excel_input;
        private System.Windows.Forms.GroupBox groupBox_rand_input;
        private System.Windows.Forms.TextBox textBox_sigma_exam;
        private System.Windows.Forms.TextBox textBox_mean_X_exam;
        private System.Windows.Forms.TextBox textBox_sigma_2;
        private System.Windows.Forms.TextBox textBox_mean_X_2;
        private System.Windows.Forms.TextBox textBox_sigma_1;
        private System.Windows.Forms.TextBox textBox_mean_X_1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_random_gen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_count_exam;
        private System.Windows.Forms.TextBox textBox_count_2;
        private System.Windows.Forms.TextBox textBox_count_1;
        private System.Windows.Forms.TextBox textBox_mean_Y_exam;
        private System.Windows.Forms.TextBox textBox_mean_Y_2;
        private System.Windows.Forms.TextBox textBox_mean_Y_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_X1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Y1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_X2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Y2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Xe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Ye;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_X_name;
        private System.Windows.Forms.TextBox textBox_Y_name;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.TextBox textBox_weight_num;
        private System.Windows.Forms.RadioButton radioButton_weight_diff;
        private System.Windows.Forms.RadioButton radioButton_weight_same;
        private System.Windows.Forms.Label label_coord_X;
        private System.Windows.Forms.Label label_coord_Y;
        private System.Windows.Forms.ComboBox comboBox_distances;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_neighbours;
        private System.Windows.Forms.Label label_neighbors_count;
        private System.Windows.Forms.TextBox textBox_p;
        private System.Windows.Forms.Label label_p;
        private System.Windows.Forms.Label label_metric;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Button button_excel_graph;
    }
}

