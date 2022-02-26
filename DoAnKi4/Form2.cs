using System;
using System.Drawing;
using System.Windows.Forms;

namespace DoAnKi4
{
    public partial class Form2 : Form
    {
        public Form2(string ms)
        {
            InitializeComponent();
            LoadInfor(ms);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void helloToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void xemĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void lịchSửSửaĐiểmToolStripMenuItem_Click(object sender, EventArgs e)   //cai nay la sua diem nha
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void xemĐiểmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void ýKiếnVềĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f5 = new Form3();
            f5.ShowDialog();
        }

        private void lịchSửSửaĐiểmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void thêmHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }

        private void xoáHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
      
        public HocSinh GetHocSinhByMSHS(string ms)
        {
            var db = new QLKQHS_DB();
            var hs = new HocSinh();
            foreach (HocSinh i in db.HocSinhs)
            {
                if (ms == i.MaHocSinh )
                {
                    hs = i;
                }

            }
            return hs;
        }
        public GiaoVien GetGVByMSGV(string ms)
        {
            var db = new QLKQHS_DB();
            var gv = new GiaoVien();
            foreach (GiaoVien i in db.GiaoViens)
            {
                if (ms == i.MaGiaoVien)
                {
                    gv = i;
                }

            }
            return gv;
        }
        public bool ContainHS(String mshs)
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
        public bool ContainGV(String msgv)
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
        public void LoadInfor(string ms)
        {
            
            if (ContainHS(ms) == true)
            {
                var HS = new HocSinh(); 
                HS = GetHocSinhByMSHS(ms);
                 string s1 = "C:\\Users\\PC\\Pictures\\";
                 string s2 = HS.LinkAnh.ToString();
                pictureBox1.Image = Image.FromFile(s1+s2); 
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                txtName.Text = HS.NameHS;
     
                if(HS.GioiTinh == true)
                {
                    txtGender.Text = "Nam";
                }
                else
                {
                    txtGender.Text = "Nữ";
                }
                       
                txtNumberPhone.Text = HS.LienHe;
                txtMSHS.Text = HS.MaHocSinh;
                txtAdress.Text = HS.NoiO;
                txtChucVu.Text = "Học Sinh ";


            }
            else if (ContainGV(ms) == true)
            {
                var GV = new GiaoVien();
                 GV =  GetGVByMSGV(ms);
                string s3 = "C:\\Users\\PC\\Pictures\\";
                string s4 = GV.LinkAnh.ToString();
                pictureBox1.Image = Image.FromFile(s3+s4);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                 txtName.Text = GV.NameGV;

                if (GV.GioiTinh == true)
                {
                    txtGender.Text = "Nam";
                }
                else
                {
                    txtGender.Text = "Nữ";
                }

                txtNumberPhone.Text = GV.LienHe;
                txtMSHS.Text = GV.MaGiaoVien;
                txtAdress.Text =GV.DiaChi ;
                txtChucVu.Text = "Giao Vien ";
            }
            else
            {
                MessageBox.Show("Không tồn tại học sinh này trong danh sách ");
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
