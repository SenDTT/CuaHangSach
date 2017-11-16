using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace CuaHangSach
{
    public partial class ChiTietHDB : Form
    {
        SqlConnection cn = null;
        double tongTien;
        int tichluy;
        public ChiTietHDB()
        {
            InitializeComponent();
        }

        private void ChiTietHDB_Load(object sender, EventArgs e)
        {
            string cnStr = ConfigurationManager.ConnectionStrings["Cua_Hang_Sach"].ConnectionString;
            cn = new SqlConnection(cnStr);
            loadItemFromDB();
            btLuuHD.Enabled = false;
            btXoaHD.Enabled = false;
            btThemHD.Enabled = true;
        }

        public void Connect()
        {
            try
            {
                if (cn != null && cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ConfigurationErrorsException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void DisConnect()
        {
            if (cn != null && cn.State != ConnectionState.Closed)
            {
                cn.Close();
            }
        }

        private void loadItemFromDB()
        {
            Connect();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT MaSach FROM Sach", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cbMaSach.Items.Add(dr["MaSach"].ToString());
            }
            DisConnect();
            cbMaSach.SelectedIndexChanged += new EventHandler(cbMaSach_SelectedIndexChanged);
        }

        private void cbMaSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connect();
            SqlCommand cmd = new SqlCommand("SELECT Chi_Tiet_HDB.*, Sach.TenSach FROM Chi_Tiet_HDB,Sach WHERE Sach.MaSach = Chi_Tiet_HDB.MaSach AND Sach.MaSach = '" + cbMaSach.Text + "'", cn);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string DonGiaBan = (string)dr["DonGiaBan"].ToString();
                txtDonBan.Text = DonGiaBan;

                string TenSach = (string)dr["TenSach"].ToString();
                txtTenSach.Text = TenSach;
            }
            cmd.Dispose();
            DisConnect();
        }

        private double TongTien()
        {
            tongTien = 0;
            for (int i = 0; i < dgvMatHang.Rows.Count - 1; i++)
            {
                tongTien += double.Parse(dgvMatHang.Rows[i].Cells["ThanhTien"].Value.ToString());
            }
            return tongTien;
        }

        private void btThemHD_Click(object sender, EventArgs e)
        {
            if (txtDonBan.Text != "" && txtSoLuong.Text != "" && txtThue.Text != "")
            {
                double a = double.Parse(txtDonBan.Text);
                double b = double.Parse(txtSoLuong.Text);
                double c = a * b;
                txtThanhTien.Text = c.ToString();
                dgvMatHang.Rows.Add(cbMaSach.Text, txtTenSach.Text, int.Parse(txtSoLuong.Text), float.Parse(txtDonBan.Text), int.Parse(txtThue.Text), double.Parse(txtThanhTien.Text));
                txtTongTien.Text = TongTien().ToString();
            }
            else
            {
                if (txtDonBan.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đơn giá");
                }
                else if (txtSoLuong.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập số lượng");
                }
                else if (txtThue.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập thuế");
                }
            }
            btLuuHD.Enabled = true;
            btXoaHD.Enabled = true;
            btThemHD.Enabled = true;
            txtMaHD.Enabled = true;
            txtMaKH.Enabled = true;
            txtMaNV.Enabled = true;
            dtpNgayBan.Enabled = true;
        }

        private void btLuuHD_Click(object sender, EventArgs e)
        {
            Connect();
            if(KtKhachHang() == false)
            {
                MessageBox.Show("Khách hàng không tồn tại.\nVui lòng nhập lại mã KH!");
                txtMaKH.Clear();
            }
            else if(KtMaHDB() == true)
            {
                MessageBox.Show("Hóa đơn đã tồn tại.\nVui lòng nhập lại mã hóa đơn khác!");
                txtMaHD.Clear();
            }
            else if(KtNhanVien() == false)
            {
                MessageBox.Show("Nhân viên không tồn tại.\nVui lòng nhập lại mã nhân viên!");
                txtMaNV.Clear();
            }
            else if (double.Parse(txtSoLuong.Text) <= 0)
            {
                MessageBox.Show("Số lượng không được nhỏ hơn 0!");
                txtSoLuong.Clear();
            }
            else if (dtpNgayBan.Value.Year > DateTime.Today.Year)
            {
                MessageBox.Show("Nhập lại ngày bán!");
            }
            else if ((dtpNgayBan.Value.Year == DateTime.Today.Year) && (DateTime.Today.Month < dtpNgayBan.Value.Month))
            {
                MessageBox.Show("Nhập lại ngày bán!");
            }
            else if ((dtpNgayBan.Value.Year == DateTime.Today.Year) && (DateTime.Today.Month == dtpNgayBan.Value.Month) && (dtpNgayBan.Value.Day > DateTime.Today.Day))
            {
                MessageBox.Show("Nhập lại ngày bán!");
            }
            else if (txtMaNV.Text != "" && txtMaKH.Text != "" && txtMaHD.Text != "")
            {
                try
                {
                    SqlCommand cmd1 = new SqlCommand("INSERT INTO Hoa_Don_Ban(MaHDB,NgayBan,MaKH,MaNV,ThueVAT) VALUES(@MaHDB, @NgayBan,@MaKH,@MaNV,@Thue)", cn);
                    cmd1.Parameters.AddWithValue("@MaHDB", txtMaHD.Text);
                    cmd1.Parameters.AddWithValue("@NgayBan", dtpNgayBan.Text);
                    cmd1.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
                    cmd1.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                    cmd1.Parameters.AddWithValue("@Thue", txtThue.Text);
                    cmd1.ExecuteNonQuery();
                    cmd1.Parameters.Clear();

                    SqlCommand cmd2 = new SqlCommand("INSERT INTO Chi_Tiet_HDB(MaHDB,MaSach,DonGiaBan,SoLuong) VALUES(@MaHDB,@MaSach,@DonGiaBan,@SoLuong)", cn);
                    cmd2.Parameters.AddWithValue("@MaHDB", txtMaHD.Text);
                    cmd2.Parameters.AddWithValue("@MaSach", cbMaSach.Text);
                    cmd2.Parameters.AddWithValue("@DonGiaBan", txtDonBan.Text);
                    cmd2.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text);
                    cmd2.ExecuteNonQuery();
                    cmd2.Parameters.Clear();
                    MessageBox.Show("Thêm thành công");

                    btLuuHD.Enabled = true;
                    btXoaHD.Enabled = true;
                    btThemHD.Enabled = true;
                    txtMaHD.Enabled = false;
                    txtMaKH.Enabled = false;
                    txtMaNV.Enabled = false;
                    dtpNgayBan.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                if (txtMaHD.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã hóa đơn!");
                }
                else if (txtMaKH.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã khách hàng!");
                }
                else if (txtMaNV.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã nhân viên!");
                }

            }
        }

        private void btXoaHD_Click(object sender, EventArgs e)
        {
            Connect();
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {

                try
                {
                    foreach (DataGridViewRow row in dgvMatHang.SelectedRows)
                    {
                        dgvMatHang.Rows.Remove(row);
                    }
                    MessageBox.Show("Xóa thành công!");
                    btLuuHD.Enabled = true;
                    btXoaHD.Enabled = true;
                    btThemHD.Enabled = true;
                    txtMaHD.Enabled = true;
                    txtMaKH.Enabled = true;
                    txtMaNV.Enabled = true;
                    dtpNgayBan.Enabled = true;
                }
                catch (Exception)
                {

                    MessageBox.Show("Không xóa thành công!");
                }
            }
        }

        private bool KtKhachHang()
        {

            bool kt = false;
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Khach_Hang WHERE MaKH='" + txtMaKH.Text + "'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                kt = true;
            }
            return kt;
        }

        private bool KtMaHDB()
        {

            bool kt = false;
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Hoa_Don_Ban WHERE MaHDB='" + txtMaHD.Text + "'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                kt = true;
            }
            return kt;
        }

        private bool KtNhanVien()
        {

            bool kt = false;
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Nhan_Vien WHERE MaNV='" + txtMaNV.Text + "'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                kt = true;
            }
            return kt;
        }
    }
}
