using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using CarsCollection;

namespace StoreDatabase
{
    public class StoreDB
    {
        public ICollection<Product> GetProducts()
        {
            DataSet ds = StoreDbDataSet.ReadDataSet();

            ObservableCollection<Product> products = new ObservableCollection<Product>();

            foreach (DataRow productRow in ds.Tables["Products"].Rows)
            {
                products.Add(new Product(modelName: (string)productRow["ModelName"],
                    year: (string)productRow["Year"], engineCapacity:
                    (string)productRow["EngineCapacity"], description: (string)productRow["Description"]));
            }
            return products;
        }
    }
}
