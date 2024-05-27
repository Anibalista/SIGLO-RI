namespace RingoFront
{
    partial class FrmRegistrarPrenda
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
            btnCancelarPrenda = new Button();
            label1 = new Label();
            txtCodigoPrenda = new TextBox();
            label2 = new Label();
            cbxCategoria = new ComboBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            textBox1 = new TextBox();
            btnGuardarPrenda = new Button();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // btnCancelarPrenda
            // 
            btnCancelarPrenda.BackColor = SystemColors.ActiveCaption;
            btnCancelarPrenda.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelarPrenda.Location = new Point(641, 515);
            btnCancelarPrenda.Name = "btnCancelarPrenda";
            btnCancelarPrenda.Size = new Size(102, 45);
            btnCancelarPrenda.TabIndex = 8;
            btnCancelarPrenda.Text = "CANCELAR";
            btnCancelarPrenda.UseVisualStyleBackColor = false;
            btnCancelarPrenda.Click += btnCancelarPrenda_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(43, 44);
            label1.Name = "label1";
            label1.Size = new Size(176, 28);
            label1.TabIndex = 1;
            label1.Text = "CÓDIGO PRENDA";
            // 
            // txtCodigoPrenda
            // 
            txtCodigoPrenda.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigoPrenda.ForeColor = SystemColors.WindowText;
            txtCodigoPrenda.Location = new Point(245, 38);
            txtCodigoPrenda.Name = "txtCodigoPrenda";
            txtCodigoPrenda.Size = new Size(151, 34);
            txtCodigoPrenda.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(43, 143);
            label2.Name = "label2";
            label2.Size = new Size(122, 28);
            label2.TabIndex = 3;
            label2.Text = "CATEGORIA";
            // 
            // cbxCategoria
            // 
            cbxCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.ItemHeight = 28;
            cbxCategoria.Location = new Point(245, 135);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(151, 36);
            cbxCategoria.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(43, 240);
            label3.Name = "label3";
            label3.Size = new Size(59, 28);
            label3.TabIndex = 5;
            label3.Text = "TELA";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(245, 232);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 36);
            comboBox1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(43, 346);
            label4.Name = "label4";
            label4.Size = new Size(141, 28);
            label4.TabIndex = 6;
            label4.Text = "DESCRIPCIÓN";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(245, 340);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(333, 34);
            textBox1.TabIndex = 4;
            // 
            // btnGuardarPrenda
            // 
            btnGuardarPrenda.BackColor = SystemColors.ActiveCaption;
            btnGuardarPrenda.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardarPrenda.Location = new Point(143, 515);
            btnGuardarPrenda.Name = "btnGuardarPrenda";
            btnGuardarPrenda.Size = new Size(111, 45);
            btnGuardarPrenda.TabIndex = 7;
            btnGuardarPrenda.Text = "GUARDAR";
            btnGuardarPrenda.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(559, 138);
            label5.Name = "label5";
            label5.Size = new Size(116, 28);
            label5.TabIndex = 8;
            label5.Text = "CANTIDAD";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(711, 135);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(71, 34);
            numericUpDown1.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(574, 232);
            button1.Name = "button1";
            button1.Size = new Size(208, 41);
            button1.TabIndex = 6;
            button1.Text = "AGREGAR DETALLES";
            button1.UseVisualStyleBackColor = false;
            // 
            // FrmRegistrarPrenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.IMG_20220824_WA0014;
            ClientSize = new Size(878, 623);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(label5);
            Controls.Add(btnGuardarPrenda);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(cbxCategoria);
            Controls.Add(label2);
            Controls.Add(txtCodigoPrenda);
            Controls.Add(label1);
            Controls.Add(btnCancelarPrenda);
            MaximizeBox = false;
            Name = "FrmRegistrarPrenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Prenda";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelarPrenda;
        private Label label1;
        private TextBox txtCodigoPrenda;
        private Label label2;
        private ComboBox cbxCategoria;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private TextBox textBox1;
        private Button btnGuardarPrenda;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private Button button1;
    }
}