using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitapb4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.IsEdit = false; 

            if (f.ShowDialog() == DialogResult.OK)
            {
                dgvNhanVien.Rows.Add(f.MSNV, f.TenNV, f.Luong);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null) return;

            Form2 f = new Form2();
            f.IsEdit = true;

            // Truyền dữ liệu sang Form phụ
            f.MSNV = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            f.TenNV = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
            f.Luong = dgvNhanVien.CurrentRow.Cells[2].Value.ToString();

            if (f.ShowDialog() == DialogResult.OK)
            {
                dgvNhanVien.CurrentRow.Cells[0].Value = f.MSNV;
                dgvNhanVien.CurrentRow.Cells[1].Value = f.TenNV;
                dgvNhanVien.CurrentRow.Cells[2].Value = f.Luong;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow != null)
            {
                dgvNhanVien.Rows.Remove(dgvNhanVien.CurrentRow);
            }
        }
    }
}
