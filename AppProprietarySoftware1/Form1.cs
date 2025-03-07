namespace AppProprietarySoftware1
{
    public partial class Form1 : Form
    {
        

        //lista de usuarios
        List<Cliente> usuarios = new List<Cliente>();
        
        //instancia de las habitaciones
        private Hotel hotel;

        public Form1()
        {
            InitializeComponent();
            hotel = new Hotel();

        }

       

        private void adduser_Click(object sender, EventArgs e)
        {
            //En el parentesis mandamos la lista
            addingusers adding = new addingusers(usuarios);
            adding.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void disponibility_Click(object sender, EventArgs e)
        {
            disponibilities dis = new disponibilities(hotel);
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
