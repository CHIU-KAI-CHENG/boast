using project3.Properties;
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
    public partial class declare : Form
    {
        GameInfo talk;
        TcpClient client;
        NetworkStream stream;
        MyID ID;
        Byte[] mainByte;

        int tmp_number;
        bool select = true;

        public declare(GameInfo info,TcpClient client,MyID ID)
        {
            InitializeComponent();

            this.talk = info;
            this.client = client;
            this.stream = this.client.GetStream();
            this.ID = ID;



            //send 老師資訊
            mainByte = new byte[client.SendBufferSize];
            mainByte = talk.GameInfoToBytes();
            stream.Write(mainByte, 0, mainByte.Length);



            //recv 所有人基本資料
            GameInfo tmp;
            mainByte = new byte[client.ReceiveBufferSize];
            stream.Read(mainByte, 0, mainByte.Length);
            tmp = talk.BytesToGameInfo(mainByte);
            Array.Copy(tmp.AllName, talk.AllName, tmp.AllName.Length);
            Array.Copy(tmp.AllTeacher, talk.AllTeacher, tmp.AllTeacher.Length);
            talk.MaxPlayer = tmp.MaxPlayer;


            MyDice1Pic.Image = GetDiceImage(talk.Dice[ID.ID, 0]);
            MyDice2Pic.Image = GetDiceImage(talk.Dice[ID.ID, 1]);
            MyDice3Pic.Image = GetDiceImage(talk.Dice[ID.ID, 2]);
            MyDice4Pic.Image = GetDiceImage(talk.Dice[ID.ID, 3]);
            MyDice5Pic.Image = GetDiceImage(talk.Dice[ID.ID, 4]);
            MyDice6Pic.Image = GetDiceImage(talk.Dice[ID.ID, 5]);


            for (int i = 0; i < talk.MaxPlayer; i++)
            {
                int tmpID = (ID.ID + i)% talk.MaxPlayer;
                
                if(i == 0)
                {
                    MyNameLabel.Text = talk.AllName[tmpID];
                    switch (talk.AllTeacher[tmpID])
                    {
                        case TeacherPhoto.玉山:
                            MyPic.Image = Image.FromFile(NTPUTeacher.teacher_str[1] + ".jpg");
                            break;
                        case TeacherPhoto.伯星:
                            MyPic.Image = Image.FromFile(NTPUTeacher.teacher_str[2] + ".jpg");
                            break;
                        case TeacherPhoto.東穎:
                            MyPic.Image = Image.FromFile(NTPUTeacher.teacher_str[3] + ".jpg");
                            break;
                        case TeacherPhoto.俊元:
                            MyPic.Image = Image.FromFile(NTPUTeacher.teacher_str[4] + ".jpg");
                            break;
                        case TeacherPhoto.致芳:
                            MyPic.Image = Image.FromFile(NTPUTeacher.teacher_str[5] + ".jpg");
                            break;
                        case TeacherPhoto.裕賢:
                            MyPic.Image = Image.FromFile(NTPUTeacher.teacher_str[6] + ".jpg");
                            break;
                    }
                }
                else if(i == 1)
                {
                    OtherName1Label.Text = talk.AllName[tmpID];
                    switch (talk.AllTeacher[tmpID])
                    {
                        case TeacherPhoto.玉山:
                            OtherPic1.Image = Image.FromFile(NTPUTeacher.teacher_str[1] + ".jpg");
                            break;
                        case TeacherPhoto.伯星:
                            OtherPic1.Image = Image.FromFile(NTPUTeacher.teacher_str[2] + ".jpg");
                            break;
                        case TeacherPhoto.東穎:
                            OtherPic1.Image = Image.FromFile(NTPUTeacher.teacher_str[3] + ".jpg");
                            break;
                        case TeacherPhoto.俊元:
                            OtherPic1.Image = Image.FromFile(NTPUTeacher.teacher_str[4] + ".jpg");
                            break;
                        case TeacherPhoto.致芳:
                            OtherPic1.Image = Image.FromFile(NTPUTeacher.teacher_str[5] + ".jpg");
                            break;
                        case TeacherPhoto.裕賢:
                            OtherPic1.Image = Image.FromFile(NTPUTeacher.teacher_str[6] + ".jpg");
                            break;
                    }
                }
                else if (i == 2)
                {
                    OtherName2Label.Text = talk.AllName[tmpID];
                    switch (talk.AllTeacher[tmpID])
                    {
                        case TeacherPhoto.玉山:
                            OtherPic2.Image = Image.FromFile(NTPUTeacher.teacher_str[1] + ".jpg");
                            break;
                        case TeacherPhoto.伯星:
                            OtherPic2.Image = Image.FromFile(NTPUTeacher.teacher_str[2] + ".jpg");
                            break;
                        case TeacherPhoto.東穎:
                            OtherPic2.Image = Image.FromFile(NTPUTeacher.teacher_str[3] + ".jpg");
                            break;
                        case TeacherPhoto.俊元:
                            OtherPic2.Image = Image.FromFile(NTPUTeacher.teacher_str[4] + ".jpg");
                            break;
                        case TeacherPhoto.致芳:
                            OtherPic2.Image = Image.FromFile(NTPUTeacher.teacher_str[5] + ".jpg");
                            break;
                        case TeacherPhoto.裕賢:
                            OtherPic2.Image = Image.FromFile(NTPUTeacher.teacher_str[6] + ".jpg");
                            break;
                    }
                }
                else if (i == 3)
                {
                    OtherName3Label.Text = talk.AllName[tmpID];
                    switch (talk.AllTeacher[tmpID])
                    {
                        case TeacherPhoto.玉山:
                            OtherPic3.Image = Image.FromFile(NTPUTeacher.teacher_str[1] + ".jpg");
                            break;
                        case TeacherPhoto.伯星:
                            OtherPic3.Image = Image.FromFile(NTPUTeacher.teacher_str[2] + ".jpg");
                            break;
                        case TeacherPhoto.東穎:
                            OtherPic3.Image = Image.FromFile(NTPUTeacher.teacher_str[3] + ".jpg");
                            break;
                        case TeacherPhoto.俊元:
                            OtherPic3.Image = Image.FromFile(NTPUTeacher.teacher_str[4] + ".jpg");
                            break;
                        case TeacherPhoto.致芳:
                            OtherPic3.Image = Image.FromFile(NTPUTeacher.teacher_str[5] + ".jpg");
                            break;
                        case TeacherPhoto.裕賢:
                            OtherPic3.Image = Image.FromFile(NTPUTeacher.teacher_str[6] + ".jpg");
                            break;
                    }
                }
                
            }

            backgroundWorker1.RunWorkerAsync();

        }

        private static Image GetDiceImage(int index)
        {
            switch (index)
            {
                case 1:
                    return Resources.dice1;
                case 2:
                    return Resources.dice2;
                case 3:
                    return Resources.dice3;
                case 4:
                    return Resources.dice4;
                case 5:
                    return Resources.dice5;
                case 6:
                    return Resources.dice6;
                default:
                    return GetDiceImage(index);
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            DicePanel.Visible = true;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            MyDicePic.Image = OnePic.Image;
            tmp_number = 1;
            DicePanel.Visible = false;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            MyDicePic.Image = TwoPic.Image;
            tmp_number = 2;
            DicePanel.Visible = false;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            MyDicePic.Image = ThreePic.Image;
            tmp_number = 3;
            DicePanel.Visible = false;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            MyDicePic.Image = FourPic.Image;
            tmp_number = 4;
            DicePanel.Visible = false;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            MyDicePic.Image = FivePic.Image;
            tmp_number = 5;
            DicePanel.Visible = false;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            MyDicePic.Image = SixPic.Image;
            tmp_number = 6;
            DicePanel.Visible = false;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && !DicePanel.Visible && (GetLabelText(comboBox1.Text) > talk.DiceAmount || (GetLabelText(comboBox1.Text) == talk.DiceAmount && tmp_number > talk.DiceNum)))
            {
                talk.DiceNum = tmp_number;
                switch (comboBox1.Text)
                {
                    case "1":
                        talk.DiceAmount = 1;
                        label6.Text = "1    個";
                        break;
                    case "2":
                        talk.DiceAmount = 2;
                        label6.Text = "2    個";
                        break;
                    case "3":
                        talk.DiceAmount = 3;
                        label6.Text = "3    個";
                        break;
                    case "4":
                        talk.DiceAmount = 4;
                        label6.Text = "4    個";
                        break;
                    case "5":
                        talk.DiceAmount = 5;
                        label6.Text = "5    個";
                        break;
                    case "6":
                        talk.DiceAmount = 6;
                        label6.Text = "6    個";
                        break;
                    case "7":
                        talk.DiceAmount = 7;
                        label6.Text = "7    個";
                        break;
                    case "8":
                        talk.DiceAmount = 8;
                        label6.Text = "8    個";
                        break;
                    case "9":
                        talk.DiceAmount = 9;
                        label6.Text = "9    個";
                        break;
                    case "10":
                        talk.DiceAmount = 10;
                        label6.Text = "10   個";
                        break;
                    case "11":
                        talk.DiceAmount = 11;
                        label6.Text = "11   個";
                        break;
                    case "12":
                        talk.DiceAmount = 12;
                        label6.Text = "12   個";
                        break;
                }

                //送出喊得資訊
                /*
                mainByte = new byte[client.SendBufferSize];
                mainByte = talk.GameInfoToBytes();
                stream.Write(mainByte, 0, mainByte.Length);
                */
                select = false;
            }
        }

        private int GetLabelText(string text)
        {
            switch (text)
            {
                case "1":
                    return 1;
                case "2":
                    return 2;
                case "3":
                    return 3;
                case "4":
                    return 4;
                case "5":
                    return 5;
                case "6":
                    return 6;
                case "7":
                    return 7;
                case "8":
                    return 8;
                case "9":
                    return 9;
                case "10":
                    return 10;
                case "11":
                    return 11;
                case "12":
                    return 12;
                default:
                    return GetLabelText(text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            talk.WhoGrab = ID.ID;
            talk.WhoGrabed = talk.NowDec;

            mainByte = new byte[client.SendBufferSize];
            mainByte = talk.GameInfoToBytes();
            stream.Write(mainByte, 0, mainByte.Length);

            GrabButton.Visible = false;
            NotGrabButton.Visible = false;


            this.Close();       //目前先幫你設定關閉
        }

        private void ToDeclare()
        {
            MyDeclareLabel.Visible = true;
            comboBox1.Visible = true;
            numLabel.Visible = true;
            MyDicePic.Visible = true;
            declareSendButton.Visible = true;



        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int MyNowDec;
            int MyNextDec;
            Byte[] myByte;
            while (true)
            {

                //MessageBox.Show(talk.NowDec + "");
                MyNowDec = talk.NowDec;
                //判斷是不是輪到自己
                if (talk.NowDec == ID.ID)
                {
                    backgroundWorker1.ReportProgress(0);//顯示喊控制項
                    select = true;
                    while (select)
                    {

                    }
                    backgroundWorker1.ReportProgress(1);//隱藏喊控制項

                    myByte = new byte[client.SendBufferSize];
                    myByte = talk.GameInfoToBytes();
                    stream.Write(myByte, 0, myByte.Length);

                    
                }
                else    //只好等別人喊
                {
                    backgroundWorker1.ReportProgress(4);
                }

                MyNowDec = talk.NowDec;


                //Recv三次喊或不抓   若是抓就結束
                for(int i = 0; i < talk.MaxPlayer ; i++)
                {
                    myByte = new byte[client.ReceiveBufferSize];
                    stream.Read(myByte, 0, client.ReceiveBufferSize);
                    talk.BytesToGameInfo(myByte);

                    MyNowDec = talk.NowDec;
                    //自己只要recv三個抓或不抓

                    if (MyNowDec == ID.ID)
                    {
                        //MessageBox.Show(talk.WhoGrab + "");
                        backgroundWorker1.ReportProgress(3);
                    }
                    else{//不是自己喊的
                        //要先接收別人喊的
                        if (i == 0)
                        {
                            
                            //MessageBox.Show(talk.DiceAmount +"個"+ talk.DiceNum +"點");
                            backgroundWorker1.ReportProgress(2);//別人喊了我要做抓或不抓

                            

                        }
                        else//再來接收別人抓或不抓
                        {
                            //MessageBox.Show(talk.WhoGrab + "");
                            backgroundWorker1.ReportProgress(3);//我還要另外收別人的抓或不抓
                        }
                    }



                    //
                    if(talk.WhoGrab != -1)
                    {
                        backgroundWorker1.ReportProgress(5);
                        return;
                    }
                }
                
                
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            if(e.ProgressPercentage == 0)
            {
                //MyDeclareLabel.Visible = true;
                MyDeclareLabel.Text = "你想要喊:";
                comboBox1.Visible = true;
                numLabel.Visible = true;
                MyDicePic.Visible = true;
                declareSendButton.Visible = true;
            }
            else if(e.ProgressPercentage == 1)
            {
                //MyDeclareLabel.Visible = false;
                MyDeclareLabel.Text = "等待其他角色動作";
                comboBox1.Visible = false;
                numLabel.Visible = false;
                MyDicePic.Visible = false;
                declareSendButton.Visible = false;
            }
            else if (e.ProgressPercentage == 2)
            {
                GrabButton.Visible = true;
                NotGrabButton.Visible = true;

                P2notGrabLabel.Visible = false;
                P3notGrabLabel.Visible = false;
                P4notGrabLabel.Visible = false;

            }
            else if (e.ProgressPercentage == 3) //將別人喊的不抓作轉換
            {
                

                int count = 0;
                for(int i = 1; i < talk.MaxPlayer; i++){
                    count++;
                    int tmp = (ID.ID + i) % talk.MaxPlayer;

                    if (talk.WhoNotGrab == tmp)
                    {
                        switch (count)
                        {
                            case 1:
                                P2notGrabLabel.Visible = true;
                                break;
                            case 2:
                                P3notGrabLabel.Visible = true;
                                break;
                            case 3:
                                P4notGrabLabel.Visible = true;
                                break;
                        }
                    }
                }  

            }
            else if (e.ProgressPercentage == 4)
            {
                MyDeclareLabel.Text = "等待其他角色動作";
            }
            else if (e.ProgressPercentage == 5)
            {
                this.Close();
            }
            
        }

        private void NotGrabButton_Click(object sender, EventArgs e)
        {
            talk.WhoNotGrab = ID.ID;

            mainByte = new byte[client.SendBufferSize];
            mainByte = talk.GameInfoToBytes();
            stream.Write(mainByte, 0, mainByte.Length);


            GrabButton.Visible = false;
            NotGrabButton.Visible = false;
        }
    }
}
