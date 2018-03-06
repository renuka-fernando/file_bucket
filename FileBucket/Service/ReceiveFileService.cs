using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FileBucket.Service {
    class ReceiveFileService {

        public FileProgressEventHandler FileReceiveProgress;
        public FileSharedCompleteEventHandler FileReceivedComplete;
        public ConnectEventHandler Connect;
        TcpClient client;

        public static int bufferSize = 4096;
        public String FilePath { get; set; }

        public long FileSize { get; private set; }

        public String HostName { get; set; }

        public bool IsValidHostName() {
            try {
                TcpClient client = new TcpClient(HostName, 4975);
                client.Close();
            } catch (Exception e) {
                return false;
            }
            return true;
        }

        public void ReceiveFileAsync() {
            Task.Run(() => {
                ReceiveFile();
            });
        }

        public void GetFileInfo() {
            client = new TcpClient(HostName, config.Configuration.PORT);
            Stream stream = client.GetStream();
                //Receive file size
                byte[] fileSizeBytes = new byte[4];
                stream.Read(fileSizeBytes, 0, 4);
                int fileSize = BitConverter.ToInt32(fileSizeBytes, 0);
                FileSize = fileSize;

                //Receive File name
                stream.Read(fileSizeBytes, 0, 4);
                int fileNameLen = BitConverter.ToInt32(fileSizeBytes, 0);
                byte[] fileNamebytes = new byte[fileNameLen];
                stream.Read(fileNamebytes, 0, fileNameLen);
                string fileName = Encoding.ASCII.GetString(fileNamebytes);
                FilePath = fileName;
            
        }

        private void ReceiveFile() {
            using (Stream stream = client.GetStream()) {
                if (Connect != null) Connect(Connection.Successful);
                
                using (FileStream fileStream = new FileStream(FilePath, FileMode.Create)) {
                    //int count = (int)(fileSize / bufferSize);
                    //int rest = (int)(fileSize % bufferSize);

                    //byte[] fileBytes = new byte[bufferSize];
                    ////TODO hard code replace this
                    //FilePath = "D:\\downloaded_image.jpg";

                    //if (FileReceiveProgress == null) {
                    //    for (int i = 0; i < count; i++) {
                    //        stream.Read(fileBytes, 0, bufferSize);
                    //        System.Threading.Thread.Sleep(10);
                    //        fileStream.Write(fileBytes, 0, bufferSize);
                    //    }
                    //} else {
                    //    for (int i = 0; i < count;) {
                    //        stream.Read(fileBytes, 0, bufferSize);
                    //        System.Threading.Thread.Sleep(10);
                    //        fileStream.Write(fileBytes, 0, bufferSize);
                    //        i++;
                    //        FileReceiveProgress(i / (double)count);
                    //    }
                    //}

                    ////Rest Bytes
                    //fileBytes = new byte[rest];
                    //stream.Read(fileBytes, 0, rest);
                    //fileStream.Write(fileBytes, 0, rest);
                    //if (FileReceiveProgress != null) FileReceiveProgress(1);

                    #region
                    int fileSize = (int)FileSize;
                    byte[] fileBytes = new byte[fileSize];
                    stream.Read(fileBytes, 0, fileSize);
                    fileStream.Write(fileBytes, 0, fileSize);
                    if (FileReceiveProgress != null) FileReceiveProgress(1);
                    #endregion
                }
            }

            //File received complete
            if (FileReceivedComplete != null) FileReceivedComplete();
        }
    }
}
