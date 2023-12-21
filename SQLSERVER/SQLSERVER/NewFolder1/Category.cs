using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SQLSERVER
{
    class Category
    {
        public string ID { get; set; }
        public string CategoryName { get; set; }

        public Category()
        {

        }

        public Category(string iD, string categoryNAme)
        {
            ID = iD;
            CategoryName = categoryNAme;
        }

        public override string ToString()
        {
            return CategoryName;
        }

        public static List<Category> GetCategories(SqlDataReader r)
        {
            List<Category> categories = new List<Category>();
            while (r.Read())
            {
                string id = r[0].ToString();
                string categoryName = r[1].ToString();
                categories.Add(new Category(id, categoryName));
            }
            return categories;
        }
    }
}
