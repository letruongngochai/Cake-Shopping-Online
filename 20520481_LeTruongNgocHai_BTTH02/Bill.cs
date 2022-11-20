using Microsoft.Reporting.WinForms;
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
    public partial class Bill : Form
    {
        
        public Bill()
        {
            InitializeComponent();

        }

        private void Bill_Load(object sender, EventArgs e)
        {
            LoadReport();
            if (ShoppingList.isDiscount == true)
            {
                label1.Visible = true;
                label1.Text += ShoppingList.CurCode;
            }
            TenKH.Text += UserInfomationInput.TenKH;
            SoKH.Text += UserInfomationInput.SoKH;
            DiaChiKH.Text += UserInfomationInput.DiaChiKH;
            PayMethod.Text += UserInfomationInput.Payment_Method;
            this.reportViewer1.RefreshReport();
        }

        private void LoadReport()
        {

            string query = "SELECT * FROM SHOPPINGPRODUCT";
            DataProvider dp = new DataProvider();
            DataTable dt = dp.ExecuteQuery(query);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);

            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "ProductReport.rdlc";
            if (ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "SHOPPINGPRODUCT";
                rds.Value = ds.Tables[0];
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                //reportViewer1.RefreshReport();
            }

            TenKH.Text += UserInfomationInput.TenKH;
            SoKH.Text += UserInfomationInput.SoKH;
            DiaChiKH.Text += UserInfomationInput.DiaChiKH;
            PayMethod.Text += UserInfomationInput.Payment_Method;

            ReportParameter para1 = new ReportParameter();
            para1.Name = "Name"; //Đặt đúng tên khi đặt trong report
            para1.Values.Add(UserInfomationInput.TenKH);

            ReportParameter para2 = new ReportParameter();
            para2.Name = "Address";
            para2.Values.Add(UserInfomationInput.DiaChiKH);
            ReportParameter para3 = new ReportParameter();
            para3.Name = "Number";
            para3.Values.Add(UserInfomationInput.SoKH);
            ReportParameter para4 = new ReportParameter();
            para4.Name = "Method";
            para4.Values.Add(UserInfomationInput.Payment_Method);

            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { para1, para2, para3, para4});
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
