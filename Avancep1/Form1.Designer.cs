namespace Avancep1
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
            this.gpbIniciarSesion = new System.Windows.Forms.GroupBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.gpbIniciarSesion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbIniciarSesion
            // 
            this.gpbIniciarSesion.Controls.Add(this.btnIngresar);
            this.gpbIniciarSesion.Controls.Add(this.txtContrasena);
            this.gpbIniciarSesion.Controls.Add(this.txtID);
            this.gpbIniciarSesion.Controls.Add(this.lblContrasena);
            this.gpbIniciarSesion.Controls.Add(this.lblID);
            this.gpbIniciarSesion.Location = new System.Drawing.Point(238, 104);
            this.gpbIniciarSesion.Name = "gpbIniciarSesion";
            this.gpbIniciarSesion.Size = new System.Drawing.Size(316, 208);
            this.gpbIniciarSesion.TabIndex = 0;
            this.gpbIniciarSesion.TabStop = false;
            this.gpbIniciarSesion.Text = "Iniciar Sesion";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(116, 174);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 28);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(152, 91);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(100, 22);
            this.txtContrasena.TabIndex = 3;
            this.txtContrasena.TextChanged += new System.EventHandler(this.txtContrasena_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(152, 58);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 2;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Location = new System.Drawing.Point(48, 94);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(79, 16);
            this.lblContrasena.TabIndex = 1;
            this.lblContrasena.Text = "Contraseña:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(48, 58);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(23, 16);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpbIniciarSesion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpbIniciarSesion.ResumeLayout(false);
            this.gpbIniciarSesion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbIniciarSesion;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtContrasena;
    }
}

