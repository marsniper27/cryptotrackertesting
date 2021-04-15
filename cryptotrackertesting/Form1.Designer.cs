﻿namespace cryptotrackertesting
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.PortfolioTotalText = new System.Windows.Forms.Label();
            this.returnData = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CoinPrices = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.balancesLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.APIKey = new System.Windows.Forms.TextBox();
            this.SecretKey = new System.Windows.Forms.TextBox();
            this.pairName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Portfolio Total value";
            // 
            // PortfolioTotalText
            // 
            this.PortfolioTotalText.AutoSize = true;
            this.PortfolioTotalText.Location = new System.Drawing.Point(38, 49);
            this.PortfolioTotalText.Name = "PortfolioTotalText";
            this.PortfolioTotalText.Size = new System.Drawing.Size(34, 13);
            this.PortfolioTotalText.TabIndex = 1;
            this.PortfolioTotalText.Text = "$0.00";
            // 
            // returnData
            // 
            this.returnData.AutoSize = true;
            this.returnData.Location = new System.Drawing.Point(177, 92);
            this.returnData.Name = "returnData";
            this.returnData.Size = new System.Drawing.Size(35, 13);
            this.returnData.TabIndex = 2;
            this.returnData.Text = "label2";
            this.returnData.Click += new System.EventHandler(this.returnData_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "server status";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_ClickAsync);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Get Coin price";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CoinPrices
            // 
            this.CoinPrices.AutoSize = true;
            this.CoinPrices.Location = new System.Drawing.Point(29, 125);
            this.CoinPrices.Name = "CoinPrices";
            this.CoinPrices.Size = new System.Drawing.Size(58, 13);
            this.CoinPrices.TabIndex = 5;
            this.CoinPrices.Text = "coin prices";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(408, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Get SPOT account snapshot";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // balancesLabel
            // 
            this.balancesLabel.AutoSize = true;
            this.balancesLabel.Location = new System.Drawing.Point(405, 75);
            this.balancesLabel.Name = "balancesLabel";
            this.balancesLabel.Size = new System.Drawing.Size(50, 13);
            this.balancesLabel.TabIndex = 7;
            this.balancesLabel.Text = "balances";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "API Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "API secret";
            // 
            // APIKey
            // 
            this.APIKey.Location = new System.Drawing.Point(90, 291);
            this.APIKey.Name = "APIKey";
            this.APIKey.Size = new System.Drawing.Size(256, 20);
            this.APIKey.TabIndex = 10;
            this.APIKey.Text = "Enter API Key";
            // 
            // SecretKey
            // 
            this.SecretKey.Location = new System.Drawing.Point(91, 313);
            this.SecretKey.Name = "SecretKey";
            this.SecretKey.Size = new System.Drawing.Size(255, 20);
            this.SecretKey.TabIndex = 11;
            this.SecretKey.Text = "Enter API Key";
            // 
            // pairName
            // 
            this.pairName.Location = new System.Drawing.Point(12, 75);
            this.pairName.Name = "pairName";
            this.pairName.Size = new System.Drawing.Size(149, 20);
            this.pairName.TabIndex = 12;
            this.pairName.Text = "Enter trading pair (ETHUSDT)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pairName);
            this.Controls.Add(this.SecretKey);
            this.Controls.Add(this.APIKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.balancesLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.CoinPrices);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.returnData);
            this.Controls.Add(this.PortfolioTotalText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PortfolioTotalText;
        public System.Windows.Forms.Label returnData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label CoinPrices;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label balancesLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox APIKey;
        private System.Windows.Forms.TextBox SecretKey;
        private System.Windows.Forms.TextBox pairName;
    }
}

