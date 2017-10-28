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
    public partial class end_form : Form
    {
        Random rand = new Random();

        Bool inTheGame;

        GameInfo talk;
        TcpClient client;
        MyID myID;

        int[] total;
        int lose= -1 ;
        int win = -1;
        bool result = true;

        public end_form(GameInfo info,TcpClient client,MyID ID)
        {
            InitializeComponent();
            this.talk = info;
            this.client = client;
            myID = ID;
            total = new int[6];
        }

        private void end_form_Load(object sender, EventArgs e)
        {
            Random rand = new Random();

            judge();

            int n = rand.Next(13);

            switch (n)
            {
                case 0:
                    words.Text = "賭場是一個黑暗的世界，我希望成為這個黑暗世界裡的一盞明燈。" +
                        Environment.NewLine + " 雖然我無法照亮整個黑暗世界，但是只要有我存在的一天，" +
                        Environment.NewLine + "就要讓這個黑暗的世界看到光明。";
                    break;
                case 1:
                    words.Text = "沒有人能靠賭博發財的，贏來的錢都不當錢花，來得快去得快。";
                    break;
                case 2:
                    words.Text = "勸君莫把賭博沾，賭博是個害人灘，" +
                        Environment.NewLine + "害你下灘翻了船，害你妻離家又散，" +
                        Environment.NewLine + "勸君莫講賭博強，賭博發財理不當，" +
                        Environment.NewLine + "輸了錢來偷和搶，國法判你進牢房。";
                    break;
                case 3:
                    words.Text = "“小賭怡情，大賭要命”，" +
                        Environment.NewLine + "其實，大賭就是從小賭開始的。";
                    break;
                case 4:
                    words.Text = "曾俊元是大帥哥!!!!!!";
                    break;
                case 5:
                    words.Text = "要戒賭，就得與兩個敵人作鬥爭" +
                                Environment.NewLine + "，一是自己內心的賭癮，二是周圍的環境。";
                    break;
                case 6:
                    words.Text = "張紘輪好醜，張紘輪好醜，張紘輪好醜，" +
                        Environment.NewLine + "張紘輪好醜，張紘輪好醜，張紘輪好醜。";
                    break;
                case 7:
                    words.Text = "賭賭賭你可想過你的父母，撈撈撈你可想過兒女書包。";
                    break;
                case 8:
                    words.Text = "豬的媽媽一直向馬求愛" + Environment.NewLine +
                                 "快把馬逼瘋" +
                                  Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine 
                                  + "                                                                               豬母讓馬瘋";
                    break;
                case 9:
                    words.Text = "最有意思的是一副春聯：一元、二元、三元，" +
                        Environment.NewLine + "元元都是血汗錢。" +
                        Environment.NewLine + "兒子、妻子、房子，子子都是家中寶。";
                    break;
                case 10:
                    words.Text = "賭賭賭親朋好友齊上陣，輸輸輸兄弟反目不認人" +
                        Environment.NewLine + "，衝衝衝蘇貞昌~。";
                    break;
                case 11:
                    words.Text = "關關難過.但關關不說 想入非非.但非非不肯 天天想你.天天問自己" +
                        Environment.NewLine + " 絮絮不休.但絮絮累了惶惶不安.但惶惶不說 年年有魚.但年年不賣 " +
                        Environment.NewLine + " 步步高升.但步步懼高 天天開心.但天天不好笑 心有戚戚焉.戚戚不給醃 " +
                       Environment.NewLine + "  昏昏欲睡.但昏昏得熬夜 亭亭預立.但亭亭站不起 嚇嚇有名.但嚇嚇搞排聞 ";
                    break;
                case 12:
                    words.Text = "十個賭徒九個輸，傾家蕩產不如豬。" +
                        Environment.NewLine + "你我從豬開始做起 ^ __ ^ ";
                    break;
            }
            //-----------------------------------------------------------------------------------------------------------------------



            switch (talk.AllTeacher[talk.WhoGrab])
            {
                case TeacherPhoto.玉山:
                    playerImg1.Image = Properties.Resources.玉山;
                    label1.Text = "玉山";
                    break;
                case TeacherPhoto.東穎:
                    playerImg1.Image = Properties.Resources.東穎;
                    label1.Text = "東穎";
                    break;
                case TeacherPhoto.伯星:
                    playerImg1.Image = Properties.Resources.伯星;
                    label1.Text = "伯星";
                    break;
                case TeacherPhoto.俊元:
                    playerImg1.Image = Properties.Resources.俊元;
                    label1.Text = "俊元";
                    break;
                case TeacherPhoto.致芳:
                    playerImg1.Image = Properties.Resources.致芳;
                    label1.Text = "致芳";
                    break;
                case TeacherPhoto.裕賢:
                    playerImg1.Image = Properties.Resources.裕賢;
                    label1.Text = "裕賢";
                    break;
            }

            switch (talk.AllTeacher[talk.WhoGrabed])
            {
                case TeacherPhoto.玉山:
                    playerImg2.Image = Properties.Resources.玉山;
                    label2.Text = "玉山";
                    break;
                case TeacherPhoto.東穎:
                    playerImg2.Image = Properties.Resources.東穎;
                    label2.Text = "東穎";
                    break;
                case TeacherPhoto.伯星:
                    playerImg2.Image = Properties.Resources.伯星;
                    label2.Text = "伯星";
                    break;
                case TeacherPhoto.俊元:
                    playerImg2.Image = Properties.Resources.俊元;
                    label2.Text = "俊元";
                    break;
                case TeacherPhoto.致芳:
                    playerImg2.Image = Properties.Resources.致芳;
                    label2.Text = "致芳";
                    break;
                case TeacherPhoto.裕賢:
                    playerImg2.Image = Properties.Resources.裕賢;
                    label2.Text = "裕賢";
                    break;
            }
            //-----------------------------------------------------------------------------------------------------------------

            label1.Text = talk.AllName[talk.WhoGrab];//更改
            label2.Text = talk.AllName[talk.WhoGrabed];//更改


            
               
            

            

            for (int i = 0; i < 6; i++)
            {
                switch (i)
                {
                    case 0:
                        myDice1.Image = GetDiceImage(talk.Dice[talk.WhoGrab,0]);
                        oppDice1.Image = GetDiceImage(talk.Dice[talk.WhoGrabed, 0]);
                        break;
                    case 1:
                        myDice2.Image = GetDiceImage(talk.Dice[talk.WhoGrab,1]);
                        oppDice2.Image = GetDiceImage(talk.Dice[talk.WhoGrabed, 1]);
                        break;
                    case 2:
                        myDice3.Image = GetDiceImage(talk.Dice[talk.WhoGrab,2]);
                        oppDice3.Image = GetDiceImage(talk.Dice[talk.WhoGrabed, 2]);
                        break;
                    case 3:
                        myDice4.Image = GetDiceImage(talk.Dice[talk.WhoGrab,3]);
                        oppDice4.Image = GetDiceImage(talk.Dice[talk.WhoGrabed, 3]);
                        break;
                    case 4:
                        myDice5.Image = GetDiceImage(talk.Dice[talk.WhoGrab,4]);
                        oppDice5.Image = GetDiceImage(talk.Dice[talk.WhoGrabed, 4]);
                        break;
                    case 5:
                        myDice6.Image = GetDiceImage(talk.Dice[talk.WhoGrab,5]);
                        oppDice6.Image = GetDiceImage(talk.Dice[talk.WhoGrabed, 5]);
                        break;
                }
            }
        }
        void SetTotalPoint()
        {
       
            for (int i = 0; i < talk.MaxPlayer; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    switch (talk.Dice[i, j])
                    {
                        case 1:
                            total[0]++;
                            total[1]++;
                            total[2]++;
                            total[3]++;
                            total[4]++;
                            total[5]++;
                            break;
                        case 2:
                            total[1]++;
                            break;
                        case 3:
                            total[2]++;
                            break;
                        case 4:
                            total[4]++;
                            break;
                        case 5:
                            total[5]++;
                            break;
                        case 6:
                            total[6]++;
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        private static Image GetDiceImage(int index)
        {
            switch (index)
            {
                case 1:
                    return Properties.Resources.dice1;
                case 2:
                    return Properties.Resources.dice2;
                case 3:
                    return Properties.Resources.dice3;
                case 4:
                    return Properties.Resources.dice4;
                case 5:
                    return Properties.Resources.dice5;
                case 6:
                    return Properties.Resources.dice6;
                default:
                    return GetDiceImage(index);
            }
        }

        private void again_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            end_form end = this;

            inTheGame.inTheGame = false;

            end.Close();
        }

        private void sendMesButton_Click(object sender, EventArgs e)
        {
            textBox.AppendText("ID:" + message.Text + Environment.NewLine);
            message.Clear();
        }

        private void message_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBox.AppendText("ID:" + message.Text + Environment.NewLine);
                message.Clear();
            }
        }

        public void judge()
        {
            if (talk.DiceAmount > GetOnePoint(talk.DiceNum))
            {   
                win = talk.WhoGrab;
                lose = talk.WhoGrabed;
                result = true;
            }
            else
            {
                win = talk.WhoGrabed;
                lose = talk.WhoGrab;
                result = false;
            }


            if (result)      //更改
            {
                player1Head.Image = Properties.Resources.crown;
                player2Head.Image = Properties.Resources.popo;
                textBox.AppendText(talk.AllName[talk.WhoGrabed] + ":喊了" + talk.DiceAmount + "個" + talk.DiceNum + Environment.NewLine);
                textBox.AppendText(talk.AllName[talk.WhoGrab] + "獲勝" + Environment.NewLine);
            }
            else
            {
                player1Head.Image = Properties.Resources.popo;
                player2Head.Image = Properties.Resources.crown;
                textBox.AppendText(talk.AllName[talk.WhoGrabed] + ":喊了" + talk.DiceAmount + "個" + talk.DiceNum + Environment.NewLine);
                textBox.AppendText(talk.AllName[talk.WhoGrabed] + "獲勝" + Environment.NewLine);
            }
        }
        //--------------------------------------------------------------------------------------------------------------
        public int GetOnePoint(int num)
        {
            return total[num];
        }

        //--------------------------------------------------------------------------------------------------------------

        private void button1_Click(object sender, EventArgs e)
        {
            textBox.AppendText("ID:" + "再來阿!!!" + Environment.NewLine);
            message.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox.AppendText("ID:" + "阿不是很會吹?" + Environment.NewLine);
            message.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox.AppendText("ID:" + "我阿罵都比你厲害!!!" + Environment.NewLine);
            message.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox.AppendText("ID:" + "腦袋是很棒的東西，真希望你也有一個" + Environment.NewLine);
            message.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox.AppendText("ID:" + "寶寶很強，但寶寶不說" + Environment.NewLine);
            message.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox.AppendText("ID:" + "紘綸是帥哥" + Environment.NewLine);
            message.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox.AppendText("ID:" + "我要把你的腦袋格式化" + Environment.NewLine);
            message.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox.AppendText("ID:" + "張晏誠好醜" + Environment.NewLine);
            message.Clear();
        }
    }
}
