using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Memory;

namespace Cyber_Punk_Trainer
{
    public partial class Form1 : Form
    {
        Mem Meme = new Mem();
        public static string CyberPunk = "Cyberpunk2077.exe";
        public static string PerkPoints = "Cyberpunk2077.exe+0x03CBF400,0x9B0,0x38,0x0,0x0,0x38,0x68,0x14";

        public Form1()
        {
            InitializeComponent();
        }

        private void butPerk_Click(object sender, EventArgs e)
        {
            int PID = Meme.GetProcIdFromName("Cyberpunk2077.exe");
            if (PID > 0)
            {
                Meme.OpenProcess(PID);

                Thread PPA = new Thread(addPerk) { IsBackground = true };
                PPA.Start();
                
            }
        }



        /// <summary>
        /// This adds a specified value to a stat of your choosing, provided you've found the value in memory
        /// </summary>
        /// <param name="pointer"> The string to reach memory (pointer/offsets),
        /// i.e (PerkPoints = "Cyberpunk2077.exe+0x03CBF400,0x9B0,0x38,0x0,0x0,0x38,0x68,0x14")</param>
        /// <param name="amount">The amount (int) to increase stat</param>
        /// <param name="stat">The name of the stat in string format</param>
        private void statAdd(string pointer, int amount, string stat)
        {
            try
            {
                int currentStat = Meme.ReadInt(pointer);
                int newStat = currentStat + amount;
                Meme.WriteMemory(pointer, "int", newStat.ToString());
                Thread.Sleep(2);
                MessageBox.Show("You now have " + newStat.ToString() + " " + stat);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }



        /// <summary>
        /// This method makes any methods in the parameter, a background, threaded task.
        /// </summary>
        /// <param name="method"> Takes in a method that edits memory
        /// i.e (addPerk()) Which, will add 1 point to the perk stat</param>
        private void CPThreader(System.Threading.ThreadStart method)
        {
            int PID = Meme.GetProcIdFromName(CyberPunk);
            if (PID > 0)
            {
                Meme.OpenProcess(PID);
                Thread Thrd = new Thread(method) { IsBackground = true };
                Thrd.Start();
            }
        }




        private void addPerk()
        {
            try
            {
                int currentStat = Meme.ReadInt(PerkPoints);
                int newStat = currentStat + 1;
                Meme.WriteMemory(PerkPoints, "int", newStat.ToString());
                MessageBox.Show("You now have " + newStat.ToString() + " perk points");
                Thread.Sleep(2);
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Thread.Sleep(2);
            }
        }
    }
}   

