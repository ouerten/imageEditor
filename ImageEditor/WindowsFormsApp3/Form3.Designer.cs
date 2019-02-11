namespace WindowsFormsApp3
{
    partial class Form3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart5 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart6 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart7 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart8 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart8)).BeginInit();
            this.SuspendLayout();
            // 
            // chart5
            // 
            chartArea5.Name = "ChartArea1";
            this.chart5.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart5.Legends.Add(legend5);
            this.chart5.Location = new System.Drawing.Point(12, 12);
            this.chart5.Name = "chart5";
            this.chart5.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart5.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red};
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series5.IsXValueIndexed = true;
            series5.Legend = "Legend1";
            series5.Name = "Red";
            this.chart5.Series.Add(series5);
            this.chart5.Size = new System.Drawing.Size(630, 300);
            this.chart5.TabIndex = 0;
            this.chart5.Text = "chart5";
            // 
            // chart6
            // 
            chartArea6.Name = "ChartArea1";
            this.chart6.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart6.Legends.Add(legend6);
            this.chart6.Location = new System.Drawing.Point(649, 12);
            this.chart6.Name = "chart6";
            this.chart6.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart6.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))))};
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series6.IsXValueIndexed = true;
            series6.Legend = "Legend1";
            series6.Name = "Green";
            this.chart6.Series.Add(series6);
            this.chart6.Size = new System.Drawing.Size(630, 300);
            this.chart6.TabIndex = 1;
            this.chart6.Text = "chart6";
            // 
            // chart7
            // 
            this.chart7.BackImageTransparentColor = System.Drawing.Color.White;
            this.chart7.BorderSkin.PageColor = System.Drawing.Color.Silver;
            chartArea7.Name = "ChartArea1";
            this.chart7.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart7.Legends.Add(legend7);
            this.chart7.Location = new System.Drawing.Point(12, 318);
            this.chart7.Name = "chart7";
            this.chart7.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart7.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Blue};
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series7.IsXValueIndexed = true;
            series7.Legend = "Legend1";
            series7.Name = "Blue";
            this.chart7.Series.Add(series7);
            this.chart7.Size = new System.Drawing.Size(630, 300);
            this.chart7.TabIndex = 2;
            this.chart7.Text = "chart7";
            // 
            // chart8
            // 
            chartArea8.Name = "ChartArea1";
            this.chart8.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chart8.Legends.Add(legend8);
            this.chart8.Location = new System.Drawing.Point(649, 320);
            this.chart8.Name = "chart8";
            this.chart8.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart8.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.DimGray};
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series8.IsXValueIndexed = true;
            series8.Legend = "Legend1";
            series8.Name = "Grey";
            this.chart8.Series.Add(series8);
            this.chart8.Size = new System.Drawing.Size(630, 300);
            this.chart8.TabIndex = 3;
            this.chart8.Text = "chart8";
            // 
            // Form3
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1288, 632);
            this.Controls.Add(this.chart8);
            this.Controls.Add(this.chart7);
            this.Controls.Add(this.chart6);
            this.Controls.Add(this.chart5);
            this.Name = "Form3";
            this.Text = "Histogram";
            ((System.ComponentModel.ISupportInitialize)(this.chart5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart5;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart6;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart7;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart8;
    }
}