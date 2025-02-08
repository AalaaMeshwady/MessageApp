using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageApp
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Please Enter The Username");
                txtUserName.Focus();
                return;
            }

            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please Enter The Password");
                txtUserName.Focus();
                return;
            }

            //Select username from gusers where username='Mona' and password='1'

            string sl = "select UserID from Users where UserName='";
            sl += txtUserName.Text + "' and Password='";
            sl += txtPassword.Text + "'";

            string result = MyAdo.Search(sl);
            if (result == null)
            {
                MessageBox.Show("Invalid User");
                txtUserName.Focus();
                return;
            }
            MyAdo.UserId = int.Parse(result);
            this.Hide();
            FrmMain frmMain = new FrmMain();
            frmMain.ShowDialog();
            //string result = MyAdo.Search(sl);
            //if (result == null)
            //{
            //    MessageBox.Show("Invalid User");
            //    txtUserName.Focus();
            //    return;
            //}

            // استخدم TryParse لتحويل القيمة إلى int بشكل آمن
            //if (!int.TryParse(result, out int userId))
            //{
            //    MessageBox.Show("Invalid User ID format");
            //    return;
            //}

            //MyAdo.UserId = userId;
            //this.Hide();
            //FrmMain frmMain = new FrmMain();
            //frmMain.ShowDialog();
            this.Close();
        }
        
        private void btnNewUser_Click(object sender, EventArgs e)
        {
            FrmNewUser frmNewUser = new FrmNewUser();
            frmNewUser.ShowDialog();
            this.Close();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
           
        }
    }
}
