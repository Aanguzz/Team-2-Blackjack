
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
            this.label1.Location = new System.Drawing.Point(415, 336);
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1263, 724);
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
    }
}

