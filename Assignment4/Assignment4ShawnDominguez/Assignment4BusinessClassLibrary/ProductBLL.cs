using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Assignment4DatabaseClassLibrary;

namespace Assignment4BusinessClassLibrary
{
    public class ProductBLL
    {
        public List<Product> GetProductNameAndCode()
        {
            ProductDAL prodDAL = new ProductDAL();
            DataTable dtProducts = new DataTable();
            List<Product> lstProducts = new List<Product>();

            dtProducts = prodDAL.RetrieveProductNameAndCode();
            foreach (DataRow dr in dtProducts.Rows)
            {
                Product aProduct = new Product();
                aProduct.Name = dr["Name"].ToString();
                aProduct.ProductCode = dr["ProductCode"].ToString();
                lstProducts.Add(aProduct);
            }

            return lstProducts;
        }

        public ProductBLL()
        {

        }
    }
}
