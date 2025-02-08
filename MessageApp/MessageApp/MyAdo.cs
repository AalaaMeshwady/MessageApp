using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageApp
{
    internal class MyAdo
    {
        private static SqlConnection con = new SqlConnection();
        private static SqlCommand cmd = new SqlCommand();

        public static int UserId { get; set; }
        public static void Begin()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close(); 
            }
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = "server=DESKTOP-22FD9GU;database=MessageAppDb;Trusted_Connection=True;";
                con.Open();
                cmd.Connection = con;
            }
        }
        public static void CloseConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        //public static int Execute(string sl, Dictionary<string, object> dictionary)
        //{
        //    cmd.CommandText = sl;
        //    return cmd.ExecuteNonQuery();
        //}
        //public static string Search(string sl)
        //{
        //    string res = null;
        //    cmd.CommandText = sl;
        //    if (cmd.ExecuteScalar() != null)
        //        res = cmd.ExecuteScalar().ToString();
        //    return res;
        //}
        public static string Search(string sl)
        {
            string res = null;
            if (con.State != ConnectionState.Open)
            {
                Begin();  
            }
            cmd.CommandText = sl;
            var result = cmd.ExecuteScalar();  
            if (result != null)
                res = result.ToString();
            return res;
        }

        public void FillComboBox(ComboBox comboBox)
        {
            try
            {

                Begin();
                string sl = "select GroupID, GroupName from Groups";
                cmd = new SqlCommand(sl, con);

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    {

                        DataTable dt = new DataTable();
                        dt.Load(rd);
                        comboBox.DataSource = dt;
                        comboBox.DisplayMember = "GroupName";
                        comboBox.ValueMember = "GroupID";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }

            comboBox.SelectedIndex = -1;
        }
        public void FillCheckListBox(CheckedListBox checkedListBox)
        {
            try
            {

                Begin();
                string sl = "select UserID, UserName from Users";
                cmd = new SqlCommand(sl, con);

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    {

                        DataTable dt = new DataTable();
                        dt.Load(rd);
                        checkedListBox.DataSource = dt;
                        checkedListBox.DisplayMember = "UserName";
                        checkedListBox.ValueMember = "UserID";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }

            //checkedListBox.SelectedIndex = -1;
        }

        internal static SqlConnection GetConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

            // فتح الاتصال إذا كان مغلقًا
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = "server=DESKTOP-22FD9GU;database=MessageAppDb;Trusted_Connection=True;";
                con.Open();
            }

            return con;
        }

        
        public static int Execute(string sl, Dictionary<string, object> parameters)
        {
            if (con.State != ConnectionState.Open)
            {
                Begin();
            }

            cmd.CommandText = sl;
            cmd.Parameters.Clear(); // تنظيف المعاملات القديمة

            // إضافة المعاملات من القاموس إلى SqlCommand
            foreach (var param in parameters)
            {
                cmd.Parameters.AddWithValue(param.Key, param.Value);
            }

            return cmd.ExecuteNonQuery();
        }

        internal static void Execute(string sl)
        {
            throw new NotImplementedException();
        }
        private void MarkMessageAsRead(int messageId)
        {
            Begin();
            cmd.Parameters.AddWithValue("@MessageID", messageId);
            cmd.ExecuteNonQuery();
        }
        private void OpenMessage(int messageId)
        {
            MessageBox.Show("Opeaning message....");
            MarkMessageAsRead(messageId);
        }
    }
}
