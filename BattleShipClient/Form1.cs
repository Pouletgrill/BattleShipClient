using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShipClient
{
    public partial class Form1 : Form
    {
        Jeu jeu;
        Thread thread;
        public Form1()
        {
            InitializeComponent();
            jeu = new Jeu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (thread == null)
            {
                thread = new Thread(jeu.AttendreDebutPartie);
                thread.Start();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            KillCurrentThread();
            jeu.Close();
        }

        private void KillCurrentThread()
        {
            if (thread != null && thread.IsAlive)
                thread.Abort();
        }
    }
}
