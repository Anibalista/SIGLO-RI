using RingoEntidades;
using RingoNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RingoFront
{
    public partial class FrmEditClientes : Form
    {
        public EnumModoForm modo = EnumModoForm.Alta;
        public Personas _persona = new Personas();
        public List<Domicilios> _domicilios = new List<Domicilios>();
        public List<Ciudades> _ciudades = new List<Ciudades>();
        public List<Contactos> _contactos = new List<Contactos>();
        public List<Provincias> _provincias = new List<Provincias>();
        public List<Estados> _estados = new List<Estados>();
        public FrmEditClientes()
        {
            InitializeComponent();
        }


        private void CargarComboEstados ()
        {
            Estados estados = new Estados();
            estados.Estado = "Error: no fue \nPosible cargar Estados";
            estados.Indole = "Personas";
            List<Estados>? estados1 = new List<Estados>();
            estados1 = RingoNegocio.PersonasMetodos.EstadosPorIndole(estados.Indole);
            if (estados1 == null)
                _estados.Add(estados);
            estadosBindingSource.DataSource = _estados;
            cbEstados.SelectedIndex = 0;
        }

        private void CargarComboProvincias ()
        {
            Provincias provincia = new Provincias();
            provincia.NombreProvincia = "Provincia";
            provincia.IdProvincia = 0;
            _provincias.Add(provincia);
            List<Provincias>? provincias = RingoNegocio.DomiciliosMetodos.ProvinciasTodas();
            if (provincias != null && provincias.Count > 0)
                _provincias.AddRange(provincias);
            else
                _provincias[0].NombreProvincia = "Error: no fue \nPosible cargar Provincias";
            provinciasBindingSource.DataSource = _provincias;
            cbProvincias.SelectedIndex = 0;
        }

        private void CargarComboCiudades (Provincias p)
        {
            Ciudades ciudades = new Ciudades();
            ciudades.NombreCiudad = "Ciudad";
            ciudades.IdCiudad = 0;
            _ciudades.Add(ciudades);
            if (p == null)
            {
                _ciudades[0].NombreCiudad = "Error: no fue \nPosible cargar Provincias";
            }   
            else if (p.IdProvincia != 0)
            {
                List<Ciudades>? ciudades1 = RingoNegocio.DomiciliosMetodos.CiudadesPorProvincia(p);
                if (ciudades1 != null)
                    _ciudades.AddRange(ciudades1);
                else
                    _ciudades[0].NombreCiudad = "Error: no fue \nPosible cargar Ciudades";
            }
            CiudadesBindingSource.DataSource = _ciudades;
            cbCiudades.SelectedIndex = 0;
        }

        private void LimpiarControles()
        {
            txtIdCliente.Text = "";
            txtIdPersona.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtPreCuil.Text = "";
            txtPostCuil.Text = "";
            txtDni.Text = "";
            dtFechaNac.Value = DateTime.Now;
            txtObservaciones.Text = "";
            cbEstados.Items.Clear();
            cbDomicilios.Items.Clear();
            cbContactos.Items.Clear();
            cbCiudades.Items.Clear();
            cbProvincias.Items.Clear();
            cbRedesSociales.Items.Clear();
            cbBarrio.Items.Clear();
            checkBarrio.Checked = false;
            checkWhatsApp.Checked = true;
            checkEliminarContacto.Checked = false;
            checkEliminarDomicilio.Checked = false;
            txtCalle.Text = "";
            txtAltura.Text = "";
            txtPiso.Text = "";
            txtDepartamento.Text = "";
            txtCodPostal.Text = "";
            txtObsBarrio.Text = "";
            txtArea.Text = "";
            txtTelefono.Text = "";
            txtEMail.Text = "";
        }

        private void HabilitarControles(bool habilitar)
        {
            txtNombres.Enabled = habilitar;
            txtApellidos.Enabled = habilitar;
            txtPreCuil.Enabled = habilitar;
            txtPostCuil.Enabled = habilitar;
            txtDni.Enabled = habilitar;
            dtFechaNac.Enabled = habilitar;
            txtObservaciones.Enabled = habilitar;
            cbEstados.Enabled = habilitar;
            cbCiudades.Enabled = habilitar;
            cbProvincias.Enabled = habilitar;
            cbRedesSociales.Enabled = habilitar;
            cbBarrio.Enabled = habilitar;
            checkBarrio.Enabled = habilitar;
            checkWhatsApp.Enabled = habilitar;
            checkEliminarDomicilio.Enabled = habilitar;
            checkEliminarContacto.Enabled = habilitar;
            txtCalle.Enabled = habilitar;
            txtAltura.Enabled = habilitar;
            txtPiso.Enabled = habilitar;
            txtDepartamento.Enabled = habilitar;
            txtCodPostal.Enabled = habilitar;
            txtObsBarrio.Enabled = habilitar;
            txtArea.Enabled = habilitar;
            txtTelefono.Enabled = habilitar;
            txtEMail.Enabled = habilitar;
        }

        private void btnCancelarC1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
