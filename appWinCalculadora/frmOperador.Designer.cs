namespace appWinCalculadora
{
    partial class frmOperador<Tipo>
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
            this.lblOperando1 = new System.Windows.Forms.Label();
            this.lblOperando2 = new System.Windows.Forms.Label();
            this.txtOperando1 = new System.Windows.Forms.TextBox();
            this.txtOperando2 = new System.Windows.Forms.TextBox();
            this.chkDesbordamiento = new System.Windows.Forms.CheckBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnOperar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOperando1
            // 
            this.lblOperando1.AutoSize = true;
            this.lblOperando1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperando1.Location = new System.Drawing.Point(35, 35);
            this.lblOperando1.Name = "lblOperando1";
            this.lblOperando1.Size = new System.Drawing.Size(84, 15);
            this.lblOperando1.TabIndex = 0;
            this.lblOperando1.Text = "Operando 1:";
            // 
            // lblOperando2
            // 
            this.lblOperando2.AutoSize = true;
            this.lblOperando2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperando2.Location = new System.Drawing.Point(35, 75);
            this.lblOperando2.Name = "lblOperando2";
            this.lblOperando2.Size = new System.Drawing.Size(84, 15);
            this.lblOperando2.TabIndex = 1;
            this.lblOperando2.Text = "Operando 2:";
            // 
            // txtOperando1
            // 
            this.txtOperando1.Location = new System.Drawing.Point(197, 30);
            this.txtOperando1.Name = "txtOperando1";
            this.txtOperando1.Size = new System.Drawing.Size(187, 25);
            this.txtOperando1.TabIndex = 2;
            this.txtOperando1.TextChanged += new System.EventHandler(this.txtOperando1_TextChanged);
            // 
            // txtOperando2
            // 
            this.txtOperando2.Location = new System.Drawing.Point(197, 70);
            this.txtOperando2.Name = "txtOperando2";
            this.txtOperando2.Size = new System.Drawing.Size(187, 25);
            this.txtOperando2.TabIndex = 3;
            this.txtOperando2.TextChanged += new System.EventHandler(this.txtOperando2_TextChanged);
            // 
            // chkDesbordamiento
            // 
            this.chkDesbordamiento.AutoSize = true;
            this.chkDesbordamiento.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDesbordamiento.Location = new System.Drawing.Point(197, 109);
            this.chkDesbordamiento.Name = "chkDesbordamiento";
            this.chkDesbordamiento.Size = new System.Drawing.Size(187, 19);
            this.chkDesbordamiento.TabIndex = 4;
            this.chkDesbordamiento.Text = "Chequear Desbordamiento";
            this.chkDesbordamiento.UseVisualStyleBackColor = true;
            this.chkDesbordamiento.Visible = false;
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(197, 147);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(187, 25);
            this.txtResultado.TabIndex = 5;
            // 
            // btnOperar
            // 
            this.btnOperar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperar.Location = new System.Drawing.Point(38, 140);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(95, 38);
            this.btnOperar.TabIndex = 6;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // frmOperador
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(428, 197);
            this.ControlBox = false;
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.chkDesbordamiento);
            this.Controls.Add(this.txtOperando2);
            this.Controls.Add(this.txtOperando1);
            this.Controls.Add(this.lblOperando2);
            this.Controls.Add(this.lblOperando1);
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOperador";
            this.ShowIcon = false;
            this.Text = "Operador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOperando1;
        private System.Windows.Forms.Label lblOperando2;
        private System.Windows.Forms.TextBox txtOperando1;
        private System.Windows.Forms.TextBox txtOperando2;
        private System.Windows.Forms.CheckBox chkDesbordamiento;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnOperar;
    }
}