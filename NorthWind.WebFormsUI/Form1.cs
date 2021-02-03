using NorthWind.Business.Abstract;
using NorthWind.Business.Concrete;
using NorthWind.DataAccess.Abstract;
using NorthWind.DataAccess.Concrete.EntityFramework;
using NorthWind.DataAccess.Concrete.NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthWind.WebFormsUI
{
    public partial class btnUpdate : Form
    {
        public btnUpdate()
        {
            InitializeComponent();
        }
        IProductService _productService = new ProductManager(new EfProductDal());
        ICategoryService _categoryService = new CategoryManager(new EfCategoryDal());
        private void Form1_Load(object sender, EventArgs e)
        {

            GetProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
            cbxcCategory.DataSource = _categoryService.GetAll();
            cbxekleCategoryName.DataSource = _categoryService.GetAll();
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxcCategory.DisplayMember = "CategoryName";
            cbxcCategory.ValueMember = "CategoryId";

            cbxekleCategoryName.DisplayMember = "CategoryName";
            cbxekleCategoryName.ValueMember = "CategoryId";
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";
        }

        private void GetProducts()
        {
            dataGridView1.DataSource = _productService.GetAll();
        }

        private void cbxcCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxcCategory.SelectedValue));
            }
            catch
            {


            }

        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxProductName.Text))
            {
                GetProducts();
            }
            else
            {
                dataGridView1.DataSource = _productService.GetProductsByName(tbxProductName.Text);
            }

        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            _productService.Add(new Products
            {
                ProductName = tbxekleProductName.Text,
                CategoryID = Convert.ToInt32(cbxekleCategoryName.SelectedValue),
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                UnitsInStock = Convert.ToInt16(tbxStockAmount.Text),
                QuantityPerUnit = tbxQuantityPerUnit.Text,


            });
            MessageBox.Show("Ürün Kaydedildi");
            GetProducts();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1 3 5 6 4
            tbxupdateProductName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cbxCategory.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbxUpdateUnitPrice.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tbxUpdateStockAmount.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            tbxUpdateQuantityPerUnit.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _productService.Update(new Products
            {
                ProductID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                ProductName = tbxupdateProductName.Text,
                CategoryID = Convert.ToInt32(cbxCategory.SelectedValue),
                UnitPrice = Convert.ToDecimal(tbxUpdateUnitPrice.Text),
                UnitsInStock = Convert.ToInt16(tbxUpdateStockAmount.Text),
                QuantityPerUnit = tbxUpdateQuantityPerUnit.Text,
            });
            MessageBox.Show("Ürün başarıyla güncellendi.");
            GetProducts();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                try
                {
                    _productService.Delete(new Products
                    {
                        ProductID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),

                    });
                   
                    GetProducts();
                }
                catch(Exception exception)
                {

                    MessageBox.Show("Bu ürünü silemezsiniz");
                }




            }


        }
    }
}
