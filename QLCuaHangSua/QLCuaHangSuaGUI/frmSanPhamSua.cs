using QLCuaHangSuaBUS;
using QLCuaHangSuaDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangSuaGUI
{
    public partial class frmSanPhamSua : Form
    {
        List<LoaiSuaDTO> lsLoaiSua;
        List<SanPhamSuaDTO> lsSua;
        SanPhamSuaBUS spBUS = new SanPhamSuaBUS();
        SanPhamSuaDTO suachon = null;
        string strHA = "Dulieu/Spham/";
        public frmSanPhamSua()
        {
            InitializeComponent();
        }

        private void frmSanPhamSua_Load(object sender, EventArgs e)
        {
            dgvSua.AutoGenerateColumns = false;
            LoadDanhSachLoaiSua();
            LoadSanPhamSua();
            button1_Click(sender, e);
        }

        private void LoadSanPhamSua()
        {
            lsSua = spBUS.DanhSachSua();
            dgvSua.DataSource = lsSua;
        }

        private void LoadDanhSachLoaiSua()
        {

            LoaiSuaBUS loaiBUS = new LoaiSuaBUS();
            lsLoaiSua = loaiBUS.DanhSachLoaiSua();
            cboLoaiSua.DataSource = lsLoaiSua;
            cboLoaiSua.ValueMember = "MaLoai";
            cboLoaiSua.DisplayMember = "TenLoai";


            DataGridViewComboBoxColumn cboDGVLoai = (DataGridViewComboBoxColumn)dgvSua.Columns["colLoai"];
            cboDGVLoai.DataSource = lsLoaiSua;
            cboDGVLoai.ValueMember = "MaLoai";
            cboDGVLoai.DisplayMember = "TenLoai";
            //colLoai.DataSource = lsLoaiSua;
        }

        private void dgvSua_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvSua.Columns[e.ColumnIndex].Name == "ColHinhAnh")
            {
                if (File.Exists(e.Value.ToString()))
                {
                    byte[] byteHA = File.ReadAllBytes(e.Value.ToString());
                    MemoryStream ms = new MemoryStream(byteHA);
                    e.Value = Image.FromStream(ms);
                }
                else
                {
                    e.Value = null;
                }
            }
        }

        private void dgvSua_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSua.SelectedRows.Count > 0)
            {
                suachon = (SanPhamSuaDTO)dgvSua.SelectedRows[0].DataBoundItem; // currenrow
            }
            else
            {
                suachon = null;
            }
            BinDingChiTiet();
        }

        private void BinDingChiTiet()
        {

            if (suachon != null)
            {
                txtMaSua.Text = suachon.MaSua;
                txtTenSua.Text = suachon.TenSua;
                txtGia.Text = suachon.GiaBan.ToString("#,##0 VNĐ");
                txtNSX.Text = suachon.NhaSanXuat.ToString();
                cboLoaiSua.SelectedValue = suachon.MaLoai;
                rtbMoTa.Text = suachon.MoTa.ToString();

                if (File.Exists(suachon.HinhAnh))
                {
                    byte[] byteHA = File.ReadAllBytes(suachon.HinhAnh.ToString());
                    MemoryStream ms = new MemoryStream(byteHA);
                    pboHAnh.Image = Image.FromStream(ms);
                }
                else
                {
                    pboHAnh.Image = null;
                }

            }
            else
            {
                txtMaSua.Text = "";
                txtTenSua.Text = "";
                txtGia.Text = "";
                txtNSX.Text = "";
                cboLoaiSua.SelectedIndex = -1;
                rtbMoTa.Text = "";
                pboHAnh.Image = null;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string matieptheo = spBUS.MaSuaTiepTheo();
            txtMaSua.Text = matieptheo;

            txtTenSua.Text = "";
            txtGia.Text = "";
            txtNSX.Text = "";
            cboLoaiSua.SelectedIndex = -1;
            rtbMoTa.Text = "";
            pboHAnh.Image = null;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            getdatchitiet();
            suachon.HinhAnh = strHA + suachon.MaSua + ".PNG";

            bool kq = spBUS.ThemSua(suachon);
            if (kq)
            {
                if (pboHAnh.Image != null)
                {
                    pboHAnh.Image.Save(suachon.HinhAnh);
                }
                MessageBox.Show("Them thanh cong", txtMaSua.Text);
                LoadSanPhamSua();
            }
            else
            {
                MessageBox.Show("Them khong thanh cong");
                suachon = null;
            }
        }

        private void getdatchitiet()
        {
            string matieptheo = spBUS.MaSuaTiepTheo();
            suachon.MaSua = matieptheo;
            suachon.TenSua = txtTenSua.Text;
            suachon.GiaBan = int.Parse(txtGia.Text.ToString());
            suachon.NhaSanXuat = txtNSX.Text;
            suachon.MaLoai = cboLoaiSua.SelectedIndex;

            suachon.MoTa = rtbMoTa.Text;

        }

        private void pboHAnh_Click(object sender, EventArgs e)
        {
           
           
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Hình Ảnh | *.png";
            DialogResult dr = open.ShowDialog();
            if(dr != DialogResult.Cancel)
            {
                byte[] hA = File.ReadAllBytes(open.FileName);
                MemoryStream ms = new MemoryStream(hA);
                pboHAnh.Image = Image.FromStream(ms);
            }

        }
    }
}
