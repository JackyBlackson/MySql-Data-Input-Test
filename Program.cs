using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace TCP_Connection
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] input;
            Console.WriteLine("Hello, please connect me!");
            Console.WriteLine("Please input info as \"ip:port:maxConnectionAmount\"");
            input = Console.ReadLine().ToString().Split(':');
            */


            //TcpLongServer thisServer = new TcpLongServer(input[0], int.Parse(input[1]), int.Parse(input[2]));

            byte[] HeartBeatFrame = new byte[2048];
            TcpLongServer thisServer = new TcpLongServer("192.168.3.85", 2000, 100, 30);
            thisServer.Start();

            Console.ReadLine();
            while (true)
            {
                //try
                {
                    /*
                    string[] send = new string[2];
                    send = Console.ReadLine().Split(':');
                    thisServer.Send(int.Parse(send[0]), System.Text.Encoding.UTF8.GetBytes(send[1]));
                    */
                    thisServer.Receive(0);
                    thisServer.Receive(1);
                    Thread.Sleep(1000);
                }
                /*
                catch (Exception)
                {
                    Console.WriteLine("[ Main Thread ] 输入格式错误，请按照“连接编号:内容的格式来输入！”");
                }
                */
            }
        }
    }
    //End of Class
}



