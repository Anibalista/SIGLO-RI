namespace RingoFront
{
    partial class FrmAdminClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBoxHeader = new GroupBox();
            labelTitulo = new Label();
            btnUsuario = new Button();
            btnAtras = new Button();
            groupBoxConsulta = new GroupBox();
            checkEliminados = new CheckBox();
            btnBuscar = new Button();
            groupBox1 = new GroupBox();
            txtPrenda = new TextBox();
            label4 = new Label();
            label7 = new Label();
            dateTimePickerDesde = new DateTimePicker();
            dateTimePickerHasta = new DateTimePicker();
            label5 = new Label();
            comboLocalidades = new ComboBox();
            bindingSourceLocalidades = new BindingSource(components);
            txtNombres = new TextBox();
            txtDni = new TextBox();
            txtId = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            bindingSourcePersonas = new BindingSource(components);
            btnELiminar = new Button();
            btnConsultar = new Button();
            btnRegistrar = new Button();
            btnModificar = new Button();
            dataGridView1 = new DataGridView();
            check = new DataGridViewCheckBoxColumn();
            IDCliente = new DataGridViewTextBoxColumn();
            idPersonaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Dni = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellidos = new DataGridViewTextBoxColumn();
            Cuil = new DataGridViewTextBoxColumn();
            FechaNacimiento = new DataGridViewTextBoxColumn();
            Observaciones = new DataGridViewTextBoxColumn();
            EstadoPersona = new DataGridViewTextBoxColumn();
            condicionFiscalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bindingSourceClientes = new BindingSource(components);
            groupBoxHeader.SuspendLayout();
            groupBoxConsulta.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceLocalidades).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourcePersonas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceClientes).BeginInit();
            SuspendLayout();
            // 
            // groupBoxHeader
            // 
            groupBoxHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxHeader.Controls.Add(labelTitulo);
            groupBoxHeader.Controls.Add(btnUsuario);
            groupBoxHeader.Controls.Add(btnAtras);
            groupBoxHeader.Location = new Point(0, 2);
            groupBoxHeader.Name = "groupBoxHeader";
            groupBoxHeader.Size = new Size(1031, 95);
            groupBoxHeader.TabIndex = 0;
            groupBoxHeader.TabStop = false;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Roboto Condensed", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitulo.Location = new Point(314, 17);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(313, 58);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "ABMC Clientes";
            // 
            // btnUsuario
            // 
            btnUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUsuario.Location = new Point(956, 10);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(69, 65);
            btnUsuario.TabIndex = 1;
            btnUsuario.Text = "Usuario";
            btnUsuario.UseVisualStyleBackColor = true;
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(0, 10);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(69, 65);
            btnAtras.TabIndex = 1;
            btnAtras.Text = "Cerrar";
            btnAtras.UseVisualStyleBackColor = true;
            // 
            // groupBoxConsulta
            // 
            groupBoxConsulta.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxConsulta.Controls.Add(checkEliminados);
            groupBoxConsulta.Controls.Add(btnBuscar);
            groupBoxConsulta.Controls.Add(groupBox1);
            groupBoxConsulta.Controls.Add(comboLocalidades);
            groupBoxConsulta.Controls.Add(txtNombres);
            groupBoxConsulta.Controls.Add(txtDni);
            groupBoxConsulta.Controls.Add(txtId);
            groupBoxConsulta.Controls.Add(label6);
            groupBoxConsulta.Controls.Add(label3);
            groupBoxConsulta.Controls.Add(label2);
            groupBoxConsulta.Controls.Add(label1);
            groupBoxConsulta.Location = new Point(0, 103);
            groupBoxConsulta.Name = "groupBoxConsulta";
            groupBoxConsulta.Size = new Size(1031, 139);
            groupBoxConsulta.TabIndex = 1;
            groupBoxConsulta.TabStop = false;
            // 
            // checkEliminados
            // 
            checkEliminados.AutoSize = true;
            checkEliminados.Font = new Font("Roboto Condensed", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkEliminados.Location = new Point(12, 115);
            checkEliminados.Name = "checkEliminados";
            checkEliminados.Size = new Size(160, 19);
            checkEliminados.TabIndex = 8;
            checkEliminados.Text = "Incluir Clientes Eliminados";
            checkEliminados.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Roboto Condensed", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.Location = new Point(827, 54);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(193, 59);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPrenda);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dateTimePickerDesde);
            groupBox1.Controls.Add(dateTimePickerHasta);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(6, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(789, 54);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Por compras realizadas";
            // 
            // txtPrenda
            // 
            txtPrenda.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPrenda.Enabled = false;
            txtPrenda.Location = new Point(421, 15);
            txtPrenda.MaxLength = 99;
            txtPrenda.Name = "txtPrenda";
            txtPrenda.Size = new Size(362, 23);
            txtPrenda.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(0, 19);
            label4.Name = "label4";
            label4.Size = new Size(58, 19);
            label4.TabIndex = 5;
            label4.Text = "Desde";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(350, 19);
            label7.Name = "label7";
            label7.Size = new Size(65, 19);
            label7.TabIndex = 7;
            label7.Text = "Prenda";
            // 
            // dateTimePickerDesde
            // 
            dateTimePickerDesde.Enabled = false;
            dateTimePickerDesde.Format = DateTimePickerFormat.Short;
            dateTimePickerDesde.Location = new Point(64, 15);
            dateTimePickerDesde.MaxDate = new DateTime(2300, 12, 31, 0, 0, 0, 0);
            dateTimePickerDesde.MinDate = new DateTime(2024, 5, 27, 0, 0, 0, 0);
            dateTimePickerDesde.Name = "dateTimePickerDesde";
            dateTimePickerDesde.Size = new Size(96, 23);
            dateTimePickerDesde.TabIndex = 8;
            dateTimePickerDesde.Value = new DateTime(2024, 5, 27, 13, 35, 55, 0);
            // 
            // dateTimePickerHasta
            // 
            dateTimePickerHasta.Enabled = false;
            dateTimePickerHasta.Format = DateTimePickerFormat.Short;
            dateTimePickerHasta.Location = new Point(238, 15);
            dateTimePickerHasta.MaxDate = new DateTime(2300, 12, 31, 0, 0, 0, 0);
            dateTimePickerHasta.MinDate = new DateTime(2024, 5, 27, 0, 0, 0, 0);
            dateTimePickerHasta.Name = "dateTimePickerHasta";
            dateTimePickerHasta.Size = new Size(96, 23);
            dateTimePickerHasta.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(179, 19);
            label5.Name = "label5";
            label5.Size = new Size(53, 19);
            label5.TabIndex = 6;
            label5.Text = "Hasta";
            // 
            // comboLocalidades
            // 
            comboLocalidades.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboLocalidades.DataSource = bindingSourceLocalidades;
            comboLocalidades.DisplayMember = "NombreCiudad";
            comboLocalidades.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboLocalidades.FormattingEnabled = true;
            comboLocalidades.Location = new Point(827, 15);
            comboLocalidades.MaxLength = 99;
            comboLocalidades.Name = "comboLocalidades";
            comboLocalidades.Size = new Size(193, 23);
            comboLocalidades.TabIndex = 2;
            comboLocalidades.ValueMember = "IdCiudad";
            // 
            // bindingSourceLocalidades
            // 
            bindingSourceLocalidades.DataSource = typeof(RingoEntidades.Ciudades);
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(438, 15);
            txtNombres.MaxLength = 99;
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(269, 23);
            txtNombres.TabIndex = 3;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(151, 15);
            txtDni.MaxLength = 14;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(108, 23);
            txtDni.TabIndex = 3;
            // 
            // txtId
            // 
            txtId.Location = new Point(40, 15);
            txtId.MaxLength = 99;
            txtId.Name = "txtId";
            txtId.Size = new Size(41, 23);
            txtId.TabIndex = 2;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(737, 19);
            label6.Name = "label6";
            label6.Size = new Size(87, 19);
            label6.TabIndex = 7;
            label6.Text = "Localidad";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(286, 19);
            label3.Name = "label3";
            label3.Size = new Size(150, 19);
            label3.TabIndex = 4;
            label3.Text = "Nombre|Apellido";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(104, 19);
            label2.Name = "label2";
            label2.Size = new Size(41, 19);
            label2.TabIndex = 3;
            label2.Text = "DNI";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(28, 19);
            label1.TabIndex = 2;
            label1.Text = "ID";
            // 
            // bindingSourcePersonas
            // 
            bindingSourcePersonas.DataSource = typeof(RingoEntidades.Personas);
            // 
            // btnELiminar
            // 
            btnELiminar.Enabled = false;
            btnELiminar.Font = new Font("Roboto Condensed", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnELiminar.Location = new Point(185, 505);
            btnELiminar.Name = "btnELiminar";
            btnELiminar.Size = new Size(133, 51);
            btnELiminar.TabIndex = 3;
            btnELiminar.Text = "Eliminar";
            btnELiminar.UseVisualStyleBackColor = true;
            btnELiminar.Visible = false;
            // 
            // btnConsultar
            // 
            btnConsultar.Enabled = false;
            btnConsultar.Font = new Font("Roboto Condensed", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultar.Location = new Point(347, 505);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(133, 51);
            btnConsultar.TabIndex = 4;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Visible = false;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Enabled = false;
            btnRegistrar.Font = new Font("Roboto Condensed", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrar.Location = new Point(508, 505);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(133, 51);
            btnRegistrar.TabIndex = 5;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Enabled = false;
            btnModificar.Font = new Font("Roboto Condensed", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.Location = new Point(674, 505);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(133, 51);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { check, IDCliente, idPersonaDataGridViewTextBoxColumn, Dni, Nombre, Apellidos, Cuil, FechaNacimiento, Observaciones, EstadoPersona, condicionFiscalDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bindingSourcePersonas;
            dataGridView1.Location = new Point(-2, 248);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1033, 229);
            dataGridView1.TabIndex = 7;
            // 
            // check
            // 
            check.HeaderText = "";
            check.Name = "check";
            check.Width = 30;
            // 
            // IDCliente
            // 
            IDCliente.HeaderText = "ID";
            IDCliente.Name = "IDCliente";
            IDCliente.Width = 50;
            // 
            // idPersonaDataGridViewTextBoxColumn
            // 
            idPersonaDataGridViewTextBoxColumn.DataPropertyName = "IdPersona";
            idPersonaDataGridViewTextBoxColumn.HeaderText = "ID Persona";
            idPersonaDataGridViewTextBoxColumn.Name = "idPersonaDataGridViewTextBoxColumn";
            idPersonaDataGridViewTextBoxColumn.Width = 70;
            // 
            // Dni
            // 
            Dni.DataPropertyName = "Dni";
            Dni.HeaderText = "Dni";
            Dni.Name = "Dni";
            Dni.Width = 80;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.Width = 170;
            // 
            // Apellidos
            // 
            Apellidos.DataPropertyName = "Apellidos";
            Apellidos.HeaderText = "Apellidos";
            Apellidos.Name = "Apellidos";
            Apellidos.Width = 170;
            // 
            // Cuil
            // 
            Cuil.DataPropertyName = "Cuil";
            Cuil.HeaderText = "Cuil";
            Cuil.Name = "Cuil";
            // 
            // FechaNacimiento
            // 
            FechaNacimiento.DataPropertyName = "FechaNacimiento";
            FechaNacimiento.HeaderText = "FechaNacimiento";
            FechaNacimiento.Name = "FechaNacimiento";
            FechaNacimiento.Width = 110;
            // 
            // Observaciones
            // 
            Observaciones.DataPropertyName = "Observaciones";
            Observaciones.HeaderText = "Observaciones";
            Observaciones.Name = "Observaciones";
            Observaciones.Width = 220;
            // 
            // EstadoPersona
            // 
            EstadoPersona.DataPropertyName = "EstadoPersona";
            EstadoPersona.HeaderText = "EstadoPersona";
            EstadoPersona.Name = "EstadoPersona";
            EstadoPersona.ReadOnly = true;
            // 
            // condicionFiscalDataGridViewTextBoxColumn
            // 
            condicionFiscalDataGridViewTextBoxColumn.DataPropertyName = "CondicionFiscal";
            condicionFiscalDataGridViewTextBoxColumn.HeaderText = "CondicionFiscal";
            condicionFiscalDataGridViewTextBoxColumn.Name = "condicionFiscalDataGridViewTextBoxColumn";
            condicionFiscalDataGridViewTextBoxColumn.ReadOnly = true;
            condicionFiscalDataGridViewTextBoxColumn.Width = 120;
            // 
            // bindingSourceClientes
            // 
            bindingSourceClientes.DataSource = typeof(RingoEntidades.Clientes);
            // 
            // FrmAdminClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 605);
            Controls.Add(dataGridView1);
            Controls.Add(btnModificar);
            Controls.Add(btnRegistrar);
            Controls.Add(btnConsultar);
            Controls.Add(btnELiminar);
            Controls.Add(groupBoxConsulta);
            Controls.Add(groupBoxHeader);
            Name = "FrmAdminClientes";
            Text = "FrmAdminClientes";
            groupBoxHeader.ResumeLayout(false);
            groupBoxHeader.PerformLayout();
            groupBoxConsulta.ResumeLayout(false);
            groupBoxConsulta.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceLocalidades).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourcePersonas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxHeader;
        private Button btnAtras;
        private Button btnUsuario;
        private Label labelTitulo;
        private GroupBox groupBoxConsulta;
        private BindingSource bindingSourcePersonas;
        private BindingSource bindingSourceLocalidades;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtId;
        private TextBox txtNombres;
        private TextBox txtDni;
        private DateTimePicker dateTimePickerDesde;
        private ComboBox comboLocalidades;
        private DateTimePicker dateTimePickerHasta;
        private Label label7;
        private TextBox txtPrenda;
        private GroupBox groupBox1;
        private Button btnBuscar;
        private Button btnELiminar;
        private Button btnConsultar;
        private Button btnRegistrar;
        private Button btnModificar;
        private CheckBox checkEliminados;
        private DataGridView dataGridView1;
        private BindingSource bindingSourceClientes;
        private DataGridViewCheckBoxColumn check;
        private DataGridViewTextBoxColumn IDCliente;
        private DataGridViewTextBoxColumn idPersonaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Dni;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellidos;
        private DataGridViewTextBoxColumn Cuil;
        private DataGridViewTextBoxColumn FechaNacimiento;
        private DataGridViewTextBoxColumn Observaciones;
        private DataGridViewTextBoxColumn EstadoPersona;
        private DataGridViewTextBoxColumn condicionFiscalDataGridViewTextBoxColumn;
    }
}