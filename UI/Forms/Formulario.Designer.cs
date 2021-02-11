
namespace UI.Forms
{
    partial class Formulario
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tlpBase = new System.Windows.Forms.TableLayoutPanel();
            this.tlpAside = new System.Windows.Forms.TableLayoutPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tlpSeleccion = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tlpBase.SuspendLayout();
            this.tlpAside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tlpSeleccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpBase
            // 
            this.tlpBase.ColumnCount = 2;
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.125F));
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.875F));
            this.tlpBase.Controls.Add(this.tlpAside, 0, 0);
            this.tlpBase.Controls.Add(this.chart2, 1, 0);
            this.tlpBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpBase.Location = new System.Drawing.Point(0, 0);
            this.tlpBase.Name = "tlpBase";
            this.tlpBase.RowCount = 1;
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBase.Size = new System.Drawing.Size(1000, 600);
            this.tlpBase.TabIndex = 0;
            // 
            // tlpAside
            // 
            this.tlpAside.ColumnCount = 1;
            this.tlpAside.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAside.Controls.Add(this.chart1, 0, 1);
            this.tlpAside.Controls.Add(this.textBox1, 0, 3);
            this.tlpAside.Controls.Add(this.tlpSeleccion, 0, 0);
            this.tlpAside.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAside.Location = new System.Drawing.Point(3, 3);
            this.tlpAside.Name = "tlpAside";
            this.tlpAside.RowCount = 4;
            this.tlpAside.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAside.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAside.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAside.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAside.Size = new System.Drawing.Size(215, 594);
            this.tlpAside.TabIndex = 0;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 151);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(209, 142);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 447);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(209, 144);
            this.textBox1.TabIndex = 2;
            // 
            // tlpSeleccion
            // 
            this.tlpSeleccion.ColumnCount = 1;
            this.tlpSeleccion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSeleccion.Controls.Add(this.pictureBox1, 0, 0);
            this.tlpSeleccion.Controls.Add(this.listBox1, 0, 1);
            this.tlpSeleccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSeleccion.Location = new System.Drawing.Point(3, 3);
            this.tlpSeleccion.Name = "tlpSeleccion";
            this.tlpSeleccion.RowCount = 2;
            this.tlpSeleccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.33334F));
            this.tlpSeleccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.66667F));
            this.tlpSeleccion.Size = new System.Drawing.Size(209, 142);
            this.tlpSeleccion.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Ander",
            "Jon",
            "Mikel"});
            this.listBox1.Location = new System.Drawing.Point(3, 107);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(203, 32);
            this.listBox1.TabIndex = 1;
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Transparent;
            this.chart2.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            this.chart2.BorderlineColor = System.Drawing.Color.Transparent;
            this.chart2.BorderlineWidth = 0;
            chartArea2.AxisX.IsMarginVisible = false;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX.LabelStyle.Interval = 0D;
            chartArea2.AxisX.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisX2.MajorGrid.Enabled = false;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipX;
            chartArea2.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            chartArea2.BorderWidth = 4;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart2.Location = new System.Drawing.Point(224, 3);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series2.BorderWidth = 0;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.SystemColors.ActiveCaption;
            series2.CustomProperties = "DrawSideBySide=True, EmptyPointValue=Zero";
            series2.EmptyPointStyle.CustomProperties = "LabelStyle=Top";
            series2.EmptyPointStyle.IsValueShownAsLabel = true;
            series2.EmptyPointStyle.LabelAngle = 10;
            series2.EmptyPointStyle.LabelForeColor = System.Drawing.Color.Maroon;
            series2.EmptyPointStyle.MarkerBorderColor = System.Drawing.Color.Transparent;
            series2.EmptyPointStyle.MarkerColor = System.Drawing.Color.Transparent;
            series2.IsVisibleInLegend = false;
            series2.IsXValueIndexed = true;
            series2.LabelForeColor = System.Drawing.Color.SaddleBrown;
            series2.MarkerBorderColor = System.Drawing.Color.Transparent;
            series2.MarkerBorderWidth = 0;
            series2.MarkerColor = System.Drawing.Color.Transparent;
            series2.MarkerSize = 0;
            series2.Name = "Series1";
            series2.SmartLabelStyle.Enabled = false;
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(773, 594);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.tlpBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formulario";
            this.Text = "Formulario";
            this.tlpBase.ResumeLayout(false);
            this.tlpAside.ResumeLayout(false);
            this.tlpAside.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tlpSeleccion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBase;
        private System.Windows.Forms.TableLayoutPanel tlpAside;
        private System.Windows.Forms.TableLayoutPanel tlpSeleccion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}