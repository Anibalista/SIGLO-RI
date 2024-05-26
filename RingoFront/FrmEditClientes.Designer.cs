namespace RingoFront
{
    partial class FrmEditClientes
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
            txtIdCliente = new TextBox();
            txtIdPersona = new TextBox();
            txtDni = new TextBox();
            txtPreCuil = new TextBox();
            txtPostCuil = new TextBox();
            txtNombres = new TextBox();
            txtApellidos = new TextBox();
            txtObservaciones = new TextBox();
            groupBox1 = new GroupBox();
            cbEstados = new ComboBox();
            dtFechaNac = new DateTimePicker();
            label10 = new Label();
            label9 = new Label();
            label4 = new Label();
            lbObservaciones = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            cbBarrio = new ComboBox();
            label16 = new Label();
            txtObsBarrio = new TextBox();
            checkBarrio = new CheckBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label8 = new Label();
            cbProvincias = new ComboBox();
            cbCiudades = new ComboBox();
            txtCodPostal = new TextBox();
            txtDepartamento = new TextBox();
            txtPiso = new TextBox();
            txtAltura = new TextBox();
            txtCalle = new TextBox();
            cbDomicilios = new ComboBox();
            groupBox3 = new GroupBox();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            txtEMail = new TextBox();
            txtUserRedSocial = new TextBox();
            checkWhatsApp = new CheckBox();
            textBox8 = new TextBox();
            txtArea = new TextBox();
            label18 = new Label();
            cbRedesSociales = new ComboBox();
            label17 = new Label();
            cbContactos = new ComboBox();
            btnCancelarC1 = new Button();
            btnConfirmarC1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(76, 22);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(38, 27);
            txtIdCliente.TabIndex = 0;
            // 
            // txtIdPersona
            // 
            txtIdPersona.Location = new Point(76, 51);
            txtIdPersona.Name = "txtIdPersona";
            txtIdPersona.Size = new Size(38, 27);
            txtIdPersona.TabIndex = 1;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(303, 22);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "DNI";
            txtDni.Size = new Size(86, 27);
            txtDni.TabIndex = 2;
            txtDni.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPreCuil
            // 
            txtPreCuil.Location = new Point(253, 22);
            txtPreCuil.Name = "txtPreCuil";
            txtPreCuil.Size = new Size(28, 27);
            txtPreCuil.TabIndex = 3;
            // 
            // txtPostCuil
            // 
            txtPostCuil.Location = new Point(412, 22);
            txtPostCuil.Name = "txtPostCuil";
            txtPostCuil.Size = new Size(29, 27);
            txtPostCuil.TabIndex = 4;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(253, 51);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(189, 27);
            txtNombres.TabIndex = 5;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(545, 51);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(213, 27);
            txtApellidos.TabIndex = 6;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(253, 80);
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(505, 27);
            txtObservaciones.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbEstados);
            groupBox1.Controls.Add(dtFechaNac);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lbObservaciones);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtIdCliente);
            groupBox1.Controls.Add(txtPostCuil);
            groupBox1.Controls.Add(txtApellidos);
            groupBox1.Controls.Add(txtObservaciones);
            groupBox1.Controls.Add(txtIdPersona);
            groupBox1.Controls.Add(txtPreCuil);
            groupBox1.Controls.Add(txtNombres);
            groupBox1.Controls.Add(txtDni);
            groupBox1.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 124);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Personales";
            // 
            // cbEstados
            // 
            cbEstados.FormattingEnabled = true;
            cbEstados.Location = new Point(54, 80);
            cbEstados.Name = "cbEstados";
            cbEstados.Size = new Size(104, 27);
            cbEstados.TabIndex = 20;
            // 
            // dtFechaNac
            // 
            dtFechaNac.Format = DateTimePickerFormat.Short;
            dtFechaNac.Location = new Point(641, 22);
            dtFechaNac.MaxDate = new DateTime(2024, 5, 23, 0, 0, 0, 0);
            dtFechaNac.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtFechaNac.Name = "dtFechaNac";
            dtFechaNac.Size = new Size(117, 27);
            dtFechaNac.TabIndex = 10;
            dtFechaNac.Value = new DateTime(2024, 5, 23, 0, 0, 0, 0);
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Roboto Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(521, 28);
            label10.Name = "label10";
            label10.Size = new Size(114, 15);
            label10.TabIndex = 19;
            label10.Text = "Fecha de Nacimiento";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Roboto Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(396, 28);
            label9.Name = "label9";
            label9.Size = new Size(10, 15);
            label9.TabIndex = 18;
            label9.Text = "-";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(287, 28);
            label4.Name = "label4";
            label4.Size = new Size(10, 15);
            label4.TabIndex = 17;
            label4.Text = "-";
            // 
            // lbObservaciones
            // 
            lbObservaciones.AutoSize = true;
            lbObservaciones.Font = new Font("Roboto Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbObservaciones.Location = new Point(164, 86);
            lbObservaciones.Name = "lbObservaciones";
            lbObservaciones.Size = new Size(83, 15);
            lbObservaciones.TabIndex = 16;
            lbObservaciones.Text = "Observaciones";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Roboto Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(190, 28);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 15;
            label7.Text = "CUIL - DNI";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Roboto Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(485, 57);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 14;
            label6.Text = "Apellidos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(193, 57);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 13;
            label5.Text = "Nombres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 86);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 11;
            label3.Text = "Estado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 57);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 10;
            label2.Text = "Id Persona";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 28);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 9;
            label1.Text = "Id Cliente";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbBarrio);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(txtObsBarrio);
            groupBox2.Controls.Add(checkBarrio);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(cbProvincias);
            groupBox2.Controls.Add(cbCiudades);
            groupBox2.Controls.Add(txtCodPostal);
            groupBox2.Controls.Add(txtDepartamento);
            groupBox2.Controls.Add(txtPiso);
            groupBox2.Controls.Add(txtAltura);
            groupBox2.Controls.Add(txtCalle);
            groupBox2.Controls.Add(cbDomicilios);
            groupBox2.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 156);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 142);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos Domicilio";
            // 
            // cbBarrio
            // 
            cbBarrio.FormattingEnabled = true;
            cbBarrio.Location = new Point(6, 86);
            cbBarrio.Name = "cbBarrio";
            cbBarrio.Size = new Size(121, 27);
            cbBarrio.TabIndex = 26;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Roboto Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(144, 94);
            label16.Name = "label16";
            label16.Size = new Size(117, 15);
            label16.TabIndex = 25;
            label16.Text = "Observaciones Barrio";
            // 
            // txtObsBarrio
            // 
            txtObsBarrio.Location = new Point(267, 88);
            txtObsBarrio.Name = "txtObsBarrio";
            txtObsBarrio.Size = new Size(503, 27);
            txtObsBarrio.TabIndex = 24;
            // 
            // checkBarrio
            // 
            checkBarrio.AutoSize = true;
            checkBarrio.Location = new Point(6, 57);
            checkBarrio.Name = "checkBarrio";
            checkBarrio.Size = new Size(86, 23);
            checkBarrio.TabIndex = 23;
            checkBarrio.Text = "Es Barrio";
            checkBarrio.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Roboto Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(144, 61);
            label15.Name = "label15";
            label15.Size = new Size(66, 15);
            label15.TabIndex = 22;
            label15.Text = "Cod. Postal";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Roboto Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(339, 61);
            label14.Name = "label14";
            label14.Size = new Size(41, 15);
            label14.TabIndex = 21;
            label14.Text = "Ciudad";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Roboto Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(661, 28);
            label13.Name = "label13";
            label13.Size = new Size(37, 15);
            label13.TabIndex = 20;
            label13.Text = "Depto";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Roboto Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(557, 28);
            label12.Name = "label12";
            label12.Size = new Size(30, 15);
            label12.TabIndex = 19;
            label12.Text = "Piso";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Roboto Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(422, 28);
            label11.Name = "label11";
            label11.Size = new Size(48, 15);
            label11.TabIndex = 18;
            label11.Text = "N° Casa";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Roboto Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(178, 28);
            label8.Name = "label8";
            label8.Size = new Size(32, 15);
            label8.TabIndex = 17;
            label8.Text = "Calle";
            // 
            // cbProvincias
            // 
            cbProvincias.FormattingEnabled = true;
            cbProvincias.Location = new Point(621, 55);
            cbProvincias.Name = "cbProvincias";
            cbProvincias.Size = new Size(149, 27);
            cbProvincias.TabIndex = 7;
            // 
            // cbCiudades
            // 
            cbCiudades.FormattingEnabled = true;
            cbCiudades.Location = new Point(386, 55);
            cbCiudades.Name = "cbCiudades";
            cbCiudades.Size = new Size(189, 27);
            cbCiudades.TabIndex = 6;
            // 
            // txtCodPostal
            // 
            txtCodPostal.Location = new Point(216, 55);
            txtCodPostal.Name = "txtCodPostal";
            txtCodPostal.Size = new Size(100, 27);
            txtCodPostal.TabIndex = 5;
            // 
            // txtDepartamento
            // 
            txtDepartamento.Location = new Point(704, 22);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(66, 27);
            txtDepartamento.TabIndex = 4;
            // 
            // txtPiso
            // 
            txtPiso.Location = new Point(593, 22);
            txtPiso.Name = "txtPiso";
            txtPiso.Size = new Size(42, 27);
            txtPiso.TabIndex = 3;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(476, 22);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(63, 27);
            txtAltura.TabIndex = 2;
            // 
            // txtCalle
            // 
            txtCalle.Location = new Point(216, 22);
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(189, 27);
            txtCalle.TabIndex = 1;
            // 
            // cbDomicilios
            // 
            cbDomicilios.FormattingEnabled = true;
            cbDomicilios.Location = new Point(6, 22);
            cbDomicilios.Name = "cbDomicilios";
            cbDomicilios.Size = new Size(136, 27);
            cbDomicilios.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label24);
            groupBox3.Controls.Add(label23);
            groupBox3.Controls.Add(label22);
            groupBox3.Controls.Add(label21);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(txtEMail);
            groupBox3.Controls.Add(txtUserRedSocial);
            groupBox3.Controls.Add(checkWhatsApp);
            groupBox3.Controls.Add(textBox8);
            groupBox3.Controls.Add(txtArea);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(cbRedesSociales);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(cbContactos);
            groupBox3.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(12, 320);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(776, 100);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos de Contacto";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label24.ForeColor = SystemColors.ButtonShadow;
            label24.Location = new Point(299, 30);
            label24.Name = "label24";
            label24.Size = new Size(17, 19);
            label24.TabIndex = 32;
            label24.Text = "0";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label23.ForeColor = SystemColors.ButtonShadow;
            label23.Location = new Point(391, 30);
            label23.Name = "label23";
            label23.Size = new Size(25, 19);
            label23.TabIndex = 31;
            label23.Text = "15";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Roboto Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(513, 65);
            label22.Name = "label22";
            label22.Size = new Size(38, 15);
            label22.TabIndex = 30;
            label22.Text = "E-Mail";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Roboto Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(253, 65);
            label21.Name = "label21";
            label21.Size = new Size(46, 15);
            label21.TabIndex = 29;
            label21.Text = "Usuario";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Roboto Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(245, 32);
            label20.Name = "label20";
            label20.Size = new Size(48, 15);
            label20.TabIndex = 28;
            label20.Text = "Número";
            // 
            // txtEMail
            // 
            txtEMail.Location = new Point(557, 59);
            txtEMail.Name = "txtEMail";
            txtEMail.Size = new Size(213, 27);
            txtEMail.TabIndex = 25;
            // 
            // txtUserRedSocial
            // 
            txtUserRedSocial.Location = new Point(306, 59);
            txtUserRedSocial.Name = "txtUserRedSocial";
            txtUserRedSocial.Size = new Size(179, 27);
            txtUserRedSocial.TabIndex = 24;
            // 
            // checkWhatsApp
            // 
            checkWhatsApp.AutoSize = true;
            checkWhatsApp.Location = new Point(557, 28);
            checkWhatsApp.Name = "checkWhatsApp";
            checkWhatsApp.Size = new Size(133, 23);
            checkWhatsApp.TabIndex = 23;
            checkWhatsApp.Text = "Tiene WhatsApp";
            checkWhatsApp.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(422, 26);
            textBox8.Name = "textBox8";
            textBox8.PlaceholderText = "número";
            textBox8.Size = new Size(112, 27);
            textBox8.TabIndex = 22;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(316, 26);
            txtArea.Name = "txtArea";
            txtArea.PlaceholderText = "área";
            txtArea.Size = new Size(64, 27);
            txtArea.TabIndex = 21;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Roboto Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(6, 65);
            label18.Name = "label18";
            label18.Size = new Size(85, 15);
            label18.TabIndex = 20;
            label18.Text = "Redes Sociales";
            // 
            // cbRedesSociales
            // 
            cbRedesSociales.FormattingEnabled = true;
            cbRedesSociales.Location = new Point(97, 59);
            cbRedesSociales.Name = "cbRedesSociales";
            cbRedesSociales.Size = new Size(121, 27);
            cbRedesSociales.TabIndex = 19;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Roboto Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(34, 32);
            label17.Name = "label17";
            label17.Size = new Size(60, 15);
            label17.TabIndex = 18;
            label17.Text = "Contactos";
            // 
            // cbContactos
            // 
            cbContactos.FormattingEnabled = true;
            cbContactos.Location = new Point(97, 26);
            cbContactos.Name = "cbContactos";
            cbContactos.Size = new Size(121, 27);
            cbContactos.TabIndex = 0;
            // 
            // btnCancelarC1
            // 
            btnCancelarC1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelarC1.Location = new Point(167, 470);
            btnCancelarC1.Name = "btnCancelarC1";
            btnCancelarC1.Size = new Size(144, 43);
            btnCancelarC1.TabIndex = 12;
            btnCancelarC1.Text = "Cancelar";
            btnCancelarC1.UseVisualStyleBackColor = true;
            // 
            // btnConfirmarC1
            // 
            btnConfirmarC1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirmarC1.Location = new Point(436, 470);
            btnConfirmarC1.Name = "btnConfirmarC1";
            btnConfirmarC1.Size = new Size(163, 43);
            btnConfirmarC1.TabIndex = 13;
            btnConfirmarC1.Text = "Confirmar";
            btnConfirmarC1.UseVisualStyleBackColor = true;
            // 
            // FrmEditClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 541);
            Controls.Add(btnConfirmarC1);
            Controls.Add(btnCancelarC1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmEditClientes";
            Text = "FrmEditClientes";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtIdCliente;
        private TextBox txtIdPersona;
        private TextBox txtDni;
        private TextBox txtPreCuil;
        private TextBox txtPostCuil;
        private TextBox txtNombres;
        private TextBox txtApellidos;
        private TextBox txtObservaciones;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Label lbObservaciones;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label4;
        private DateTimePicker dtFechaNac;
        private Label label10;
        private Label label9;
        private GroupBox groupBox2;
        private TextBox txtCalle;
        private ComboBox cbDomicilios;
        private TextBox txtCodPostal;
        private TextBox txtDepartamento;
        private TextBox txtPiso;
        private TextBox txtAltura;
        private Label label11;
        private Label label8;
        private ComboBox cbProvincias;
        private ComboBox cbCiudades;
        private Label label13;
        private Label label12;
        private CheckBox checkBarrio;
        private Label label15;
        private Label label14;
        private ComboBox cbBarrio;
        private Label label16;
        private TextBox txtObsBarrio;
        private GroupBox groupBox3;
        private Label label17;
        private ComboBox cbContactos;
        private ComboBox cbRedesSociales;
        private TextBox txtEMail;
        private TextBox txtUserRedSocial;
        private CheckBox checkWhatsApp;
        private TextBox textBox8;
        private TextBox txtArea;
        private Label label18;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label24;
        private Button btnCancelarC1;
        private Button btnConfirmarC1;
        private ComboBox cbEstados;
    }
}