using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avancep1.Formulario
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombreProducto = txtNombreProducto.Text;
            string categoria = cbxCategoria.SelectedItem.ToString();
            string codigo = txtCodigo.Text;
            decimal precio;
            int cantidadEnStock;

            if (decimal.TryParse(txtPrecio.Text, out precio) && int.TryParse(txtCantidadStock.Text, out cantidadEnStock))
            {

                MessageBox.Show("Producto agregado correctamente");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores válidos para el precio y la cantidad en stock.");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Get the selected product from the database
            string selectedProduct = GetSelectedProduct();

            // Update the product in the database
            bool isUpdated = UpdateProduct(selectedProduct);

            if (isUpdated)
            {
                MessageBox.Show("Producto actualizado correctamente");
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el producto");
            }
        }

        private string GetSelectedProduct()
        {
            // Get the selected product from the UI
            string selectedProduct = GetSelectedItem().ToString();

            return selectedProduct;
        }

        private object GetSelectedItem()
        {
            return txtNombreProducto.SelectedItem;
        }

        private bool UpdateProduct(string product)
        {
            bool isUpdated = true;

            return isUpdated;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Producto eliminado correctamente");
        }
    }
}


