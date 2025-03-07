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
            habitacionselecionada = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            addreservation = new Button();
            total = new Label();
            pagoTotal = new Label();
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
            // habitacionselecionada
            // 
            habitacionselecionada.AutoSize = true;
            habitacionselecionada.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            habitacionselecionada.Location = new Point(25, 63);
            habitacionselecionada.Name = "habitacionselecionada";
            habitacionselecionada.Size = new Size(249, 26);
            habitacionselecionada.TabIndex = 1;
            habitacionselecionada.Text = "reservacion de habitacion";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(25, 215);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(295, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(361, 215);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(292, 27);
            dateTimePicker2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 166);
            label1.Name = "label1";
            label1.Size = new Size(153, 26);
            label1.TabIndex = 4;
            label1.Text = "Fecha de inicio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(361, 166);
            label2.Name = "label2";
            label2.Size = new Size(127, 26);
            label2.TabIndex = 5;
            label2.Text = "Fecha de fin";
            // 
            // addreservation
            // 
            addreservation.Location = new Point(202, 356);
            addreservation.Name = "addreservation";
            addreservation.Size = new Size(133, 44);
            addreservation.TabIndex = 6;
            addreservation.Text = "Reservar";
            addreservation.UseVisualStyleBackColor = true;
            // 
            // total
            // 
            total.AutoSize = true;
            total.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            total.Location = new Point(47, 293);
            total.Name = "total";
            total.Size = new Size(152, 26);
            total.TabIndex = 7;
            total.Text = "Monto a pagar:";
            // 
            // pagoTotal
            // 
            pagoTotal.AutoSize = true;
            pagoTotal.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pagoTotal.Location = new Point(216, 293);
            pagoTotal.Name = "pagoTotal";
            pagoTotal.Size = new Size(23, 26);
            pagoTotal.TabIndex = 8;
            pagoTotal.Text = "$";
            // 
            // newbookings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pagoTotal);
            Controls.Add(total);
            Controls.Add(addreservation);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(habitacionselecionada);
            Controls.Add(home);
            Name = "newbookings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "newbookings";
            Load += newbookings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button home;
        private Label habitacionselecionada;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Label label2;
        private Button addreservation;
        private Label total;
        private Label pagoTotal;
    }
}