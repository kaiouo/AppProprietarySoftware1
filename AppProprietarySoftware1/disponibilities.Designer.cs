namespace AppProprietarySoftware1
{
    partial class disponibilities
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(disponibilities));
            home = new Button();
            RoomsdataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)RoomsdataGridView).BeginInit();
            SuspendLayout();
            // 
            // home
            // 
            home.BackgroundImage = (Image)resources.GetObject("home.BackgroundImage");
            home.BackgroundImageLayout = ImageLayout.Center;
            home.Location = new Point(723, 12);
            home.Name = "home";
            home.Size = new Size(74, 72);
            home.TabIndex = 1;
            home.UseVisualStyleBackColor = true;
            home.Click += home_Click;
            // 
            // RoomsdataGridView
            // 
            RoomsdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RoomsdataGridView.Location = new Point(12, 21);
            RoomsdataGridView.Name = "RoomsdataGridView";
            RoomsdataGridView.RowHeadersWidth = 51;
            RoomsdataGridView.Size = new Size(705, 417);
            RoomsdataGridView.TabIndex = 2;
            RoomsdataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // disponibilities
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RoomsdataGridView);
            Controls.Add(home);
            Name = "disponibilities";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "disponibilities";
            ((System.ComponentModel.ISupportInitialize)RoomsdataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button home;
        private DataGridView RoomsdataGridView;
    }
}