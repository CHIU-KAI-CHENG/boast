using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Information;
using System.Net.Sockets;

namespace project3
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            Bool inTheGame = new Bool();
            TcpClient client = new TcpClient();
            MyID ID = new MyID();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //while (inTheGame.inTheGame)
            //{

                GameInfo info = new GameInfo();
                ServerIP serverIP = new ServerIP();

                Application.Run(new start_form());
                Application.Run(new BlowerSelectForm(info, client, ID));
                Application.Run(new declare(info, client, ID));
                Application.Run(new end_form(info, client, ID));
            //}
        }
    }

    public class Bool
    {
        public bool inTheGame = true;
    }
    public class ServerIP
    {
        public string IP = "";
    }
    public class MyID
    {
        public int ID = -1;
    }
}
