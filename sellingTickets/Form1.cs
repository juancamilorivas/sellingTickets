namespace sellingTickets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void agregar_Click(object sender, EventArgs e)
        {
            //Boton activador de datos recopilados en "intEdad" en forma de string
            int edad = int.Parse(intEdad.Text);
            string message = "";

            if(edad == 16)
            {
                message = "ERES MUY JOVEN, NO PUEDES ENTRAR!!";
            }
            else if (edad <= 21 & edad > 16)
            {
                message = "INGRESAS GRATIS!!";
            }
            else
            {
                message = "Debes pagar us4.00";
            }
            MessageBox.Show(message);
        }


        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}