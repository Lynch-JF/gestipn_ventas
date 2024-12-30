using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_ventas.Report
{
    public partial class ReportFactura : Form
    {

        private string query;
        private string datasetName;
        private string reportPath;
        public ReportFactura( string SQL)
        {
            query = SQL;
            InitializeComponent();

        }

        public ReportFactura()
        {
        }

        private void ReportFactura_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();

            datasetName = "DataSetFactura";
            reportPath = "Gestion_de_ventas.Report.Report_factury.rdlc";

            DataSet ds = ConexionII.ExecuteQuery(query);
            LoadReport(ds);

        }  
        private void LoadReport(DataSet ds)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = reportPath;
            ReportDataSource rds = new ReportDataSource(datasetName, ds.Tables[0]);
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {


        }
    }
}
