﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace CuaHangSach
{
    public partial class HoaDonBan : Form
    {
        SqlConnection cn = null;
        private DataTable dt;
        private DataSet ds;
        private SqlDataAdapter da;
        public HoaDonBan()
        {
            InitializeComponent();
        }
        
        private void HoaDonBan_Load(object sender, EventArgs e)
        {
            string cnStr = ConfigurationManager.ConnectionStrings["Cua_Hang_Sach"].ConnectionString;
            cn = new SqlConnection(cnStr);
            LoadDataGirdView();
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

        public void LoadDataGirdView()
        {
            string sql = "SELECT Hoa_Don_ban.* FROM Hoa_Don_ban";
            ds = GetDataSet(sql);
            dt = ds.Tables[0];
            dgvHoaDon.DataSource = dt;
        }

        private DataSet GetDataSet(string sql)
        {
            da = new SqlDataAdapter(sql, cn);
            ds = new DataSet();
            int numberOfRows = da.Fill(ds);

            if (numberOfRows <= 0)
                ds = null;
            return ds;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            ChiTietHDB cthdb = new ChiTietHDB();
            cthdb.ShowDialog();
            LoadDataGirdView();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            Connect();
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                try
                {

                    SqlDataAdapter da = new SqlDataAdapter();
                    string del = "DELETE FROM [Chi_Tiet_HDB] WHERE Chi_Tiet_HDB.MaHDB=" + dgvHoaDon.CurrentRow.Cells[0].Value.ToString();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandText = del;
                    cmd.ExecuteNonQuery();
                    string del1 = "DELETE FROM [Hoa_Don_Ban] WHERE Hoa_Don_Ban.MaHDB=" + dgvHoaDon.CurrentRow.Cells[0].Value.ToString();
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.Connection = cn;
                    cmd1.CommandText = del1;
                    cmd1.ExecuteNonQuery();
                    foreach (DataGridViewRow row in dgvHoaDon.SelectedRows)
                    {
                        dgvHoaDon.Rows.Remove(row);
                    }
                    MessageBox.Show("Xóa thành công");
                    LoadDataGirdView();
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            Connect();
            try
            {
                string sql = "SELECT * FROM Hoa_Don_Ban WHERE MaHDB like '%" + txtTuKhoa.Text + "%' ";
                ds = GetDataSet(sql);
                dt = ds.Tables[0];
                dgvHoaDon.DataSource = dt;
                MessageBox.Show("Tìm thấy hóa đơn");
            }
            catch (Exception)
            {

                MessageBox.Show("Không tìm thấy hóa đơn");
            }
        }
    }
}
