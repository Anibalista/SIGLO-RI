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
        public List<RedesSociales> _redesSociales = new List<RedesSociales>();
        public FrmEditClientes()
        {
            InitializeComponent();
        }


        private void CargarComboEstados (Personas p)
        {
            _estados.Clear();
            Estados estados = new Estados();
            estados.Estado = "Error: no fue \nPosible cargar Estados";
            estados.Indole = "Personas";
            List<Estados>? estados1 = new List<Estados>();
            estados1 = RingoNegocio.PersonasMetodos.EstadosPorIndole(estados.Indole);
            if (estados1 == null)
                _estados.Add(estados);
            estadosBindingSource.DataSource = _estados;
            int i = 0;
            if (p != null)
            {
                Estados? actual = (from estado in _estados where estado.IdEstado == p.IdEstado select estado).FirstOrDefault();
                if (actual != null)
                    i = _estados.IndexOf(actual);
            }
            cbEstados.SelectedIndex = i;
        }

        private void CargarComboProvincias ()
        {
            _provincias.Clear();
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
            _ciudades.Clear();
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

        private void CargarComboRedesSociales ()
        {
            _redesSociales.Clear();
            RedesSociales redesSociales = new RedesSociales();
            redesSociales.NombreRedSocial = "Nueva Red Social";
            redesSociales.IdRedSocial = 0;
            _redesSociales.Add(redesSociales);
            List<RedesSociales>? redesSociales1 = RingoNegocio.PersonasMetodos.RedesSociales();
            if (redesSociales1 != null)
                _redesSociales.AddRange(redesSociales1);
            redesSocialesbindingSource.DataSource = _redesSociales;
            cbRedesSociales.SelectedIndex = 0;
        }

        private void CargarComboDomicilios(Personas? p)
        {
            _domicilios.Clear();
            List<Domicilios> DomiciliosMostrar = new();
            int i = 0;
            if (modo != EnumModoForm.Consulta)
            {
                Domicilios domicilios = new Domicilios();
                domicilios.Calle = "Nuevo Domicilio";
                domicilios.IdDomicilio = 0;
                _domicilios.Add(domicilios);
                DomiciliosMostrar.Add(domicilios);
                i++;
            }
            
            List<Domicilios>? domicilios1 = new();
            if (p != null)
                domicilios1 = RingoNegocio.DomiciliosMetodos.DomiciliosPersona(p);
            if (domicilios1 != null)
                _domicilios.AddRange(domicilios1);
            
            if (_domicilios.Count > i)
            {
                while (i < _domicilios.Count)
                {
                    Domicilios nuevo = new();
                    nuevo.IdDomicilio = _domicilios[i].IdDomicilio;
                    if (modo == EnumModoForm.Consulta)
                        nuevo.Calle = "Domicilio " + (i + 1);
                    else
                        nuevo.Calle = "Domicilio " + i;
                    DomiciliosMostrar.Add(nuevo);
                    i++;
                }
            }
            cbDomicilios.DataSource = DomiciliosMostrar;
            cbDomicilios.DisplayMember = "Calle";
            cbDomicilios.ValueMember = "IdDomicilio";
            cbDomicilios.SelectedIndex = 0;
        }

        private void CargarComboContactos(Personas p)
        {
            _contactos.Clear();
            List<Contactos> ContactosMostrar = new();
            int i = 0;
            if (modo != EnumModoForm.Consulta)
            {
                Contactos contactos = new Contactos();
                contactos.IdContacto = 0;
                contactos.Telefono = "Nuevo Contacto";
                _contactos.Add(contactos);
                ContactosMostrar.Add(contactos);
                i++;
            }
            List<Contactos>? contactos1 = new();
            if (p != null)
                contactos1 = RingoNegocio.ContactosMetodos.ContactosPorPersona(p);
            if (contactos1 != null)
                _contactos.AddRange(contactos1);

            if (_contactos.Count > i)
            {
                while (i < _contactos.Count)
                {
                    Contactos nuevo = new();
                    nuevo.IdContacto = _contactos[i].IdContacto;
                    if (modo == EnumModoForm.Consulta)
                        nuevo.Telefono = "Contacto " + (i + 1);
                    else
                        nuevo.Telefono = "Contacto " + i;
                    ContactosMostrar.Add(nuevo);
                    i++;
                }
            }
            cbContactos.DataSource = ContactosMostrar;
            cbContactos.DisplayMember = "Telefono";
            cbContactos.ValueMember = "IdContacto";
            cbContactos.SelectedIndex = 0;
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
            checkEliminarPersona.Checked = false;
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
