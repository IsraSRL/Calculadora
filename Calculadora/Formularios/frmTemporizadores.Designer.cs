namespace Calculadora.Formularios
{
    partial class frmTemporizadores
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
            lblHora = new Label();
            tmrHora = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHora.Location = new Point(45, 27);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(286, 55);
            lblHora.TabIndex = 0;
            lblHora.Text = "00:00:00 x.x";
            // 
            // tmrHora
            // 
            tmrHora.Enabled = true;
            tmrHora.Interval = 1000;
            tmrHora.Tick += tmrHora_Tick;
            // 
            // frmTemporizadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 111);
            Controls.Add(lblHora);
            Name = "frmTemporizadores";
            Text = "Reloj";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHora;
        private System.Windows.Forms.Timer tmrHora;
    }
}