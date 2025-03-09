namespace AppProprietarySoftware1
{
    public partial class Form1 : Form
    {


        //lista de usuarios
        List<Cliente> usuarios = new List<Cliente>();
        //diccionario
        private Dictionary<int, Reservacion> reservaciones;
        //instancia de las habitaciones
        private Hotel hotel;


        public Form1()
        {
            InitializeComponent();
            hotel = new Hotel();
            reservaciones = new Dictionary<int, Reservacion>(); //iniciar diccionario 

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
            disponibilities dis = new disponibilities(hotel, usuarios, reservaciones);
            dis.Show();
            this.Hide();
        }

        private void booking_Click(object sender, EventArgs e)
        {

        }

        private void currents_Click(object sender, EventArgs e)
        {
            currentbookings currents = new currentbookings(hotel, usuarios, reservaciones);
            currents.Show();
            this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void grafics_Click(object sender, EventArgs e)
        {
            Grafico graficos = new Grafico(hotel, usuarios, reservaciones);
            graficos.Show();
            this.Hide();
        }
    }
}
