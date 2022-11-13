using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _20520481_LeTruongNgocHai_BTTH02.DAO;
using _20520481_LeTruongNgocHai_BTTH02.CustomControls;

namespace _20520481_LeTruongNgocHai_BTTH02
{
    public partial class HaiSweet : Form
    {
        public static ShoppingList sl;
        static DataTable dt;
        public string category = "";
        public static DataTable shopping;
        public HaiSweet()
        {
            sl = new ShoppingList();
            InitializeComponent();
            Loading();
        }
        private void Loading()
        {
            string query = "select * from PRODUCT where PRODUCT_ID like '" + category + "%'";

            DataProvider provider = new DataProvider();
            dt = new DataTable();
            dt = provider.ExecuteQuery(query);
        }

        

        bool cake_clicked = false;
        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            cake_clicked = !cake_clicked;
            panel1.Visible = cake_clicked;
            
        }

        bool drink_clicked = false;
        private void label2_Click(object sender, EventArgs e)
        {
            drink_clicked = !drink_clicked;
            panel2.Visible = drink_clicked;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            sl.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void X_click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = true;
            detail.Visible = false;
            detail.Controls.Clear();
        }

        private void Cart_Click(object sender, EventArgs e)
        {
            //shopping.Rows.Add(CurId, NameProduct, SizeProduct, Quantity, Price);
        }

        //static string CurId, NameProduct, SizeProduct;
        //static int Quantity, Price;

        private void OnClickDetailProduct(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            ProductDetail pd = new ProductDetail(p.Name);
            pd.button2.Click += new EventHandler(X_click);
            pd.button2.Click += new EventHandler(Cart_Click);
            detail.Controls.Add(pd);

            //CurId = p.Name;
            //NameProduct = pd.name.Text;
            //SizeProduct = pd.size.Text;
            //Quantity = Int32.Parse(pd.quantity.Value.ToString());
            //Price = Int32.Parse(pd.label5.Name);

            flowLayoutPanel1.Visible = false;
            detail.Visible = true;
        }
        private void ShowItem()
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string id = dt.Rows[i]["PRODUCT_ID"].ToString();
                id = id.Replace(" ", "");

                string name = dt.Rows[i]["PRODUCT_NAME"].ToString();
                int price = Convert.ToInt32(dt.Rows[i]["PRODUCT_PRICE"]);

                CustomControls.Item it = new CustomControls.Item(id, name, price.ToString());
                it.pictureBox1.Click += new EventHandler(OnClickDetailProduct);
                flowLayoutPanel1.Controls.Add(it);
            }
        }
        private void HaiSweet_Load(object sender, EventArgs e)
        {
            shopping = new DataTable();
            shopping.Columns.Add("ID", typeof(string));
            shopping.Columns.Add("Name", typeof(string));
            shopping.Columns.Add("Size", typeof(string));
            shopping.Columns.Add("Quantity", typeof(int));
            shopping.Columns.Add("Price", typeof(int));

            ShowItem();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            category = "combo";
            Loading();
            ShowItem();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            category = "bakedgoods";
            Loading();
            ShowItem();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            category = "tiramisu";
            Loading();
            ShowItem();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            category = "chiffon";
            Loading();
            ShowItem();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            category = "others";
            Loading();
            ShowItem();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            category = "milktea";
            Loading();
            ShowItem();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            category = "coffee";
            Loading();
            ShowItem();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            category = "juice";
            Loading();
            ShowItem();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (category != "")
            {
                category = "";
                Loading();
                ShowItem();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (category != "")
            {
                category = "";
                Loading();
                ShowItem();
            }
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (category != "")
            {
                category = "";
                Loading();
                ShowItem();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DataTable temp = SearchProduct(richTextBox1.Text);
            ShowProductSearch(temp);
        }

        private DataTable SearchProduct(string txt_search)
        {
            category = "abc";
            string query = "select * from PRODUCT where PRODUCT_NAME like '%" + txt_search + "%'";
            DataProvider provider = new DataProvider();
            DataTable temp = new DataTable();
            temp = provider.ExecuteQuery(query);
            return temp;
        }
        private void ShowProductSearch(DataTable dt_search)
        {
            if (dt_search.Rows.Count == 0)
                MessageBox.Show("Element not found!!!", "Notification", MessageBoxButtons.OK);
            else
            {
                flowLayoutPanel1.Controls.Clear();
                for (int i = 0; i < dt_search.Rows.Count; i++)
                {

                    string id = dt_search.Rows[i]["PRODUCT_ID"].ToString();
                    id = id.Replace(" ", "");

                    string name = dt_search.Rows[i]["PRODUCT_NAME"].ToString();
                    int price = Convert.ToInt32(dt_search.Rows[i]["PRODUCT_PRICE"]);

                    CustomControls.Item it = new CustomControls.Item(id, name, price.ToString());

                    flowLayoutPanel1.Controls.Add(it);
                }
            }
        }

        private void richTextBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable temp = SearchProduct(richTextBox1.Text);
                ShowProductSearch(temp);
                richTextBox1.Text = "";
            }
        }
        static DataTable dt_filter;
        private DataTable FilterType(string txt_cb)
        {
            string query = "select * from PRODUCT where PRODUCT_TYPE like '" + txt_cb + "'";
            DataProvider provider = new DataProvider();
            dt_filter = new DataTable();
            dt_filter = provider.ExecuteQuery(query);
            return dt_filter;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            dt_filter = FilterType(comboBox1.Text);
            ShowProductSearch(dt_filter);
        }
    }

}
