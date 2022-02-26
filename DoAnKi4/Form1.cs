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
using System.Data;

namespace DoAnKi4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            setCbo();


        }

        

        public void loadCBB(ComboBox cbb)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void abcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }
        private void setCbo()
        {
            cbbTuCach.Items.AddRange(new CBBItem[]
               {
               new CBBItem{ _Text = "Học Sinh " , _Value = 0},
               new CBBItem{ _Text = "Giáo Viên " , _Value = 1},
               new CBBItem { _Text = "Phụ Huynh", _Value = 2},
               });


        }
        public bool CheckTaiKhoanHS(String mshs)
        {
            var db = new QLKQHS_DB();

            foreach (HocSinh HS in db.HocSinhs)
            {
                if (HS.MaHocSinh.ToString() == mshs)
                {
                    return true;
                }

            }
            return false;

        }
        public bool CheckTaiKhoanGV(String msgv)
        {
            var db = new QLKQHS_DB();

            foreach (GiaoVien GV in db.GiaoViens)
            {
                if (GV.MaGiaoVien.ToString() == msgv)
                {
                    return true;
                }

            }
            return false;

        }
        public bool CheckPassHS(String mk)
        {
            var db = new QLKQHS_DB();

            foreach (HocSinh HS in db.HocSinhs)
            {
                if (HS.MatKhau.ToString() == mk)
                {
                    return true;
                }

            }
            return false;

        }
        public bool CheckPassGV(String mk)
        {
            var db = new QLKQHS_DB();

            foreach (GiaoVien GV in db.GiaoViens)
            {
                if (GV.MatKhau.ToString() == mk)
                {
                    return true;
                }

            }
            return false;

        }

        private void butDangNhap_Click(object sender, EventArgs e)
        {
            if (cbbTuCach.SelectedIndex == -1)
            {
                MessageBox.Show("Vui long chon tu cach dang nhap");
                return;
            }
            CBBItem cb = cbbTuCach.SelectedItem as CBBItem;
          
            switch (cb._Value)
            {

                case 0:
                    if (CheckTaiKhoanHS(txtTaiKhoan.Text) == true && CheckPassHS(txtMatKhau.Text) == true)
                    {
                        MessageBox.Show("Đăng nhập thành công ");
                        Form2 f2 = new Form2(txtTaiKhoan.Text);
                        f2.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thất bại");
                    }
                    break;
                case 1:
                    if (CheckTaiKhoanGV(txtTaiKhoan.Text) == true && CheckPassGV(txtMatKhau.Text) == true)
                    {
                        MessageBox.Show("Đăng nhập thành công ");
                        Form2 f2 = new Form2(txtTaiKhoan.Text);
                        f2.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thất bại");
                    }
                    break;
                case 2:
                    if (CheckTaiKhoanHS(txtTaiKhoan.Text) == true && CheckPassHS(txtMatKhau.Text) == true)
                    {
                        MessageBox.Show("Đăng nhập thành công ");
                        Form2 f2 = new Form2(txtTaiKhoan.Text);
                        f2.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thất bại"); 
                    }
                    break;
                default:
                    MessageBox.Show("Đăng nhập thất bại");
                    break;
            }

            
        }
    }
}
