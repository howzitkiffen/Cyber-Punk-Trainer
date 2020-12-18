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
        public static string PerkPoints = "Cyberpunk2077.exe+0x03CBF400,0x9B0,0x38,0x0,0x0,0x38,0x68,0x14"; //Perk Points
        public static string CommonCraftingItem = "Cyberpunk2077.exe+049221B8,0x260,0x18,0x5F0,0x58,0x0,0x0,0x120,0x78"; //Common Item Components
        public static string UncommonCraftingItem = "Cyberpunk2077.exe+0x03CBF400,0xF60,0x50,0x38,0x280,0xF0,0x0,0x130,0x78"; //Uncommon Item Component
        public static string RareCraftingItem = "Cyberpunk2077.exe+0x04921BB8,0x40,0x38,0x2F0,0x58,0x0,0x0,0x310,0x78"; //Rare Item Components
        public static string RareUpgradeItem = "Cyberpunk2077.exe+0x04637A50,0x240,0x18,0x120,0xB0,0xF0,0x0,0xA80,0x108"; //Rare Upgrade Components
        public static string EpicItemComponents = "Cyberpunk2077.exe+0x04921BB8,0x118,0x50,0x120,0xB0,0xF0,0x0,0xB00,0x738"; //Epic Item Components
        public static string EpicUpgradeComponents = "Cyberpunk2077.exe+0x04921BB8,0x198,0x80,0x120,0xB0,0xF0,0x0,0x9A0,0x108"; //Epic Upgrade Components
        public static string LegendaryItemComponents = "Cyberpunk2077.exe+0x04922100,0x480,0x18,0x5F0,0x58,0x0,0x0,0x310,0x588"; //Legendary Item Components
        public Form1()
        {
            InitializeComponent();
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
                if (currentStat == 0) { MessageBox.Show("Value may be 0/invalid!"); }
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

        //Button to add 1k to uncommon item components
        private void butUncommon_Click(object sender, EventArgs e)
        {
            {
                int PID = Meme.GetProcIdFromName(CyberPunk);
                if (PID > 0)
                {
                    Meme.OpenProcess(PID);
                    // This method makes any methods in the parameter, a background, threaded task.
                    Thread t = new Thread(() => statAdd(UncommonCraftingItem, 1000, "Uncommon Crafting Items")) { IsBackground = true };
                    t.Start();

                }
            }
        }

        //Button to add 1k to rare item components
        private void butRare_Click(object sender, EventArgs e)
        {

        }

        //Button to add 1 available perk point
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

        //Button to add 1k to common item components
        private void butCommonItem_Click(object sender, EventArgs e)
        {
            int PID = Meme.GetProcIdFromName(CyberPunk);
            if (PID > 0)
            {
                Meme.OpenProcess(PID);
                // This method makes any methods in the parameter, a background, threaded task.
                Thread t = new Thread(() => statAdd(CommonCraftingItem, 1000, "Common Item Components")) { IsBackground = true };
                t.Start();
            }
        }

        //Button to add 1k to rare upgrade components
        private void butRareUp_Click(object sender, EventArgs e)
        {

        }

        //Button to add 1k to epic upgrade components
        private void butEpicUp_Click(object sender, EventArgs e)
        {

        }

        //Button to add 1k to legendary item components
        private void butLegItems_Click(object sender, EventArgs e)
        {
            {
                int PID = Meme.GetProcIdFromName(CyberPunk);
                if (PID > 0)
                {
                    Meme.OpenProcess(PID);
                    // This method makes any methods in the parameter, a background, threaded task.
                    Thread t = new Thread(() => statAdd(LegendaryItemComponents, 1000, "Legendary Crafting Items")) { IsBackground = true };
                    t.Start();

                }
            }
        }
    }
}   

