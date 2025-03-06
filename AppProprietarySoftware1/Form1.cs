namespace AppProprietarySoftware1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void adduser_Click(object sender, EventArgs e)
        {
            addingusers adding = new addingusers();
            adding.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void disponibility_Click(object sender, EventArgs e)
        {
            disponibilities dis = new disponibilities();
            dis.Show();
            this.Hide();
        }

        private void booking_Click(object sender, EventArgs e)
        {
            newbookings newbooks = new newbookings();
            newbooks.Show();
            this.Hide();
        }

        private void currents_Click(object sender, EventArgs e)
        {
            currentbookings currents = new currentbookings();
            currents.Show();
            this.Hide();

        }
    }
}
