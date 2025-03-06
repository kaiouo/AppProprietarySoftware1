namespace AppProprietarySoftware1
{
    partial class newbookings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newbookings));
            home = new Button();
            SuspendLayout();
            // 
            // home
            // 
            home.BackgroundImage = (Image)resources.GetObject("home.BackgroundImage");
            home.BackgroundImageLayout = ImageLayout.Center;
            home.Location = new Point(709, 23);
            home.Name = "home";
            home.Size = new Size(65, 66);
            home.TabIndex = 0;
            home.UseVisualStyleBackColor = true;
            home.Click += button1_Click;
            // 
            // newbookings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(home);
            Name = "newbookings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "newbookings";
            ResumeLayout(false);
        }

        #endregion

        private Button home;
    }
}