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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
