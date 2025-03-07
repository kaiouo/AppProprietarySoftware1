namespace AppProprietarySoftware1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            adduser = new Button();
            disponibility = new Button();
            currents = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // adduser
            // 
            adduser.Image = (Image)resources.GetObject("adduser.Image");
            adduser.Location = new Point(80, 294);
            adduser.Name = "adduser";
            adduser.Size = new Size(79, 77);
            adduser.TabIndex = 0;
            adduser.UseVisualStyleBackColor = true;
            adduser.Click += adduser_Click;
            // 
            // disponibility
            // 
            disponibility.Image = (Image)resources.GetObject("disponibility.Image");
            disponibility.Location = new Point(364, 291);
            disponibility.Name = "disponibility";
            disponibility.Size = new Size(79, 77);
            disponibility.TabIndex = 1;
            disponibility.UseVisualStyleBackColor = true;
            disponibility.Click += disponibility_Click;
            // 
            // currents
            // 
            currents.Image = (Image)resources.GetObject("currents.Image");
            currents.Location = new Point(642, 294);
            currents.Name = "currents";
            currents.Size = new Size(76, 74);
            currents.TabIndex = 3;
            currents.UseVisualStyleBackColor = true;
            currents.Click += currents_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cuarto_de_hotel11;
            pictureBox1.Location = new Point(80, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(638, 198);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(318, 107);
            label1.Name = "label1";
            label1.Size = new Size(154, 38);
            label1.TabIndex = 7;
            label1.Text = "Bienvenido";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(currents);
            Controls.Add(disponibility);
            Controls.Add(adduser);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button adduser;
        private Button disponibility;
        private Button currents;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
