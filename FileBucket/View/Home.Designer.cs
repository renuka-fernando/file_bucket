namespace FileBucket.View {
    partial class Home {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.mainTab = new System.Windows.Forms.TabControl();
            this.receiveTabPage = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ReceiveFileButton = new System.Windows.Forms.Button();
            this.receiveFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.sendTabPage = new System.Windows.Forms.TabPage();
            this.sendFileButton = new System.Windows.Forms.Button();
            this.sendFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.hostNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sendFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.receiveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.sendFileTile1 = new FileBucket.View.UserControls.SendFileTile();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.mainTab.SuspendLayout();
            this.receiveTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.sendTabPage.SuspendLayout();
            this.sendFlowLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTab
            // 
            this.mainTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTab.Controls.Add(this.receiveTabPage);
            this.mainTab.Controls.Add(this.sendTabPage);
            this.mainTab.Location = new System.Drawing.Point(12, 73);
            this.mainTab.Name = "mainTab";
            this.mainTab.SelectedIndex = 0;
            this.mainTab.Size = new System.Drawing.Size(728, 365);
            this.mainTab.TabIndex = 0;
            // 
            // receiveTabPage
            // 
            this.receiveTabPage.Controls.Add(this.pictureBox2);
            this.receiveTabPage.Controls.Add(this.ReceiveFileButton);
            this.receiveTabPage.Controls.Add(this.receiveFlowLayout);
            this.receiveTabPage.Location = new System.Drawing.Point(4, 22);
            this.receiveTabPage.Name = "receiveTabPage";
            this.receiveTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.receiveTabPage.Size = new System.Drawing.Size(720, 339);
            this.receiveTabPage.TabIndex = 0;
            this.receiveTabPage.Text = "Receive";
            this.receiveTabPage.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FileBucket.Properties.Resources.download;
            this.pictureBox2.Location = new System.Drawing.Point(6, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // ReceiveFileButton
            // 
            this.ReceiveFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReceiveFileButton.Location = new System.Drawing.Point(613, 15);
            this.ReceiveFileButton.Name = "ReceiveFileButton";
            this.ReceiveFileButton.Size = new System.Drawing.Size(101, 23);
            this.ReceiveFileButton.TabIndex = 1;
            this.ReceiveFileButton.Text = "&Receive File...";
            this.ReceiveFileButton.UseVisualStyleBackColor = true;
            this.ReceiveFileButton.Click += new System.EventHandler(this.ReceiveFileButton_Click);
            // 
            // receiveFlowLayout
            // 
            this.receiveFlowLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.receiveFlowLayout.BackColor = System.Drawing.Color.White;
            this.receiveFlowLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.receiveFlowLayout.Location = new System.Drawing.Point(6, 44);
            this.receiveFlowLayout.Name = "receiveFlowLayout";
            this.receiveFlowLayout.Size = new System.Drawing.Size(708, 289);
            this.receiveFlowLayout.TabIndex = 0;
            // 
            // sendTabPage
            // 
            this.sendTabPage.Controls.Add(this.pictureBox3);
            this.sendTabPage.Controls.Add(this.sendFileButton);
            this.sendTabPage.Controls.Add(this.sendFlowLayout);
            this.sendTabPage.Location = new System.Drawing.Point(4, 22);
            this.sendTabPage.Name = "sendTabPage";
            this.sendTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.sendTabPage.Size = new System.Drawing.Size(720, 339);
            this.sendTabPage.TabIndex = 1;
            this.sendTabPage.Text = "Send";
            this.sendTabPage.UseVisualStyleBackColor = true;
            // 
            // sendFileButton
            // 
            this.sendFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sendFileButton.Location = new System.Drawing.Point(613, 15);
            this.sendFileButton.Name = "sendFileButton";
            this.sendFileButton.Size = new System.Drawing.Size(101, 23);
            this.sendFileButton.TabIndex = 3;
            this.sendFileButton.Text = "&Send File...";
            this.sendFileButton.UseVisualStyleBackColor = true;
            this.sendFileButton.Click += new System.EventHandler(this.sendFileButton_Click);
            // 
            // sendFlowLayout
            // 
            this.sendFlowLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendFlowLayout.BackColor = System.Drawing.Color.White;
            this.sendFlowLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sendFlowLayout.Controls.Add(this.sendFileTile1);
            this.sendFlowLayout.Location = new System.Drawing.Point(6, 44);
            this.sendFlowLayout.Name = "sendFlowLayout";
            this.sendFlowLayout.Size = new System.Drawing.Size(708, 289);
            this.sendFlowLayout.TabIndex = 2;
            // 
            // hostNameTextBox
            // 
            this.hostNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hostNameTextBox.Location = new System.Drawing.Point(555, 69);
            this.hostNameTextBox.Name = "hostNameTextBox";
            this.hostNameTextBox.ReadOnly = true;
            this.hostNameTextBox.Size = new System.Drawing.Size(181, 20);
            this.hostNameTextBox.TabIndex = 5;
            this.hostNameTextBox.Text = "Renuka";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(489, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Host Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "File Bucket";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Share Yourselves";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FileBucket.Properties.Resources.FileBucketICon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // sendFileTile1
            // 
            this.sendFileTile1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendFileTile1.BackColor = System.Drawing.Color.White;
            this.sendFileTile1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sendFileTile1.FilePath = null;
            this.sendFileTile1.Location = new System.Drawing.Point(3, 3);
            this.sendFileTile1.Name = "sendFileTile1";
            this.sendFileTile1.Size = new System.Drawing.Size(700, 0);
            this.sendFileTile1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FileBucket.Properties.Resources.upload;
            this.pictureBox3.Location = new System.Drawing.Point(6, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hostNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mainTab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Bucket";
            this.Load += new System.EventHandler(this.Home_Load);
            this.Resize += new System.EventHandler(this.Home_Resize);
            this.mainTab.ResumeLayout(false);
            this.receiveTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.sendTabPage.ResumeLayout(false);
            this.sendFlowLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl mainTab;
        private System.Windows.Forms.TabPage receiveTabPage;
        private System.Windows.Forms.FlowLayoutPanel receiveFlowLayout;
        private System.Windows.Forms.TabPage sendTabPage;
        private System.Windows.Forms.Button ReceiveFileButton;
        private System.Windows.Forms.Button sendFileButton;
        private System.Windows.Forms.FlowLayoutPanel sendFlowLayout;
        private System.Windows.Forms.OpenFileDialog sendFileDialog;
        private System.Windows.Forms.TextBox hostNameTextBox;
        private System.Windows.Forms.Label label1;
        private UserControls.SendFileTile sendFileTile1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.SaveFileDialog receiveFileDialog;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}