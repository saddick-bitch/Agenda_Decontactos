namespace GUI
{
    partial class FormContacto
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.ComboBox cmbTipoContacto;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvContactos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            cmbTipoContacto = new ComboBox();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvContactos = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvContactos).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(174, 24);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 27);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(174, 54);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(200, 27);
            txtApellido.TabIndex = 1;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(174, 83);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(200, 27);
            txtTelefono.TabIndex = 2;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(174, 112);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(200, 27);
            txtCorreo.TabIndex = 3;
            // 
            // cmbTipoContacto
            // 
            cmbTipoContacto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoContacto.Location = new Point(174, 141);
            cmbTipoContacto.Name = "cmbTipoContacto";
            cmbTipoContacto.Size = new Size(200, 28);
            cmbTipoContacto.TabIndex = 4;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(30, 190);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(90, 30);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(140, 190);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 30);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(250, 190);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(90, 30);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvContactos
            // 
            dgvContactos.AllowUserToAddRows = false;
            dgvContactos.ColumnHeadersHeight = 29;
            dgvContactos.Location = new Point(30, 239);
            dgvContactos.Name = "dgvContactos";
            dgvContactos.ReadOnly = true;
            dgvContactos.RowHeadersWidth = 51;
            dgvContactos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContactos.Size = new Size(500, 200);
            dgvContactos.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 27);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 9;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 62);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 10;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 92);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 11;
            label3.Text = "Teléfono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(104, 120);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 12;
            label4.Text = "Correo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 149);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 13;
            label5.Text = "Tipo contacto:";
            // 
            // FormContacto
            // 
            ClientSize = new Size(600, 480);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(txtTelefono);
            Controls.Add(txtCorreo);
            Controls.Add(cmbTipoContacto);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(dgvContactos);
            Name = "FormContacto";
            Text = "Agenda de Contactos";
            Load += FormContacto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvContactos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
