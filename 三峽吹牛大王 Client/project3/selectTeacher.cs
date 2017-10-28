using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Information;
using System.Net.Sockets;

namespace project3
{
    public partial class BlowerSelectForm : Form
    {
        GameInfo info;
        string serverIP;
        int teacherNum;
        TcpClient client;
        MyID ID;

        public BlowerSelectForm(GameInfo info,TcpClient client,MyID ID)
        {
            InitializeComponent();
            this.info = info;
            this.client = client;
            this.ID = ID;
        }

        private void BlowerSelectForm_Load(object sender, EventArgs e)
        {

        }

        private void SelectTecher(TNum teacher)
        {
            if (P1ReadyButton.Enabled == true)
            {
                headLabel.Text = "頭像:" + NTPUTeacher.teacher_str[(int)teacher];
                teacherNum = (int)teacher - 1;
                playerImg1.Image = Image.FromFile(NTPUTeacher.teacher_str[(int)teacher] + ".jpg");
                P1_name.Text = teacher.ToString();
            }
        }

        private void P1ReadyButton_Click(object sender, EventArgs e)
        {
            if (NameTexstBox.Text.Equals(""))
            {
                MessageBox.Show("請輸入你的名子");
                return;
            }

            if (serverIpTextBox.Text.Equals(""))
            {
                serverIpTextBox.Text = "10.201.5.94";
            }

            info.MyName = NameTexstBox.Text;
            info.MyTeacher = (TeacherPhoto)teacherNum;
            serverIP = serverIpTextBox.Text;

            P1NameLabel.Text = "吹牛者:" + info.MyName;
            IPlabel.Text = "IP:" + serverIP;

            P1NameLabel.Visible = true;
            IPlabel.Visible = true;
            headLabel.Visible = true;

            teacher1.Enabled = false;
            teacher2.Enabled = false;
            teacher3.Enabled = false;
            teacher4.Enabled = false;
            teacher5.Enabled = false;
            teacher6.Enabled = false;

            gameStartButton.Enabled = true;


        }

        private void teacher1_Click(object sender, EventArgs e)
        {
            P1ReadyButton.Enabled = true;
            SelectTecher(TNum.玉山);
           
        }

        private void teacher2_Click(object sender, EventArgs e)
        {
            P1ReadyButton.Enabled = true;
            SelectTecher(TNum.伯星);
            
        }

        private void teacher3_Click(object sender, EventArgs e)
        {
            P1ReadyButton.Enabled = true;
            SelectTecher(TNum.東穎);
            
        }

        private void teacher4_Click(object sender, EventArgs e)
        {
            P1ReadyButton.Enabled = true;
            SelectTecher(TNum.俊元);
            
        }

        private void teacher5_Click(object sender, EventArgs e)
        {
            P1ReadyButton.Enabled = true;
            SelectTecher(TNum.致芳);
            
        }

        private void teacher6_Click(object sender, EventArgs e)
        {
            P1ReadyButton.Enabled = true;
            SelectTecher(TNum.裕賢);
            
        }

        private void ResetTeacherButton_Click(object sender, EventArgs e)
        {
            playerImg1.Image = null;
            P1ReadyButton.Enabled = false;
            gameStartButton.Enabled = false;
            P1NameLabel.Visible = false;
            IPlabel.Visible = false;
            headLabel.Visible = false;
            P1_name.Text = "無";

            teacher1.Enabled = true;
            teacher2.Enabled = true;
            teacher3.Enabled = true;
            teacher4.Enabled = true;
            teacher5.Enabled = true;
            teacher6.Enabled = true;
        }

        private void msgSendButton_Click(object sender, EventArgs e)
        {
        }

        private void gameStartButton_Click(object sender, EventArgs e)
        {
            try
            {
                client.Connect(serverIP, 5200);
            }
            catch
            {
                MessageBox.Show("輸入的serverIP無法連接");
                return;
            }

            ID.ID = recvInt();

            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public int recvInt()
        {
            Byte[] mainBytes = new Byte[client.ReceiveBufferSize];
            NetworkStream stream = client.GetStream();
            stream.Read(mainBytes, 0, client.ReceiveBufferSize);
            stream.Flush();
            return BitConverter.ToInt32(mainBytes, 0);
        }
    }
}
