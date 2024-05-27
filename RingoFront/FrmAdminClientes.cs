using RingoEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace RingoFront
{
    public partial class FrmAdminClientes : Form
    {
        List<Clientes> listaClientes = new();
        List<Personas> listaPersonas = new();
        List<Ciudades> listaCiudades = new();
        public FrmAdminClientes()
        {
            InitializeComponent();
        }



        private void buscarClientes ()
        {
            listaClientes.Clear();
            Personas? persona = new();
            Clientes? clientes = new();
            Ciudades? ciudades = new();
            string nombreYApellido = "";
            int id = 0;
            int dni = 0;
            try
            {
                if (!String.IsNullOrEmpty(txtNombres.Text))
                    nombreYApellido = txtNombres.Text.Trim().ToLower();
                persona.Apellidos = nombreYApellido;
                persona.Nombre = nombreYApellido;
                if (int.TryParse(txtId.Text.Trim(),out id) && int.TryParse(txtDni.Text.Trim(), out dni)) 
                {
                    clientes.IdCliente = id;
                    persona.Dni = dni.ToString();
                }
                int idCiudad = (int)comboLocalidades.SelectedValue;
                if (idCiudad > 0)
                {
                    ciudades.NombreCiudad = comboLocalidades.SelectedItem.ToString();
                    ciudades.IdCiudad = idCiudad;
                }
            }
            catch { }
            if (persona != null)
            {
                listaPersonas = RingoNegocio.PersonasMetodos.buscarPersonas(clientes, persona, ciudades, checkEliminados.Checked);

            }
        }

        private void refreshGrid ()
        {
            bindingSourceClientes.DataSource = null;
            bindingSourceClientes.DataSource = listaClientes;
        }

        private void cargarComboCiudades ()
        {
            listaCiudades.Clear();
            Ciudades nueva = new();
            nueva.NombreCiudad = "Localidad";
            nueva.IdCiudad = 0;
            listaCiudades.Add(nueva);
            List<Ciudades>? ciudades = new();
            ciudades = RingoNegocio.DomiciliosMetodos.CiudadesTodas();
            if (ciudades != null)
                listaCiudades.AddRange(ciudades);
            comboLocalidades.DataSource = listaCiudades;
            comboLocalidades.SelectedIndex = 0;
        }
    }
}
