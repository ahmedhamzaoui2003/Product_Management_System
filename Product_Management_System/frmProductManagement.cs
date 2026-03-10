using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Product_Management_System;
using clsBusinessLayer;

namespace Product_Management_System
{
    public partial class frmProductManagement : Form
    {
        enum enMode { AddNew , Update}
        clsProduct _Product;
        enMode _Mode;

        public frmProductManagement()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        private void _FillListBoxWithProducts()
        {
            ListOfProducts.Items.Clear();
            DataTable dtProducts = clsProduct.GetAllProducts();

            if(dtProducts != null )
            {
                foreach (DataRow row in dtProducts.Rows)
                {
                    ListOfProducts.Items.Add(row["ProdName"]);
                }
            }
        }

        private void _FillComboBoxWithCategories()
        {
            cbCategories.DataSource = clsCategory.GetAllCategories();
            cbCategories.DisplayMember = "CategoryName"; // yodhhor fel comboBox
            cbCategories.ValueMember = "CategoryID"; // el value el 7a9i9i 
        }

        private void _LoadData()
        {
            _FillListBoxWithProducts();
            _FillComboBoxWithCategories();

            cbCategories.SelectedIndex = 0;
            if(_Mode == enMode.AddNew)
            {
                _Product = new clsProduct();
                return;
            }
        }

        private void ProductManagement_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void _ClearTextBoxes()
        {
            cbCategories.SelectedIndex = 0;
            txtNameProduct.Text = "";
            txtCodeProduct.Text = "";
            txtPriceProduct.Text = "";
            txtMadeIn.Text = "";
            dtpExpiryDate.Value = DateTime.Now;
        }

        private bool IsEmptyData()
        {
            return string.IsNullOrEmpty(txtCodeProduct.Text) && string.IsNullOrEmpty(txtNameProduct.Text) && string.IsNullOrEmpty(txtPriceProduct.Text) && string.IsNullOrEmpty(txtMadeIn.Text) && string.IsNullOrEmpty(dtpExpiryDate.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Product.ProdName = txtNameProduct.Text;
            _Product.ProdCode = txtCodeProduct.Text;
            _Product.ProdPrice = Convert.ToDouble(txtPriceProduct.Text);
            _Product.MadeIn = txtMadeIn.Text;
            _Product.ExpiryDate = dtpExpiryDate.Value;

            // bech nesta3mlo el value mte3 el comboBox :
            _Product.CategoryID = (int)cbCategories.SelectedValue;

            if (_Product.Save())
            {
                _FillListBoxWithProducts();
                _ClearTextBoxes();
                MessageBox.Show($"Category [ {_Product.ProdID} ] Added Successfully :-)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            Form fAddNewCategory = new frmAddNewCategory();
            fAddNewCategory.ShowDialog();
            _FillComboBoxWithCategories();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(ListOfProducts.SelectedIndex != -1)
            {
                string ProdName = ListOfProducts.SelectedItem.ToString();
                if (clsProduct.IsProductExist(ProdName))
                {
                    if (MessageBox.Show($"Are you sure to delete Product \'{ProdName}\'", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (clsProduct.DeleteProduct(ProdName))
                        {
                            _FillListBoxWithProducts();
                            _ClearTextBoxes();
                            MessageBox.Show($"Product '{ProdName}' was deleted successfully :-)");
                        }
                    }
                }
                else
                    MessageBox.Show("Product is not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("No Item Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void ListOfProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Product = clsProduct.Find(ListOfProducts.SelectedItem.ToString());

            //automatically yrakka7lek el categoryName wa7do:
            cbCategories.SelectedValue = _Product.CategoryID;

            txtNameProduct.Text = _Product.ProdName;
            txtCodeProduct.Text = _Product.ProdCode;
            txtPriceProduct.Text = _Product.ProdPrice.ToString();
            txtMadeIn.Text = _Product.MadeIn;
            dtpExpiryDate.Value = _Product.ExpiryDate;

        }
    }
}
