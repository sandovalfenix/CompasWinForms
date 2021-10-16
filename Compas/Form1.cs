using System;
using System.Windows.Forms;

namespace Compas
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var listProducts = await Program.GetProductsAsync("webApi/products");
                dataGridView1.DataSource = listProducts;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        private async void reLoad_dataGridView1()
        {
            var listProducts = await Program.GetProductsAsync("webApi/products");
            dataGridView1.Update();
            dataGridView1.Refresh();
            dataGridView1.DataSource = listProducts;
        }

        private Product getTextBoxAllProduct()
        {
            return new Product
            {
                id_product = int.Parse(txt_id.Text),
                name_product = txt_name.Text,
                price_product = float.Parse(txt_price.Text),
                quantity_product = int.Parse(txt_quantity.Text)
            };
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {

            try
            {
                var url = Program.CreateProductAsync(getTextBoxAllProduct());
                MessageBox.Show($"Registro Completado: Producto ID {txt_id.Text}");

                reLoad_dataGridView1();

                Console.WriteLine($"Created at {url}");
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

            txt_id.Clear();
            txt_name.Clear();
            txt_price.Clear();
            txt_quantity.Clear();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnAddProduct.Visible = false;
            btnDeleteProduct.Visible = true;
            btnUpdateProduct.Visible = true;
            btnCancelActions.Visible = true;
            txt_id.ReadOnly = true;

            txt_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_price.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_quantity.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnCancelActions_Click(object sender, EventArgs e)
        {
            btnAddProduct.Visible = !btnAddProduct.Visible;
            btnDeleteProduct.Visible = !btnDeleteProduct.Visible;
            btnUpdateProduct.Visible = !btnUpdateProduct.Visible;
            btnCancelActions.Visible = !btnCancelActions.Visible;
            txt_id.ReadOnly = !txt_id.ReadOnly;

            txt_id.Clear();
            txt_name.Clear();
            txt_price.Clear();
            txt_quantity.Clear();
        }

        private async void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            
            if (txt_id.Text != null)
            {
                try
                {
                    var statusCode = await Program.DeleteProductAsync(txt_id.Text);
                    MessageBox.Show($"Registro Eliminado: Producto ID {txt_id.Text}");
                    Console.WriteLine($"Deleted (HTTP Status = {(int)statusCode})");

                    reLoad_dataGridView1();
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            }
            else
            {
                MessageBox.Show($"El campo codigo esta vacio");
            }
            
        }

        private async void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != null)
            {
                try
                {
                    var content = await Program.UpdateProductAsync(getTextBoxAllProduct());
                    MessageBox.Show($"Registro Actualizado: Producto ID {txt_id}");

                    reLoad_dataGridView1();

                    Console.WriteLine($"Update at {content}");
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            }
            else
            {
                MessageBox.Show($"El campo codigo esta vacio");
            }
        }
    }
}
