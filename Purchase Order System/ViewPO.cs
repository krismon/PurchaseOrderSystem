using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Purchase_Order_System
{
    public partial class ViewPO : Form
    {
        public ViewPO()
        {
            InitializeComponent();
        }
        public ViewPO(string PO_Number)
        {
            InitializeComponent();
            Cr_L_PO.Text = PO_Number;
            Retrieve_info();
        }
        public void Retrieve_info()
        {
            POConn conn = new POConn();
            DataTable result = conn.RetrievePODetails(Cr_L_PO.Text);

            if(result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                Cr_DD_PODate.Value = DateTime.Parse(row[0].ToString());
                Cr_TB_Terms.Text = row[6].ToString();
                Cr_DD_Store.Text = row[2].ToString();
                Cr_TB_Company.Text = row[3].ToString();
                Cr_TB_Address.Text = row[4].ToString();
                Cr_DD_DueDate.Value  = DateTime.Parse(row[5].ToString());
                Cr_TB_Delivery.Text = row[7].ToString();
                Cr_L_User.Text = row[8].ToString();

                DataTable order_result = conn.RetrievePO_Order_Details(Cr_L_PO.Text);
                foreach(DataRow rows in order_result.Rows)
                {
                    Cr_DGV_Order.Rows.Add(
                        rows[0].ToString(),
                        rows[1].ToString(),
                        rows[2].ToString(),
                        rows[3].ToString(),
                        rows[4].ToString());
                }
            }


            


        }

        private void Cr_B_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (dgv.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void Cr_B_Save_Click(object sender, EventArgs e)
        {
            if (!IsEmpty(Cr_TB_Company.Text))
            {
                if (!IsDGVEmpty(Cr_DGV_Order))
                {
                    POConn conn = new POConn();
                    conn.DeletePO(Cr_L_PO.Text);
                    CreatePO();
                    MessageBox.Show("PO #:" + Cr_L_PO.Text + " has been saved.");
                    this.Close();
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
            String address = IsEmpty(Cr_TB_Address.Text) ? "N/A" : Cr_TB_Address.Text.ToUpper();
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
                if (Qty_text.Text.Length < 1)
                {
                    Message += "Quantity";
                }
                if (Unit_text.Text.Length < 1)
                {
                    if (Message.Length > 0)
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
                if (Message.Length > 0)
                {
                    Message += " must not be empty.";
                }
                MessageBox.Show(Message);
            }
        }

        private void Delete_row_btn_Click(object sender, EventArgs e)
        {
            if (Cr_DGV_Order.SelectedRows.Count > 0)
            {
                Cr_DGV_Order.Rows.RemoveAt(Cr_DGV_Order.SelectedRows[0].Index);
            }
        }

        public void Delete_Add()
        {
            Qty_text.Text = "";
            Unit_text.Text = "";
            Desc_text.Text = "";
            Uprice_text.Text = "";
            Amount_text.Text = "";
        }
    }
}
