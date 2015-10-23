using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Threading;

namespace BattleShipClient
{
    class Jeu
    {
        private TcpClient serveur;
        private Byte[] buffer = new Byte[100];
        private volatile bool gameStarted = false;
        public Jeu()
        {
            serveur = new TcpClient("P104-14", 8080);
        }
        public void AttendreDebutPartie()
        {
            try
            {
                String result = "";
                //serveur.GetStream().ReadTimeout = 500;
                serveur.GetStream().Read(buffer, 0, sizeof(char) * 10);
                using (NetworkStream ns = serveur.GetStream())
                {
                    do
                    {
                        //Console.Beep(700, 200);
                        continue;
                    } while ((String)ConnUtility.ReadAndDeserialize(ns) != "Start");
                }
                gameStarted = true;

            }
            catch (ThreadAbortException ex)
            {

            }
        }
        public void Close()
        {
            serveur.Close();
        }
    }
}
