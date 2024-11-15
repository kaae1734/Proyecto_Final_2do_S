using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avancep1.Formulario;

namespace Avancep1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Usuario
        {
            public string Nombre { get; set; }
            public string Contrasena { get; set; }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            // ID
        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {
            // Contraseña


        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            this.txtID.Text = "Usurario";
            this.txtContrasena.Text = "Contraseña";
            
            Form2 nuevoFormulario = new Form2();
            nuevoFormulario.Show();
        }
    }
}
