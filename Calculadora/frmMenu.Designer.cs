namespace Calculadora
{
    partial class frmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mnsPrincipal = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            aplicacionesToolStripMenuItem = new ToolStripMenuItem();
            calculadoraSimpleToolStripMenuItem = new ToolStripMenuItem();
            ordenamientosToolStripMenuItem = new ToolStripMenuItem();
            burbujaToolStripMenuItem = new ToolStripMenuItem();
            registroToolStripMenuItem = new ToolStripMenuItem();
            temporizadoresToolStripMenuItem = new ToolStripMenuItem();
            relojToolStripMenuItem = new ToolStripMenuItem();
            mnsPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // mnsPrincipal
            // 
            mnsPrincipal.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, aplicacionesToolStripMenuItem });
            mnsPrincipal.Location = new Point(0, 0);
            mnsPrincipal.Name = "mnsPrincipal";
            mnsPrincipal.Size = new Size(800, 24);
            mnsPrincipal.TabIndex = 0;
            mnsPrincipal.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(96, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // aplicacionesToolStripMenuItem
            // 
            aplicacionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { calculadoraSimpleToolStripMenuItem, ordenamientosToolStripMenuItem, registroToolStripMenuItem, temporizadoresToolStripMenuItem });
            aplicacionesToolStripMenuItem.Name = "aplicacionesToolStripMenuItem";
            aplicacionesToolStripMenuItem.Size = new Size(86, 20);
            aplicacionesToolStripMenuItem.Text = "Aplicaciones";
            // 
            // calculadoraSimpleToolStripMenuItem
            // 
            calculadoraSimpleToolStripMenuItem.Name = "calculadoraSimpleToolStripMenuItem";
            calculadoraSimpleToolStripMenuItem.Size = new Size(180, 22);
            calculadoraSimpleToolStripMenuItem.Text = "Calculadora Simple";
            calculadoraSimpleToolStripMenuItem.Click += calculadoraSimpleToolStripMenuItem_Click;
            // 
            // ordenamientosToolStripMenuItem
            // 
            ordenamientosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { burbujaToolStripMenuItem });
            ordenamientosToolStripMenuItem.Name = "ordenamientosToolStripMenuItem";
            ordenamientosToolStripMenuItem.Size = new Size(180, 22);
            ordenamientosToolStripMenuItem.Text = "Ordenamientos";
            // 
            // burbujaToolStripMenuItem
            // 
            burbujaToolStripMenuItem.Name = "burbujaToolStripMenuItem";
            burbujaToolStripMenuItem.Size = new Size(115, 22);
            burbujaToolStripMenuItem.Text = "Burbuja";
            burbujaToolStripMenuItem.Click += burbujaToolStripMenuItem_Click;
            // 
            // registroToolStripMenuItem
            // 
            registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            registroToolStripMenuItem.Size = new Size(180, 22);
            registroToolStripMenuItem.Text = "Registro";
            registroToolStripMenuItem.Click += registroToolStripMenuItem_Click;
            // 
            // temporizadoresToolStripMenuItem
            // 
            temporizadoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { relojToolStripMenuItem });
            temporizadoresToolStripMenuItem.Name = "temporizadoresToolStripMenuItem";
            temporizadoresToolStripMenuItem.Size = new Size(180, 22);
            temporizadoresToolStripMenuItem.Text = "Temporizadores";
            // 
            // relojToolStripMenuItem
            // 
            relojToolStripMenuItem.Name = "relojToolStripMenuItem";
            relojToolStripMenuItem.Size = new Size(180, 22);
            relojToolStripMenuItem.Text = "Reloj";
            relojToolStripMenuItem.Click += relojToolStripMenuItem_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mnsPrincipal);
            MainMenuStrip = mnsPrincipal;
            Name = "frmMenu";
            Text = "Menu";
            mnsPrincipal.ResumeLayout(false);
            mnsPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnsPrincipal;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem aplicacionesToolStripMenuItem;
        private ToolStripMenuItem calculadoraSimpleToolStripMenuItem;
        private ToolStripMenuItem ordenamientosToolStripMenuItem;
        private ToolStripMenuItem burbujaToolStripMenuItem;
        private ToolStripMenuItem registroToolStripMenuItem;
        private ToolStripMenuItem temporizadoresToolStripMenuItem;
        private ToolStripMenuItem relojToolStripMenuItem;
    }
}
