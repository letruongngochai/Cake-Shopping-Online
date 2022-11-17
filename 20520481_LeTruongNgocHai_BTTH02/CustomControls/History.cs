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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = HaiSweet.history;
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                string id = dt.Rows[i]["ID"].ToString();
                id = id.Replace(" ", "");

                string name = dt.Rows[i]["Name"].ToString();
                int price = Convert.ToInt32(dt.Rows[i]["Price"]);

                CustomControls.Item it = new CustomControls.Item(id, name, price.ToString());

                flowLayoutPanel1.Controls.Add(it);
            }
        }
    }
}
