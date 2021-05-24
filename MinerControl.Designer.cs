namespace RainbowBOT_Shop_Helper
{
    partial class MinerControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numbox_count = new System.Windows.Forms.NumericUpDown();
            this.numbox_price = new System.Windows.Forms.NumericUpDown();
            this.buy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Highlight_timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbox_count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbox_price)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numbox_count);
            this.groupBox1.Controls.Add(this.numbox_price);
            this.groupBox1.Controls.Add(this.buy);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 68);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bitminer S1";
            // 
            // numbox_count
            // 
            this.numbox_count.Location = new System.Drawing.Point(44, 43);
            this.numbox_count.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numbox_count.Name = "numbox_count";
            this.numbox_count.Size = new System.Drawing.Size(150, 20);
            this.numbox_count.TabIndex = 14;
            this.numbox_count.ValueChanged += new System.EventHandler(this.numbox_count_ValueChanged);
            // 
            // numbox_price
            // 
            this.numbox_price.Location = new System.Drawing.Point(44, 20);
            this.numbox_price.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numbox_price.Name = "numbox_price";
            this.numbox_price.Size = new System.Drawing.Size(150, 20);
            this.numbox_price.TabIndex = 13;
            this.numbox_price.ValueChanged += new System.EventHandler(this.numbox_price_ValueChanged);
            // 
            // buy
            // 
            this.buy.Dock = System.Windows.Forms.DockStyle.Right;
            this.buy.Location = new System.Drawing.Point(200, 16);
            this.buy.Name = "buy";
            this.buy.Size = new System.Drawing.Size(44, 49);
            this.buy.TabIndex = 12;
            this.buy.Text = "Buy";
            this.buy.UseVisualStyleBackColor = true;
            this.buy.Click += new System.EventHandler(this.buy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Count";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Price";
            // 
            // Highlight_timer
            // 
            this.Highlight_timer.Interval = 17;
            this.Highlight_timer.Tick += new System.EventHandler(this.Highlight_timer_Tick);
            // 
            // MinerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "MinerControl";
            this.Size = new System.Drawing.Size(253, 74);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbox_count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbox_price)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buy;
        private System.Windows.Forms.NumericUpDown numbox_price;
        private System.Windows.Forms.NumericUpDown numbox_count;
        private System.Windows.Forms.Timer Highlight_timer;
    }
}
