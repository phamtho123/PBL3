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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        public bool ContainHS(String mshs)
        {
            var db = new QLKQHS_DB();
                   
                foreach (HocSinh HS in db.HocSinhs)
                {
                    if( HS.MaHocSinh.ToString() == mshs)
                    {
                        return true;
                    }

                }
                return false;
            
        }
        public bool AddHS(HocSinh HS)
        {    
                try
                {
                    if (ContainHS( txtMSHS.Text) == false)
                    {

                        HS.NameHS = txtNameHS.Text;
                        HS.MaLop = cbbNameLop.Text;
                        HS.MaHocSinh = txtMSHS.Text;

                        if (rdoMale.Checked == true)
                        {
                            HS.GioiTinh = rdoMale.Checked;
                        }
                        else
                        {
                            HS.GioiTinh = rdoFeMale.Checked;
                        }
                        HS.LienHe = txtNumberPhone.Text;
                        HS.NoiO = txtAdress.Text;
                        HS.NoiSinh = txtNoiSinh.Text;
                        return true;
                    }
                return false;
                }
                catch (Exception e)
                {
                    return false;
                }
            
        }

        private void butAdd_Click(object sender, EventArgs e)
        {

                var db = new QLKQHS_DB();
                var HS = new HocSinh(); 
                if (AddHS(HS) == true )
                {
                      db.HocSinhs.Add(HS);
                      db.SaveChanges();
                      MessageBox.Show("Thêm thành công ");
                
                }
                else
                {
                MessageBox.Show("Thêm failed , có thể trùng mshs!");
            }
               
            
           
        }
        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
