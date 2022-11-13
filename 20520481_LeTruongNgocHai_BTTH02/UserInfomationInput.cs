using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20520481_LeTruongNgocHai_BTTH02
{
    public partial class UserInfomationInput : Form
    {
        public UserInfomationInput()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (PaymentMethod.SelectedItem)
            {
                case "Internet Banking":
                    QR.BackgroundImage = (Image)Resources.Resource1.ResourceManager.GetObject("internetbanking");
                    break;
                case "MoMo":
                    QR.BackgroundImage = (Image)Resources.Resource1.ResourceManager.GetObject("momo");
                    break;
                default:
                    QR.BackgroundImage = null;
                    break;
            }

                
        }
    }
}
