using FileBucket.Service;
using FileBucket.View.Dialog;
using FileBucket.View.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileBucket.View {
    public partial class Home : Form {
        LinkedList<String> fileList = new LinkedList<string>();

        public Home() {
            InitializeComponent();
            FileShareService.StartListener();
        }

        private void sendFileButton_Click(object sender, EventArgs e) {
            DialogResult result = sendFileDialog.ShowDialog(this);
            if(result == DialogResult.OK) {
                String filePath = sendFileDialog.FileName;
                SendFileService service = new SendFileService(filePath);
                addSendFileTile(service);
            }
        }

        private void addSendFileTile(SendFileService service) {
            SendFileTile tile = new SendFileTile();
            tile.Service = service;

            this.sendFlowLayout.Controls.Add(tile);
            Home_Resize(null, null);
        }

        private async void ReceiveFileButton_Click(object sender, EventArgs e) {
            //Get host name
            DialogResult result = ReceiveFileDialog.ShowDialogFB(this);
            if (result == DialogResult.Cancel) return;

            ReceiveFileService service = new ReceiveFileService();
            service.HostName = ReceiveFileDialog.HostName;

            //Check the host name
            Task<bool> taskResult = Task.Run(() => {
                bool resultVal = service.IsValidHostName();
                ConnectingDialog.hideConnectingDialog();
                return resultVal;
            });
            ConnectingDialog.showConnectingDialog(this);
            bool isValid = taskResult.Result;

            if (!isValid) {
                MessageBox.Show("Host : " + service.HostName + " is not found", "Invalid Host Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Task fileTask = Task.Run(() => service.GetFileInfo());

            //Show file list
            FileListDialog.ShowDialogFB(this);

            await fileTask;

            //Save file dialog
            receiveFileDialog.FileName = service.FilePath;
            string ext = service.FilePath.Split('.')[1];

            //File already exist
            if (fileList.Contains(service.FilePath)) {
                if(DialogResult.No == MessageBox.Show("'" + service.FilePath + "' is already exists. Do you want to download again?", "File already exists!", MessageBoxButtons.YesNo, MessageBoxIcon.Information)) {
                    return;
                }
            }
            fileList.AddFirst(service.FilePath);

            receiveFileDialog.DefaultExt = ext;
            receiveFileDialog.Filter = "FileBucket|*." + ext;
            if(DialogResult.OK != receiveFileDialog.ShowDialog()) {
                return;
            }
            service.FilePath = receiveFileDialog.FileName;

            //Add to list
            addReceiveFileTile(service);
        }

        private void addReceiveFileTile(ReceiveFileService service) {
            ReceiveFileTile tile = new ReceiveFileTile();
            this.receiveFlowLayout.Controls.Add(tile);
            tile.Service = service;
        }

        private void Home_Load(object sender, EventArgs e) {
            hostNameTextBox.Text = FileShareService.HostName;
        }

        private void Home_Resize(object sender, EventArgs e) {
            foreach (SendFileTile tile in sendFlowLayout.Controls) {
                tile.Width = sendFlowLayout.Width - 8;
            }

            foreach (ReceiveFileTile tile in receiveFlowLayout.Controls) {
                tile.Width = sendFlowLayout.Width - 8;
            }
        }
    }
}
