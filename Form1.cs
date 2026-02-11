using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using Memory;

namespace Cyber_Punk_Trainer
{
    public partial class Form1 : Form
    {
        private const string CyberPunk = "Cyberpunk2077.exe";

        private static readonly Dictionary<string, string> DefaultPointers = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "AttributePoints", "Cyberpunk2077.exe+0x03C7F200,0x9B0,0x38,0x0,0x0,0x38,0x68,0x8" },
            { "PerkPoints", "Cyberpunk2077.exe+0x03C7F200,9B0,0x8,0x38,0x0,0x0,0x38,0x68,0x14" },
            { "CommonCraftingItem", "Cyberpunk2077.exe+0x048E0FF8,0x40,0x38,0x2F0,0x58,0x0,0x0,0x120,0x78" },
            { "UncommonCraftingItem", "Cyberpunk2077.exe+0x048E0FF8,0x138,0x40,0x120,0xB0,0xF0,0x0,0x130,0x78" },
            { "RareCraftingItem", "Cyberpunk2077.exe+0x048E0FF8,0x198,0x80,0x98,0xA0,0xF0,0,0x310,0x78" },
            { "RareUpgradeItem", "Cyberpunk2077.exe+0x048E0FF8,0x40,0x18,0x5F0,0x58,0x0,0x0,0xA90,0x78" },
            { "EpicItemComponents", "Cyberpunk2077.exe+0x048E1508,0x590,0x38,0x2F0,0x58,0x0,0x0,0xC40,0x78" },
            { "EpicUpgradeComponents", "Cyberpunk2077.exe+0x048E0FF8,0x118,0x50,0x120,0xB0,0xF0,0x0,0x9B0,0x78" },
            { "LegendaryItemComponents", "Cyberpunk2077.exe+0x048E1640,0x150,0x18,0x270,0x1D8,0x0,0x0,0x3F0,0x78" },
            { "LegendaryUpgradeComponents", "Cyberpunk2077.exe+0x048E0FF8,0x40,0x38,0x2F0,0x58,0x0,0x0,0x550,0x78" }
        };

        private readonly Mem meme = new Mem();
        private readonly PointerConfig pointerConfig;

        public Form1()
        {
            InitializeComponent();
            pointerConfig = new PointerConfig("pointers.ini", DefaultPointers);
            pointerConfig.Initialize();
        }

        private bool OpenCyberPunkProcess()
        {
            int processId = meme.GetProcIdFromName(CyberPunk);
            if (processId <= 0)
            {
                MessageBox.Show("Cyberpunk2077.exe was not found. Start the game first.");
                return false;
            }

            meme.OpenProcess(processId);
            return true;
        }

        private void addPerk()
        {
            try
            {
                string perkPointer = pointerConfig.GetPointer("PerkPoints");
                int currentStat = meme.ReadInt(perkPointer);
                int newStat = currentStat + 1;
                meme.WriteMemory(perkPointer, "int", newStat.ToString());
                MessageBox.Show("You now have " + newStat + " perk points");
                Thread.Sleep(2);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Thread.Sleep(2);
            }
        }

        private void statAdd(string pointerKey, int amount, string stat)
        {
            try
            {
                string pointer = pointerConfig.GetPointer(pointerKey);
                int currentStat = meme.ReadInt(pointer);
                if (currentStat < 0)
                {
                    MessageBox.Show("Value may be 0/invalid!");
                }

                int newStat = currentStat + amount;
                meme.WriteMemory(pointer, "int", newStat.ToString());
                Thread.Sleep(2);
                MessageBox.Show("You now have " + newStat + " " + stat);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void butUncommon_Click(object sender, EventArgs e)
        {
            if (!OpenCyberPunkProcess())
            {
                return;
            }

            Thread t = new Thread(() => statAdd("UncommonCraftingItem", 1000, "Uncommon Crafting Items")) { IsBackground = true };
            t.Start();
        }

        private void butRare_Click(object sender, EventArgs e)
        {
            if (!OpenCyberPunkProcess())
            {
                return;
            }

            Thread t = new Thread(() => statAdd("RareCraftingItem", 1000, "Rare Crafting Items")) { IsBackground = true };
            t.Start();
        }

        private void butPerk_Click(object sender, EventArgs e)
        {
            if (!OpenCyberPunkProcess())
            {
                return;
            }

            Thread ppa = new Thread(addPerk) { IsBackground = true };
            ppa.Start();
        }

        private void butCommonItem_Click(object sender, EventArgs e)
        {
            if (!OpenCyberPunkProcess())
            {
                return;
            }

            Thread t = new Thread(() => statAdd("CommonCraftingItem", 1000, "Common Item Components")) { IsBackground = true };
            t.Start();
        }

        private void butRareUp_Click(object sender, EventArgs e)
        {
            if (!OpenCyberPunkProcess())
            {
                return;
            }

            Thread t = new Thread(() => statAdd("RareUpgradeItem", 1000, "Rare Upgrade Items")) { IsBackground = true };
            t.Start();
        }

        private void butEpicUp_Click(object sender, EventArgs e)
        {
            if (!OpenCyberPunkProcess())
            {
                return;
            }

            Thread t = new Thread(() => statAdd("EpicUpgradeComponents", 1000, "Epic Upgrade Items")) { IsBackground = true };
            t.Start();
        }

        private void butLegItems_Click(object sender, EventArgs e)
        {
            if (!OpenCyberPunkProcess())
            {
                return;
            }

            Thread t = new Thread(() => statAdd("LegendaryItemComponents", 1000, "Legendary Crafting Items")) { IsBackground = true };
            t.Start();
        }

        private void butLegUp_Click(object sender, EventArgs e)
        {
            if (!OpenCyberPunkProcess())
            {
                return;
            }

            Thread t = new Thread(() => statAdd("LegendaryUpgradeComponents", 1000, "Legendary Upgrade Items")) { IsBackground = true };
            t.Start();
        }

        private void butAttribute_Click(object sender, EventArgs e)
        {
            if (!OpenCyberPunkProcess())
            {
                return;
            }

            Thread t = new Thread(() => statAdd("AttributePoints", 1, "Attribute Points")) { IsBackground = true };
            t.Start();
        }

        private void butEpicIt_Click(object sender, EventArgs e)
        {
            if (!OpenCyberPunkProcess())
            {
                return;
            }

            Thread t = new Thread(() => statAdd("EpicItemComponents", 1000, "Epic Crafting Items")) { IsBackground = true };
            t.Start();
        }
    }
}
