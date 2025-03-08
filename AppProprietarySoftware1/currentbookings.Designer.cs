namespace AppProprietarySoftware1
{
    partial class currentbookings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(currentbookings));
            home = new Button();
            currentReservations = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)currentReservations).BeginInit();
            SuspendLayout();
            // 
            // home
            // 
            home.BackgroundImage = (Image)resources.GetObject("home.BackgroundImage");
            home.BackgroundImageLayout = ImageLayout.Center;
            home.Location = new Point(689, 28);
            home.Name = "home";
            home.Size = new Size(59, 60);
            home.TabIndex = 2;
            home.UseVisualStyleBackColor = true;
            home.Click += home_Click;
            // 
            // currentReservations
            // 
            currentReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            currentReservations.Location = new Point(91, 49);
            currentReservations.Name = "currentReservations";
            currentReservations.RowHeadersWidth = 51;
            currentReservations.Size = new Size(548, 375);
            currentReservations.TabIndex = 3;
            currentReservations.CellContentClick += currentReservations_CellContentClick;
            // 
            // currentbookings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(currentReservations);
            Controls.Add(home);
            Name = "currentbookings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "currentbookings";
            Load += currentbookings_Load;
            ((System.ComponentModel.ISupportInitialize)currentReservations).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button home;
        private DataGridView currentReservations;
    }
}