using System.Data;

namespace StoreDatabase
{
    public class StoreDbDataSet
    {
        internal static DataSet ReadDataSet()
        {
            DataSet ds = new DataSet();
            ds.ReadXml("store.xml");
            return ds;
        }
    }
}
