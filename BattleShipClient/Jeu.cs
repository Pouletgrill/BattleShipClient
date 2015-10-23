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
        public enum GameState
        {
            WaitingStartGame,
            PlacingBoat,
            WaitingTurn,
            PlayingTurn,
            Victory,
            Lose
        }
        public GameState State {get; private set;}
        private TcpClient serveur;
        private Thread Attente;
        //private volatile bool gameStarted = false;
        public Jeu()
        {
            State = GameState.WaitingStartGame;
            serveur = new TcpClient("P104-14", 8080);
            Attente = new Thread(AttendreDebutPartie);
            Attente.Start();
        }
        public void AttendreDebutPartie()
        {
            try
            {
                using (NetworkStream ns = serveur.GetStream())
                {
                    do
                    {
                        //Console.Beep(700, 200);
                        continue;
                    } while ((String)ConnUtility.ReadAndDeserialize(ns) != "Start");
                }
                //gameStarted = true;
                State = GameState.PlacingBoat;

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
