using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RainbowBOT_Shop_Helper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public void Recalculate()
        {
            List<MinerControl> miners = this.flowLayoutPanel1.Controls.OfType<MinerControl>().ToList();
            MinerControl max = miners[0];
            double max_ratio = (double)miners[0].GetMiningRate() / (double)miners[0].GetPrice();

            foreach (MinerControl miner in miners)
            {
                miner.UnHighlight();
                double ratio = (double)miner.GetMiningRate() / (double)miner.GetPrice();
                if (ratio > max_ratio)
                {
                    max_ratio = ratio;
                    max = miner;
                }
            }
            max.Highlight(Color.FromArgb(255, 51, 51));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.Controls.Add(new MinerControl("Bitminer S1", 0, 0, 4320, Recalculate));
            this.flowLayoutPanel1.Controls.Add(new MinerControl("Bitminer S2", 0, 0, 9000, Recalculate));
            this.flowLayoutPanel1.Controls.Add(new MinerControl("Bitminer Rack", 0, 0, 20160, Recalculate));
            this.flowLayoutPanel1.Controls.Add(new MinerControl("Bitminer Datacenter", 0, 0, 100080, Recalculate));
            this.flowLayoutPanel1.Controls.Add(new MinerControl("Solar Station", 0, 0, 10080, Recalculate));
        }
        private void recalc_btn_Click(object sender, EventArgs e)
        {
            this.Recalculate();
        }
    }
}
