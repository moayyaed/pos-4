using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.Model;
using POS.Controller;
using POS.Utils;
using POS.Services;
namespace POS.Views
{
    public partial class UpdateProductForm : MaterialSkin.Controls.MaterialForm
    {
        /// <summary>
        /// CONTROLLERS
        /// </summary>
        ProductController productController = new ProductController();
        ProductModel pModel = new ProductModel();
        public UpdateProductForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// CLOSE PAGE BUTTON CLICK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClosePagebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// LOAD PRODUCT FORM ENTRIES
        /// </summary>
        private void LoadFieldsDetails()
        {
            ProductDbIDlbl.Text = StaticProductModel.PID;
            ProductNametxt.Text = StaticProductModel.ProductName;
            ProductIdtxt.Text = StaticProductModel.ProductId;
            ProductQuantitytxt.Text = StaticProductModel.ProductQuantity;
            ProductSellingPricetxt.Text = StaticProductModel.ProductSellingPrice;
            ProductCostPricetxt.Text = StaticProductModel.ProductCostPrice;
            ProductCatetxt.Text = StaticProductModel.ProductCategory;
        }

        /// <summary>
        /// DELETE PRODUCT BUTTON CLICK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteProductbtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("do you want to delete this item???","Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                productController.DeleteProductByProductId(ProductIdtxt.Text);
            }
        }

        /// <summary>
        /// PREPARE THE PRODUCT MODEL
        /// </summary>
        /// <returns></returns>
        private ProductModel PrepareProductModel()
        {
            pModel = new ProductModel();
            pModel.ProductName = ProductNametxt.Text;
            pModel.ProductQuantity = ProductQuantitytxt.Text;
            pModel.ID = ProductDbIDlbl.Text;
            pModel.ProductID = ProductIdtxt.Text;
            pModel.ProductCostPrice=ProductCostPricetxt.Text;
            pModel.ProductSellingPrice = ProductSellingPricetxt.Text;
            pModel.ProductCategory = ProductCatetxt.Text;
            return pModel;
        }
        /// <summary>
        /// FORM LOAD EVENT HANDLER
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateProductForm_Load(object sender, EventArgs e)
        {
            LoadFieldsDetails();
            SelectedNewProductCategorycbx.DataSource = productController.ProductCategoryList(productController.GetProductCategories());
        }
        /// <summary>
        /// UPDATE CHANGES BUTTON CLICK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveChangebtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Save Changes??", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                productController.UpdateProductEntriesByProductDbId(PrepareProductModel());
            }
        }

        /// <summary>
        /// ENABLE CHANGE PROD CATE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeCateccb_CheckedChanged(object sender, EventArgs e)
        {
            if (ChangeCateccb.Checked == true)
            {
                SelectedNewProductCategorycbx.Enabled = true;
            }
            else
            {
                SelectedNewProductCategorycbx.Enabled = false;

            }
        }

        /// <summary>
        /// EDIT SELLING PRICE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditSellingPriceckb_CheckedChanged(object sender, EventArgs e)
        {
            if (EditSellingPriceckb.Checked == true)
            {
                ProductSellingPricetxt.Enabled = true;
            }
            else
            {
                ProductSellingPricetxt.Enabled = false;

            }
        }

        /// <summary>
        /// EDIT COST PRICE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditCostPriceckb_CheckedChanged(object sender, EventArgs e)
        {
            
            if (EditCostPriceckb.Checked == true)
            {
                ProductCostPricetxt.Enabled = true;
            }
            else
            {
                ProductCostPricetxt.Enabled = false;

            }
        }

        /// <summary>
        /// EDIT QUANTITY
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditQntyckb_CheckedChanged(object sender, EventArgs e)
        {
            if (EditQntyckb.Checked == true)
            {
                ProductQuantitytxt.Enabled = true;
            }
            else
            {
                ProductQuantitytxt.Enabled = false;

            }
        }

        private void EditNameckb_CheckedChanged(object sender, EventArgs e)
        {
            if (EditNameckb.Checked == true)
            {
                ProductNametxt.Enabled = true;
            }
            else
            {
                ProductNametxt.Enabled = false;

            }
        }

        private void SelectedNewProductCategorycbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductCatetxt.Text = SelectedNewProductCategorycbx.Text;
        }

        private void ProductNametxt_TextChanged(object sender, EventArgs e)
        {
            if (ProductNametxt.Text.Length <= 0)
            {
                ProductNametxt.Focus();
                SaveChangebtn.Enabled = false;
                return;
            }
            else
            {
                SaveChangebtn.Enabled = true;
                return;
            }
        }

        private void ProductQuantitytxt_TextChanged(object sender, EventArgs e)
        {
            int validqnt = 0;
            if (ProductNametxt.Text.Length <= 0 || !int.TryParse(ProductQuantitytxt.Text,out validqnt))
            {
                ProductQuantitytxt.Focus();
                SaveChangebtn.Enabled = false;
                return;
            }
            else
            {
                SaveChangebtn.Enabled = true;
                return;
            }
        }

        private void ProductCostPricetxt_TextChanged(object sender, EventArgs e)
        {
            double validqnt = 0;
            if (ProductCostPricetxt.Text.Length <= 0 || !Double.TryParse(ProductCostPricetxt.Text, out validqnt))
            {
                ProductCostPricetxt.Focus();
                SaveChangebtn.Enabled = false;
                return;
            }
            else
            {
                SaveChangebtn.Enabled = true;
                return;
            }
        }

        private void ProductSellingPricetxt_TextChanged(object sender, EventArgs e)
        {
            double validqnt = 0;
            if (ProductSellingPricetxt.Text.Length <= 0 || !Double.TryParse(ProductSellingPricetxt.Text, out validqnt))
            {
                ProductSellingPricetxt.Focus();
                SaveChangebtn.Enabled = false;
                return;
            }
            else
            {
                SaveChangebtn.Enabled = true;
                return;
            }
        }
    }
}
