namespace Charts
{
    partial class Funny
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Funny));
            this.funnychart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.funnychart)).BeginInit();
            this.SuspendLayout();
            // 
            // funnychart
            // 
            chartArea1.Name = "ChartArea1";
            this.funnychart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.funnychart.Legends.Add(legend1);
            this.funnychart.Location = new System.Drawing.Point(-3, 2);
            this.funnychart.Name = "funnychart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "gameofthrones";
            this.funnychart.Series.Add(series1);
            this.funnychart.Size = new System.Drawing.Size(1257, 637);
            this.funnychart.TabIndex = 0;
            this.funnychart.Text = "chart1";
            title1.BackColor = System.Drawing.Color.Blue;
            title1.Font = new System.Drawing.Font("Segoe Print", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "Title1";
            title1.Text = "Reactions to Last Night \'Game of Thrones\'";
            this.funnychart.Titles.Add(title1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe Print", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1082, 645);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Funny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1258, 722);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.funnychart);
            this.Name = "Funny";
            this.Text = "funny";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.funny_FormClosing);
            this.Load += new System.EventHandler(this.funny_Load);
            ((System.ComponentModel.ISupportInitialize)(this.funnychart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart funnychart;
        private System.Windows.Forms.Button button1;
    }
}