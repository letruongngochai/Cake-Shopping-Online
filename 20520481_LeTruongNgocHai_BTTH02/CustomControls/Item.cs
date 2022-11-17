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
    public partial class Item : UserControl
    {
        public Item()
        {
            InitializeComponent();
        }
        static int money;
        public Item(string id, string name, string price) : this()
        {
            Bitmap bm1 = (Bitmap)Resources.Resource1.ResourceManager.GetObject(id);

            pictureBox1.BackgroundImage = bm1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Name = id;

            label1.Text = name;
            money = Int32.Parse(price);
            label2.Text = Int32.Parse(price) / 1000 + ".000VND";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HaiSweet.history.Rows.Add(pictureBox1.Name, label1.Text, money);
        }
    }
}
