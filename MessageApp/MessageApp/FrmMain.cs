using MessageApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageApp
{
    public partial class FrmMain : Form
    {
        private string recipientId;
        private SqlConnection connection;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            MyAdo myAdo = new MyAdo();
            myAdo.FillCheckListBox(checkedListBoxTo);

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxTo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAll.Checked)
            {
                for (int i = 0; i < checkedListBoxTo.Items.Count; i++)
                {
                    checkedListBoxTo.SetItemChecked(i, true); 
                }
            }
            else
            {
                for (int i = 0; i < checkedListBoxTo.Items.Count; i++)
                {
                    checkedListBoxTo.SetItemChecked(i, false); // إلغاء تحديد العنصر
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
           
            if (checkedListBoxTo.CheckedItems.Count == 0)
    {
        MessageBox.Show("Please select at least one recipient.");
        return;
    }

    if (string.IsNullOrEmpty(txtSubject.Text) || string.IsNullOrEmpty(txtMessage.Text))
    {
        MessageBox.Show("Please enter both subject and message.");
        return;
    }

int senderId = MyAdo.UserId;
string subject = txtSubject.Text;
string body = txtMessage.Text;

foreach (var item in checkedListBoxTo.CheckedItems)
{
    DataRowView recipient = item as DataRowView;
    if (recipient != null)
    {
        int recipientId = Convert.ToInt32(recipient["UserID"]);

        string query = "INSERT INTO Messages (SenderID, RecipientID, Subject, Body) " +
                       "VALUES (@SenderID, @RecipientID, @Subject, @Body)";

        try
        {
            MyAdo.Execute(query, new Dictionary<string, object>
                {
                    { "@SenderID", senderId },
                    { "@RecipientID", recipientId },
                    { "@Subject", subject },
                    { "@Body", body }
                });
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error sending message: " + ex.Message);
        }
    }
}

MessageBox.Show("Message sent successfully!");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Name == "tabInbox")
            {
                btnRefresh_Click(sender, e);
            }
            if (tabControl1.SelectedTab.Name == "tabSentMessage")
            {
                btnRefresh_Click(sender, e);
            }
        }

        private void tabInbox_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                MyAdo.Begin();
                string sl = "select * from View_2 where SenderID = @UserId";
                SqlDataAdapter da = new SqlDataAdapter(sl, MyAdo.GetConnection());
                da.SelectCommand.Parameters.AddWithValue("@UserId", MyAdo.UserId);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewSent.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                MyAdo.CloseConnection();
            }

        }

        private void btnRefreshSent_Click(object sender, EventArgs e)
        {
            try
            {
                MyAdo.Begin();
                string sl = "select * from View_2 where RecipientID = @UserId";
                SqlDataAdapter da = new SqlDataAdapter(sl, MyAdo.GetConnection());
                da.SelectCommand.Parameters.AddWithValue("@UserId", MyAdo.UserId);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewRec.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                MyAdo.CloseConnection();
            }
           
        }

        private void dataGridViewRec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
