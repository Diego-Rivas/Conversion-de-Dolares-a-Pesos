namespace Calcular_Cambio
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbCentral = new System.Windows.Forms.GroupBox();
            this.lblCostoArt = new System.Windows.Forms.Label();
            this.lblCantDine = new System.Windows.Forms.Label();
            this.lblCambio = new System.Windows.Forms.Label();
            this.txtCostArt = new System.Windows.Forms.TextBox();
            this.txtEntrega = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gbCentral.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCentral
            // 
            this.gbCentral.Controls.Add(this.txtResultado);
            this.gbCentral.Controls.Add(this.txtEntrega);
            this.gbCentral.Controls.Add(this.txtCostArt);
            this.gbCentral.Controls.Add(this.lblCambio);
            this.gbCentral.Controls.Add(this.lblCantDine);
            this.gbCentral.Controls.Add(this.lblCostoArt);
            this.gbCentral.Location = new System.Drawing.Point(38, 33);
            this.gbCentral.Name = "gbCentral";
            this.gbCentral.Size = new System.Drawing.Size(668, 394);
            this.gbCentral.TabIndex = 0;
            this.gbCentral.TabStop = false;
            this.gbCentral.Text = "Calculo de Valores";
            // 
            // lblCostoArt
            // 
            this.lblCostoArt.AutoSize = true;
            this.lblCostoArt.Location = new System.Drawing.Point(22, 60);
            this.lblCostoArt.Name = "lblCostoArt";
            this.lblCostoArt.Size = new System.Drawing.Size(148, 18);
            this.lblCostoArt.TabIndex = 0;
            this.lblCostoArt.Text = "Costo del Articulo:";
            // 
            // lblCantDine
            // 
            this.lblCantDine.AutoSize = true;
            this.lblCantDine.Location = new System.Drawing.Point(22, 132);
            this.lblCantDine.Name = "lblCantDine";
            this.lblCantDine.Size = new System.Drawing.Size(252, 18);
            this.lblCantDine.TabIndex = 1;
            this.lblCantDine.Text = "Cantidad de Dinero que Entrega:";
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Location = new System.Drawing.Point(39, 264);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(137, 18);
            this.lblCambio.TabIndex = 2;
            this.lblCambio.Text = "Cambio a recibir:";
            // 
            // txtCostArt
            // 
            this.txtCostArt.Location = new System.Drawing.Point(296, 57);
            this.txtCostArt.Name = "txtCostArt";
            this.txtCostArt.Size = new System.Drawing.Size(229, 24);
            this.txtCostArt.TabIndex = 3;
            // 
            // txtEntrega
            // 
            this.txtEntrega.Location = new System.Drawing.Point(296, 129);
            this.txtEntrega.Name = "txtEntrega";
            this.txtEntrega.Size = new System.Drawing.Size(229, 24);
            this.txtEntrega.TabIndex = 4;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(220, 261);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(222, 24);
            this.txtResultado.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnCalcular);
            this.panel1.Location = new System.Drawing.Point(748, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 327);
            this.panel1.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.OldLace;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalir.Image = global::Calcular_Cambio.Properties.Resources.icons8_x_100;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSalir.Location = new System.Drawing.Point(0, 223);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(234, 103);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.OldLace;
            this.btnLimpiar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLimpiar.Image = global::Calcular_Cambio.Properties.Resources.icons8_escoba_80;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(0, 111);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(234, 112);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.OldLace;
            this.btnCalcular.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalcular.Image = global::Calcular_Cambio.Properties.Resources.icons8_monedas_48;
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.Location = new System.Drawing.Point(0, 0);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(234, 111);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1333, 623);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbCentral);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Calcular Cambio";
            this.gbCentral.ResumeLayout(false);
            this.gbCentral.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCentral;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtEntrega;
        private System.Windows.Forms.TextBox txtCostArt;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.Label lblCantDine;
        private System.Windows.Forms.Label lblCostoArt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalcular;
    }
}

