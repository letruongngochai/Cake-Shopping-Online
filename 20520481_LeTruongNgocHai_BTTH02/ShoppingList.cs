using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _20520481_LeTruongNgocHai_BTTH02.CustomControls;

namespace _20520481_LeTruongNgocHai_BTTH02
{
    public partial class ShoppingList : Form
    {
        static string[] Codes = new string[] {  "haisweet071102", "haisweet170103", "haisweet" };
        static string cur_total;
        public static DataTable ShoppingItems;
        static string origin_total;

        public ShoppingList()
        {
            InitializeComponent();
        }
        private int total()
        {
            int total = 0;
            for (int i = 0; i < ShoppingItems.Rows.Count; i++)
            {
                total += Int32.Parse(ShoppingItems.Rows[i]["Price"].ToString());
            }
            return total;
        }

        private bool IsContain(string str)
        {
            foreach (string s in Codes)
                if (str == s)
                    return true;
            return false;
        }

        private void DisplayNoti()
        {
            if (textBox1.Text == "")
            {
                sad.Visible = false;
                congrats.Visible = false;
            }
            else 
            {
                if (IsContain(textBox1.Text))
                {
                    congrats.Visible = true;
                    sad.Visible = false;
                    cur_total = Discount(Int32.Parse(TotalMoney.Text)).ToString();
                    TotalMoney.Text = TotalMoney.Text + " - " + (Int32.Parse(TotalMoney.Text) - Discount(Int32.Parse(TotalMoney.Text))) +" = " + cur_total;
                }
                else
                {
                    congrats.Visible = false;
                    sad.Visible = true;
                    textBox1.Clear();
                    TotalMoney.Text = origin_total;
                }
            }
            
        }

        private int Discount(int price)
        {
            return price * 85 / 100;
        }

        private void ShoppingList_Load(object sender, EventArgs e)
        {
            try
            {
                ShoppingItems = HaiSweet.shopping;
                flowLayoutPanel1.Controls.Clear();
                for (int i = 0; i < ShoppingItems.Rows.Count; i++)
                {
                    ItemOnCart it = new ItemOnCart(ShoppingItems.Rows[i]["ID"].ToString(), ShoppingItems.Rows[i]["Name"].ToString(), ShoppingItems.Rows[i]["Size"].ToString(), Int32.Parse(ShoppingItems.Rows[i]["Quantity"].ToString()), Int32.Parse(ShoppingItems.Rows[i]["Price"].ToString()));
                    

                    it.DeleteButton.Click += new EventHandler(DeleteButton_Click);
                    
                    flowLayoutPanel1.Controls.Add(it);
                }
                TotalMoney.Text = total().ToString();
                cur_total = total().ToString();
                origin_total = total().ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Looks like there is no orders yet @@ \nLet's have a look at our product ^^", ":(", MessageBoxButtons.OK);
            }
            DisplayNoti();
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            ShoppingItems = HaiSweet.shopping;
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < ShoppingItems.Rows.Count; i++)
            {
                ItemOnCart it = new ItemOnCart(ShoppingItems.Rows[i]["ID"].ToString(), ShoppingItems.Rows[i]["Name"].ToString(), ShoppingItems.Rows[i]["Size"].ToString(), Int32.Parse(ShoppingItems.Rows[i]["Quantity"].ToString()), Int32.Parse(ShoppingItems.Rows[i]["Price"].ToString()));
                it.DeleteButton.Click += new EventHandler(DeleteButton_Click);
                flowLayoutPanel1.Controls.Add(it);
            }
            TotalMoney.Text = total().ToString();
            cur_total = total().ToString();
            origin_total = total().ToString();
        }

        private void ShoppingList_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                DisplayNoti();
            }
        }
    }
}
