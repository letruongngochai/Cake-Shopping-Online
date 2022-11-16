using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _20520481_LeTruongNgocHai_BTTH02.DAO;


namespace _20520481_LeTruongNgocHai_BTTH02
{
    public partial class UserInfomationInput : Form
    {
        public static string TenKH, SoKH, DiaChiKH, Payment_Method;
        public UserInfomationInput()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (PaymentMethod.SelectedItem)
            {
                case "Internet Banking":
                    ScanHere.Visible = true;
                    QR.BackgroundImage = (Image)Resources.Resource1.ResourceManager.GetObject("internetbanking");
                    break;
                case "MoMo":
                    ScanHere.Visible = true;
                    QR.BackgroundImage = (Image)Resources.Resource1.ResourceManager.GetObject("momo");
                    break;
                default:
                    QR.BackgroundImage = null;
                    ScanHere.Visible = false;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveData(ShoppingList.ShoppingItems);
            if (ReceiverName.Text == "" || ReceiverNumber.Text == "" || ReceiverAddress.Text == "")
                MessageBox.Show("Please fill all the empty fields in order to buy!", ":(");
            else
            {
                TenKH = ReceiverName.Text;
                DiaChiKH = ReceiverAddress.Text;
                SoKH = ReceiverNumber.Text;
                Payment_Method = PaymentMethod.Text;
                Bill bill = new Bill();
                bill.ShowDialog();
            }

        }
        private void SaveData(DataTable dt)
        {
            string connectionString = "Data Source=NGOCHAI;Initial Catalog=ShoppingOnline;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection))
                {
                    foreach (DataColumn c in dt.Columns)
                        bulkCopy.ColumnMappings.Add(c.ColumnName, c.ColumnName);

                    bulkCopy.DestinationTableName = "SHOPPINGPRODUCT";
                    bulkCopy.WriteToServer(dt);
                }
            }
        }

    }
}
