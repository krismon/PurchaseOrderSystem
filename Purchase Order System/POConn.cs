using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace Purchase_Order_System
{
    public class POConn
    {
        public DataTable SelectQuery(string QueryString)
        {
            using (SQLiteConnection conn = new SQLiteConnection("data source= C:\\POData\\PurchaseOrders"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();
                    
                  

                    SQLiteHelper sh = new SQLiteHelper(cmd);
                    DataTable dt = sh.Select(QueryString + ";");
                    conn.Close();


                    return dt;
                }
            }
        }
        public int InsertQuery(string Table, Dictionary<string, object> Parameters)
        {
            using (SQLiteConnection conn = new SQLiteConnection("data source= C:\\POData\\PurchaseOrders"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);
                    sh.Insert(Table, Parameters);
                    int Id = Convert.ToInt32(sh.LastInsertRowId());
                    conn.Close();
                    return Id;
                }
            }

        }
        public void DeleteQuery(string Table, string Id)
        {
            using (SQLiteConnection conn = new SQLiteConnection("data source= C:\\POData\\PurchaseOrders"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);
                    sh.Execute("Delete from " + Table + " WHERE ID = '" + Id + "';");
                    conn.Close();

                }
            }
        }

        public void DeletePO(string Po_Number)
        {
            using (SQLiteConnection conn = new SQLiteConnection("data source= C:\\POData\\PurchaseOrders"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);
                    sh.Execute("Delete from Purchase_orders where po_number ='" + Po_Number + "'");
                    sh.Execute("Delete from order_items where po_number ='" + Po_Number + "'");
                    conn.Close();

                }
            }
        }
        public void ExecuteSQL(string ExecuteScript)
        {
            using (SQLiteConnection conn = new SQLiteConnection("data source=C:\\BalanseData\\Balanse"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);
                    sh.Execute(ExecuteScript + ";");
                    conn.Close();

                }
            }
        }
        public int InsertOrder(DateTime PODate, int PO, int qty, string unit, string item, double unit_price, double amount, DateTime rec_date, int poid)
        {
            Dictionary<string, object> InsertOrderParameters = new Dictionary<string, object>();
            InsertOrderParameters.Add("DATE", PODate);
            InsertOrderParameters.Add("PO_NUMBER", PO);
            InsertOrderParameters.Add("QTY", qty);
            InsertOrderParameters.Add("UNIT", unit);
            InsertOrderParameters.Add("ITEM", item);
            InsertOrderParameters.Add("UNIT_PRICE", unit_price);
            InsertOrderParameters.Add("AMOUNT", amount);
            InsertOrderParameters.Add("RECORD_DATE", rec_date);
            InsertOrderParameters.Add("PO_ID", poid);
            int orderId = InsertQuery("ORDER_ITEMS", InsertOrderParameters);
            return orderId;
        }

        public int InsertPO(DateTime PODate, int PO, string store, string company_name, string address, DateTime due_date, string terms, string del_address, string ordered_by, DateTime rec_date)
        {
            Dictionary<string, object> InsertPOParameters = new Dictionary<string, object>();
            InsertPOParameters.Add("DATE", PODate);
            InsertPOParameters.Add("PO_NUMBER", PO);
            InsertPOParameters.Add("STORE", store);
            InsertPOParameters.Add("COMPANY_NAME", company_name);
            InsertPOParameters.Add("ADDRESS", address);
            InsertPOParameters.Add("DUE_DATE", due_date);
            InsertPOParameters.Add("TERMS", terms);
            InsertPOParameters.Add("DEL_ADDRESS", del_address);
            InsertPOParameters.Add("ORDERED_BY", ordered_by);
            InsertPOParameters.Add("RECORD_DATE", rec_date);
            int POId = InsertQuery("PURCHASE_ORDERS", InsertPOParameters);
            return POId;
        }
        public DataTable RetrievePODetails(string PONumber)
        {

            DataTable result = SelectQuery("SELECT DATE, " +
                "PO_NUMBER, " +
                "STORE, " +
                "COMPANY_NAME, " +
                "ADDRESS, " +
                "DATE(DUE_DATE), " +
                "TERMS, " +
                "DEL_ADDRESS, " +
                "ORDERED_BY, "+ 
                "DATE(DATE) "+ 
                "FROM PURCHASE_ORDERS WHERE PO_NUMBER = '" + PONumber + "'");
            return result;
        }
        public DataTable RetrievePO_Order_Details(string PONumber)
        {

            DataTable result = SelectQuery("SELECT " +
                "QTY, " +
                "UNIT, " +
                "ITEM, " +
                "UNIT_PRICE, " +
                "AMOUNT " +
                "FROM ORDER_ITEMS WHERE PO_NUMBER = '" + PONumber + "'");
            return result;
        }
        public DataTable SearchPO(string Date, string PONumber, string CompanyName, string Store)
        {
            String WhereClause = "";

            if(Date.Length > 0)
            {
                if(WhereClause.Length > 0)
                {
                    WhereClause += " AND";
                }
                WhereClause += " DATE(DATE) = DATE( '" + Date + "')";
            }
            if (PONumber.Length > 0)
            {
                if (WhereClause.Length > 0)
                {
                    WhereClause += " AND";
                }
                WhereClause += " PO_NUMBER = '" + PONumber + "'";
            }
            if (CompanyName.Length > 0)
            {
                if (WhereClause.Length > 0)
                {
                    WhereClause += " AND";
                }
                WhereClause += " COMPANY_NAME = '" + CompanyName + "'";
            }
            if (Store.Length > 0)
            {
                if (WhereClause.Length > 0)
                {
                    WhereClause += " AND";
                }
                WhereClause += " STORE = '" + Store + "'";
            }
            if(WhereClause.Length > 0)
            {
                WhereClause = " Where" + WhereClause;
            }
            DataTable POList = SelectQuery("SELECT DATE, PO_NUMBER, COMPANY_NAME, STORE FROM PURCHASE_ORDERS" + WhereClause);
            return POList;
        }
    }
}
