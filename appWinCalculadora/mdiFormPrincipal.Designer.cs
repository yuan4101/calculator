namespace appWinCalculadora
{
    partial class mdiFormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.subMnuSumar = new System.Windows.Forms.ToolStripMenuItem();
            this.subMnuSumarOpcByte = new System.Windows.Forms.ToolStripMenuItem();
            this.subMnuSumarOpcShort = new System.Windows.Forms.ToolStripMenuItem();
            this.subMnuSumarOpcEntero = new System.Windows.Forms.ToolStripMenuItem();
            this.subMnuSumarOpcLong = new System.Windows.Forms.ToolStripMenuItem();
            this.subMnuSumarOpcFloat = new System.Windows.Forms.ToolStripMenuItem();
            this.subMnuSumarOpcDoble = new System.Windows.Forms.ToolStripMenuItem();
            this.subMnuRestar = new System.Windows.Forms.ToolStripMenuItem();
            this.subMnuRestarOpcEntero = new System.Windows.Forms.ToolStripMenuItem();
            this.subMnuRestarOpcFloat = new System.Windows.Forms.ToolStripMenuItem();
            this.subMnuMultiplicar = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuMultiplicarOpcEntero = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuMultiplicarOpcFloat = new System.Windows.Forms.ToolStripMenuItem();
            this.subMnuDividir = new System.Windows.Forms.ToolStripMenuItem();
            this.subMnuDividirOpcEntero = new System.Windows.Forms.ToolStripMenuItem();
            this.subMnuDividirOpcFloat = new System.Windows.Forms.ToolStripMenuItem();
            this.opcSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPrincipal});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(428, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMnuSumar,
            this.subMnuRestar,
            this.subMnuMultiplicar,
            this.subMnuDividir,
            this.opcSalir});
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(96, 20);
            this.mnuPrincipal.Text = "MenuPrincipal";
            // 
            // subMnuSumar
            // 
            this.subMnuSumar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMnuSumarOpcByte,
            this.subMnuSumarOpcShort,
            this.subMnuSumarOpcEntero,
            this.subMnuSumarOpcLong,
            this.subMnuSumarOpcFloat,
            this.subMnuSumarOpcDoble});
            this.subMnuSumar.Name = "subMnuSumar";
            this.subMnuSumar.Size = new System.Drawing.Size(180, 22);
            this.subMnuSumar.Text = "Sumar...";
            // 
            // subMnuSumarOpcByte
            // 
            this.subMnuSumarOpcByte.Name = "subMnuSumarOpcByte";
            this.subMnuSumarOpcByte.Size = new System.Drawing.Size(180, 22);
            this.subMnuSumarOpcByte.Text = "Byte";
            this.subMnuSumarOpcByte.Click += new System.EventHandler(this.subMnuSumarOpcByte_Click);
            // 
            // subMnuSumarOpcShort
            // 
            this.subMnuSumarOpcShort.Name = "subMnuSumarOpcShort";
            this.subMnuSumarOpcShort.Size = new System.Drawing.Size(180, 22);
            this.subMnuSumarOpcShort.Text = "Short";
            this.subMnuSumarOpcShort.Click += new System.EventHandler(this.subMnuSumarOpcShort_Click);
            // 
            // subMnuSumarOpcEntero
            // 
            this.subMnuSumarOpcEntero.Name = "subMnuSumarOpcEntero";
            this.subMnuSumarOpcEntero.Size = new System.Drawing.Size(180, 22);
            this.subMnuSumarOpcEntero.Text = "Entero";
            this.subMnuSumarOpcEntero.Click += new System.EventHandler(this.subMnuSumarOpcEntero_Click);
            // 
            // subMnuSumarOpcLong
            // 
            this.subMnuSumarOpcLong.Name = "subMnuSumarOpcLong";
            this.subMnuSumarOpcLong.Size = new System.Drawing.Size(180, 22);
            this.subMnuSumarOpcLong.Text = "Long";
            this.subMnuSumarOpcLong.Click += new System.EventHandler(this.subMnuSumarOpcLong_Click);
            // 
            // subMnuSumarOpcFloat
            // 
            this.subMnuSumarOpcFloat.Name = "subMnuSumarOpcFloat";
            this.subMnuSumarOpcFloat.Size = new System.Drawing.Size(180, 22);
            this.subMnuSumarOpcFloat.Text = "Float";
            this.subMnuSumarOpcFloat.Click += new System.EventHandler(this.subMnuSumarOpcFloat_Click);
            // 
            // subMnuSumarOpcDoble
            // 
            this.subMnuSumarOpcDoble.Name = "subMnuSumarOpcDoble";
            this.subMnuSumarOpcDoble.Size = new System.Drawing.Size(180, 22);
            this.subMnuSumarOpcDoble.Text = "Doble";
            this.subMnuSumarOpcDoble.Click += new System.EventHandler(this.subMnuSumarOpcDoble_Click);
            // 
            // subMnuRestar
            // 
            this.subMnuRestar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMnuRestarOpcEntero,
            this.subMnuRestarOpcFloat});
            this.subMnuRestar.Name = "subMnuRestar";
            this.subMnuRestar.Size = new System.Drawing.Size(180, 22);
            this.subMnuRestar.Text = "Restar...";
            // 
            // subMnuRestarOpcEntero
            // 
            this.subMnuRestarOpcEntero.Name = "subMnuRestarOpcEntero";
            this.subMnuRestarOpcEntero.Size = new System.Drawing.Size(180, 22);
            this.subMnuRestarOpcEntero.Text = "Entero";
            this.subMnuRestarOpcEntero.Click += new System.EventHandler(this.subMnuRestarOpcEntero_Click);
            // 
            // subMnuRestarOpcFloat
            // 
            this.subMnuRestarOpcFloat.Name = "subMnuRestarOpcFloat";
            this.subMnuRestarOpcFloat.Size = new System.Drawing.Size(180, 22);
            this.subMnuRestarOpcFloat.Text = "Float";
            this.subMnuRestarOpcFloat.Click += new System.EventHandler(this.subMnuRestarOpcFloat_Click);
            // 
            // subMnuMultiplicar
            // 
            this.subMnuMultiplicar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuMultiplicarOpcEntero,
            this.subMenuMultiplicarOpcFloat});
            this.subMnuMultiplicar.Name = "subMnuMultiplicar";
            this.subMnuMultiplicar.Size = new System.Drawing.Size(180, 22);
            this.subMnuMultiplicar.Text = "Multiplicar...";
            // 
            // subMenuMultiplicarOpcEntero
            // 
            this.subMenuMultiplicarOpcEntero.Name = "subMenuMultiplicarOpcEntero";
            this.subMenuMultiplicarOpcEntero.Size = new System.Drawing.Size(180, 22);
            this.subMenuMultiplicarOpcEntero.Text = "Entero";
            this.subMenuMultiplicarOpcEntero.Click += new System.EventHandler(this.subMenuMultiplicarOpcEntero_Click);
            // 
            // subMenuMultiplicarOpcFloat
            // 
            this.subMenuMultiplicarOpcFloat.Name = "subMenuMultiplicarOpcFloat";
            this.subMenuMultiplicarOpcFloat.Size = new System.Drawing.Size(180, 22);
            this.subMenuMultiplicarOpcFloat.Text = "Float";
            this.subMenuMultiplicarOpcFloat.Click += new System.EventHandler(this.subMenuMultiplicarOpcFloat_Click);
            // 
            // subMnuDividir
            // 
            this.subMnuDividir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMnuDividirOpcEntero,
            this.subMnuDividirOpcFloat});
            this.subMnuDividir.Name = "subMnuDividir";
            this.subMnuDividir.Size = new System.Drawing.Size(180, 22);
            this.subMnuDividir.Text = "Dividir...";
            // 
            // subMnuDividirOpcEntero
            // 
            this.subMnuDividirOpcEntero.Name = "subMnuDividirOpcEntero";
            this.subMnuDividirOpcEntero.Size = new System.Drawing.Size(180, 22);
            this.subMnuDividirOpcEntero.Text = "Entero";
            this.subMnuDividirOpcEntero.Click += new System.EventHandler(this.subMnuDividirOpcEntero_Click);
            // 
            // subMnuDividirOpcFloat
            // 
            this.subMnuDividirOpcFloat.Name = "subMnuDividirOpcFloat";
            this.subMnuDividirOpcFloat.Size = new System.Drawing.Size(180, 22);
            this.subMnuDividirOpcFloat.Text = "Float";
            this.subMnuDividirOpcFloat.Click += new System.EventHandler(this.subMnuDividirOpcFloat_Click);
            // 
            // opcSalir
            // 
            this.opcSalir.Name = "opcSalir";
            this.opcSalir.Size = new System.Drawing.Size(180, 22);
            this.opcSalir.Text = "Salir";
            this.opcSalir.Click += new System.EventHandler(this.opcSalir_Click);
            // 
            // mdiFormPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(428, 241);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mdiFormPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem subMnuSumar;
        private System.Windows.Forms.ToolStripMenuItem subMnuSumarOpcByte;
        private System.Windows.Forms.ToolStripMenuItem subMnuSumarOpcShort;
        private System.Windows.Forms.ToolStripMenuItem subMnuSumarOpcEntero;
        private System.Windows.Forms.ToolStripMenuItem subMnuSumarOpcLong;
        private System.Windows.Forms.ToolStripMenuItem subMnuSumarOpcFloat;
        private System.Windows.Forms.ToolStripMenuItem subMnuSumarOpcDoble;
        private System.Windows.Forms.ToolStripMenuItem subMnuRestar;
        private System.Windows.Forms.ToolStripMenuItem subMnuRestarOpcEntero;
        private System.Windows.Forms.ToolStripMenuItem subMnuRestarOpcFloat;
        private System.Windows.Forms.ToolStripMenuItem subMnuMultiplicar;
        private System.Windows.Forms.ToolStripMenuItem subMenuMultiplicarOpcEntero;
        private System.Windows.Forms.ToolStripMenuItem subMenuMultiplicarOpcFloat;
        private System.Windows.Forms.ToolStripMenuItem subMnuDividir;
        private System.Windows.Forms.ToolStripMenuItem subMnuDividirOpcEntero;
        private System.Windows.Forms.ToolStripMenuItem subMnuDividirOpcFloat;
        private System.Windows.Forms.ToolStripMenuItem opcSalir;
    }
}

