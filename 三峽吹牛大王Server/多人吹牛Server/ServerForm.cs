using Information;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 多人吹牛Server
{
    public partial class ServerForm : Form
    {
        TcpListener Listener;
        List<TcpClient> Clients;
        List<NetworkStream> ClientStreams;
        GameInfo AllInfo;

        BackgroundWorker[] RcvGrabBckWrkr;

        public ServerForm()
        {
            InitializeComponent();
            AllInfo = new GameInfo();
        }

        private void StartListening()//接收Client的連接
        {
            Listener = new TcpListener(IPAddress.Any, 5200);
            Listener.Start();//開始偵測Client的連接
        }

        private void MaxPlayerBtn_Click(object sender, EventArgs e)
        {
            MaxPlayerBtn.Dispose();
            MaxPlayerCmbBox.Enabled = false;

            switch (MaxPlayerCmbBox.Text)
            {
                case "2人":
                    AllInfo.MaxPlayer = 2;
                    break;
                case "3人":
                    AllInfo.MaxPlayer = 3;
                    break;
                case "4人":
                    AllInfo.MaxPlayer = 4;
                    break;
            }

            Clients = new List<TcpClient>(AllInfo.MaxPlayer);//開兩個TcpClient的List準備接收兩個Client連接
            ClientStreams = new List<NetworkStream>(AllInfo.MaxPlayer);
            RcvGrabBckWrkr = new BackgroundWorker[AllInfo.MaxPlayer];
            
            StartListening();
            AcptRcvBckWrkr.RunWorkerAsync();
        }

        private void ThrowDice()
        {
            Random rnd = new Random();
            for (int i = 0; i < AllInfo.MaxPlayer; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    AllInfo.Dice[i, j] = rnd.Next(1, 7);
                }
            }
        }

        private void AcptClntsSndIDs()
        {
            for (int i = 0; i < AllInfo.MaxPlayer; i++)
            {
                //連接Clients
                Clients.Add(Listener.AcceptTcpClient());
                ClientStreams.Add(Clients[i].GetStream());
                ClientStreams[i].Flush();
                //寄送ID
                Byte[] SndIDBuf = new Byte[Clients[i].SendBufferSize];
                SndIDBuf = BitConverter.GetBytes(i);
                ClientStreams[i].Write(SndIDBuf, 0, SndIDBuf.Length);
            }
        }

        private void RcvNamePhoto()
        {
            for(int i=0;i<AllInfo.MaxPlayer;i++)
            {
                GameInfo TmpInfo;
                Byte[] RcvNameBuf = new Byte[Clients[i].ReceiveBufferSize];
                ClientStreams[i].Read(RcvNameBuf, 0, RcvNameBuf.Length);
                TmpInfo = AllInfo.BytesToGameInfo(RcvNameBuf);

                AllInfo.AllName[i] = TmpInfo.MyName;
                AllInfo.AllTeacher[i] = TmpInfo.MyTeacher;
            }
        }

        private void SndInfoBeforeGame()
        {
            ThrowDice();
            for (int i = 0; i < AllInfo.MaxPlayer; i++)
            {
                Byte[] SndInfo = new Byte[Clients[i].SendBufferSize];
                SndInfo = AllInfo.GameInfoToBytes();
                ClientStreams[i].Write(SndInfo, 0, SndInfo.Length);
            }
        }

        private void RcvInfoInGame()
        {
            Byte[] RcvInfoBuf = new Byte[Clients[AllInfo.NowDec].ReceiveBufferSize];
            ClientStreams[AllInfo.NowDec].Read(RcvInfoBuf, 0, RcvInfoBuf.Length);
            AllInfo.BytesToGameInfo(RcvInfoBuf);
        }

        private void SndDecInfoInGame()
        {
            for (int i = 0; i < AllInfo.MaxPlayer; i++)
            {
                Byte[] SndInfo = new Byte[Clients[i].SendBufferSize];
                SndInfo = AllInfo.GameInfoToBytes();
                ClientStreams[i].Write(SndInfo, 0, SndInfo.Length);
            }
        }

        private void CreateData()
        {
            for (int i = 0; i < AllInfo.MaxPlayer; i++)
            {
                int row = dataGridView1.Rows.Add();

                dataGridView1.Rows[row].Cells[0].Value = row;
                dataGridView1.Rows[row].Cells[1].Value = AllInfo.AllName[row];
                dataGridView1.Rows[row].Cells[2].Value = AllInfo.AllTeacher[row];
            }
        }

        private void FillInData()
        {
            dataGridView1.Rows[AllInfo.NowDec].Cells[3].Value += AllInfo.DiceAmount + "個" + AllInfo.DiceNum + " ";
        }

        private void AcptRcvBckWrkr_DoWork(object sender, DoWorkEventArgs e)
        {
            AcptClntsSndIDs();
            RcvNamePhoto();
        }

        private void AcptRcvBckWrkr_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CreateData();
            SndInfoBeforeGame();
            RcvDecBckWrkr.RunWorkerAsync();
        }

        private void RcvDecBckWrkr_DoWork(object sender, DoWorkEventArgs e)
        {
            RcvInfoInGame();
        }

        private void RcvDecBckWrkr_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FillInData();
            SndDecInfoInGame();
            for (int i = 0; i < AllInfo.MaxPlayer ; i++)
            {
                RcvGrabBckWrkr[i] = new BackgroundWorker();
                if (i == AllInfo.NowDec)
                {
                    continue;
                }                
                switch(i)
                {
                    case 0:
                        RcvGrabBckWrkr[i].DoWork += RcvGrabBckWrkr1_DoWork;
                        RcvGrabBckWrkr[i].RunWorkerCompleted += RcvGrabBckWrkr_RunWorkerCompleted;
                        break;
                    case 1:
                        RcvGrabBckWrkr[i].DoWork += RcvGrabBckWrkr2_DoWork;
                        RcvGrabBckWrkr[i].RunWorkerCompleted += RcvGrabBckWrkr_RunWorkerCompleted;
                        break;
                    case 2:
                        RcvGrabBckWrkr[i].DoWork += RcvGrabBckWrkr3_DoWork;
                        RcvGrabBckWrkr[i].RunWorkerCompleted += RcvGrabBckWrkr_RunWorkerCompleted;
                        break;
                    case 3:
                        RcvGrabBckWrkr[i].DoWork += RcvGrabBckWrkr4_DoWork;
                        RcvGrabBckWrkr[i].RunWorkerCompleted += RcvGrabBckWrkr_RunWorkerCompleted;
                        break;
                }
                RcvGrabBckWrkr[i].RunWorkerAsync();
            }
        }

        private void RcvGrabBckWrkr1_DoWork(object sender, DoWorkEventArgs e)
        {
            Byte[] RcvGrabBuf = new Byte[Clients[0].ReceiveBufferSize];
            ClientStreams[0].Read(RcvGrabBuf, 0, RcvGrabBuf.Length);
            AllInfo.BytesToGameInfo(RcvGrabBuf);
        }

        private void RcvGrabBckWrkr2_DoWork(object sender, DoWorkEventArgs e)
        {
            Byte[] RcvGrabBuf = new Byte[Clients[1].ReceiveBufferSize];
            ClientStreams[1].Read(RcvGrabBuf, 0, RcvGrabBuf.Length);
            AllInfo.BytesToGameInfo(RcvGrabBuf);
        }

        private void RcvGrabBckWrkr3_DoWork(object sender, DoWorkEventArgs e)
        {
            Byte[] RcvGrabBuf = new Byte[Clients[2].ReceiveBufferSize];
            ClientStreams[2].Read(RcvGrabBuf, 0, RcvGrabBuf.Length);
            AllInfo.BytesToGameInfo(RcvGrabBuf);
        }

        private void RcvGrabBckWrkr4_DoWork(object sender, DoWorkEventArgs e)
        {
            Byte[] RcvGrabBuf = new Byte[Clients[3].ReceiveBufferSize];
            ClientStreams[3].Read(RcvGrabBuf, 0, RcvGrabBuf.Length);
            AllInfo.BytesToGameInfo(RcvGrabBuf);
        }

        private void RcvGrabBckWrkr_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (AllInfo.WhoGrab == -1)//沒抓的話
            {
                int CountIsGrab = 0;
                for (int i = 0; i < AllInfo.MaxPlayer;i++ )
                {
                    if (!RcvGrabBckWrkr[i].IsBusy)
                    {
                        CountIsGrab++;
                    }
                }
                if (CountIsGrab == AllInfo.MaxPlayer)
                {
                    int tmp = AllInfo.PreDec;
                    AllInfo.PreDec = AllInfo.NowDec;
                    AllInfo.NowDec = AllInfo.NextDec;
                    if (AllInfo.NextDec == AllInfo.MaxPlayer - 1)
                    {
                        AllInfo.NextDec = 0;
                    }
                    else
                    {
                        AllInfo.NextDec++;
                    }
                    RcvDecBckWrkr.RunWorkerAsync();
                }
                //Send其中一人抓不抓的資訊給大家
                for (int i = 0; i < AllInfo.MaxPlayer; i++)
                {
                    Byte[] SndGrabBuf = new Byte[Clients[i].SendBufferSize];
                    SndGrabBuf = AllInfo.GameInfoToBytes();
                    ClientStreams[i].Write(SndGrabBuf, 0, SndGrabBuf.Length);
                }
            }
            else//有人抓的話
            {
                for (int i = 0; i < AllInfo.MaxPlayer; i++)
                {
                    RcvGrabBckWrkr[i].Dispose();
                    if (i != AllInfo.WhoGrab)
                    {
                        Byte[] SndGrabBuf = new Byte[Clients[i].SendBufferSize];
                        SndGrabBuf = AllInfo.GameInfoToBytes();
                        ClientStreams[i].Write(SndGrabBuf, 0, SndGrabBuf.Length);
                    }
                }
                MessageBox.Show(AllInfo.AllName[AllInfo.WhoGrab] + "抓了" + AllInfo.AllName[AllInfo.WhoGrabed]);
            }
        }
    }
}
