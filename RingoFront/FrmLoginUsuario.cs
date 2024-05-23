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

            // Verificamos que no hayan espacios en blanco o ingreso nulo
            if (!String.IsNullOrWhiteSpace(usuarioBuscar) && !String.IsNullOrWhiteSpace(contraseñaBuscar))
            {
                // insertamos los text box en las properties del objeto Usuarios llamado 'parametro'
                parametro.NombreUsuario = usuarioBuscar;
                parametro.ClaveUsuario = contraseñaBuscar;

                //llamamos al metodo login de la capa negocio enviandole el objeto Usuarios 'parametro' como parametro

                if (LoginUsuario.login(parametro)) //el metodo login devuelve true o false
                {
                    //Guarda las credenciales del usuairo que puede entrar el usuario

                    List<Credenciales>? credenciales = new();
                    credenciales = LoginUsuario.Permisos(parametro);
                    List<string>? acceso = new();
                    acceso = (from credencial in credenciales select credencial.CodigoCredencial).ToList();
                    string mensaje = "Codigos de acceso: \n";

                    if ( acceso != null)
                    {
                        for (int i = 0; i < acceso.Count(); i++)
                        {
                            mensaje += acceso.ElementAt(i);
                            if (i == acceso.Count() - 1)
                                mensaje += "!";
                            else
                                mensaje += "\n";
                        }
                    }
                    else
                    {
                        mensaje = "\n No tiene codigos de acceso";
                    }

                    //si devuelve true debe abrir el MDI Parent 'FrmPrincipal' y cerrar el login




                    //Prueba con un mensaje
                    MessageBox.Show("Ingreso Exitoso. \n" + mensaje);

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