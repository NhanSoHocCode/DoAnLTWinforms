using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_QuanLyThuVien;
using Microsoft.Reporting.WinForms;

namespace GUI_QuanLyThuVien
{
    public partial class GUI_Report : Form
    {
        public GUI_Report()
        {
            InitializeComponent();
        }
        BLL_QuanLyPhieuMuon BLL_QuanLyPhieuMuon = new BLL_QuanLyPhieuMuon();
        private void GUI_Report_Load(object sender, EventArgs e)
        {

            try {
                reportViewer1.LocalReport.ReportEmbeddedResource = "GUI_QuanLyThuVien.Report1.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DataSet1"; // Tên DataSet trong RDLC
                reportDataSource.Value = BLL_QuanLyPhieuMuon.ListPMchuatra(); // Dữ liệu của bạn ở đây
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
