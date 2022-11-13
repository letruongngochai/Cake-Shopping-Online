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

namespace _20520481_LeTruongNgocHai_BTTH02.CustomControls
{
    public partial class ProductDetail : UserControl
    {
        DataTable dt = new DataTable();
        int int_price;
        string str_price;
        public ProductDetail()
        {
            InitializeComponent();
        }
        public ProductDetail(string id) : this()
        {
            Bitmap bm1 = (Bitmap)Resources.Resource1.ResourceManager.GetObject(id);

            pic_detail.BackgroundImage = bm1;
            pic_detail.BackgroundImageLayout = ImageLayout.Stretch;
            pic_detail.Name = id;

            string query = "select * from PRODUCT where PRODUCT_ID like '" + id + "%'";
            DataProvider provider = new DataProvider();
            
            dt = provider.ExecuteQuery(query);
            int_price = Int32.Parse(dt.Rows[0]["PRODUCT_PRICE"].ToString());
            str_price = (int_price / 1000 + ".000 VND").ToString();
            price.Text = str_price;
            name.Text = dt.Rows[0]["PRODUCT_NAME"].ToString();
            description.Text = dt.Rows[0]["PRODUCT_INFO"].ToString();
            label5.Name = int_price.ToString();
        }

        private void size_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdjustPrice(size.Text, (int)quantity.Value);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (quantity.Value < 1)
                quantity.Value = 1;
            AdjustPrice(size.Text, (int)quantity.Value);
        }

        private void AdjustPrice(string size, int num)
        {
            int new_price;
            if (size == "Large")
                new_price = Int32.Parse(dt.Rows[0]["PRODUCT_PRICE"].ToString()) + 100000;
            else
                new_price = Int32.Parse(dt.Rows[0]["PRODUCT_PRICE"].ToString());

            new_price = new_price * (int)quantity.Value;
            str_price = (new_price / 1000 + ".000 VND").ToString();
            price.Text = str_price;
            label5.Name = new_price.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            noti.Visible = true;
            HaiSweet.shopping.Rows.Add(pic_detail.Name, name.Text, size.SelectedItem.ToString(), Int32.Parse(quantity.Value.ToString()), Int32.Parse(label5.Name));
        }
    }
}
