using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using POS.Model;
using System.Windows.Forms;
using POS.Utils;
namespace POS.Controller
{
    public class ProductController
    {
        ServerController serverController = new ServerController();
        Utils.Utils utils = new Utils.Utils();
         
        ///
        ///GET LAST ITEM ID FROM THE PRODUCT TABLE
        ///
        public string GetLastProductId()
        {
            try
            {
                string total;
                serverController.da = new SqlDataAdapter();
                serverController.dt = new DataTable();
                serverController.cmd = new SqlCommand("select * from nbs_products", serverController.connection);
                serverController.connection.Open();
                serverController.da.SelectCommand = serverController.cmd;
                serverController.da.Fill(serverController.dt);
                serverController.connection.Close();
                total = serverController.dt.Rows.Count.ToString();

                //
                return total;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        ///
        ///PREPARE THE NEXT PRODUCT ID
        ///
        public string PrepareProductId(string value)
        {
            string initial = utils.AppendProductID();
            string productId = string.Format(initial + (Int32.Parse(value) + 1));
            return productId;
        }

        ///
        ///ADD PRODUCT CATEGORY
        ///
        public void AddProductCategory(ProductModel model) {
            try
            {
                serverController.cmd = new SqlCommand("insert into nbs_product_category values(@cat)", serverController.connection);
                serverController.connection.Open();
                serverController.cmd.Parameters.Add("@cat", SqlDbType.VarChar).Value = model.ProductCategory;
                string state = serverController.cmd.ExecuteNonQuery().ToString();
                serverController.connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "AddCategory Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        /// <summary>
        /// SAVING THE PRODUCT TO THE DB
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public void AddProductToDataBase(ProductModel model)
        {
            try
            {
                serverController.cmd = new SqlCommand("insert into nbs_products values(@pname,@pqnty,@pcp,@psp,@pcat,@pid)", serverController.connection);
                serverController.cmd.Parameters.Add("@pname", SqlDbType.VarChar).Value = model.ProductName;
                serverController.cmd.Parameters.Add("@pqnty", SqlDbType.VarChar).Value = model.ProductQuantity;
                serverController.cmd.Parameters.Add("@pcp", SqlDbType.VarChar).Value = model.ProductCostPrice;
                serverController.cmd.Parameters.Add("@psp", SqlDbType.VarChar).Value = model.ProductSellingPrice;
                serverController.cmd.Parameters.Add("@pid", SqlDbType.VarChar).Value = model.ProductID;
                serverController.cmd.Parameters.Add("@pcat", SqlDbType.VarChar).Value = model.ProductCategory;
                serverController.connection.Open();
                serverController.cmd.ExecuteNonQuery();
                serverController.connection.Close();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Product Category Get Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// GET ALL THE PRODUCT CATEGORIES FROM THE DATABASE
        /// </summary>
        /// <returns></returns>
        public DataSet GetProductCategories()
        {
            serverController.da = new SqlDataAdapter();
            serverController.dt = new DataTable();
            serverController.ds = new DataSet();
            try
            {
                serverController.ds = new DataSet();
                serverController.cmd = new SqlCommand("select * from nbs_product_category", serverController.connection);
                serverController.connection.Open();
                serverController.da.SelectCommand = serverController.cmd;
                serverController.da.Fill(serverController.ds);
                serverController.connection.Close();
                return serverController.ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Product Category Get Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return serverController.ds;
        }

        /// <summary>
        /// LIST OF PRODUCT CATEGORIES
        /// </summary>
        /// <param name="ds"></param>
        /// <returns></returns>
        public List<string> ProductCategoryList(DataSet ds)
        {
            List<string> ProductCategories = new List<string>();
            ProductCategories.Clear();
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dataRow  in ds.Tables[0].Rows)
                {
                    ProductCategories.Add(dataRow["category"].ToString());
                }
                return ProductCategories;
            }
            else
            {
                return ProductCategories;

            }
        }

        /// <summary>
        /// FETCHING ALL PRODUCTS FROM THE DATABASE;
        /// </summary>
        /// <returns></returns>
        public List<string> GetAllProducts()
        {
            List<string> AllProductsList = new List<string>();
            AllProductsList.Clear();

            try
            {
                serverController.da = new SqlDataAdapter();
                serverController.dt = new DataTable();
                serverController.connection.Open();
                serverController.cmd = new SqlCommand("select * from nbs_products where not quantity=0", serverController.connection);
                serverController.da.SelectCommand = serverController.cmd;
                serverController.da.Fill(serverController.dt);
                serverController.connection.Close();
                if (serverController.dt.Rows.Count > 0)
                {
                    foreach (DataRow dataRow in serverController.dt.Rows)
                    {
                        AllProductsList.Add(dataRow["name"].ToString());
                    }
                }
                else
                {

                    return AllProductsList;
                }
                return AllProductsList;
            }
            catch (Exception ex)
            {
                serverController.connection.Close();
                MessageBox.Show(ex.Message, "Products Get Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return AllProductsList;
        }


        /// <summary>
        /// RETURN THE DETAILS OF THE SELECTED PRODUCT
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public DataTable GetSelectedProduct(string name)
        {
            serverController.dt = new DataTable();
            serverController.da = new SqlDataAdapter();
            try
            {
                serverController.cmd = new SqlCommand("select * from nbs_products where name=@name", serverController.connection);
                serverController.connection.Open();
                serverController.cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                serverController.da.SelectCommand = serverController.cmd;
                serverController.da.Fill(serverController.dt);
                serverController.connection.Close();
                return serverController.dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Selected Product Get Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return serverController.dt;
        }


        /// <summary>
        /// Fetch all products from the database;
        /// </summary>
        /// <returns></returns>
        public DataTable FetchAllProducts()
        {
            serverController.dt = new DataTable();
            try
            {
                serverController.da = new SqlDataAdapter();
                serverController.cmd = new SqlCommand("select name,quantity,costPrice,sellingPrice,productCategory,productId from nbs_products", serverController.connection);
                serverController.connection.Open();
                serverController.da.SelectCommand = serverController.cmd;
                serverController.da.Fill(serverController.dt);
                serverController.connection.Close();
                return serverController.dt;
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message, "Product Fetch Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return serverController.dt;
        }

        /// <summary>
        /// GET THE PRODUCT QUANTITY BY  THE PRODUCT ID
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public ProductModel GetProductQntyById(string productId)
        {
            ProductModel model = new ProductModel();
            try
            {
                serverController.da = new SqlDataAdapter();
                serverController.dt = new DataTable();
                serverController.cmd = new SqlCommand("select * from nbs_products where productId='"+productId+"'", serverController.connection);
                serverController.connection.Open();
                serverController.da.SelectCommand = serverController.cmd;
                serverController.da.Fill(serverController.dt);
                serverController.connection.Close();
                if (serverController.dt.Rows.Count > 0)
                {
                    foreach (DataRow dataRow in serverController.dt.Rows)
                    {
                        model.ProductQuantity = dataRow["quantity"].ToString();
                        model.ID = dataRow["id"].ToString();
                    }

                }
                return model;
            }
            catch (Exception ex)
            {
                serverController.connection.Close();
                MessageBox.Show(ex.Message, "Get Product By ID Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return model;
        }

        /// <summary>
        /// UPDATE THE PRODUCT QUANTIY BY THE PRODUCT ID;
        /// </summary>
        /// <param name="pid"></param>
        /// <param name="pqnty"></param>
        public void UpdateProductByProductId(ProductModel model)
        {
            try
            {
                serverController.cmd = new SqlCommand("update nbs_products set quantity=@qnty where id=@id", serverController.connection);
                serverController.connection.Open();
                serverController.cmd.Parameters.Add("@qnty", SqlDbType.VarChar).Value = model.ProductQuantity;
                serverController.cmd.Parameters.Add("@id", SqlDbType.Int).Value = model.ID;
                serverController.cmd.ExecuteNonQuery();
                serverController.connection.Close();
            }
            catch (Exception ex)
            {
                serverController.connection.Close();
                MessageBox.Show(ex.Message, "Product Quantity Update Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ///SORTING PRODUCT
        /// <summary>
        /// SORT BY PRODUCT NAME
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public DataTable SortProdoctsByName(string order)
        {
            serverController.da = new SqlDataAdapter();
            serverController.dt = new DataTable();
            try
            {
                switch (order)
                {
                    case "ASC":
                        serverController.da = new SqlDataAdapter();
                        serverController.dt = new DataTable();
                        serverController.connection.Open();
                        serverController.cmd = new SqlCommand("SELECT * FROM nbs_products where not quantity=0 ORDER BY name ASC", serverController.connection);
                        serverController.da.SelectCommand = serverController.cmd;
                        serverController.da.Fill(serverController.dt);
                        serverController.connection.Close();
                        return serverController.dt;
                    case "DESC":
                        serverController.da = new SqlDataAdapter();
                        serverController.dt = new DataTable();
                        serverController.connection.Open();
                        serverController.cmd = new SqlCommand("select * from nbs_products where not quantity=0 order by name desc", serverController.connection);
                        serverController.da.SelectCommand = serverController.cmd;
                        serverController.da.Fill(serverController.dt);
                        serverController.connection.Close();
                        return serverController.dt;
                    default:
                       return serverController.dt;
                }
            }
            catch (Exception ex)
            {
                serverController.connection.Close();
                MessageBox.Show(ex.Message, "Sort Product Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return serverController.dt;
        }

        /// <summary>
        /// SORT BY QUANTITY
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public DataTable SortProdoctsByQuantity(string order)
        {
            serverController.da = new SqlDataAdapter();
            serverController.dt = new DataTable();
            try
            {
                switch (order)
                {
                    case "ASC":
                        serverController.da = new SqlDataAdapter();
                        serverController.dt = new DataTable();
                        serverController.connection.Open();
                        serverController.cmd = new SqlCommand("select * from nbs_products where not quantity=0 order by quantity asc", serverController.connection);
                        serverController.da.SelectCommand = serverController.cmd;
                        serverController.da.Fill(serverController.dt);
                        serverController.connection.Close();
                        return serverController.dt;
                    case "DESC":
                        serverController.da = new SqlDataAdapter();
                        serverController.dt = new DataTable();
                        serverController.connection.Open();
                        serverController.cmd = new SqlCommand("select * from nbs_products where not quantity=0 order by quantity desc", serverController.connection);
                        serverController.da.SelectCommand = serverController.cmd;
                        serverController.da.Fill(serverController.dt);
                        serverController.connection.Close();
                        return serverController.dt;
                    default:
                        return serverController.dt;
                }
            }
            catch (Exception ex)
            {
                serverController.connection.Close();
                MessageBox.Show(ex.Message, "Sort Product Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return serverController.dt;
        }

        /// <summary>
        /// SORT BY COST PRICE
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public DataTable SortProdoctsByCostPrice(string order)
        {
            serverController.da = new SqlDataAdapter();
            serverController.dt = new DataTable();
            try
            {
                switch (order)
                {
                    case "ASC":
                        serverController.da = new SqlDataAdapter();
                        serverController.dt = new DataTable();
                        serverController.connection.Open();
                        serverController.cmd = new SqlCommand("select * from nbs_products where not quantity=0 order by costPrice asc", serverController.connection);
                        serverController.da.SelectCommand = serverController.cmd;
                        serverController.da.Fill(serverController.dt);
                        serverController.connection.Close();
                        return serverController.dt;
                    case "DESC":
                        serverController.da = new SqlDataAdapter();
                        serverController.dt = new DataTable();
                        serverController.connection.Open();
                        serverController.cmd = new SqlCommand("select * from nbs_products where not quantity=0 order by costPrice desc", serverController.connection);
                        serverController.da.SelectCommand = serverController.cmd;
                        serverController.da.Fill(serverController.dt);
                        serverController.connection.Close();
                        return serverController.dt;
                    default:
                        return serverController.dt;
                }
            }
            catch (Exception ex)
            {
                serverController.connection.Close();
                MessageBox.Show(ex.Message, "Sort Product Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return serverController.dt;
        }

        /// <summary>
        /// SORT BY SELLING PRICE
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public DataTable SortProdoctsBySellingPrice(string order)
        {
            serverController.da = new SqlDataAdapter();
            serverController.dt = new DataTable();
            try
            {
                switch (order)
                {
                    case "ASC":
                        serverController.da = new SqlDataAdapter();
                        serverController.dt = new DataTable();
                        serverController.connection.Open();
                        serverController.cmd = new SqlCommand("select * from nbs_products where not quantity=0 order by sellingPrice asc", serverController.connection);
                        serverController.da.SelectCommand = serverController.cmd;
                        serverController.da.Fill(serverController.dt);
                        serverController.connection.Close();
                        return serverController.dt;
                    case "DESC":
                        serverController.da = new SqlDataAdapter();
                        serverController.dt = new DataTable();
                        serverController.connection.Open();
                        serverController.cmd = new SqlCommand("select * from nbs_products where not quantity=0 order by sellingPrice desc", serverController.connection);
                        serverController.da.SelectCommand = serverController.cmd;
                        serverController.da.Fill(serverController.dt);
                        serverController.connection.Close();
                        return serverController.dt;
                    default:
                        return serverController.dt;
                }
            }
            catch (Exception ex)
            {
                serverController.connection.Close();
                MessageBox.Show(ex.Message, "Sort Product Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return serverController.dt;
        }

        /// <summary>
        /// SORT BY ID
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public DataTable SortProdoctsByID(string order)
        {
            serverController.da = new SqlDataAdapter();
            serverController.dt = new DataTable();
            try
            {
                switch (order)
                {
                    case "ASC":
                        serverController.da = new SqlDataAdapter();
                        serverController.dt = new DataTable();
                        serverController.connection.Open();
                        serverController.cmd = new SqlCommand("select * from nbs_products where not quantity=0 order by id asc", serverController.connection);
                        serverController.da.SelectCommand = serverController.cmd;
                        serverController.da.Fill(serverController.dt);
                        serverController.connection.Close();
                        return serverController.dt;
                    case "DESC":
                        serverController.da = new SqlDataAdapter();
                        serverController.dt = new DataTable();
                        serverController.connection.Open();
                        serverController.cmd = new SqlCommand("select * from nbs_products where not quantity=0 order by id desc", serverController.connection);
                        serverController.da.SelectCommand = serverController.cmd;
                        serverController.da.Fill(serverController.dt);
                        serverController.connection.Close();
                        return serverController.dt;
                    default:
                        return serverController.dt;
                }
            }
            catch (Exception ex)
            {
                serverController.connection.Close();
                MessageBox.Show(ex.Message, "Sort Product Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return serverController.dt;
        }

        /// <summary>
        /// SORT BY PRODUCT CATEGORY
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public DataTable SortProdoctsByCategory(string order)
        {
            serverController.da = new SqlDataAdapter();
            serverController.dt = new DataTable();
            try
            {
                switch (order)
                {
                    case "ASC":
                        serverController.da = new SqlDataAdapter();
                        serverController.dt = new DataTable();
                        serverController.connection.Open();
                        serverController.cmd = new SqlCommand("select * from nbs_products where not quantity=0 order by productCategory asc", serverController.connection);
                        serverController.da.SelectCommand = serverController.cmd;
                        serverController.da.Fill(serverController.dt);
                        serverController.connection.Close();
                        return serverController.dt;
                    case "DESC":
                        serverController.da = new SqlDataAdapter();
                        serverController.dt = new DataTable();
                        serverController.connection.Open();
                        serverController.cmd = new SqlCommand("select * from nbs_products where not quantity=0 order by productCategory desc", serverController.connection);
                        serverController.da.SelectCommand = serverController.cmd;
                        serverController.da.Fill(serverController.dt);
                        serverController.connection.Close();
                        return serverController.dt;
                    default:
                        return serverController.dt;
                }
            }
            catch (Exception ex)
            {
                serverController.connection.Close();
                MessageBox.Show(ex.Message, "Sort Product Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return serverController.dt;
        }

        /// <summary>
        /// SORT BY PRODUCT ID
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public DataTable SortProdoctsByProductID(string order)
        {
            serverController.da = new SqlDataAdapter();
            serverController.dt = new DataTable();
            try
            {
                switch (order)
                {
                    case "ASC":
                        serverController.da = new SqlDataAdapter();
                        serverController.dt = new DataTable();
                        serverController.connection.Open();
                        serverController.cmd = new SqlCommand("select * from nbs_products where not quantity=0 order by productId asc", serverController.connection);
                        serverController.da.SelectCommand = serverController.cmd;
                        serverController.da.Fill(serverController.dt);
                        serverController.connection.Close();
                        return serverController.dt;
                    case "DESC":
                        serverController.da = new SqlDataAdapter();
                        serverController.dt = new DataTable();
                        serverController.connection.Open();
                        serverController.cmd = new SqlCommand("select * from nbs_products where not quantity=0 order by productId desc", serverController.connection);
                        serverController.da.SelectCommand = serverController.cmd;
                        serverController.da.Fill(serverController.dt);
                        serverController.connection.Close();
                        return serverController.dt;
                    default:
                        return serverController.dt;
                }
            }
            catch (Exception ex)
            {
                serverController.connection.Close();
                MessageBox.Show(ex.Message, "Sort Product Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return serverController.dt;
        }


        /// <summary>
        /// PREPARE THE SORTED PRODUCT LIST 
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public List<string> PrepareSortedProductList(DataTable dt)
        {
            List<string> AllProductsList = new List<string>();
            AllProductsList.Clear();
            try
            {
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        AllProductsList.Add(dataRow["name"].ToString());
                    }
                }
                else
                {

                    return AllProductsList;
                }
                return AllProductsList;
            }
            catch (Exception ex)
            {
                serverController.connection.Close();
                MessageBox.Show(ex.Message, "Prepare Sorted Product List Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return AllProductsList;
        }


        /// <summary>
        /// GET PRODUCT BY THE PRODUT ID
        /// </summary>
        /// <param name="ProductId"></param>
        /// <returns></returns>
        public DataTable GetProductByProductId(string ProductId)
        {
            serverController.da = new SqlDataAdapter();
            serverController.dt = new DataTable();
            try
            {
                serverController.cmd = new SqlCommand("select name,quantity,costPrice,sellingPrice,productCategory,productId from nbs_products where productId=@pid", serverController.connection);
                serverController.cmd.Parameters.Add("@pid", SqlDbType.VarChar).Value = ProductId;
                serverController.connection.Open();
                serverController.da.SelectCommand = serverController.cmd;
                serverController.da.Fill(serverController.dt);
                serverController.connection.Close();
                return serverController.dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "GetProductByProductID Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return serverController.dt;
        }

        /// <summary>
        /// GET ALL THE PRODUCT DETAILS BY THE PRODUCT 
        /// </summary>
        /// <param name="ProductId"></param>
        /// <returns></returns>
        public DataTable GetProductDetailsByProductId(string ProductId)
        {
            serverController.da = new SqlDataAdapter();
            serverController.dt = new DataTable();
            try
            {
                serverController.cmd = new SqlCommand("select * from nbs_products where productId=@pid", serverController.connection);
                serverController.cmd.Parameters.Add("@pid", SqlDbType.VarChar).Value = ProductId;
                serverController.connection.Open();
                serverController.da.SelectCommand = serverController.cmd;
                serverController.da.Fill(serverController.dt);
                serverController.connection.Close();
                return serverController.dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "GetProductByProductID Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return serverController.dt;
        }



        /// <summary>
        /// DELETE PRODUCT BY PRODUCT  ID
        /// </summary>
        /// <param name="productId"></param>
        public void DeleteProductByProductId(string productId)
        {
            try
            {
                serverController.cmd = new SqlCommand("delete from nbs_products where productId=@pid", serverController.connection);
                serverController.cmd.Parameters.Add("@pid", SqlDbType.VarChar).Value = productId;
                serverController.connection.Open();
                serverController.cmd.ExecuteNonQuery();
                serverController.connection.Close();
               // MessageBox.Show("Product Deleted Successfully", "Delete Product Server", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                serverController.connection.Close();
                MessageBox.Show(ex.Message, "Delete Product Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// UPDATE ALL THE PRODUT ENTRIES
        /// </summary>
        /// <param name="model"></param>
        public void UpdateProductEntriesByProductDbId(ProductModel model)
        {
            try
            {
                serverController.cmd = new SqlCommand("update nbs_products set name=@name,costPrice=@cp,sellingPrice=@sp,productCategory=@cat,quantity=@qnty where id=@id", serverController.connection);
                serverController.connection.Open();
                serverController.cmd.Parameters.Add("@qnty", SqlDbType.VarChar).Value = model.ProductQuantity;
                serverController.cmd.Parameters.Add("@id", SqlDbType.Int).Value = Double.Parse(model.ID);
                serverController.cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = model.ProductName;
                serverController.cmd.Parameters.Add("@cp", SqlDbType.VarChar).Value = model.ProductCostPrice;
                serverController.cmd.Parameters.Add("@sp", SqlDbType.VarChar).Value = model.ProductSellingPrice;
                serverController.cmd.Parameters.Add("@cat", SqlDbType.VarChar).Value = model.ProductCategory;
                serverController.cmd.ExecuteNonQuery();
                serverController.connection.Close();
               // MessageBox.Show("Product Updated Successfully", "Update Product Server", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                serverController.connection.Close();
                MessageBox.Show(ex.Message, "Product Entries Update Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// CHECKING TO SEE IF THE QUANTITY ON DEMAND FOR SALE IS MORE THAN THE STOCKED QUANTITY OF THE PRODUCT
        /// </summary>
        /// <param name="productid"></param>
        /// <param name="quatity"></param>
        /// <returns></returns>
        public bool CheckProductQuantitySelected(string productid,string quatity)
        {
            try
            {
                string StockedQuantity="";
                serverController.dt = new DataTable();
                serverController.da = new SqlDataAdapter();
                serverController.cmd = new SqlCommand("select * from nbs_products where productId=@pid", serverController.connection);
                serverController.connection.Open();
                serverController.cmd.Parameters.Add("@pid", SqlDbType.VarChar).Value = productid;
                serverController.da.SelectCommand = serverController.cmd;
                serverController.da.Fill(serverController.dt);
                serverController.connection.Close();
                if (serverController.dt.Rows.Count > 0)
                {
                    foreach (DataRow row in serverController.dt.Rows)
                    {
                        StockedQuantity = row["quantity"].ToString();
                    }
                }
                if (Int32.Parse(quatity) > Int32.Parse(StockedQuantity))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Product Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
