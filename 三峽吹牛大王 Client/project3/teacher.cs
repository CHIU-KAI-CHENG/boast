using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project3
{
    public enum TNum { 無,玉山,伯星,東穎,俊元,致芳,裕賢}

    public class NTPUTeacher
    {
        public static string[] teacher_str =
        {
            "無","玉山","伯星","東穎","俊元","致芳","裕賢"
        };

        private string IP;
        private string name;
        private TNum teacher_num;
        private int[] Dices;
        private Talk talk;

        //public methods
        public NTPUTeacher()
        {
            IP = "";
            name = "";
            teacher_num = TNum.無;
            Dices = new int[] { 0, 0, 0, 0, 0, 0 };
        }

        public void Declare(int amount,int number)
        {
            talk.d_amount = amount;
            talk.d_number = number;
            talk.who_Dec = (talk.who_Dec) % 2 + 1;  // 1 -> 2, 2 -> 1
        }
        public void Grab()
        {
            talk.isGrab = true;
            talk.who_Grab = talk.who_Dec;
            talk.who_Grabed = 2 - (3 - talk.who_Dec) % 2;   // 2 -> 1, 1 -> 2

        }

        public string IP_value
        {
            set { IP = value; }
            get { return IP; }
        }

        public string name_value
        {
            set { name = value; }
            get { return name; }
        }
        public TNum teacher_value
        {
            set { teacher_num = value; }
            get { return teacher_num; }
        }
        public int[] Dices_value
        {
            set { Array.Copy(value, Dices, 6); }
            get
            {
                int[] tempDices = new int[6];

                Array.Copy(Dices, tempDices, 6);

                return tempDices;
            }
        }
    }

    class Talk
    {
        public bool isGrab;
        public int d_amount;
        public int d_number;
        public int who_Dec;
        public int who_Grab;
        public int who_Grabed;

        public Talk()
        {
            isGrab = false;
            d_amount = 0;
            d_number = 0;
            who_Dec = 1;
            who_Grab = 0;
            who_Grabed = 0;
        }
    }
}
