using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Purchase_Order_System
{
    public partial class POSystem : Form
    {
        public POSystem(string name)
        {
            InitializeComponent();

            
            Cr_L_User.Text = name;
            DateTime today = DateTime.Today;
            int PO_Number = 0;
            POConn conn = new POConn();
            DataTable PO= conn.SelectQuery("SELECT MAX(PO_NUMBER) FROM PURCHASE_ORDERS");
            //MessageBox.Show(PO.Rows.Count.ToString());
            foreach(DataRow row in PO.Rows)
            {
                
                if (row[0]!=DBNull.Value)
                {
                    PO_Number = Convert.ToInt32(row[0].ToString())+1;
                   
                }
                else
                {
                    PO_Number = 1;
                }
               
            }
            Cr_L_PO.Text = PO_Number.ToString();
        }
        public Boolean IsEmpty(string item)
        {
            if (item.Length <= 0)
            {
                return true;
            }

            else return false;
        }

        public Boolean IsDGVEmpty(DataGridView dgv)
        {
            if (dgv.Rows.Count>0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
   

        private void ViewPO_Click(object sender, EventArgs e)
        {

        }

        private void Cr_B_Save_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Cr_DGV_Order.Rows.Count.ToString());
            if (!IsEmpty(Cr_TB_Company.Text))
            {
                if (!IsDGVEmpty(Cr_DGV_Order))
                {
                    POConn conn = new POConn();
                    CreatePO();
                    MessageBox.Show("PO #:" + Cr_L_PO.Text + " has been saved.");
                    Cr_L_PO.Text = (Convert.ToInt32(Cr_L_PO.Text) + 1).ToString();
                    Cr_DGV_Order.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("Item list cannot be empty.");
                }
            }
            else
            {
                MessageBox.Show("Company name cannot be empty.");
            }

        }
        public int CreatePO()
        {
            int PO = Convert.ToInt32(Cr_L_PO.Text);
            String store = Cr_DD_Store.Text.ToUpper();
            String company_name = Cr_TB_Company.Text.ToUpper();
            String address = IsEmpty(Cr_TB_Address.Text) ? "N/A": Cr_TB_Address.Text.ToUpper();
            DateTime PODate = Cr_DD_PODate.Value.Date;
            DateTime DueDate = Cr_DD_DueDate.Value.Date;
            String del_address = IsEmpty(Cr_TB_Delivery.Text) ? "N/A" : Cr_TB_Delivery.Text.ToUpper();
            String terms = IsEmpty(Cr_TB_Terms.Text) ? "N/A" : Cr_TB_Terms.Text.ToUpper();


            POConn conn = new POConn();
            int POId = conn.InsertPO(PODate, PO, store, company_name, address, DueDate, terms, del_address, Cr_L_User.Text, DateTime.Now);
            string outputrowid = "";
            foreach (DataGridViewRow row in Cr_DGV_Order.Rows)
            {
                outputrowid += conn.InsertOrder(
                    PODate,
                    PO,
                    Convert.ToInt32(row.Cells[0].Value.ToString()),
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString(),
                    Convert.ToDouble(row.Cells[3].Value.ToString()),
                    Convert.ToDouble(row.Cells[4].Value.ToString()),
                    DateTime.Now,
                    POId);
            }
            return POId;     
        }

        public void Delete_Add()
        {
            Qty_text.Text = "";
            Unit_text.Text = "";
            Desc_text.Text = "";
            Uprice_text.Text = "";
            Amount_text.Text = "";
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (Qty_text.Text.Length > 0 &&
                Unit_text.Text.Length > 0 &&
                Desc_text.Text.Length > 0 &&
                Uprice_text.Text.Length > 0 &&
                Amount_text.Text.Length > 0)
            {
                Cr_DGV_Order.Rows.Add(Qty_text.Text, Unit_text.Text, Desc_text.Text, Uprice_text.Text, Amount_text.Text);
                Delete_Add();
            }
            else
            {
                string Message = "";
                if(Qty_text.Text.Length < 1)
                {
                    Message += "Quantity";
                }
                if (Unit_text.Text.Length < 1)
                {
                    if(Message.Length > 0)
                    {
                        Message += ", ";
                    }
                    Message += "Unit";
                }
                if (Desc_text.Text.Length < 1)
                {
                    if (Message.Length > 0)
                    {
                        Message += ", ";
                    }
                    Message += "Description";
                }
                if (Uprice_text.Text.Length < 1)
                {
                    if (Message.Length > 0)
                    {
                        Message += ", ";
                    }
                    Message += "Unit Price";
                }
                if (Amount_text.Text.Length < 1)
                {
                    if (Message.Length > 0)
                    {
                        Message += ", ";
                    }
                    Message += "Amount";
                }
                if(Message.Length > 0)
                {
                    Message += " must not be empty.";
                }
                MessageBox.Show(Message);
            }

            
        }

        private void Delete_row_btn_Click(object sender, EventArgs e)
        {
            if(Cr_DGV_Order.SelectedRows.Count > 0)
            {
                Cr_DGV_Order.Rows.RemoveAt(Cr_DGV_Order.SelectedRows[0].Index);
            }
        }

        private void V_B_Search_Click(object sender, EventArgs e)
        {
            V_DGV_Results.Rows.Clear();
           POConn conn = new POConn();
            DataTable PO_List = conn.SearchPO(V_DD_PODate.Value.Date.ToString("yyyy-MM-dd"),V_V_PO.Text,V_DD_Company.Text,V_DD_Store.Text);

            foreach (DataRow item in PO_List.Rows)
            {
                V_DGV_Results.Rows.Add(item[0].ToString(), item[1].ToString(), item[2].ToString(), item[3].ToString());
            }
            
        }

        private void V_DGV_Results_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(e.ColumnIndex + "-" + e.RowIndex);
            if(e.ColumnIndex == 4) // view
            {

                ViewPO viewpo = new ViewPO(V_DGV_Results.Rows[e.RowIndex].Cells[1].Value.ToString());
                viewpo.Show();
                this.Hide();
                viewpo.FormClosing += viewpo_Closing;
            }
            else if(e.ColumnIndex == 5) // delete
            {

            }
        }
        private void viewpo_Closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void Cr_B_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
