namespace Calculadora.Formularios
{
    partial class frmRegistro
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnRegistro = new Button();
            dtpFecha = new DateTimePicker();
            txtApellido = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            dgvPersonas = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(580, 387);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnRegistro);
            tabPage1.Controls.Add(dtpFecha);
            tabPage1.Controls.Add(txtApellido);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtNombre);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(572, 359);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Registros";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRegistro
            // 
            btnRegistro.Location = new Point(292, 209);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(75, 23);
            btnRegistro.TabIndex = 6;
            btnRegistro.Text = "Registro";
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(6, 207);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(248, 23);
            dtpFecha.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(6, 128);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(361, 23);
            txtApellido.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 189);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 3;
            label3.Text = "Fecha de nacimiento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 110);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Apellidos";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(6, 58);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(361, 23);
            txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 40);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvPersonas);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(572, 359);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Mostrar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvPersonas
            // 
            dgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonas.Location = new Point(6, 6);
            dgvPersonas.Name = "dgvPersonas";
            dgvPersonas.Size = new Size(560, 347);
            dgvPersonas.TabIndex = 0;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 411);
            Controls.Add(tabControl1);
            Name = "frmRegistro";
            Text = "Registros";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnRegistro;
        private DateTimePicker dtpFecha;
        private TextBox txtApellido;
        private Label label3;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private DataGridView dgvPersonas;
    }
}