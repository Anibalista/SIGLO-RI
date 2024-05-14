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
            string contraseñaBuscar = txtContraseña.Text;

            //crear un Objeto usuarios vacio llamado parametro
            Usuarios parametro = new Usuarios();

            // Verificamos que no hayan espacios en blanco o ingreso nulo
            if (!String.IsNullOrWhiteSpace(usuarioBuscar) && !String.IsNullOrWhiteSpace(contraseñaBuscar))
            {
                // insertamos los text box en las properties del objeto Usuarios llamado 'parametro'
                parametro.NombreUsuario = usuarioBuscar;
                parametro.ClaveUsuario = contraseñaBuscar;

                //llamamos al metodo login de la capa negocio enviandole el objeto Usuarios 'parametro' como parametro

                if (LoginUsuario.login(parametro)) //el metodo login devuelve true o false
                {
                    //si devuelve true debe abrir el MDI Parent 'FrmPrincipal' y cerrar el login

                    //Prueba con un mensaje
                    MessageBox.Show("Ingreso Exitoso");
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrectas");
                }
            }

            else
            {
                _ = MessageBox.Show("Ingrese Usuario y Contraseña correctos.");
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