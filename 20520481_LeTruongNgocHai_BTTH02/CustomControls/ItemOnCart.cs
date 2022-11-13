using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20520481_LeTruongNgocHai_BTTH02.CustomControls
{
    public partial class ItemOnCart : UserControl
    {
        public ItemOnCart()
        {
            InitializeComponent();
        }

        public ItemOnCart(string id, string pname, string psize, int pquantity, int pprice) : this()
        {
            Bitmap bm1 = (Bitmap)Resources.Resource1.ResourceManager.GetObject(id);

            pictureBox1.BackgroundImage = bm1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Name = id;
            name.Text = pname;
            size.Text = psize;
            quantity.Text = pquantity.ToString();
            price.Text = pprice.ToString();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DataRow[] dr = ShoppingList.ShoppingItems.Select(string.Format("ID ='{0}' ", pictureBox1.Name));
            for (int i = 0; i < dr.Length; i++)
                ShoppingList.ShoppingItems.Rows.Remove(dr[i]);
            ShoppingList.ShoppingItems.AcceptChanges();
        }
    }
}
