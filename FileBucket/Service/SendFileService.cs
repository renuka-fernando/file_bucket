using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FileBucket.Service {

    class SendFileService {

        public FileProgressEventHandler FileSendProgress;
        public FileSharedCompleteEventHandler FileSendComplete;
        public ConnectEventHandler Connect;

        public static int bufferSize = 4096;
        TcpClient client;
        private Task task = null;

        public String FilePath { get; set; }

        public long FileSize { get; private set; }

        public SendFileService(String filePath) {
            FilePath = filePath;
            FileSize = new FileInfo(filePath).Length;

            //Linstener for validation
            Task.Run(() => {
                TcpListener listener = new TcpListener(4975);
                listener.Start();
            });
        }

        public void StartListening() {
            Task.Run(() => {
                if (Connect != null) Connect(Connection.Connecting);
                client = FileShareService.GetNewClient();
                if (Connect != null) Connect(Connection.Successful);
            });
        }

        public void SendFileAsync() {
            task = Task.Run(() => {
                sendFile();
            });
        }

        private void sendFile() {
            using (Stream stream = client.GetStream()) {
                //Send file size
                FileInfo fileInfo = new FileInfo(FilePath);
                int fileSize = (int) fileInfo.Length;
                byte[] fileSizeBytes = BitConverter.GetBytes(fileSize);
                stream.Write(fileSizeBytes, 0, 4);

                //Send file name
                byte[] fileNamebytes = Encoding.ASCII.GetBytes(fileInfo.Name);
                fileSizeBytes = BitConverter.GetBytes(fileNamebytes.Length);
                stream.Write(fileSizeBytes, 0, 4);
                stream.Write(fileNamebytes, 0, fileNamebytes.Length);

                using (FileStream fileStream = new FileStream(FilePath, FileMode.Open)) {
                    //int count = (int)(fileSize / bufferSize);
                    //int rest = (int)(fileSize % bufferSize);

                    //byte[] fileBytes = new byte[bufferSize];
                    //if (FileSendProgress == null) {
                    //    for (int i = 0; i < count; i++) {
                    //        fileStream.Read(fileBytes, 0, bufferSize);
                    //        System.Threading.Thread.Sleep(10);
                    //        stream.Write(fileBytes, 0, bufferSize);
                    //    }
                    //} else {
                    //    for (int i = 0; i < count;) {
                    //        fileStream.Read(fileBytes, 0, bufferSize);
                    //        System.Threading.Thread.Sleep(10);
                    //        stream.Write(fileBytes, 0, bufferSize);
                    //        i++;
                    //        FileSendProgress(i / (double)count);
                    //    }
                    //}

                    ////Rest Bytes
                    //fileBytes = new byte[rest];
                    //fileStream.Read(fileBytes, 0, rest);
                    //stream.Write(fileBytes, 0, rest);


                    #region
                    byte[] fileBytes = new byte[fileSize];
                    fileStream.Read(fileBytes, 0, fileSize);
                    stream.Write(fileBytes, 0, fileSize);

                    if (FileSendProgress != null) FileSendProgress(1);
                    #endregion
                }
            }

            //File send competed
            if (FileSendComplete != null) FileSendComplete();
            client.Close();
        }

        public void CancelSending() {
            client.Close();
        }
    }
}
