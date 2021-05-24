using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RainbowBOT_Shop_Helper
{
    public partial class MinerControl : UserControl
    {
        private string name;
        private decimal price;
        private decimal count;
        private bool isHighlighted;
        private Color DefBGColor;
        private double highlight_counter = 1;
        private Color highlight_color;
        private int mining_rate;
        public delegate void recalcFun();
        private recalcFun Recalc;

        public string GetName()
        {
            return name;
        }
        public decimal GetPrice()
        {
            return price;
        }
        public decimal GetCount()
        {
            return count;
        }
        public decimal GetMiningRate()
        {
            return mining_rate;
        }


        public void SetName(string value)
        {
            name = value;
            this.groupBox1.Text = name;
        }
        public void SetPrice(decimal value)
        {
            price = value;
            this.numbox_price.Value = price;
        }
        public void SetCount(decimal value)
        {
            count = value;
            this.numbox_count.Value = count;
        }
        public void SetMiningRate(int value)
        {
            mining_rate = value;
        }

        public MinerControl(string Name, decimal Price, decimal Count, int MiningRate)
        {
            InitializeComponent();
            this.SetName(Name);
            this.SetPrice(Price);
            this.SetCount(Count);
            this.DefBGColor = this.BackColor;
            this.mining_rate = MiningRate;
        }

        public MinerControl(string Name, decimal Price, decimal Count, int MiningRate, recalcFun recalc)
        {
            InitializeComponent();
            this.SetName(Name);
            this.SetPrice(Price);
            this.SetCount(Count);
            this.DefBGColor = this.BackColor;
            this.mining_rate = MiningRate;
            this.Recalc = recalc;
        }

        public void Highlight(Color color)
        {
            this.isHighlighted = true;
            this.highlight_color = color;
            this.Highlight_timer.Start();
        }

        public void UnHighlight()
        {
            this.isHighlighted = false;
        }

        

        private void Highlight_timer_Tick(object sender, EventArgs e)
        {
            if (this.isHighlighted)
            {
                int r = 255 - (int)((Math.Sin(highlight_counter)+1) * (255 - this.highlight_color.R) / 2);
                int g = 255 - (int)((Math.Sin(highlight_counter)+1) * (255 - this.highlight_color.G) / 2);
                int b = 255 - (int)((Math.Sin(highlight_counter)+1) * (255 - this.highlight_color.B) / 2);
                this.BackColor = Color.FromArgb(r, g, b);
                highlight_counter += 0.05;
            }
            else
            {
                this.Highlight_timer.Stop();
                this.BackColor = this.DefBGColor;
                this.highlight_counter = 1;
            }
        }

        private void numbox_price_ValueChanged(object sender, EventArgs e)
        {
            this.SetPrice(numbox_price.Value);
        }

        private void numbox_count_ValueChanged(object sender, EventArgs e)
        {
            this.SetCount(numbox_count.Value);
        }
        private void buy_Click(object sender, EventArgs e)
        {
            this.SetCount(count + 1);
            double Cost = ((double)this.GetPrice() * 1.2);
            this.SetPrice((decimal)Cost);
            Recalc?.Invoke();
        }
    }
}
