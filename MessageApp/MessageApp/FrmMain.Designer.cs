namespace MessageApp
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabNewMessage = new System.Windows.Forms.TabPage();
            this.checkBoxAll = new System.Windows.Forms.CheckBox();
            this.checkedListBoxTo = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.tabInbox = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataGridViewRec = new System.Windows.Forms.DataGridView();
            this.tabSentMessages = new System.Windows.Forms.TabPage();
            this.dataGridViewSent = new System.Windows.Forms.DataGridView();
            this.btnRefreshSent = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabNewMessage.SuspendLayout();
            this.tabInbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRec)).BeginInit();
            this.tabSentMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSent)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabNewMessage);
            this.tabControl1.Controls.Add(this.tabInbox);
            this.tabControl1.Controls.Add(this.tabSentMessages);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabNewMessage
            // 
            this.tabNewMessage.Controls.Add(this.checkBoxAll);
            this.tabNewMessage.Controls.Add(this.checkedListBoxTo);
            this.tabNewMessage.Controls.Add(this.label2);
            this.tabNewMessage.Controls.Add(this.label1);
            this.tabNewMessage.Controls.Add(this.txtMessage);
            this.tabNewMessage.Controls.Add(this.txtSubject);
            this.tabNewMessage.Controls.Add(this.btnSend);
            this.tabNewMessage.Location = new System.Drawing.Point(4, 25);
            this.tabNewMessage.Name = "tabNewMessage";
            this.tabNewMessage.Padding = new System.Windows.Forms.Padding(3);
            this.tabNewMessage.Size = new System.Drawing.Size(792, 421);
            this.tabNewMessage.TabIndex = 0;
            this.tabNewMessage.Text = "New Message";
            this.tabNewMessage.UseVisualStyleBackColor = true;
            // 
            // checkBoxAll
            // 
            this.checkBoxAll.AutoSize = true;
            this.checkBoxAll.Location = new System.Drawing.Point(633, 28);
            this.checkBoxAll.Name = "checkBoxAll";
            this.checkBoxAll.Size = new System.Drawing.Size(85, 20);
            this.checkBoxAll.TabIndex = 4;
            this.checkBoxAll.Text = "Select All";
            this.checkBoxAll.UseVisualStyleBackColor = true;
            this.checkBoxAll.CheckedChanged += new System.EventHandler(this.checkBoxTo_CheckedChanged);
            // 
            // checkedListBoxTo
            // 
            this.checkedListBoxTo.FormattingEnabled = true;
            this.checkedListBoxTo.Location = new System.Drawing.Point(633, 54);
            this.checkedListBoxTo.Name = "checkedListBoxTo";
            this.checkedListBoxTo.Size = new System.Drawing.Size(151, 225);
            this.checkedListBoxTo.TabIndex = 3;
            this.checkedListBoxTo.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Message";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Subject";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(156, 102);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(391, 164);
            this.txtMessage.TabIndex = 1;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(156, 54);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(391, 22);
            this.txtSubject.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(156, 287);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(160, 34);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tabInbox
            // 
            this.tabInbox.Controls.Add(this.btnRefresh);
            this.tabInbox.Controls.Add(this.dataGridViewRec);
            this.tabInbox.Location = new System.Drawing.Point(4, 25);
            this.tabInbox.Name = "tabInbox";
            this.tabInbox.Size = new System.Drawing.Size(792, 421);
            this.tabInbox.TabIndex = 1;
            this.tabInbox.Text = "Inbox";
            this.tabInbox.UseVisualStyleBackColor = true;
            this.tabInbox.Click += new System.EventHandler(this.tabInbox_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(623, 27);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(151, 36);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dataGridViewRec
            // 
            this.dataGridViewRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRec.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewRec.Location = new System.Drawing.Point(0, 147);
            this.dataGridViewRec.Name = "dataGridViewRec";
            this.dataGridViewRec.RowHeadersWidth = 51;
            this.dataGridViewRec.RowTemplate.Height = 24;
            this.dataGridViewRec.Size = new System.Drawing.Size(792, 274);
            this.dataGridViewRec.TabIndex = 0;
            this.dataGridViewRec.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRec_CellContentClick);
            // 
            // tabSentMessages
            // 
            this.tabSentMessages.Controls.Add(this.dataGridViewSent);
            this.tabSentMessages.Controls.Add(this.btnRefreshSent);
            this.tabSentMessages.Location = new System.Drawing.Point(4, 25);
            this.tabSentMessages.Name = "tabSentMessages";
            this.tabSentMessages.Size = new System.Drawing.Size(792, 421);
            this.tabSentMessages.TabIndex = 2;
            this.tabSentMessages.Text = "Sent Messages";
            this.tabSentMessages.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSent
            // 
            this.dataGridViewSent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewSent.Location = new System.Drawing.Point(0, 191);
            this.dataGridViewSent.Name = "dataGridViewSent";
            this.dataGridViewSent.RowHeadersWidth = 51;
            this.dataGridViewSent.RowTemplate.Height = 24;
            this.dataGridViewSent.Size = new System.Drawing.Size(792, 230);
            this.dataGridViewSent.TabIndex = 1;
            // 
            // btnRefreshSent
            // 
            this.btnRefreshSent.Location = new System.Drawing.Point(666, 33);
            this.btnRefreshSent.Name = "btnRefreshSent";
            this.btnRefreshSent.Size = new System.Drawing.Size(118, 38);
            this.btnRefreshSent.TabIndex = 0;
            this.btnRefreshSent.Text = "Refresh";
            this.btnRefreshSent.UseVisualStyleBackColor = true;
            this.btnRefreshSent.Click += new System.EventHandler(this.btnRefreshSent_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabNewMessage.ResumeLayout(false);
            this.tabNewMessage.PerformLayout();
            this.tabInbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRec)).EndInit();
            this.tabSentMessages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabNewMessage;
        private System.Windows.Forms.TabPage tabInbox;
        private System.Windows.Forms.TabPage tabSentMessages;
        private System.Windows.Forms.CheckedListBox checkedListBoxTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.CheckBox checkBoxAll;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridViewRec;
        private System.Windows.Forms.DataGridView dataGridViewSent;
        private System.Windows.Forms.Button btnRefreshSent;
    }
}