using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
public enum TeacherPhoto { 玉山, 伯星, 東穎, 俊元, 致芳, 裕賢 };
namespace Information
{
    [Serializable]
    public class GameInfo
    {
        public int MaxPlayer;
        public string MyName;
        public string[] AllName = new string[4];
        public TeacherPhoto MyTeacher;
        public TeacherPhoto[] AllTeacher = new TeacherPhoto[4];
        public int[,] Dice = new int[4, 6];
        public int DiceNum;
        public int DiceAmount;
        public int PreDec;
        public int NowDec;
        public int NextDec;
        public int WhoGrab;
        public int WhoGrabed;
        public int WhoNotGrab;

        public GameInfo()
        {
            DiceNum = 1;
            DiceAmount = 0;
            PreDec = -1;
            NowDec = 0;
            NextDec = 1;
            WhoGrab = -1;
            WhoGrabed = -1;
            WhoNotGrab = -1;
        }

        public Byte[] GameInfoToBytes()//將GameInfo轉為Byte[]型態以便傳送
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();

            bf.Serialize(ms, this);//將本類別序列化至ms
            byte[] Bytes = ms.ToArray();
            ms.Close();
            return Bytes;
        }

        public GameInfo BytesToGameInfo(Byte[] BytesOfPacket)//將接收到的Byte[]轉為GameInfo型態以便存取
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream(BytesOfPacket);//將BytesOfGameInfo初始化

            GameInfo TmpPkt = (GameInfo)bf.Deserialize(ms);//將ms解序列化至TmpPkt
            ms.Close();

            this.MyName = TmpPkt.MyName;
            this.MyTeacher = TmpPkt.MyTeacher;
            this.DiceNum = TmpPkt.DiceNum;
            this.DiceAmount = TmpPkt.DiceAmount;
            this.PreDec = TmpPkt.PreDec;
            this.NowDec = TmpPkt.NowDec;
            this.NextDec = TmpPkt.NextDec;
            this.WhoGrab = TmpPkt.WhoGrab;
            this.WhoGrabed = TmpPkt.WhoGrabed;
            this.Dice = TmpPkt.Dice;
            this.WhoNotGrab = TmpPkt.WhoNotGrab;

            return TmpPkt;
        }
    }
}
