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

namespace GUI_QuanLyThuVien.Administration.QLThuThu
{
    public partial class GUI_ReportThuThu : Form
    {
        public GUI_ReportThuThu()
        {
            InitializeComponent();
        }
        BLL_QuanLyThuThu BLL_QuanLyThuThu = new BLL_QuanLyThuThu();
        private void GUI_ReportThuThu_Load(object sender, EventArgs e)
        {
            try
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = "GUI_QuanLyThuVien.Report4.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DataSet1"; // Tên DataSet trong RDLC
                reportDataSource.Value = BLL_QuanLyThuThu.ListThuThu(); // Dữ liệu của bạn ở đây
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
