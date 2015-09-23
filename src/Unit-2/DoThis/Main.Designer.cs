namespace ChartApp
{
    partial class Main
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.sysChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cpuToggleButton = new System.Windows.Forms.Button();
            this.memoryToggleButton = new System.Windows.Forms.Button();
            this.diskToggleButton = new System.Windows.Forms.Button();
            this.pauseResumeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sysChart)).BeginInit();
            this.SuspendLayout();
            // 
            // sysChart
            // 
            chartArea3.Name = "ChartArea1";
            this.sysChart.ChartAreas.Add(chartArea3);
            this.sysChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.sysChart.Legends.Add(legend3);
            this.sysChart.Location = new System.Drawing.Point(0, 0);
            this.sysChart.Name = "sysChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.sysChart.Series.Add(series3);
            this.sysChart.Size = new System.Drawing.Size(684, 446);
            this.sysChart.TabIndex = 0;
            this.sysChart.Text = "sysChart";
            // 
            // cpuToggleButton
            // 
            this.cpuToggleButton.Location = new System.Drawing.Point(580, 353);
            this.cpuToggleButton.Name = "cpuToggleButton";
            this.cpuToggleButton.Size = new System.Drawing.Size(92, 23);
            this.cpuToggleButton.TabIndex = 1;
            this.cpuToggleButton.Text = "CPU (OFF)";
            this.cpuToggleButton.UseVisualStyleBackColor = true;
            this.cpuToggleButton.Click += new System.EventHandler(this.cpuToggleButton_Click);
            // 
            // memoryToggleButton
            // 
            this.memoryToggleButton.Location = new System.Drawing.Point(580, 382);
            this.memoryToggleButton.Name = "memoryToggleButton";
            this.memoryToggleButton.Size = new System.Drawing.Size(92, 23);
            this.memoryToggleButton.TabIndex = 1;
            this.memoryToggleButton.Text = "MEMORY (OFF)";
            this.memoryToggleButton.UseVisualStyleBackColor = true;
            this.memoryToggleButton.Click += new System.EventHandler(this.memoryToggleButton_Click);
            // 
            // diskToggleButton
            // 
            this.diskToggleButton.Location = new System.Drawing.Point(580, 411);
            this.diskToggleButton.Name = "diskToggleButton";
            this.diskToggleButton.Size = new System.Drawing.Size(92, 23);
            this.diskToggleButton.TabIndex = 1;
            this.diskToggleButton.Text = "DISK (OFF)";
            this.diskToggleButton.UseVisualStyleBackColor = true;
            this.diskToggleButton.Click += new System.EventHandler(this.diskToggleButton_Click);
            // 
            // pauseResumeButton
            // 
            this.pauseResumeButton.Location = new System.Drawing.Point(580, 324);
            this.pauseResumeButton.Name = "pauseResumeButton";
            this.pauseResumeButton.Size = new System.Drawing.Size(92, 23);
            this.pauseResumeButton.TabIndex = 1;
            this.pauseResumeButton.Text = "PAUSE ||";
            this.pauseResumeButton.UseVisualStyleBackColor = true;
            this.pauseResumeButton.Click += new System.EventHandler(this.pauseResumeButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 446);
            this.Controls.Add(this.diskToggleButton);
            this.Controls.Add(this.memoryToggleButton);
            this.Controls.Add(this.pauseResumeButton);
            this.Controls.Add(this.cpuToggleButton);
            this.Controls.Add(this.sysChart);
            this.Name = "Main";
            this.Text = "System Metrics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sysChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart sysChart;
        private System.Windows.Forms.Button cpuToggleButton;
        private System.Windows.Forms.Button memoryToggleButton;
        private System.Windows.Forms.Button diskToggleButton;
        private System.Windows.Forms.Button pauseResumeButton;
    }
}

