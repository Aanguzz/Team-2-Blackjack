
namespace CSC478Blackjack
{
    public partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StartGame = new System.Windows.Forms.Button();
            this.StayButton = new System.Windows.Forms.Button();
            this.HitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BankrollLabel = new System.Windows.Forms.Label();
            this.CurrentBetLabel = new System.Windows.Forms.Label();
            this.BankrollAmountBox = new System.Windows.Forms.TextBox();
            this.CurrentBetBox = new System.Windows.Forms.TextBox();
            this.dealerCard5 = new System.Windows.Forms.Button();
            this.dealerCard4 = new System.Windows.Forms.Button();
            this.dealerCard3 = new System.Windows.Forms.Button();
            this.dealerCard2 = new System.Windows.Forms.Button();
            this.dealerCard1 = new System.Windows.Forms.Button();
            this.playerCard5 = new System.Windows.Forms.Button();
            this.playerCard2 = new System.Windows.Forms.Button();
            this.playerCard3 = new System.Windows.Forms.Button();
            this.playerCard4 = new System.Windows.Forms.Button();
            this.playerCard1 = new System.Windows.Forms.Button();
            this.PlayerHandLabel = new System.Windows.Forms.Label();
            this.DealerHandLabel = new System.Windows.Forms.Label();
            this.DealerTotalLabel = new System.Windows.Forms.Label();
            this.PlayerTotalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartGame
            // 
            this.StartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGame.Location = new System.Drawing.Point(578, 636);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(113, 41);
            this.StartGame.TabIndex = 0;
            this.StartGame.Text = "Start Game";
            this.StartGame.UseVisualStyleBackColor = true;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // StayButton
            // 
            this.StayButton.AccessibleDescription = "";
            this.StayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StayButton.Location = new System.Drawing.Point(807, 636);
            this.StayButton.Name = "StayButton";
            this.StayButton.Size = new System.Drawing.Size(88, 41);
            this.StayButton.TabIndex = 1;
            this.StayButton.Text = "Stay";
            this.StayButton.UseVisualStyleBackColor = true;
            this.StayButton.Click += new System.EventHandler(this.StayButton_Click);
            // 
            // HitButton
            // 
            this.HitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HitButton.Location = new System.Drawing.Point(391, 636);
            this.HitButton.Name = "HitButton";
            this.HitButton.Size = new System.Drawing.Size(88, 41);
            this.HitButton.TabIndex = 2;
            this.HitButton.Text = "Hit";
            this.HitButton.UseVisualStyleBackColor = true;
            this.HitButton.Click += new System.EventHandler(this.HitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(455, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 48);
            this.label1.TabIndex = 9;
            this.label1.Text = "Dealer Must Stand on 17 and Must Draw to 16\r\nBlackjack Pays 3 to 1\r\n";
            // 
            // BankrollLabel
            // 
            this.BankrollLabel.AutoSize = true;
            this.BankrollLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BankrollLabel.Location = new System.Drawing.Point(53, 149);
            this.BankrollLabel.Name = "BankrollLabel";
            this.BankrollLabel.Size = new System.Drawing.Size(200, 39);
            this.BankrollLabel.TabIndex = 10;
            this.BankrollLabel.Text = "BANKROLL";
            // 
            // CurrentBetLabel
            // 
            this.CurrentBetLabel.AutoSize = true;
            this.CurrentBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentBetLabel.Location = new System.Drawing.Point(53, 293);
            this.CurrentBetLabel.Name = "CurrentBetLabel";
            this.CurrentBetLabel.Size = new System.Drawing.Size(190, 39);
            this.CurrentBetLabel.TabIndex = 11;
            this.CurrentBetLabel.Text = "Current Bet";
            // 
            // BankrollAmountBox
            // 
            this.BankrollAmountBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BankrollAmountBox.Location = new System.Drawing.Point(50, 211);
            this.BankrollAmountBox.Name = "BankrollAmountBox";
            this.BankrollAmountBox.Size = new System.Drawing.Size(203, 45);
            this.BankrollAmountBox.TabIndex = 12;
            // 
            // CurrentBetBox
            // 
            this.CurrentBetBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentBetBox.Location = new System.Drawing.Point(50, 358);
            this.CurrentBetBox.Name = "CurrentBetBox";
            this.CurrentBetBox.Size = new System.Drawing.Size(193, 45);
            this.CurrentBetBox.TabIndex = 13;
            this.CurrentBetBox.TextChanged += new System.EventHandler(this.CurrentBetBox_TextChanged);
            // 
            // dealerCard5
            // 
            this.dealerCard5.BackColor = System.Drawing.SystemColors.Control;
            this.dealerCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dealerCard5.Location = new System.Drawing.Point(895, 95);
            this.dealerCard5.Name = "dealerCard5";
            this.dealerCard5.Size = new System.Drawing.Size(90, 120);
            this.dealerCard5.TabIndex = 28;
            this.dealerCard5.UseVisualStyleBackColor = false;
            this.dealerCard5.Visible = false;
            // 
            // dealerCard4
            // 
            this.dealerCard4.BackColor = System.Drawing.SystemColors.Control;
            this.dealerCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dealerCard4.Location = new System.Drawing.Point(785, 95);
            this.dealerCard4.Name = "dealerCard4";
            this.dealerCard4.Size = new System.Drawing.Size(90, 120);
            this.dealerCard4.TabIndex = 27;
            this.dealerCard4.UseVisualStyleBackColor = false;
            this.dealerCard4.Visible = false;
            // 
            // dealerCard3
            // 
            this.dealerCard3.BackColor = System.Drawing.SystemColors.Control;
            this.dealerCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dealerCard3.Location = new System.Drawing.Point(674, 95);
            this.dealerCard3.Name = "dealerCard3";
            this.dealerCard3.Size = new System.Drawing.Size(90, 120);
            this.dealerCard3.TabIndex = 26;
            this.dealerCard3.UseVisualStyleBackColor = false;
            this.dealerCard3.Visible = false;
            // 
            // dealerCard2
            // 
            this.dealerCard2.BackColor = System.Drawing.SystemColors.Control;
            this.dealerCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dealerCard2.Location = new System.Drawing.Point(564, 95);
            this.dealerCard2.Name = "dealerCard2";
            this.dealerCard2.Size = new System.Drawing.Size(90, 120);
            this.dealerCard2.TabIndex = 25;
            this.dealerCard2.UseVisualStyleBackColor = false;
            this.dealerCard2.Visible = false;
            // 
            // dealerCard1
            // 
            this.dealerCard1.BackColor = System.Drawing.SystemColors.Control;
            this.dealerCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dealerCard1.Location = new System.Drawing.Point(459, 95);
            this.dealerCard1.Name = "dealerCard1";
            this.dealerCard1.Size = new System.Drawing.Size(90, 120);
            this.dealerCard1.TabIndex = 24;
            this.dealerCard1.UseVisualStyleBackColor = false;
            this.dealerCard1.Visible = false;
            // 
            // playerCard5
            // 
            this.playerCard5.BackColor = System.Drawing.SystemColors.Control;
            this.playerCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerCard5.Location = new System.Drawing.Point(895, 451);
            this.playerCard5.Name = "playerCard5";
            this.playerCard5.Size = new System.Drawing.Size(90, 120);
            this.playerCard5.TabIndex = 33;
            this.playerCard5.UseVisualStyleBackColor = false;
            this.playerCard5.Visible = false;
            this.playerCard2.Click += new System.EventHandler(this.playerCard5_Click);
            // 
            // playerCard2
            // 
            this.playerCard2.BackColor = System.Drawing.SystemColors.Control;
            this.playerCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerCard2.Location = new System.Drawing.Point(564, 451);
            this.playerCard2.Name = "playerCard2";
            this.playerCard2.Size = new System.Drawing.Size(90, 120);
            this.playerCard2.TabIndex = 32;
            this.playerCard2.UseVisualStyleBackColor = false;
            this.playerCard2.Visible = false;
            this.playerCard2.Click += new System.EventHandler(this.playerCard2_Click);
            // 
            // playerCard3
            // 
            this.playerCard3.BackColor = System.Drawing.SystemColors.Control;
            this.playerCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerCard3.Location = new System.Drawing.Point(674, 451);
            this.playerCard3.Name = "playerCard3";
            this.playerCard3.Size = new System.Drawing.Size(90, 120);
            this.playerCard3.TabIndex = 31;
            this.playerCard3.UseVisualStyleBackColor = false;
            this.playerCard3.Visible = false;
            this.playerCard2.Click += new System.EventHandler(this.playerCard3_Click);
            // 
            // playerCard4
            // 
            this.playerCard4.BackColor = System.Drawing.SystemColors.Control;
            this.playerCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerCard4.Location = new System.Drawing.Point(785, 451);
            this.playerCard4.Name = "playerCard4";
            this.playerCard4.Size = new System.Drawing.Size(90, 120);
            this.playerCard4.TabIndex = 30;
            this.playerCard4.UseVisualStyleBackColor = false;
            this.playerCard4.Visible = false;
            this.playerCard2.Click += new System.EventHandler(this.playerCard4_Click);
            // 
            // playerCard1
            // 
            this.playerCard1.BackColor = System.Drawing.SystemColors.Control;
            this.playerCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerCard1.Location = new System.Drawing.Point(459, 451);
            this.playerCard1.Name = "playerCard1";
            this.playerCard1.Size = new System.Drawing.Size(90, 120);
            this.playerCard1.TabIndex = 29;
            this.playerCard1.UseVisualStyleBackColor = false;
            this.playerCard1.Visible = false;
            this.playerCard2.Click += new System.EventHandler(this.playerCard1_Click);
            // 
            // PlayerHandLabel
            // 
            this.PlayerHandLabel.AutoSize = true;
            this.PlayerHandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerHandLabel.Location = new System.Drawing.Point(460, 396);
            this.PlayerHandLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PlayerHandLabel.Name = "PlayerHandLabel";
            this.PlayerHandLabel.Size = new System.Drawing.Size(182, 31);
            this.PlayerHandLabel.TabIndex = 34;
            this.PlayerHandLabel.Text = "Player\'s Hand";
            // 
            // DealerHandLabel
            // 
            this.DealerHandLabel.AutoSize = true;
            this.DealerHandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DealerHandLabel.Location = new System.Drawing.Point(460, 41);
            this.DealerHandLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DealerHandLabel.Name = "DealerHandLabel";
            this.DealerHandLabel.Size = new System.Drawing.Size(185, 31);
            this.DealerHandLabel.TabIndex = 35;
            this.DealerHandLabel.Text = "Dealer\'s Hand";
            // 
            // DealerTotalLabel
            // 
            this.DealerTotalLabel.AutoSize = true;
            this.DealerTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DealerTotalLabel.Location = new System.Drawing.Point(459, 240);
            this.DealerTotalLabel.Name = "DealerTotalLabel";
            this.DealerTotalLabel.Size = new System.Drawing.Size(36, 39);
            this.DealerTotalLabel.TabIndex = 36;
            this.DealerTotalLabel.Text = "0";
            // 
            // PlayerTotalLabel
            // 
            this.PlayerTotalLabel.AutoSize = true;
            this.PlayerTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerTotalLabel.Location = new System.Drawing.Point(459, 585);
            this.PlayerTotalLabel.Name = "PlayerTotalLabel";
            this.PlayerTotalLabel.Size = new System.Drawing.Size(36, 39);
            this.PlayerTotalLabel.TabIndex = 37;
            this.PlayerTotalLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1263, 724);
            this.Controls.Add(this.PlayerTotalLabel);
            this.Controls.Add(this.DealerTotalLabel);
            this.Controls.Add(this.DealerHandLabel);
            this.Controls.Add(this.PlayerHandLabel);
            this.Controls.Add(this.playerCard5);
            this.Controls.Add(this.playerCard2);
            this.Controls.Add(this.playerCard3);
            this.Controls.Add(this.playerCard4);
            this.Controls.Add(this.playerCard1);
            this.Controls.Add(this.dealerCard5);
            this.Controls.Add(this.dealerCard4);
            this.Controls.Add(this.dealerCard3);
            this.Controls.Add(this.dealerCard2);
            this.Controls.Add(this.dealerCard1);
            this.Controls.Add(this.CurrentBetBox);
            this.Controls.Add(this.BankrollAmountBox);
            this.Controls.Add(this.CurrentBetLabel);
            this.Controls.Add(this.BankrollLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HitButton);
            this.Controls.Add(this.StayButton);
            this.Controls.Add(this.StartGame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.Button StayButton;
        private System.Windows.Forms.Button HitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BankrollLabel;
        private System.Windows.Forms.Label CurrentBetLabel;
        private System.Windows.Forms.TextBox BankrollAmountBox;
        private System.Windows.Forms.TextBox CurrentBetBox;
        private System.Windows.Forms.Button dealerCard5;
        private System.Windows.Forms.Button dealerCard4;
        private System.Windows.Forms.Button dealerCard3;
        private System.Windows.Forms.Button dealerCard2;
        private System.Windows.Forms.Button dealerCard1;
        private System.Windows.Forms.Button playerCard5;
        private System.Windows.Forms.Button playerCard2;
        private System.Windows.Forms.Button playerCard3;
        private System.Windows.Forms.Button playerCard4;
        private System.Windows.Forms.Button playerCard1;
        private System.Windows.Forms.Label PlayerHandLabel;
        private System.Windows.Forms.Label DealerHandLabel;
        private System.Windows.Forms.Label DealerTotalLabel;
        private System.Windows.Forms.Label PlayerTotalLabel;
    }
}

