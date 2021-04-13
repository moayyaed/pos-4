using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialFramework;
using MaterialSkin.Controls;
using MaterialSkin;
using POS.Controller;
using POS.Model;
using POS.Services;
using POS.Utils;
using ClosedXML.Excel;
using System.IO;
using DGVPrinterHelper;
namespace POS.Views
{
    public partial class MainPageForm : MaterialSkin.Controls.MaterialForm
    {
        /// <summary>
        /// GLOBAL VARIABLES AND INHERITED CLASSES, OOPS:)(
        /// </summary>
        MaterialSkinManager skinManager = MaterialSkinManager.Instance;
        DeveloperConfigurations.DeveloperConfigurations themeSettings = new DeveloperConfigurations.DeveloperConfigurations();

        /// <summary>
        /// CONTROLLERS
        /// </summary>
        ProductController productController = new ProductController();
        ServiceController serviceController = new ServiceController();
        SalesController salesController = new SalesController();
        ReportController reportController = new ReportController();
        /// <summary>
        /// MODELS
        /// </summary>
        ProductModel pmodel = new ProductModel();
        RemoveItemModel removeItemModel = new RemoveItemModel();
        ServicesModel serviceModel = new ServicesModel();
        SalesModel saleModel = new SalesModel();
        ReportModel reportModel = new ReportModel();
        StaticProductModel staticProductModel = new StaticProductModel();
        public DataTable saleTable = new DataTable();
        /// <summary>
        /// SERVICES
        /// </summary>
        ProductServices productServices = new ProductServices();
        Utils.Utils utils = new Utils.Utils();
        /// <summary>
        /// VARIABLES
        /// </summary>
        public string CurrentlyAddedListItem;

        /// <summary>
        /// PARENT OBJECT -> MAIN PAGE FORM 
        /// </summary>
        public MainPageForm()
        {
            InitializeComponent();
            skinManager.AddFormToManage(this);
            if (themeSettings.GetTheme() == "Dark")
            {
                skinManager.Theme = MaterialSkinManager.Themes.DARK;
                ThemeChangerbtn.Checked = false;
            }
            else
            {
                skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            }

        }

        /// <summary>
        /// MAIN FORM ON LOAD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainPageForm_Load(object sender, EventArgs e)
        {
            LoadProductCategories();
            FillAllProductList();
            FetchAllProducts();
            PrepareSalePrintTable();
            //FetchAllServices();
            // LoadSalesData();
            Usernamelbl.Text = string.Format("{0}[{1}]", StaticAccountModel.Username, StaticAccountModel.Role);
            if (StaticAccountModel.Role == "Admin")
            {
                DashBoardbtn.Enabled = true;
                ManageProductsContainer.Enabled = true;
            }
        }

        /// <summary>
        /// LOAD ALL THE PRODUCT CATEGORIES
        /// </summary>
        private void LoadProductCategories()
        {
            try
            {
                SelectedNewProductCategorycbx.DataSource = productController.ProductCategoryList(productController.GetProductCategories());

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ProductCategory Errro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// APPLICATION THEME SWITCHER
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThemeChangerbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (ThemeChangerbtn.Checked)
            {
                string theme = "Light";
                skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                ThemeChangerbtn.Text = theme;
                themeSettings.SetThemeValue(theme);
            }
            else
            {
                string theme = "Dark";
                skinManager.Theme = MaterialSkinManager.Themes.DARK;
                ThemeChangerbtn.Text = theme;
                themeSettings.SetThemeValue(theme);
            }
        }


        /// <summary>
        /// LOGOUT OUT EVENT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit application?", "Acccount Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AccountLoginForm Accountlogin = new AccountLoginForm();
                Accountlogin.Show();
                this.Hide();
            }
        }


        /// <summary>
        /// MAXIMIZE EVENT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Maximizebtn_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        /// <summary>
        /// MINIMIZE EVENT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Minimizebtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FilterProductsbtn_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// NEW PRODUCT NAME TEXT CHANGE EVENT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewProductNametxt_TextChanged(object sender, EventArgs e)
        {
            NewProductIdtxt.Text = productController.PrepareProductId(productController.GetLastProductId()).ToString();
            pmodel.ProductID = NewProductIdtxt.Text;
            pmodel.type = "ProductName";
            pmodel.ProductName = NewProductNametxt.Text;
            HandleProductValidation(pmodel);


        }

        /// <summary>
        /// SAVE THE NEW PRODUCT CATEGORY
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveCat_Click(object sender, EventArgs e)
        {
            if (AddProductCategoriestxt.Text.Length <= 0)
            {
                AddProductCategoriestxt.Focus();
                return;
            }
            else
            {
                pmodel = new ProductModel();
                pmodel.ProductCategory = AddProductCategoriestxt.Text;
                productController.AddProductCategory(pmodel);

                //MessageBox.Show("Products Category Saved", "Server Response", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddProductCategoriestxt.Text = null;
                LoadProductCategories();
                return;
            }

        }

