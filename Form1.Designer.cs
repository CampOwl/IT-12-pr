
namespace it_lab_12
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
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.input_data = new System.Windows.Forms.DataGridView();
      this.arg = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.func = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Equations = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.paint_points = new System.Windows.Forms.Button();
      this.Matrix_I = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Matrix_II = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.coef_I = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.coef_II = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.calculate_I = new System.Windows.Forms.Button();
      this.calculate_II = new System.Windows.Forms.Button();
      this.paint_I = new System.Windows.Forms.Button();
      this.paint_II = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.input_data)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Equations)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Matrix_I)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Matrix_II)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.coef_I)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.coef_II)).BeginInit();
      this.SuspendLayout();
      // 
      // input_data
      // 
      this.input_data.AllowUserToAddRows = false;
      this.input_data.AllowUserToDeleteRows = false;
      this.input_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.input_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.arg,
            this.func});
      this.input_data.Location = new System.Drawing.Point(18, 42);
      this.input_data.Name = "input_data";
      this.input_data.ReadOnly = true;
      this.input_data.RowHeadersWidth = 51;
      this.input_data.RowTemplate.Height = 24;
      this.input_data.Size = new System.Drawing.Size(458, 258);
      this.input_data.TabIndex = 1;
      // 
      // arg
      // 
      this.arg.HeaderText = "x";
      this.arg.MinimumWidth = 6;
      this.arg.Name = "arg";
      this.arg.ReadOnly = true;
      this.arg.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.arg.Width = 125;
      // 
      // func
      // 
      this.func.HeaderText = "y";
      this.func.MinimumWidth = 6;
      this.func.Name = "func";
      this.func.ReadOnly = true;
      this.func.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.func.Width = 125;
      // 
      // Equations
      // 
      chartArea4.Name = "ChartArea1";
      this.Equations.ChartAreas.Add(chartArea4);
      legend4.Name = "Legend1";
      this.Equations.Legends.Add(legend4);
      this.Equations.Location = new System.Drawing.Point(18, 335);
      this.Equations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Equations.Name = "Equations";
      series4.ChartArea = "ChartArea1";
      series4.Legend = "Legend1";
      series4.Name = "Series1";
      this.Equations.Series.Add(series4);
      this.Equations.Size = new System.Drawing.Size(602, 363);
      this.Equations.TabIndex = 8;
      this.Equations.Text = "chart1";
      // 
      // paint_points
      // 
      this.paint_points.Location = new System.Drawing.Point(632, 408);
      this.paint_points.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.paint_points.Name = "paint_points";
      this.paint_points.Size = new System.Drawing.Size(244, 82);
      this.paint_points.TabIndex = 9;
      this.paint_points.Text = "Построить точки";
      this.paint_points.UseVisualStyleBackColor = true;
      this.paint_points.Click += new System.EventHandler(this.resultButton_click);
      // 
      // Matrix_I
      // 
      this.Matrix_I.AllowUserToAddRows = false;
      this.Matrix_I.AllowUserToDeleteRows = false;
      this.Matrix_I.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.Matrix_I.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column1,
            this.dataGridViewTextBoxColumn2});
      this.Matrix_I.Location = new System.Drawing.Point(498, 42);
      this.Matrix_I.Name = "Matrix_I";
      this.Matrix_I.ReadOnly = true;
      this.Matrix_I.RowHeadersWidth = 51;
      this.Matrix_I.RowTemplate.Height = 24;
      this.Matrix_I.Size = new System.Drawing.Size(387, 129);
      this.Matrix_I.TabIndex = 10;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.HeaderText = "S_0";
      this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridViewTextBoxColumn1.Width = 30;
      // 
      // Column1
      // 
      this.Column1.HeaderText = "S_1";
      this.Column1.MinimumWidth = 8;
      this.Column1.Name = "Column1";
      this.Column1.ReadOnly = true;
      this.Column1.Width = 30;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.HeaderText = "b";
      this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.ReadOnly = true;
      this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridViewTextBoxColumn2.Width = 50;
      // 
      // Matrix_II
      // 
      this.Matrix_II.AllowUserToAddRows = false;
      this.Matrix_II.AllowUserToDeleteRows = false;
      this.Matrix_II.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.Matrix_II.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Column2,
            this.dataGridViewTextBoxColumn5});
      this.Matrix_II.Location = new System.Drawing.Point(891, 42);
      this.Matrix_II.Name = "Matrix_II";
      this.Matrix_II.ReadOnly = true;
      this.Matrix_II.RowHeadersWidth = 51;
      this.Matrix_II.RowTemplate.Height = 24;
      this.Matrix_II.Size = new System.Drawing.Size(268, 258);
      this.Matrix_II.TabIndex = 11;
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.HeaderText = "S_0";
      this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      this.dataGridViewTextBoxColumn3.ReadOnly = true;
      this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridViewTextBoxColumn3.Width = 30;
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.HeaderText = "S_1";
      this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      this.dataGridViewTextBoxColumn4.ReadOnly = true;
      this.dataGridViewTextBoxColumn4.Width = 30;
      // 
      // Column2
      // 
      this.Column2.HeaderText = "S_2";
      this.Column2.MinimumWidth = 8;
      this.Column2.Name = "Column2";
      this.Column2.ReadOnly = true;
      this.Column2.Width = 30;
      // 
      // dataGridViewTextBoxColumn5
      // 
      this.dataGridViewTextBoxColumn5.HeaderText = "b";
      this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
      this.dataGridViewTextBoxColumn5.ReadOnly = true;
      this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridViewTextBoxColumn5.Width = 60;
      // 
      // coef_I
      // 
      this.coef_I.AllowUserToAddRows = false;
      this.coef_I.AllowUserToDeleteRows = false;
      this.coef_I.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.coef_I.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
      this.coef_I.Location = new System.Drawing.Point(498, 177);
      this.coef_I.Name = "coef_I";
      this.coef_I.ReadOnly = true;
      this.coef_I.RowHeadersWidth = 51;
      this.coef_I.RowTemplate.Height = 24;
      this.coef_I.Size = new System.Drawing.Size(231, 123);
      this.coef_I.TabIndex = 12;
      // 
      // dataGridViewTextBoxColumn6
      // 
      this.dataGridViewTextBoxColumn6.HeaderText = "";
      this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
      this.dataGridViewTextBoxColumn6.ReadOnly = true;
      this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridViewTextBoxColumn6.Width = 30;
      // 
      // dataGridViewTextBoxColumn7
      // 
      this.dataGridViewTextBoxColumn7.HeaderText = "Значение";
      this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
      this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
      this.dataGridViewTextBoxColumn7.ReadOnly = true;
      this.dataGridViewTextBoxColumn7.Width = 60;
      // 
      // coef_II
      // 
      this.coef_II.AllowUserToAddRows = false;
      this.coef_II.AllowUserToDeleteRows = false;
      this.coef_II.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.coef_II.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
      this.coef_II.Location = new System.Drawing.Point(1165, 42);
      this.coef_II.Name = "coef_II";
      this.coef_II.ReadOnly = true;
      this.coef_II.RowHeadersWidth = 51;
      this.coef_II.RowTemplate.Height = 24;
      this.coef_II.Size = new System.Drawing.Size(299, 165);
      this.coef_II.TabIndex = 13;
      // 
      // dataGridViewTextBoxColumn8
      // 
      this.dataGridViewTextBoxColumn8.HeaderText = "S";
      this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
      this.dataGridViewTextBoxColumn8.ReadOnly = true;
      this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridViewTextBoxColumn8.Width = 30;
      // 
      // dataGridViewTextBoxColumn9
      // 
      this.dataGridViewTextBoxColumn9.HeaderText = "Значение";
      this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
      this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
      this.dataGridViewTextBoxColumn9.ReadOnly = true;
      this.dataGridViewTextBoxColumn9.Width = 60;
      // 
      // calculate_I
      // 
      this.calculate_I.Location = new System.Drawing.Point(736, 179);
      this.calculate_I.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.calculate_I.Name = "calculate_I";
      this.calculate_I.Size = new System.Drawing.Size(149, 121);
      this.calculate_I.TabIndex = 14;
      this.calculate_I.Text = "Вычислить I";
      this.calculate_I.UseVisualStyleBackColor = true;
      this.calculate_I.Click += new System.EventHandler(this.button1_Click);
      // 
      // calculate_II
      // 
      this.calculate_II.Location = new System.Drawing.Point(1166, 215);
      this.calculate_II.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.calculate_II.Name = "calculate_II";
      this.calculate_II.Size = new System.Drawing.Size(244, 82);
      this.calculate_II.TabIndex = 15;
      this.calculate_II.Text = "Вычислить II";
      this.calculate_II.UseVisualStyleBackColor = true;
      this.calculate_II.Click += new System.EventHandler(this.button2_Click);
      // 
      // paint_I
      // 
      this.paint_I.Location = new System.Drawing.Point(632, 498);
      this.paint_I.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.paint_I.Name = "paint_I";
      this.paint_I.Size = new System.Drawing.Size(244, 82);
      this.paint_I.TabIndex = 16;
      this.paint_I.Text = "Построить I";
      this.paint_I.UseVisualStyleBackColor = true;
      this.paint_I.Click += new System.EventHandler(this.button3_Click);
      // 
      // paint_II
      // 
      this.paint_II.Location = new System.Drawing.Point(632, 589);
      this.paint_II.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.paint_II.Name = "paint_II";
      this.paint_II.Size = new System.Drawing.Size(244, 82);
      this.paint_II.TabIndex = 17;
      this.paint_II.Text = "Построить II";
      this.paint_II.UseVisualStyleBackColor = true;
      this.paint_II.Click += new System.EventHandler(this.button4_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(1110, 515);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(173, 37);
      this.label1.TabIndex = 18;
      this.label1.Text = "Вариант 3";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1476, 717);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.paint_II);
      this.Controls.Add(this.paint_I);
      this.Controls.Add(this.calculate_II);
      this.Controls.Add(this.calculate_I);
      this.Controls.Add(this.coef_II);
      this.Controls.Add(this.coef_I);
      this.Controls.Add(this.Matrix_II);
      this.Controls.Add(this.Matrix_I);
      this.Controls.Add(this.paint_points);
      this.Controls.Add(this.Equations);
      this.Controls.Add(this.input_data);
      this.Name = "Form1";
      this.Text = "Аппроксимация ";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.input_data)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Equations)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Matrix_I)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Matrix_II)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.coef_I)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.coef_II)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView input_data;
        private System.Windows.Forms.DataVisualization.Charting.Chart Equations;
        private System.Windows.Forms.Button paint_points;
    private System.Windows.Forms.DataGridViewTextBoxColumn arg;
    private System.Windows.Forms.DataGridViewTextBoxColumn func;
    private System.Windows.Forms.DataGridView Matrix_I;
    private System.Windows.Forms.DataGridView Matrix_II;
    private System.Windows.Forms.DataGridView coef_I;
    private System.Windows.Forms.DataGridView coef_II;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    private System.Windows.Forms.Button calculate_I;
    private System.Windows.Forms.Button calculate_II;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    private System.Windows.Forms.Button paint_I;
    private System.Windows.Forms.Button paint_II;
    private System.Windows.Forms.Label label1;
  }
}

