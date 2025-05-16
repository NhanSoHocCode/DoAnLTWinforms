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

namespace GUI_QuanLyThuVien.Administration.QLDocGia
{
    public partial class GUI_ReportDocGia : Form
    {
        public GUI_ReportDocGia()
        {
            InitializeComponent();
        }
        BLL_QuanLyDocGia BLL_QuanLyDocGia = new BLL_QuanLyDocGia();
        private void GUI_ReportDocGia_Load(object sender, EventArgs e)
        {
            try
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = "GUI_QuanLyThuVien.Report3.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DataSet1"; // Tên DataSet trong RDLC
                reportDataSource.Value = BLL_QuanLyDocGia.ViewDocGia(); // Dữ liệu của bạn ở đây
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
