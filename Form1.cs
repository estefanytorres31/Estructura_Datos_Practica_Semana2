namespace Practica2
{
    public partial class Form1 : Form
    {
        Lista lista= new Lista();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (txtDato.Text.Trim() != "")
            {
                Libro libro = new Libro(txtDato.Text);
                lista.Insertar(libro);

                txtLista.Text = lista.Imprimir();

                txtMensaje.Text = "Dato agregado correctamente";

                txtDato.Clear();
                //txtDato.Focus(); ->Limpia casilla
            }
            else
            {
                MessageBox.Show("Ingrese el código del libro");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtBuscar.Text.Trim()!="")
            {
                bool encontrado =lista.Buscar(txtBuscar.Text);

                if (encontrado)
                {
                    txtMensaje.Text = "El libro con código " +
                    txtBuscar.Text + " fue encontrado";
                }
                else
                {
                    txtMensaje.Text = "El libro con código " +
                    txtBuscar.Text + " No existe";
                }
            }
            else
            {
                MessageBox.Show("Ingrese un codigo para buscar");
            }
        }
    }
}
