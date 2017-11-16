using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangSach
{
    public partial class BaoCaoTheoNgay : Form
    {
        public BaoCaoTheoNgay()
        {
            InitializeComponent();
        }

        private void BaoCaoTheoNgay_Load(object sender, EventArgs e)
        {
            this.rpvTheoNgay.RefreshReport();
        }

        private void btIn_Click(object sender, EventArgs e)
        {

            this.DataTable1TableAdapter.Fill(this.QLBanSach.DataTable1, dtpTheoNgay.Text);

            this.rpvTheoNgay.RefreshReport();
        }
    }
}
