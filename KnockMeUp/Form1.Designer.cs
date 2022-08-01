namespace KnockMeUp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbServerList = new System.Windows.Forms.ComboBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.lblNameOrIP = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cmbPacket1Type = new System.Windows.Forms.ComboBox();
            this.txtPacket1Port = new System.Windows.Forms.TextBox();
            this.txtPacket1Text = new System.Windows.Forms.TextBox();
            this.txtPacket2Text = new System.Windows.Forms.TextBox();
            this.txtPacket2Port = new System.Windows.Forms.TextBox();
            this.cmbPacket2Type = new System.Windows.Forms.ComboBox();
            this.txtPacket3Text = new System.Windows.Forms.TextBox();
            this.txtPacket3Port = new System.Windows.Forms.TextBox();
            this.cmbPacket3Type = new System.Windows.Forms.ComboBox();
            this.txtPacket4Text = new System.Windows.Forms.TextBox();
            this.txtPacket4Port = new System.Windows.Forms.TextBox();
            this.cmbPacket4Type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnKnock = new System.Windows.Forms.Button();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbServerList
            // 
            this.cmbServerList.FormattingEnabled = true;
            this.cmbServerList.Location = new System.Drawing.Point(63, 12);
            this.cmbServerList.Name = "cmbServerList";
            this.cmbServerList.Size = new System.Drawing.Size(255, 23);
            this.cmbServerList.TabIndex = 0;
            this.cmbServerList.SelectedIndexChanged += new System.EventHandler(this.cmbServerList_SelectedIndexChanged);
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(12, 15);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(45, 15);
            this.lblServer.TabIndex = 1;
            this.lblServer.Text = "Server: ";
            // 
            // lblNameOrIP
            // 
            this.lblNameOrIP.AutoSize = true;
            this.lblNameOrIP.Location = new System.Drawing.Point(12, 59);
            this.lblNameOrIP.Name = "lblNameOrIP";
            this.lblNameOrIP.Size = new System.Drawing.Size(69, 15);
            this.lblNameOrIP.TabIndex = 2;
            this.lblNameOrIP.Text = "Name or IP:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(303, 59);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(70, 15);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "4";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(87, 56);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(210, 23);
            this.txtHost.TabIndex = 8;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(379, 56);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(141, 23);
            this.txtDescription.TabIndex = 9;
            // 
            // cmbPacket1Type
            // 
            this.cmbPacket1Type.FormattingEnabled = true;
            this.cmbPacket1Type.Items.AddRange(new object[] {
            "None",
            "UDP",
            "TCP"});
            this.cmbPacket1Type.Location = new System.Drawing.Point(31, 123);
            this.cmbPacket1Type.Name = "cmbPacket1Type";
            this.cmbPacket1Type.Size = new System.Drawing.Size(65, 23);
            this.cmbPacket1Type.TabIndex = 10;
            // 
            // txtPacket1Port
            // 
            this.txtPacket1Port.Location = new System.Drawing.Point(112, 123);
            this.txtPacket1Port.Name = "txtPacket1Port";
            this.txtPacket1Port.Size = new System.Drawing.Size(100, 23);
            this.txtPacket1Port.TabIndex = 11;
            // 
            // txtPacket1Text
            // 
            this.txtPacket1Text.Location = new System.Drawing.Point(229, 123);
            this.txtPacket1Text.Name = "txtPacket1Text";
            this.txtPacket1Text.Size = new System.Drawing.Size(291, 23);
            this.txtPacket1Text.TabIndex = 12;
            // 
            // txtPacket2Text
            // 
            this.txtPacket2Text.Location = new System.Drawing.Point(229, 151);
            this.txtPacket2Text.Name = "txtPacket2Text";
            this.txtPacket2Text.Size = new System.Drawing.Size(291, 23);
            this.txtPacket2Text.TabIndex = 15;
            // 
            // txtPacket2Port
            // 
            this.txtPacket2Port.Location = new System.Drawing.Point(112, 151);
            this.txtPacket2Port.Name = "txtPacket2Port";
            this.txtPacket2Port.Size = new System.Drawing.Size(100, 23);
            this.txtPacket2Port.TabIndex = 14;
            // 
            // cmbPacket2Type
            // 
            this.cmbPacket2Type.FormattingEnabled = true;
            this.cmbPacket2Type.Items.AddRange(new object[] {
            "None",
            "UDP",
            "TCP"});
            this.cmbPacket2Type.Location = new System.Drawing.Point(31, 151);
            this.cmbPacket2Type.Name = "cmbPacket2Type";
            this.cmbPacket2Type.Size = new System.Drawing.Size(65, 23);
            this.cmbPacket2Type.TabIndex = 13;
            // 
            // txtPacket3Text
            // 
            this.txtPacket3Text.Location = new System.Drawing.Point(229, 179);
            this.txtPacket3Text.Name = "txtPacket3Text";
            this.txtPacket3Text.Size = new System.Drawing.Size(291, 23);
            this.txtPacket3Text.TabIndex = 18;
            // 
            // txtPacket3Port
            // 
            this.txtPacket3Port.Location = new System.Drawing.Point(112, 179);
            this.txtPacket3Port.Name = "txtPacket3Port";
            this.txtPacket3Port.Size = new System.Drawing.Size(100, 23);
            this.txtPacket3Port.TabIndex = 17;
            // 
            // cmbPacket3Type
            // 
            this.cmbPacket3Type.FormattingEnabled = true;
            this.cmbPacket3Type.Items.AddRange(new object[] {
            "None",
            "UDP",
            "TCP"});
            this.cmbPacket3Type.Location = new System.Drawing.Point(31, 179);
            this.cmbPacket3Type.Name = "cmbPacket3Type";
            this.cmbPacket3Type.Size = new System.Drawing.Size(65, 23);
            this.cmbPacket3Type.TabIndex = 16;
            // 
            // txtPacket4Text
            // 
            this.txtPacket4Text.Location = new System.Drawing.Point(229, 207);
            this.txtPacket4Text.Name = "txtPacket4Text";
            this.txtPacket4Text.Size = new System.Drawing.Size(291, 23);
            this.txtPacket4Text.TabIndex = 21;
            // 
            // txtPacket4Port
            // 
            this.txtPacket4Port.Location = new System.Drawing.Point(112, 207);
            this.txtPacket4Port.Name = "txtPacket4Port";
            this.txtPacket4Port.Size = new System.Drawing.Size(100, 23);
            this.txtPacket4Port.TabIndex = 20;
            // 
            // cmbPacket4Type
            // 
            this.cmbPacket4Type.FormattingEnabled = true;
            this.cmbPacket4Type.Items.AddRange(new object[] {
            "None",
            "UDP",
            "TCP"});
            this.cmbPacket4Type.Location = new System.Drawing.Point(31, 207);
            this.cmbPacket4Type.Name = "cmbPacket4Type";
            this.cmbPacket4Type.Size = new System.Drawing.Size(65, 23);
            this.cmbPacket4Type.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Port";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(229, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "Text";
            // 
            // btnKnock
            // 
            this.btnKnock.Location = new System.Drawing.Point(122, 249);
            this.btnKnock.Name = "btnKnock";
            this.btnKnock.Size = new System.Drawing.Size(90, 23);
            this.btnKnock.TabIndex = 25;
            this.btnKnock.Text = "Knock";
            this.btnKnock.UseVisualStyleBackColor = true;
            this.btnKnock.Click += new System.EventHandler(this.btnKnock_Click);
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.Location = new System.Drawing.Point(218, 249);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(90, 23);
            this.btnAddUpdate.TabIndex = 26;
            this.btnAddUpdate.Text = "Add/Update";
            this.btnAddUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(314, 249);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 23);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(445, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 289);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddUpdate);
            this.Controls.Add(this.btnKnock);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPacket4Text);
            this.Controls.Add(this.txtPacket4Port);
            this.Controls.Add(this.cmbPacket4Type);
            this.Controls.Add(this.txtPacket3Text);
            this.Controls.Add(this.txtPacket3Port);
            this.Controls.Add(this.cmbPacket3Type);
            this.Controls.Add(this.txtPacket2Text);
            this.Controls.Add(this.txtPacket2Port);
            this.Controls.Add(this.cmbPacket2Type);
            this.Controls.Add(this.txtPacket1Text);
            this.Controls.Add(this.txtPacket1Port);
            this.Controls.Add(this.cmbPacket1Type);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblNameOrIP);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.cmbServerList);
            this.Name = "Form1";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbServerList;
        private Label lblServer;
        private Label lblNameOrIP;
        private Label lblDescription;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtHost;
        private TextBox txtDescription;
        private ComboBox cmbPacket1Type;
        private TextBox txtPacket1Port;
        private TextBox txtPacket1Text;
        private TextBox txtPacket2Text;
        private TextBox txtPacket2Port;
        private ComboBox cmbPacket2Type;
        private TextBox txtPacket3Text;
        private TextBox txtPacket3Port;
        private ComboBox cmbPacket3Type;
        private TextBox txtPacket4Text;
        private TextBox txtPacket4Port;
        private ComboBox cmbPacket4Type;
        private Label label1;
        private Label label2;
        private Label label7;
        private Button btnKnock;
        private Button btnAddUpdate;
        private Button btnDelete;
        private Button button1;
    }
}