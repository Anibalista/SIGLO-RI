using RingoEntidades;
using RingoNegocio;

namespace RingoFront
{
    public partial class FrmLoginUsuario : Form
    {

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
            Usuarios parametro = new();

            //Creo un mensaje de error para Validar
            string mensaje = "";

            // Verificamos que no hayan espacios en blanco o ingreso nulo
            if (validarCampos(ref mensaje, usuarioBuscar, contraseñaBuscar))
            {
                // insertamos los text box en las properties del objeto Usuarios llamado 'parametro'
                parametro.NombreUsuario = usuarioBuscar;
                parametro.ClaveUsuario = contraseñaBuscar;
                int id = LoginUsuario.login(parametro);
                //llamamos al metodo login de la capa negocio enviandole el objeto Usuarios 'parametro' como parametro

                if (id > 0) //el metodo login devuelve true o false
                {
                    parametro.IdUsuario = id;
                    //Guarda las credenciales del usuairo que puede entrar el usuario
                    
                    if (LoginUsuario.Permisos(parametro))
                    {
                        txtUsuario.Text = "";
                        txtContraseña.Text = "";
                    }
                    
                    //si devuelve true debe abrir el MDI Parent 'FrmPrincipal' y cerrar el login




                    //Prueba con un mensaje
                    MessageBox.Show("Ingreso Exitoso.");

                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrectas");
                }
            }

            else
            {
                _ = MessageBox.Show("Error" + mensaje);
            }
        }

        private bool validarCampos(ref string mensaje, string usuario, string contrase )
        {
            if (String.IsNullOrWhiteSpace(usuario))
                mensaje += "\nIngrese un Usuario";
            if (String.IsNullOrWhiteSpace(contrase))
                mensaje += "\nIngrese una contraseña";
            if (!String.IsNullOrWhiteSpace(mensaje))
                return false;
            else
                return true;
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