        private void EnableAddProductCategorycb_CheckedChanged(object sender, EventArgs e)
        {
            if (EnableAddProductCategorycb.Checked == true)
            {
                AddProductCategoriestxt.Enabled = true;
                SaveCat.Enabled = true;
            }
            else
            {
                AddProductCategoriestxt.Enabled = false;
                SaveCat.Enabled = false;
            }
        }

        private void NewProductCostPricetxt_TextChanged(object sender, EventArgs e)
        {
            pmodel = new ProductModel();
            pmodel.type = "ProductCostPrice";
            pmodel.ProductCostPrice = NewProductCostPricetxt.Text;
            HandleProductValidation(pmodel);

        }

        private void NewProductSellingPricetxt_TextChanged(object sender, EventArgs e)
        {
            pmodel = new ProductModel();
            pmodel.type = "ProductSellingPrice";
            pmodel.ProductSellingPrice = NewProductSellingPricetxt.Text;
            HandleProductValidation(pmodel);
        }

        private void SelectedNewProductCategorycbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            pmodel = new ProductModel();
            pmodel.type = "ProductCategory";
            pmodel.ProductCategory = SelectedNewProductCategorycbx.Text;
            HandleProductValidation(pmodel);
        }

        private void NewProductQuantitytxt_TextChanged(object sender, EventArgs e)
        {
            pmodel = new ProductModel();
            pmodel.type = "ProductQuantity";
            pmodel.ProductQuantity = NewProductQuantitytxt.Text;
            HandleProductValidation(pmodel);
        }


        /// <summary>
        /// ADDING A  NEW PRODUCT CATEGORY
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddProductCategoriestxt_TextChanged(object sender, EventArgs e)
        {
            pmodel.type = "ProductCategorytxt";
            pmodel.ProductCategory = AddProductCategoriestxt.Text;
            HandleProductValidation(pmodel);
        }

        /// <summary>
        /// HANDLE THE VALIDATION OF THE PRODUCT MODEL FIELDS
        /// </summary>
        /// <param name="model"></param>
        private void HandleProductValidation(ProductModel model)
        {
            switch (model.type)
            {
                case "ProductName":
                    if (productServices.ValidateProductModel(pmodel) != null)
                    {
                        NewProductNametxt.Hint = productServices.ValidateProductModel(pmodel).ToString();
                        model.Error = true;
                        IsProductModelValid(model);
                    }
                    else
                    {
                        NewProductNametxt.Hint = "Product Name";
                        model.Error = false;
                        IsProductModelValid(model);
                    }
                    break;
                case "ProductQuantity":
                    if (productServices.ValidateProductModel(pmodel) != null)
                    {
                        NewProductQuantitytxt.Hint = productServices.ValidateProductModel(pmodel).ToString();
                        model.Error = true;
                        IsProductModelValid(model);
                    }
                    else
                    {
                        NewProductQuantitytxt.Hint = "Product Quantity";
                        model.Error = false;
                        IsProductModelValid(model);
                    }
                    break;
                case "ProductCostPrice":
                    if (productServices.ValidateProductModel(pmodel) != null)
                    {
                        NewProductCostPricetxt.Hint = productServices.ValidateProductModel(pmodel).ToString();
                        model.Error = true;
                        IsProductModelValid(model);
                    }
                    else
                    {
                        NewProductCostPricetxt.Hint = "Product Cost Price";
                        model.Error = false;
                        IsProductModelValid(model);
                    }
                    break;
                case "ProductSellingPrice":
                    if (productServices.ValidateProductModel(pmodel) != null)
                    {
                        NewProductSellingPricetxt.Hint = productServices.ValidateProductModel(pmodel).ToString();
                        model.Error = true;
                        IsProductModelValid(model);
                    }
                    else
                    {
                        NewProductSellingPricetxt.Hint = "Product Selling Price";
                        model.Error = false;
                        IsProductModelValid(model);
                    }
                    break;
                case "ProductCategory":
                    if (productServices.ValidateProductModel(pmodel) != null)
                    {
                        SelectedNewProductCategorycbx.Hint = productServices.ValidateProductModel(pmodel).ToString();
                        model.Error = true;
                        IsProductModelValid(model);
                    }
                    else
                    {
                        SelectedNewProductCategorycbx.Hint = "Select Product Category";
                        model.Error = false;
                        IsProductModelValid(model);
                    }
                    break;
                case "ProductCategorytxt":
                    if (productServices.ValidateProductModel(pmodel) != null)
                    {
                        AddProductCategoriestxt.Hint = productServices.ValidateProductModel(pmodel).ToString();
                    }
                    else
                    {
                        AddProductCategoriestxt.Hint = "Add Product Category";
                    }
                    break;
                default:
                    IsProductModelValid(model);
                    break;
            }
        }

        /// <summary>
        /// IS PRODUCT MODEL VALID
        /// </summary>
        /// <param name="model"></param>
        public void IsProductModelValid(ProductModel model)
        {
            if (!model.Error)
            {
                if (model.ProductName != "" && model.ProductQuantity != "" && model.ProductCostPrice != "" && model.ProductSellingPrice != "" && model.ProductCategory == "")
                {
                    // AddNewProductBtn.Enabled = true;
                }
                else
                {
                    // AddNewProductBtn.Enabled = false;
                }
            }
            else
            {
                if (model.ProductName != "" && model.ProductQuantity != "" && model.ProductCostPrice != "" && model.ProductSellingPrice != "" && model.ProductCategory == "")
                {
                    //AddNewProductBtn.Enabled = true;
                }
                else
                {
                    //  AddNewProductBtn.Enabled = false;
                }
            }
        }

        /// <summary>
        /// ADD NEW PRODUCT TO THE DATA BASE
        /// </summary>
        /// <param name="model"></param>
        public void AddNewProduct(ProductModel model)
        {
            try
            {
                model.ProductName = NewProductNametxt.Text;
                model.ProductID = NewProductIdtxt.Text;
                model.ProductQuantity = NewProductQuantitytxt.Text;
                model.ProductCostPrice = NewProductCostPricetxt.Text;
                model.ProductSellingPrice = NewProductSellingPricetxt.Text;
                model.ProductCategory = SelectedNewProductCategorycbx.Text;
                productController.AddProductToDataBase(model);
                MessageBox.Show("Product Added Successfully", "Save Product Server Response", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// ADD NEW PRODUCT BUTTON CLICK EVENT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNewProductBtn_Click(object sender, EventArgs e)
        {
            AddNewProduct(pmodel);
            FetchAllProducts();
            AllProductsListcbx.DataSource = productController.GetAllProducts();
        }


        /// <summary>
        /// LOADING THE DETAILS OF THE SELECTED PRODUCT
        /// </summary>
        /// <param name="dt"></param>
        private void LoadSelectedProductDetails(DataTable dt)
        {
            try
            {
                pmodel = new ProductModel();
                if (dt.Rows.Count > 0)
                {

                    foreach (DataRow dataRow in dt.Rows)
                    {
                        pmodel.ProductID = dataRow["productId"].ToString();
                        pmodel.ProductSellingPrice = dataRow["sellingPrice"].ToString();
                        pmodel.ProductCategory = dataRow["productCategory"].ToString();
                    }
                    ProductIDtxt.Text = pmodel.ProductID;
                    ProductUnitCosttxt.Text = pmodel.ProductSellingPrice;
                    SaleProductCatetxt.Text = pmodel.ProductCategory;
                }
                else
                {
                    ProductIDtxt.Text = null;
                    ProductUnitCosttxt.Text = null;
                    SaleProductCatetxt.Text = null;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Server Response", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// GENERATE SERVICE ID
        /// </summary>
        /// <param name="serviceId"></param>
        public void GenerateServiceId(string serviceId)
        {
            SaleServiceIDtxt.Text = serviceId;
        }

        /// <summary>
        /// calculate total cost
        /// </summary>
        /// <param name="cost"></param>
        public void CalculateTotalCost(string cost)
        {
            TotalCosttxt.Text = cost;
        }

        /// <summary>
        /// PRODUCT QUANTITY TEXT CHANGE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductQuantitytxt_TextChanged(object sender, EventArgs e)
        {

            int validqnt = 0;
            if (int.TryParse(ProductQuantitytxt.Text, out validqnt))
            {
                CalculateTotalCost(serviceController.CalculateSalCost(ProductQuantitytxt.Text, ProductUnitCosttxt.Text));
                ProductQuantitytxt.Hint = "Product Quantity";
                if (productController.CheckProductQuantitySelected(ProductIDtxt.Text, ProductQuantitytxt.Text))
                {
                    Notificationlbl.Text = LocalResources.AppConfigResource.QtyWarning;
                    Notificationlbl.ForeColor = Color.Red;
                    AddSelectedProductbtn.Enabled = false;
                }
                else
                {
                    Notificationlbl.Text = "";
                    AddSelectedProductbtn.Enabled = true;
                }

            }
            else
            {
                ProductQuantitytxt.Hint = "Invalid Product Quantity";
                TotalCosttxt.Text = "0";
            }
        }


        /// <summary>
        /// FETCH ALL PRODUCTS
        /// </summary>
        public void FetchAllProducts()
        {
            try
            {
                ProductsGrid.DataSource = productController.FetchAllProducts();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Server Response", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// FETCH ALL SERVICES FROM THE DATA BASE;
        /// </summary>
        public void FetchAllServices()
        {
            try
            {
                AllServicesDataGrid.DataSource = serviceController.FetAllServicesData();
                var counter = utils.CalculateReturns(serviceController.FetAllServicesData(), "serviceReport");
                ServiceReturnsMadelbl.Text = counter.TotalReturnsMade;
                ServiceProductsSoldlbl.Text = counter.TotalProductsSold;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Server Response", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// REFRESH ALL PRODUCTS DATABASE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshProductsDatabtn_Click(object sender, EventArgs e)
        {
            FetchAllProducts();
            LoadProductCategories();


        }

        /// <summary>
        /// COMPLETE AND CONDFIRM TRANSACTION
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfirmSelectedProductSalebtn_Click(object sender, EventArgs e)
        {
            if (CustomerNamechk.Checked == true && CustomeNametxt.Text.Length <= 0)
            {
                CustomeNametxt.Focus();
                return;
            }
            try
            {
                if (MessageBox.Show("complete transaction?", "Confirm Sale", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    HandleTransaction();
                    Notificationlbl.Text = "Transaction Completed:)";
                    Notificationlbl.ForeColor = Color.RoyalBlue;
                }
                FetchAllServices();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// ADD PRODUCT TO SALE LIST
        /// </summary>
        private void AddProductToSaleList()
        {
            try
            {
                // var addedItem = SelectedProductsList.Items.Add(new ListViewItem(new string[] { ProductIDtxt.Text, AllProductsListcbx.Text, ProductQuantitytxt.Text, ProductUnitCosttxt.Text, TotalCosttxt.Text }));
                CurrentlyAddedListItem = saleTable.Rows.Count.ToString();
                AddItemtoSalePrintTable(ProductIDtxt.Text, AllProductsListcbx.Text, ProductQuantitytxt.Text, ProductUnitCosttxt.Text, TotalCosttxt.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "System Response", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        /// <summary>
        /// ADD SELECTED PRODUCT BTN CLICK EVENT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddSelectedProductbtn_Click(object sender, EventArgs e)
        {

            if (ProductQuantitytxt.Text.Length <= 0)
            {
                ProductQuantitytxt.Focus();
            }
            else
            {
                int qnt = int.Parse(ProductQuantitytxt.Text);
                if (qnt <= 0)
                {
                    ProductQuantitytxt.Focus();
                }
                else
                {
                    PrepareTransactionCost(TotalCosttxt.Text, "add");
                    AddProductToSaleList();
                    ProductQuantitytxt.Hint = "quantity";
                    ProductQuantitytxt.Text = "0";
                    RemoveSelectedProductbtn.Enabled = true;
                }
            }

            // FillAllProductList();
        }

        /// <summary>
        /// REMOVE SELECTED PRODUCT BTN CLICK EVENT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveSelectedProductbtn_Click(object sender, EventArgs e)
        {
            if (CurrentlyAddedListItem != null)
            {
                if (saleTable.Rows.Count > 0)
                {
                    foreach (DataRow dataRow in saleTable.Rows)
                    {
                        if (saleTable.Rows.Count == Int32.Parse(CurrentlyAddedListItem))
                        {
                            removeItemModel.ItemId = dataRow[1].ToString();
                            removeItemModel.ItemQuantity = dataRow[2].ToString();
                            PrepareTransactionCost(dataRow[4].ToString(), "remove");
                            // MessageBox.Show(removeItemModel.ItemQuantity, "test", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    saleTable.Rows.RemoveAt(Int32.Parse(CurrentlyAddedListItem));
                    if (Int32.Parse(CurrentlyAddedListItem) > 0)
                    {
                        CurrentlyAddedListItem = (Int32.Parse(CurrentlyAddedListItem) - 1).ToString();
                        RemoveSelectedProductbtn.Enabled = true;

                    }
                    else
                    {
                        CurrentlyAddedListItem = "0";
                        RemoveSelectedProductbtn.Enabled = false;

                    }
                    RemoveSelectedProductbtn.Enabled = true;
                }
                else
                {
                    RemoveSelectedProductbtn.Enabled = false;
                }
            }
        }

        /// <summary>
        /// PREPARE TRANSACTION COST
        /// </summary>
        /// <param name="salecost"></param>
        public void PrepareTransactionCost(string incomingcost, string type)
        {
            try
            {
                switch (type)
                {
                    case "add":
                        TotalTransactionCosttxt.Text = (Double.Parse(TotalTransactionCosttxt.Text) + Double.Parse(incomingcost)).ToString();
                        break;
                    case "remove":
                        TotalTransactionCosttxt.Text = (Double.Parse(TotalTransactionCosttxt.Text) - Double.Parse(incomingcost)).ToString();
                        break;
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "System Response", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// PRIVATE METHOD TO FILL ALL THE PRODUT INTO THE LIST
        /// </summary>
        private void FillAllProductList()
        {
            try
            {
                SortProductBy();
                AllProductsListcbx.DataSource = productController.GetAllProducts();
                TotalTransactionCosttxt.Text = "0.00";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Response", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// CLEAR ALL THE SELECTION IN THE SALED LIST
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetSelectedProductsbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to clear all selection", "System Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                saleTable.Rows.Clear();
                FillAllProductList();

            }
        }

        /// <summary>
        /// PRIVATE METHOD TO HANDLE TRANSACTION
        /// </summary>
        /// 
        private void HandleTransaction()
        {
            serviceModel = new ServicesModel();
            saleModel = new SalesModel();
            pmodel = new ProductModel();
            string serviceid = SaleServiceIDtxt.Text;
            string custname = "unspecified";
            string date = SalesServiceDataPicker.Value.ToShortDateString().ToString();
            if (saleTable.Rows.Count <= 0)
            {
                MessageBox.Show("Please add product to list", "Product List Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (CustomeNametxt.Text != "")
                {
                    custname = CustomeNametxt.Text;
                }
                //
                try
                {
                    foreach (DataRow dataRow in saleTable.Rows)
                    {
                        serviceController.SaveServiceRecord(utils.PrepareServiceModel(dataRow, date, serviceid));
                        serviceModel.ProductId = dataRow[0].ToString();
                        serviceModel.QuantitySold = dataRow[2].ToString();
                        pmodel = productController.GetProductQntyById(serviceModel.ProductId);
                        var npmodel = utils.FormatProductQuantity(pmodel.ProductQuantity, serviceModel.QuantitySold, "remove");
                        npmodel.ID = pmodel.ID;
                        productController.UpdateProductByProductId(npmodel);
                    }
                    saleModel = utils.PrepareSalesModel(SaleServiceIDtxt.Text, TotalTransactionCosttxt.Text, date, custname, StaticAccountModel.Username);
                    salesController.SaveSaleRecord(saleModel);
                    FillAllProductList();
                    saleTable.Rows.Clear();


                    ///TODO
                    /// message alert on if the user wants to print the receipt;
                    ///
         
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        /// <summary>
        /// HANDLE ENABLE CUSTOMER NAME
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomerNamechk_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomerNamechk.Checked == true)
            {
                CustomeNametxt.Enabled = true;
            }
            else
            {
                CustomeNametxt.Enabled = false;
            }
        }

        /// <summary>
        /// LOAD ALL SALES
        /// </summary>
        public void LoadSalesData()
        {
            SalesDataGrid.DataSource = salesController.LoadAllSales();
            var counter = utils.CalculateReturns(salesController.LoadAllSales(), "saleReport");
            TotalReturnslbl.Text = counter.TotalReturnsMade;
        }

        /// <summary>
        /// GET SALE BY DATE METHOD
        /// </summary>
        /// <param name="date"></param>
        public void GetSalesByDate(string date)
        {
            SalesDataGrid.DataSource = salesController.GetReportByDate(date);
            var counter = utils.CalculateReturns(salesController.GetReportByDate(date), "saleReport");
            TotalReturnslbl.Text = counter.TotalReturnsMade;
        }

        /// <summary>
        /// LOAD SERVICE REPORT MODEL DETAILS
        /// </summary>
        /// <param name="serviceId"></param>
        public void LoadSingleSaleReportDetails(string serviceId)
        {
            reportModel = reportController.ServiceDetails(serviceId);
            SaleServiceIDtxt.Text = reportModel.ServiceID;
            SalesPersonsNametxt.Text = reportModel.SalesPerson;
            SaleTransactionDatetxt.Text = reportModel.TransactionDate;
            SaleCustomerNametxt.Text = reportModel.CustomerName;
            SaleTransactiontxt.Text = reportModel.TransactionAmount;
        }


        /// <summary>
        /// SORT PRODUCT GROUP
        /// </summary>
        public void SortProductBy()
        {
            SortProductscbx.Items.Add("None");
            SortProductscbx.Items.Add("Name A-Z");
            SortProductscbx.Items.Add("Name Z-A");
            SortProductscbx.Items.Add("Category A-Z");
            SortProductscbx.Items.Add("Category Z-A");
            SortProductscbx.Items.Add("Quantity 0-9");
            SortProductscbx.Items.Add("Quantity 9-0");
            SortProductscbx.Items.Add("CostPrice 0-9");
            SortProductscbx.Items.Add("CostPrice 9-0");
            SortProductscbx.Items.Add("SellingPrice 9-0");
            SortProductscbx.Items.Add("SellingPrice 0-9");
            SortProductscbx.Items.Add("ProductID 0-9");
            SortProductscbx.Items.Add("ProductID 9-0");
            SortProductscbx.Items.Add("ID 9-0");
            SortProductscbx.Items.Add("ID 0-9");


        }

        /// <summary>
        /// LOAD SORTED PRODUCTS
        /// </summary>
        /// <param name="sortby"></param>
        /// <param name="group"></param>
        public void LoadSortedProduct(string sortby, string group)
        {
            switch (group)
            {
                case "name":
                    AllProductsListcbx.DataSource = productController.PrepareSortedProductList(productController.SortProdoctsByName(sortby));
                    break;
                case "quantity":
                    AllProductsListcbx.DataSource = productController.PrepareSortedProductList(productController.SortProdoctsByQuantity(sortby));

                    break;
                case "id":
                    AllProductsListcbx.DataSource = productController.PrepareSortedProductList(productController.SortProdoctsByID(sortby));

                    break;
                case "category":
                    AllProductsListcbx.DataSource = productController.PrepareSortedProductList(productController.SortProdoctsByCategory(sortby));

                    break;
                case "sellingPrice":
                    AllProductsListcbx.DataSource = productController.PrepareSortedProductList(productController.SortProdoctsBySellingPrice(sortby));

                    break;
                case "costPrice":
                    AllProductsListcbx.DataSource = productController.PrepareSortedProductList(productController.SortProdoctsByCostPrice(sortby));

                    break;
                case "productId":
                    AllProductsListcbx.DataSource = productController.PrepareSortedProductList(productController.SortProdoctsByProductID(sortby));

                    break;
                default:
                    break;
            }

        }

        /// <summary>
        /// SORT PRODUCT COMBO BOX TEXT CHANGE EVENT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortProductscbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SortProductscbx.Text == "None")
            {
                FillAllProductList();

            }
            else if (SortProductscbx.Text == "ProductID 9-0")
            {
                LoadSortedProduct("DESC", "productId");
            }
            else if (SortProductscbx.Text == "ProductID 0-9")
            {
                LoadSortedProduct("ASC", "productId");

            }
            else if (SortProductscbx.Text == "Name Z-A")
            {
                LoadSortedProduct("DESC", "name");

            }
            else if (SortProductscbx.Text == "Name A-Z")
            {
                LoadSortedProduct("ASC", "name");

            }
            else if (SortProductscbx.Text == "Category A-Z")
            {
                LoadSortedProduct("ASC", "category");

            }
            else if (SortProductscbx.Text == "Category Z-A")
            {
                LoadSortedProduct("DESC", "category");

            }
            else if (SortProductscbx.Text == "Quantity 0-9")
            {
                LoadSortedProduct("DESC", "quantity");

            }
            else if (SortProductscbx.Text == "Quantity 0-9")
            {
                LoadSortedProduct("ASC", "quantity");

            }
            else if (SortProductscbx.Text == "CostPrice 0-9")
            {
                LoadSortedProduct("ASC", "costPrice");

            }
            else if (SortProductscbx.Text == "CostPrice 9-0")
            {
                LoadSortedProduct("DESC", "costPrice");

            }
            else if (SortProductscbx.Text == "SellingPrice 9-0")
            {
                LoadSortedProduct("DESC", "sellingPrice");

            }
            else if (SortProductscbx.Text == "SellingPrice 0-9")
            {
                LoadSortedProduct("ASC", "sellingPrice");

            }
            else if (SortProductscbx.Text == "ID 0-9")
            {
                LoadSortedProduct("ASC", "id");

            }
            else if (SortProductscbx.Text == "ID 9-0")
            {
                LoadSortedProduct("DESC", "id");

            }
            else
            {
                FillAllProductList();

            }

        }

        /// <summary>
        /// PRIVATE METHOD GET SERVICES BY THE SERVICE ID
        /// </summary>
        /// <param name="serviceId"></param>
        private void GetServiceByServiceId(string serviceId)
        {
            AllServicesDataGrid.DataSource = serviceController.GetServicesByServiceId(serviceId);
            var counter = utils.CalculateReturns(serviceController.GetServicesByServiceId(serviceId), "serviceReport");
            ServiceReturnsMadelbl.Text = counter.TotalReturnsMade;
            ServiceProductsSoldlbl.Text = counter.TotalProductsSold;
        }

        /// <summary>
        /// GET SERVICES BY SERVICE DATE
        /// </summary>
        /// <param name="serviceDate"></param>
        private void GetServiceByServiceDate(string serviceDate)
        {
            AllServicesDataGrid.DataSource = serviceController.GetServicesByServiceDate(serviceDate);
            var counter = utils.CalculateReturns(serviceController.GetServicesByServiceDate(serviceDate), "serviceReport");
            ServiceReturnsMadelbl.Text = counter.TotalReturnsMade;
            ServiceProductsSoldlbl.Text = counter.TotalProductsSold;
        }

        /// <summary>
        /// GET THE SERVICE BY THE SERVICE ID BTN CLICK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetServicebtn_Click(object sender, EventArgs e)
        {
            if (FilterServicetxts.Text.Length <= 0)
            {
                FilterServicetxts.Focus();
                return;
            }
            else
            {
                GetServiceByServiceId(FilterServicetxts.Text);
            }
        }

        /// <summary>
        /// GET REPORT BY DATE BTN CLICK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetReportDatabyDatebtn_Click(object sender, EventArgs e)
        {

            GetSalesByDate(GetReportDatabyDatetxt.Value.ToShortDateString());
        }

        /// <summary>
        /// LOAD REPORT FOR PRINTING
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="listview"></param>
        /// <param name="type"></param>
        private void LoadReport(DataTable dt, ListView listview, string type)
        {
            listview.Items.Clear();
            listview.View = View.Details;
            try
            {
                switch (type)
                {
                    case "SalesServices":
                        if (dt.Rows.Count > 0)
                        {
                            foreach (DataRow dataRow in dt.Rows)
                            {
                                listview.Items.Add(new ListViewItem(new string[] { dataRow["productId"].ToString(), dataRow["productName"].ToString(), dataRow["serviceId"].ToString(), dataRow["serviceCost"].ToString(), dataRow["productUnitCost"].ToString(), dataRow["quantitySold"].ToString(), dataRow["serviceDate"].ToString() }));
                            }
                        }
                        break;
                    case "Report":
                        if (dt.Rows.Count > 0)
                        {
                            foreach (DataRow dataRow in dt.Rows)
                            {
                                listview.Items.Add(new ListViewItem(new string[] { dataRow["serviceId"].ToString(), dataRow["transactionAmount"].ToString(), dataRow["transactionDate"].ToString(), dataRow["customerName"].ToString(), dataRow["salesPerson"].ToString() }));
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "System Response", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        /// <summary>
        /// GET ALL REPORT BTN CLICK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetAllReportDatabtn_Click(object sender, EventArgs e)
        {
            LoadSalesData();
        }
        /// <summary>
        /// REFRESH REPORT BTN CLICK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshReportDatabtn_Click(object sender, EventArgs e)
        {
            LoadSalesData();

        }

        /// <summary>
        /// LOAD SALES DATA BY THE SERVICE ID
        /// </summary>
        /// <param name="serviceId"></param>
        private void LoadSalesByServiceId(string serviceId)
        {
            SalesDataGrid.DataSource = salesController.GetSalesByServiceId(serviceId);
            var counter = utils.CalculateReturns(salesController.GetSalesByServiceId(serviceId), "saleReport");
            TotalReturnslbl.Text = counter.TotalReturnsMade;
        }

        /// <summary>
        /// GENERATE REPORT DATA BY OTHERS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetReportDatabyOthersbtn_Click_1(object sender, EventArgs e)
        {
            if (GetServiceSaleByServiceIDtxt.Text.Length <= 0)
            {
                GetServiceSaleByServiceIDtxt.Focus();
                return;
            }
            else
            {
                LoadSalesByServiceId(GetServiceSaleByServiceIDtxt.Text);
                LoadSingleSaleReportDetails(GetServiceSaleByServiceIDtxt.Text);

            }
        }

        /// <summary>
        /// clear sales report 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        /// <summary>
        /// ALL LIST PRODUCT SELECTED TEXT CHANGED
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AllProductsListcbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            pmodel = new ProductModel();
            pmodel.ProductName = AllProductsListcbx.Text;
            LoadSelectedProductDetails(productController.GetSelectedProduct(AllProductsListcbx.Text));
            GenerateServiceId(serviceController.GenerateServiceId(serviceController.GetTotalServices()));
            Notificationlbl.Text = "";
        }

        /// <summary>
        /// FILTER SALE SERVICES BY THE SALE DATE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilterDatePicker_ValueChanged(object sender, EventArgs e)
        {
            GetServiceByServiceDate(FilterDatePicker.Value.ToShortDateString());
        }

        private void LoadAllServicesBtn_Click(object sender, EventArgs e)
        {
            FetchAllServices();
        }


        /// <summary>
        /// SELECT PRODUCT BY PRODUCT ID BTN CLICK EVENT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectProductbtn_Click(object sender, EventArgs e)
        {
            if (SelectProducttxt.Text.Length <= 0)
            {
                SelectProducttxt.Focus();
                return;
            }
            else
            {
                ProductsGrid.DataSource = productController.GetProductByProductId(SelectProducttxt.Text);
            }
        }


        /// <summary>
        /// UPDATE PRODUCT BTN CLICK -MAIN PAGE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateProductbtn_Click(object sender, EventArgs e)
        {
            if (SelectProducttxt.Text.Length <= 0)
            {
                SelectProducttxt.Focus();
                return;
            }
            else
            {
                if (productController.GetProductDetailsByProductId(SelectProducttxt.Text).Rows.Count <= 0)
                {
                    MessageBox.Show("Invalid Product ID", "Invalid Product Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    staticProductModel.SetStaticProductModel(utils.PrepareProductModel(productController.GetProductDetailsByProductId(SelectProducttxt.Text)));
                    UpdateProductForm updateProductform = new UpdateProductForm();
                    updateProductform.Show();
                }

            }

        }

        private void DashBoardbtn_Click(object sender, EventArgs e)
        {
            AdminDashBoardForm AdminPage = new AdminDashBoardForm();
            this.Hide();
            AdminPage.Show();
        }

        private void MyAccountbtn_Click(object sender, EventArgs e)
        {

            this.Hide();
            UserDashboard userDashboard = new UserDashboard();
            userDashboard.Show();
        }

        private void NewProductNametxt_TextChanged_1(object sender, EventArgs e)
        {
            NewProductIdtxt.Text = productController.PrepareProductId(productController.GetLastProductId()).ToString();
            pmodel.ProductID = NewProductIdtxt.Text;
            pmodel.type = "ProductName";
            pmodel.ProductName = NewProductNametxt.Text;
            HandleProductValidation(pmodel);
        }

        /// <summary>
        /// HANDLE THE RESOURCE EXPORT
        /// </summary>
        /// <param name="datatable"></param>
        /// <param name="type"></param>
        private void HandleResourceExport(DataTable datatable, string type)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add(datatable, type);
                            workbook.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("Resource exported successfully", "export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Export Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// EXPORT ALL THE SERVICES
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintServiceReportbtn_Click(object sender, EventArgs e)
        {
            DataTable datatable = new DataTable();
            datatable = (DataTable)AllServicesDataGrid.DataSource;
            HandleResourceExport(datatable, "Sales");
        }

        /// <summary>
        /// EXPORTING THE SALES DATA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportServicesDatabtn_Click(object sender, EventArgs e)
        {
            DataTable datatable = new DataTable();
            datatable = (DataTable)SalesDataGrid.DataSource;
            HandleResourceExport(datatable, "Sales Resource");
        }

        /// <summary>
        /// PRINT THE CONTENT OF THE SALE LIST VIEW
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintSaleFormbtn_Click(object sender, EventArgs e)
        {
            if (PrintSalesDataGrid.Rows.Count <= 0)
            {
                MessageBox.Show("Please Add Items", "SaleListEmpty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string resultsHeader = "Personnel:" + StaticAccountModel.Username + "   Date:" + SalesServiceDataPicker.Value.ToShortDateString() + "  ServiceCost:Ghs" + TotalTransactionCosttxt.Text.ToString();
                string resultsFooter = "Thank you for doing business with us:) Hoping to see you again:)";
                handleDocumentPrinting(PrintSalesDataGrid, resultsHeader, resultsFooter);
            }
        }

        /// <summary>
        /// PRIVATE METPHOD TO PREPARE THE SALE PRINT TABLE
        /// </summary>
        private void PrepareSalePrintTable()
        {
            saleTable.Columns.Add("ID", typeof(string));
            saleTable.Columns.Add("ProductName", typeof(string));
            saleTable.Columns.Add("Quantity", typeof(string));
            saleTable.Columns.Add("UnitCost", typeof(string));
            saleTable.Columns.Add("Total", typeof(string));
            PrintSalesDataGrid.DataSource = saleTable;
        }

        /// <summary>
        /// ADD ITEM TO THE PRINT TABLE
        /// </summary>
        /// <param name="item"></param>
        private void AddItemtoSalePrintTable(string pid,string pname,string pqnty,string punitcost,string ptotal)
        {
           // saleTable.Rows.Add(item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text, item.SubItems[4].Text);
            saleTable.Rows.Add(pid ,pname ,pqnty,punitcost, ptotal);

        }

        /// <summary>
        /// HANDLE THE PRINTING OF DOCUMENTS
        /// </summary>
        /// <param name="dataGrid"></param>
        private void handleDocumentPrinting(DataGridView dataGridView,string resultsheader,string resultsFooter)
        {
            try
            {
                DGVPrinter printer = new DGVPrinter();
                printer.Title = LocalResources.CustomerSettings.BusinessTitle.ToString();
                printer.SubTitle = string.Format(resultsheader, printer.SubTitleColor = Color.SteelBlue);
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = false;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.Footer = resultsFooter;
                printer.FooterSpacing = 10;
                printer.PrintPreviewDataGridView(dataGridView);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// print sales report
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintServicesbtn_Click(object sender, EventArgs e)
        {
            if (SalesDataGrid.Rows.Count <= 0)
            {
                MessageBox.Show("Please Load Data", "Empty Source", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string resultsHeader = "Report By:" + StaticAccountModel.Username + "   Date:" + SalesServiceDataPicker.Value.ToShortDateString();
                string resultsFooter = "Thank you:)";
                handleDocumentPrinting(SalesDataGrid, resultsHeader, resultsFooter);
            }
        }

        private void PrintSalesbtn_Click(object sender, EventArgs e)
        {
            if (AllServicesDataGrid.Rows.Count <= 0)
            {
                MessageBox.Show("Please Load Data", "Empty Source", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string resultsHeader = "Report By:" + StaticAccountModel.Username + "   Date:" + SalesServiceDataPicker.Value.ToShortDateString();
                string resultsFooter = "Thank you:)";
                handleDocumentPrinting(AllServicesDataGrid, resultsHeader, resultsFooter);
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            LoadSalesData();
        }

        /// <summary>
        /// show the about page;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Aboutbtn_Click(object sender, EventArgs e)
        {
            Views.SettingsScreen settingsScreen = new SettingsScreen();
            settingsScreen.Show();
            settingsScreen.BringToFront();
        }
    }
}
