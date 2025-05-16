using BLL_QuanLyThuVien;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QuanLyThuVien.Administration.QLSach
{
    public partial class GUI_ReportSLSach : Form
    {
        public GUI_ReportSLSach()
        {
            InitializeComponent();
        }
        BLL_QuanLySach bll_QuanLySach = new BLL_QuanLySach();   
        private void GUI_ReportSLSach_Load(object sender, EventArgs e)
        {
            try
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = "GUI_QuanLyThuVien.Report2.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DataSet1"; // Tên DataSet trong RDLC
                reportDataSource.Value = bll_QuanLySach.DanhSachSachReportSL(); // Dữ liệu của bạn ở đây
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
