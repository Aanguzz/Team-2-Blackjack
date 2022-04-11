
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
            this.BetAmount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartGame
            // 
            this.StartGame.Location = new System.Drawing.Point(466, 541);
            this.StartGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(100, 28);
            this.StartGame.TabIndex = 0;
            this.StartGame.Text = "Start Game";
            this.StartGame.UseVisualStyleBackColor = true;
            // 
            // StayButton
            // 
            this.StayButton.AccessibleDescription = "";
            this.StayButton.Location = new System.Drawing.Point(557, 458);
            this.StayButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StayButton.Name = "StayButton";
            this.StayButton.Size = new System.Drawing.Size(100, 28);
            this.StayButton.TabIndex = 1;
            this.StayButton.Text = "Stay";
            this.StayButton.UseVisualStyleBackColor = true;
            // 
            // HitButton
            // 
            this.HitButton.Location = new System.Drawing.Point(381, 458);
            this.HitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HitButton.Name = "HitButton";
            this.HitButton.Size = new System.Drawing.Size(100, 28);
            this.HitButton.TabIndex = 2;
            this.HitButton.Text = "Hit";
            this.HitButton.UseVisualStyleBackColor = true;
            this.HitButton.Click += new System.EventHandler(this.HitButton_Click);
            // 
            // BetAmount
            // 
            this.BetAmount.Location = new System.Drawing.Point(89, 357);
            this.BetAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BetAmount.Name = "BetAmount";
            this.BetAmount.Size = new System.Drawing.Size(100, 28);
            this.BetAmount.TabIndex = 3;
            this.BetAmount.Text = "button1";
            this.BetAmount.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(399, 300);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 34);
            this.label1.TabIndex = 9;
            this.label1.Text = "Dealer Must Stand on 17 and Must Draw to 16\r\nBlackjack Pays 3 to 1\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "BANKROLL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1223, 644);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BetAmount);
            this.Controls.Add(this.HitButton);
            this.Controls.Add(this.StayButton);
            this.Controls.Add(this.StartGame);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button BetAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

