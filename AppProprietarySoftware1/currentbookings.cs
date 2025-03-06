using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppProprietarySoftware1
{
    public partial class currentbookings : Form
    {
        public currentbookings()
        {
            InitializeComponent();
        }

        private void home_Click(object sender, EventArgs e)
        {
            Form1 mainForm = Application.OpenForms["Form1"] as Form1;
            if (mainForm != null)
            {
                mainForm.Show();
            }
            this.Close();
        }
    }
}
