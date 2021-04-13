using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Model;

namespace POS.Services
{
    public class ProductServices
    {
        ProductModel model = new ProductModel();

        public string ValidateProductModel(ProductServices model)
        {
            string error = "";
            return error;
        }

        ///
        ///VALIDATE THE PRODUCT CATEGORY
        ///
        public string ValidateProductCategory(ProductModel model)
        {
            string error = null;
            if (model.ProductCategory.Length < 0)
            {
                error = "product category required";
                return error;
            }
            else
            {
                return error;
            }
        }


        ///
        ///VALIDATE ALL OF THE PRODUCT MODEL
        ///
        public string ValidateProductModel(ProductModel model)
        {
            string error = null;
            int validQuantity = 0;
            double validamount = 0;
            switch (model.type)
            {
                case "ProductName":
                    if (model.ProductName==null)
                    {
                        error = "product name required";
                        model.Error = true;
                        return error;
                    }
                    else if (model.ProductName.Length <= 0)
                    {
                        error = "product name required";
                        model.Error = true;
                        return error;
                    }
                    else
                    {
                        model.Error = false;
                        return error;
                    }
                case "ProductQuantity":
                    if(int.TryParse(model.ProductQuantity,out validQuantity))
                    {
                        model.Error = false;
                        return error;
                    }
                    else if (model.ProductQuantity.Length <= 0)
                    {
                        error = "invalid product quantity";
                        model.Error = true;
                        return error;
                    }
                    else
                    {
                        error = "invalid product quantity";
                        model.Error = true;
                        return error;
                    }
                case "ProductCostPrice":
                    if (model.ProductCostPrice==null)
                    {
                        error = "product cost price required";
                        model.Error = true;
                        return error;
                    }
                    else if (model.ProductCostPrice.Length <= 0)
                    {
                        error = "product cost price required";
                        model.Error = true;
                        return error;
                    }
                    else if(double.TryParse(model.ProductCostPrice,out validamount)){
                        model.Error = false;
                        return error;
                    }
                    else
                    {
                        error = "invalid product selling price";
                        model.Error = true;
                        return error;
                    }
                case "ProductSellingPrice":
                    if (model.ProductSellingPrice==null)
                    {
                        error = "product selling price required";
                        model.Error = true;
                        return error;
                    }
                    else if (model.ProductSellingPrice.Length <= 0)
                    {
                        error = "product cost selling required";
                        model.Error = true;
                        return error;
                    }
                    else if (double.TryParse(model.ProductSellingPrice, out validamount)){
                        model.Error = false;
                        return error;
                    }
                    else
                    {
                        error = "invalid product selling price";
                        model.Error = true;
                        return error;
                    }
                case "ProductCategory":
                    if (model.ProductCategory==null)
                    {
                        error = "product category required";
                        model.Error = true;
                        return error;
                    }else if (model.ProductCategory.Length <= 0)
                    {
                        error = "product category required";
                        model.Error = true;
                        return error;
                    }
                    else
                    {
                        model.Error = false;
                        return error;
                    }
                case "ProductCategorytxt":
                    if (model.ProductCategory == null)
                    {
                        error = "product category required";
                        model.Error = true;
                        return error;
                    }else if (model.ProductCategory.Length <= 0)
                    {
                        error = "product category required";
                        model.Error = true;
                        return error;
                    }
                    else
                    {
                        model.Error = false;
                        return error;
                    }
                default:
                    model.Error = false;
                    return error;

            }
        }

        /// <summary>
        /// CHECK IF THE PRODUCT MODE IS VALID FOR SAVING
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Boolean IsModelValid(ProductModel model)
        {
            if (!model.Error && model.ProductName !="" && model.ProductQuantity!="" && model.ProductCostPrice!="" && model.ProductSellingPrice!="" && model.ProductCategory=="" )
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
