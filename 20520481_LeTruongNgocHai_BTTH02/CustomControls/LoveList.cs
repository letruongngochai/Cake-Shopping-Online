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
    public partial class LoveList : Form
    {
        public LoveList()
        {
            InitializeComponent();
        }

        private void LoveList_Load(object sender, EventArgs e)
        {
            Random rd = new Random();
            DataTable dt = HaiSweet.lovelist;
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string id = dt.Rows[i]["ID"].ToString();
                id = id.Replace(" ", "");

                string name = dt.Rows[i]["Name"].ToString();

                CustomControls.Item it = new CustomControls.Item(id, name, "0");
                it.BackColor = Color.FromArgb(rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255));
                it.label2.Visible = false;
                flowLayoutPanel1.Controls.Add(it);
            }
        }
    }
}
