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
                    //Guarda las credenciales del usuairo que puede entrar el usuario

                    
                    List<string>? acceso;
                    acceso = LoginUsuario.Permisos(parametro);
                    string mensaje = "Codigos de acceso: ";

                    if ( acceso != null)
                    {
                        for (int i = 0; i < acceso.Count(); i++)
                        {
                            mensaje += acceso.ElementAt(i);
                        }
                    }
                    else
                    {
                        mensaje = "No tiene codigos de acceso";
                    }

                    //si devuelve true debe abrir el MDI Parent 'FrmPrincipal' y cerrar el login




                    //Prueba con un mensaje
                    MessageBox.Show("Ingreso Exitoso. " + mensaje);

                }
                else
                {
                    MessageBox.Show("Usuario o Contrase�a incorrectas");
                }
            }

            else
            {
                _ = MessageBox.Show("Ingrese Usuario y Contrase�a correctos.");
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