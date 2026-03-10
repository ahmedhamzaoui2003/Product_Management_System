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
    public partial class frmAddNewCategory : Form
    {
        enum enMode { AddNew , Update}
        clsCategory _Category;
        enMode _Mode;

        public frmAddNewCategory()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        private void _FillListOfCategories()
        {
            ListOfCategories.Items.Clear();

            DataTable dtCategories = clsCategory.GetAllCategories();
            if(dtCategories != null)
            {
                foreach (DataRow row in dtCategories.Rows)
                {
                    string categoryString = row["CategoryCode"] + " : " + row["CategoryName"];
                    ListOfCategories.Items.Add(categoryString);
                }
            }
        }

        private void _LoadData()
        {
            _FillListOfCategories();
            if(_Mode == enMode.AddNew)
            {
                _Category = new clsCategory();
                return;
            }
        }

        private string _SelectCategoryCode(string selectedItem)
        {
            
            string CategoryCode = selectedItem.Substring(0, selectedItem.IndexOf(':') - 1);
            return CategoryCode;
        }
        private void _FillTextBoxesWithData()
        {
            txtCodeCategory.Text = _Category.CategoryCode;
            txtNameCategory.Text = _Category.CategoryName;
        }
        private void _ClearTextBoxes()
        {
            txtCodeCategory.Text = "";
            txtNameCategory.Text = "";
        }

        private void frmAddNewCategory_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
      

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtCodeCategory.Text) || !string.IsNullOrEmpty(txtNameCategory.Text))
            {
                _Category.CategoryCode = txtCodeCategory.Text;
                _Category.CategoryName = txtNameCategory.Text;

                if (_Category.Save())
                {
                    _FillListOfCategories();
                    _ClearTextBoxes();
                    MessageBox.Show($"Category [ {_Category.CategoryID} ] Added Successfully :-)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } else
                    MessageBox.Show("Cannot save empty Category :-(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ListOfCategories.SelectedIndex != -1)
            {
                string CategoryCode = _SelectCategoryCode(ListOfCategories.SelectedItem.ToString());
                if (clsCategory.IsCategoryExist(CategoryCode))
                {
                    if (MessageBox.Show($"Are you sure to delete Category {CategoryCode}", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (clsCategory.Delete(CategoryCode))
                        {
                            _FillListOfCategories();
                            _ClearTextBoxes();
                            MessageBox.Show($"Category {CategoryCode} was deleted successfully :-)");
                        }
                    }
                }
                else
                    MessageBox.Show("Category is not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("No Item Selected","Error",MessageBoxButtons.OK ,MessageBoxIcon.Error);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListOfCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListOfCategories.SelectedIndex != -1)
            {
                string CategoryCode = _SelectCategoryCode(ListOfCategories.SelectedItem.ToString());
                _Category = clsCategory.Find(CategoryCode);
                _FillTextBoxesWithData();
            }
                
        }
    }
}
