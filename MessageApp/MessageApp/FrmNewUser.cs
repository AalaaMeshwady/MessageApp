using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MessageApp
{
    public partial class FrmNewUser : Form
    {
        public FrmNewUser()
        {
            InitializeComponent();
        }

        private void comboGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void FrmNewUser_Load(object sender, EventArgs e)
        {
            MyAdo ado = new MyAdo();

            ado.FillComboBox(comboGroup);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                MessageBox.Show("Please Enter The Username");
                txtUserName.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txtFullName.Text.Trim()))
            {
                MessageBox.Show("Please Enter Your Full Name");
                txtFullName.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txtPhone.Text.Trim()))
            {
                MessageBox.Show("Please Enter Your Phone");
                txtPhone.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                MessageBox.Show("Please Enter The Password");
                txtPassword.Focus();
                return;
            }

            if (txtConfirmPassword.Text != txtPassword.Text)
            {
                MessageBox.Show("Password Not Matched");
                txtPassword.Focus();  
                return;
            }
            else if (String.IsNullOrEmpty(txtConfirmPassword.Text.Trim()))
            {
                MessageBox.Show("Please Confirm Password");
                txtConfirmPassword.Focus();
                return;
            }
            string sl = $"Select UserName from Users where username='{txtUserName.Text}'";
            string res = MyAdo.Search(sl);
            if (res != null)
            {
                MessageBox.Show("user name already exist");
                txtUserName.Focus();
                return;
            }
            int groupId = Convert.ToInt32(comboGroup.SelectedValue);
            //sl = "insert into Users (UserName , FullName , Phone , Password , GroupID ) values (N'";
            //sl += txtUserName.Text + "' , N'";
            //sl += txtFullName.Text + "','";
            //sl += txtPhone.Text + "','";
            //sl += txtPassword.Text + "','";
            //sl += groupId + "')";
             sl = "INSERT INTO Users (UserName, FullName, Phone, Password, GroupID) VALUES (@UserName, @FullName, @Phone, @Password, @GroupID)";
            var parameters = new Dictionary<string, object>
{
    { "@UserName", txtUserName.Text.Trim() },
    { "@FullName", txtFullName.Text.Trim() },
    { "@Phone", txtPhone.Text.Trim() },
    { "@Password", txtPassword.Text.Trim() },
    { "@GroupID", groupId }
};

            int rowsAffected = MyAdo.Execute(sl, parameters);
            if (rowsAffected > 0)
            {
                MessageBox.Show("User created successfully!");
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error while creating the user.");

                MyAdo.Execute(sl);
            }
            
        }
    }
}
