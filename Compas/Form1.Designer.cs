using System.Windows.Forms;

namespace Compas
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
            this.txt_price = new System.Windows.Forms.TextBox();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.lbl_prices = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lb_ID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnCancelActions = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(112, 106);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(100, 20);
            this.txt_price.TabIndex = 34;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeleteProduct.FlatAppearance.BorderSize = 0;
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteProduct.Location = new System.Drawing.Point(115, 233);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteProduct.TabIndex = 33;
            this.btnDeleteProduct.Text = "Borrar";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Visible = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Location = new System.Drawing.Point(115, 191);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 23);
            this.btnAddProduct.TabIndex = 32;
            this.btnAddProduct.Text = "Añadir";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(112, 148);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(100, 20);
            this.txt_quantity.TabIndex = 30;
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AccessibleName = "";
            this.lbl_quantity.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Location = new System.Drawing.Point(56, 148);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(49, 13);
            this.lbl_quantity.TabIndex = 29;
            this.lbl_quantity.Text = "Cantidad";
            // 
            // lbl_prices
            // 
            this.lbl_prices.AccessibleName = "";
            this.lbl_prices.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lbl_prices.AutoSize = true;
            this.lbl_prices.Location = new System.Drawing.Point(68, 106);
            this.lbl_prices.Name = "lbl_prices";
            this.lbl_prices.Size = new System.Drawing.Size(37, 13);
            this.lbl_prices.TabIndex = 28;
            this.lbl_prices.Text = "Precio";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(112, 58);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 27;
            // 
            // lbl_name
            // 
            this.lbl_name.AccessibleName = "";
            this.lbl_name.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(65, 58);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(44, 13);
            this.lbl_name.TabIndex = 26;
            this.lbl_name.Text = "Nombre";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(112, 12);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 25;
            // 
            // lb_ID
            // 
            this.lb_ID.AccessibleName = "";
            this.lb_ID.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lb_ID.AutoSize = true;
            this.lb_ID.Location = new System.Drawing.Point(65, 12);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(40, 13);
            this.lb_ID.TabIndex = 24;
            this.lb_ID.Text = "Codigo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(325, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(438, 324);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateProduct.FlatAppearance.BorderSize = 0;
            this.btnUpdateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProduct.Location = new System.Drawing.Point(34, 233);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateProduct.TabIndex = 36;
            this.btnUpdateProduct.Text = "Actualizar";
            this.btnUpdateProduct.UseVisualStyleBackColor = false;
            this.btnUpdateProduct.Visible = false;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnCancelActions
            // 
            this.btnCancelActions.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelActions.Location = new System.Drawing.Point(208, 233);
            this.btnCancelActions.Name = "btnCancelActions";
            this.btnCancelActions.Size = new System.Drawing.Size(75, 23);
            this.btnCancelActions.TabIndex = 37;
            this.btnCancelActions.Text = "Cancelar";
            this.btnCancelActions.UseVisualStyleBackColor = false;
            this.btnCancelActions.Visible = false;
            this.btnCancelActions.Click += new System.EventHandler(this.btnCancelActions_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelActions);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.lbl_prices);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lb_ID);
            this.Name = "Form1";
            this.Text = "Administrador Producto";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }




        #endregion

        private TextBox txt_price;
        private Button btnDeleteProduct;
        private Button btnAddProduct;
        private TextBox txt_quantity;
        private Label lbl_quantity;
        private Label lbl_prices;
        private TextBox txt_name;
        private Label lbl_name;
        private TextBox txt_id;
        private Label lb_ID;
        private DataGridView dataGridView1;
        private Button btnUpdateProduct;
        private Button btnCancelActions;
    }
}

