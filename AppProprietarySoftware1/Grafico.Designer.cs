namespace AppProprietarySoftware1
{
    partial class Grafico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grafico));
            System.Windows.Forms.DataVisualization.Charting.LineAnnotation lineAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            home = new Button();
            grafico1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            typesComboBox = new ComboBox();
            graficView = new Button();
            ((System.ComponentModel.ISupportInitialize)grafico1).BeginInit();
            SuspendLayout();
            // 
            // home
            // 
            home.BackgroundImage = (Image)resources.GetObject("home.BackgroundImage");
            home.BackgroundImageLayout = ImageLayout.Center;
            home.Location = new Point(729, 12);
            home.Name = "home";
            home.Size = new Size(59, 60);
            home.TabIndex = 3;
            home.UseVisualStyleBackColor = true;
            home.Click += home_Click;
            // 
            // grafico1
            // 
            lineAnnotation1.Name = "LineAnnotation1";
            grafico1.Annotations.Add(lineAnnotation1);
            chartArea1.Name = "ChartArea1";
            grafico1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            grafico1.Legends.Add(legend1);
            grafico1.Location = new Point(54, 43);
            grafico1.Name = "grafico1";
            grafico1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            grafico1.Series.Add(series1);
            grafico1.Size = new Size(452, 375);
            grafico1.TabIndex = 4;
            grafico1.Text = "grafico";
            // 
            // typesComboBox
            // 
            typesComboBox.FormattingEnabled = true;
            typesComboBox.Location = new Point(618, 168);
            typesComboBox.Name = "typesComboBox";
            typesComboBox.Size = new Size(151, 28);
            typesComboBox.TabIndex = 5;
            // 
            // graficView
            // 
            graficView.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            graficView.Location = new Point(635, 231);
            graficView.Name = "graficView";
            graficView.Size = new Size(125, 40);
            graficView.TabIndex = 6;
            graficView.Text = "Ver grafico";
            graficView.UseVisualStyleBackColor = true;
            graficView.Click += graficView_Click;
            // 
            // Grafico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(graficView);
            Controls.Add(typesComboBox);
            Controls.Add(grafico1);
            Controls.Add(home);
            Name = "Grafico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grafico";
            ((System.ComponentModel.ISupportInitialize)grafico1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button home;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico1;
        private ComboBox typesComboBox;
        private Button graficView;
    }
}