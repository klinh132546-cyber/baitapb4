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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string MSNV
        {
            get { return txtMSNV.Text; }
            set { txtMSNV.Text = value; }
        }

        public string TenNV
        {
            get { return txtTenNV.Text; }
            set { txtTenNV.Text = value; }
        }

        public string Luong
        {
            get { return txtLuong.Text; }
            set { txtLuong.Text = value; }
        }

        public bool IsEdit = false;
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (txtMSNV.Text == "" || txtTenNV.Text == "" || txtLuong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
