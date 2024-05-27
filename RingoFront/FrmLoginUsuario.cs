using RingoEntidades;
using RingoNegocio;

namespace RingoFront
{
    public partial class FrmLoginUsuario : Form
    {
        List<Usuarios> usuariolista = new List<Usuarios>();
        public FrmLoginUsuario()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            buscarUsuario();
        }

        private void buscarUsuario()
        {
            // recuperar texto de los text box
            string usuarioBuscar = txtUsuario.Text.Trim().ToUpper();
            string contrase�aBuscar = txtContrase�a.Text;

            //crear un Objeto usuarios vacio llamado parametro
            Usuarios parametro = new Usuarios();

            // Verificamos que no hayan espacios en blanco o ingreso nulo
            if (!String.IsNullOrWhiteSpace(usuarioBuscar) && !String.IsNullOrWhiteSpace(contrase�aBuscar))
            {
                // insertamos los text box en las properties del objeto Usuarios llamado 'parametro'
                parametro.NombreUsuario = usuarioBuscar;
                parametro.ClaveUsuario = contrase�aBuscar;

                //llamamos al metodo login de la capa negocio enviandole el objeto Usuarios 'parametro' como parametro

                if (LoginUsuario.login(parametro)) //el metodo login devuelve true o false
                {
                    //si devuelve true debe abrir el 'FrmPrincipal' y cerrar el login
                    this.Visible = false;
                    FrmPrincipal frm = new FrmPrincipal();
                    frm.ShowDialog();

                    MessageBox.Show("Gracias por usar SIGLO RI");
                    
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o Contrase�a incorrectas");
                }
            }

            else
            {
                MessageBox.Show("Ingrese Usuario y Contrase�a .");
            }
        }

        private void enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscarUsuario();
            }
        }


    }

}