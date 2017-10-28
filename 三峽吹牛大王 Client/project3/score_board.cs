using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project3
{


    public class score_board
    {
        
        public NTPUTeacher[] player;
        private int currentPlayer;

        public score_board()
        {
            currentPlayer = 0;
        }

        public score_board(NTPUTeacher new_teacher)
        {
            player = new NTPUTeacher[1];

            player[0] = new_teacher;

            currentPlayer = 1;
        }

        public bool LoginNewTeacher(NTPUTeacher new_teacher)
        {
            if(new_teacher.name_value == "" /*|| new_teacher.name_value == ""*/)  //兩個其中一個沒有填
            {
                return false;
            }

            currentPlayer++;
            Array.Resize(ref player, currentPlayer);

            player[currentPlayer - 1] = new_teacher;

            return true;
        }

        public bool LoginNewTeacher(NTPUTeacher[] new_teacher)
        {
            for (int i = 0; i < new_teacher.Count();i++) { 
                if (new_teacher[i].name_value == "" /*|| new_teacher.name_value == ""*/)  //兩個其中一個沒有填
                {
                    return false;
                }
            }

            for (int i = 0; i < new_teacher.Count(); i++)
            {
                currentPlayer++;
                Array.Resize(ref player, currentPlayer);

                player[currentPlayer - 1] = new_teacher[i];
            }


            return true;
        }

        public void Synchronize_ScoreBoard()
        {

        }
        //------------------------------------------------------以下為scoreboard新增
        int[] total = new int[] { 0, 0, 0, 0, 0, 0, 0 };//可放到最上面


        public bool judge(declareInfo talk)
        {
            if (talk.d_amount > GetOnePoint(talk.d_number))
            {
                if (talk.whoDec == true)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else {
                if (talk.whoDec == false)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public int GetOnePoint(int num)
        {
            return total[num];
        }

        void SetTotalPoint()
        {
            for (int i = 1; i <= 6; i++)
            {
                switch (player[0].Dices_value[i])
                {
                    case 1:
                        total[1]++;
                        total[2]++;
                        total[3]++;
                        total[4]++;
                        total[5]++;
                        total[6]++;
                        break;
                    case 2:
                        total[2]++;
                        break;
                    case 3:
                        total[3]++;
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
                switch (player[1].Dices_value[i])
                {
                    case 1:
                        total[1]++;
                        total[2]++;
                        total[3]++;
                        total[4]++;
                        total[5]++;
                        total[6]++;
                        break;
                    case 2:
                        total[2]++;
                        break;
                    case 3:
                        total[3]++;
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
    
}
