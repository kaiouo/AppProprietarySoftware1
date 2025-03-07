namespace AppProprietarySoftware1
{
    partial class addingusers
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addingusers));
            home = new Button();
            label1 = new Label();
            adddata = new Button();
            name = new TextBox();
            dui = new TextBox();
            phonenumber = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            erpError = new ErrorProvider(components);
            clean = new Button();
            ((System.ComponentModel.ISupportInitialize)erpError).BeginInit();
            SuspendLayout();
            // 
            // home
            // 
            home.BackgroundImage = (Image)resources.GetObject("home.BackgroundImage");
            home.BackgroundImageLayout = ImageLayout.Center;
            home.Location = new Point(714, 12);
            home.Name = "home";
            home.Size = new Size(74, 72);
            home.TabIndex = 0;
            home.UseVisualStyleBackColor = true;
            home.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 29);
            label1.Name = "label1";
            label1.Size = new Size(216, 32);
            label1.TabIndex = 1;
            label1.Text = "Ingrese sus datos";
            // 
            // adddata
            // 
            adddata.Location = new Point(179, 342);
            adddata.Name = "adddata";
            adddata.Size = new Size(148, 38);
            adddata.TabIndex = 2;
            adddata.Text = "Agregar";
            adddata.UseVisualStyleBackColor = true;
            adddata.Click += adddata_Click;
            // 
            // name
            // 
            name.Location = new Point(202, 127);
            name.Name = "name";
            name.Size = new Size(394, 27);
            name.TabIndex = 3;
            // 
            // dui
            // 
            dui.Location = new Point(382, 194);
            dui.Name = "dui";
            dui.Size = new Size(214, 27);
            dui.TabIndex = 4;
            // 
            // phonenumber
            // 
            phonenumber.Location = new Point(303, 267);
            phonenumber.Name = "phonenumber";
            phonenumber.Size = new Size(293, 27);
            phonenumber.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(61, 128);
            label2.Name = "label2";
            label2.Size = new Size(94, 26);
            label2.TabIndex = 6;
            label2.Text = "Nombre:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(61, 193);
            label3.Name = "label3";
            label3.Size = new Size(315, 26);
            label3.TabIndex = 7;
            label3.Text = "Numero de identificacion (DUI):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(61, 266);
            label4.Name = "label4";
            label4.Size = new Size(204, 26);
            label4.TabIndex = 8;
            label4.Text = "Numero de telefono:";
            label4.Click += label4_Click;
            // 
            // erpError
            // 
            erpError.ContainerControl = this;
            // 
            // clean
            // 
            clean.Location = new Point(382, 342);
            clean.Name = "clean";
            clean.Size = new Size(148, 36);
            clean.TabIndex = 9;
            clean.Text = "Limpiar";
            clean.UseVisualStyleBackColor = true;
            clean.Click += clean_Click;
            // 
            // addingusers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(clean);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(phonenumber);
            Controls.Add(dui);
            Controls.Add(name);
            Controls.Add(adddata);
            Controls.Add(label1);
            Controls.Add(home);
            Name = "addingusers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "addingusers";
            ((System.ComponentModel.ISupportInitialize)erpError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button home;
        private Label label1;
        private Button adddata;
        private TextBox name;
        private TextBox dui;
        private TextBox phonenumber;
        private Label label2;
        private Label label3;
        private Label label4;
        private ErrorProvider erpError;
        private Button clean;
    }
}