using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnKi4
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
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
        private void butDelete_Click(object sender, EventArgs e)
        {
            var db = new QLKQHS_DB();
            
            if (ContainHS (txtMSHS.Text)==true)
            {
                var delete = (from d in db.HocSinhs where d.MaHocSinh == txtMSHS.Text select d).Single();
                db.HocSinhs.Remove(delete);
                db.SaveChanges();
                MessageBox.Show("Đã Xóa Thành Công ");
            }
            else
            {
                MessageBox.Show("Sinh viên bạn cần xóa không tồn tại ");
            }


        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
