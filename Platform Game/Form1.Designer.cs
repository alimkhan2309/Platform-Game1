namespace Platform_Game
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
            this.components = new System.ComponentModel.Container();
            this.PlatformMain = new System.Windows.Forms.PictureBox();
            this.Enemy = new System.Windows.Forms.PictureBox();
            this.PlayerBox = new System.Windows.Forms.PictureBox();
            this.PlatformSide = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.scoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PlatformMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlatformSide)).BeginInit();
            this.SuspendLayout();
            // 
            // PlatformMain
            // 
            this.PlatformMain.BackColor = System.Drawing.Color.HotPink;
            this.PlatformMain.Location = new System.Drawing.Point(101, 491);
            this.PlatformMain.Name = "PlatformMain";
            this.PlatformMain.Size = new System.Drawing.Size(1124, 109);
            this.PlatformMain.TabIndex = 1;
            this.PlatformMain.TabStop = false;
            this.PlatformMain.Tag = "platform";
            // 
            // Enemy
            // 
            this.Enemy.BackColor = System.Drawing.Color.Khaki;
            this.Enemy.Location = new System.Drawing.Point(1161, 426);
            this.Enemy.Name = "Enemy";
            this.Enemy.Size = new System.Drawing.Size(64, 64);
            this.Enemy.TabIndex = 2;
            this.Enemy.TabStop = false;
            // 
            // PlayerBox
            // 
            this.PlayerBox.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.PlayerBox.Location = new System.Drawing.Point(102, 426);
            this.PlayerBox.Name = "PlayerBox";
            this.PlayerBox.Size = new System.Drawing.Size(64, 64);
            this.PlayerBox.TabIndex = 3;
            this.PlayerBox.TabStop = false;
            // 
            // PlatformSide
            // 
            this.PlatformSide.BackColor = System.Drawing.Color.HotPink;
            this.PlatformSide.Location = new System.Drawing.Point(348, 352);
            this.PlatformSide.Name = "PlatformSide";
            this.PlatformSide.Size = new System.Drawing.Size(266, 35);
            this.PlatformSide.TabIndex = 4;
            this.PlatformSide.TabStop = false;
            this.PlatformSide.Tag = "platform";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(675, 81);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(59, 20);
            this.scoreLabel.TabIndex = 5;
            this.scoreLabel.Text = "Score: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1314, 710);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.PlatformSide);
            this.Controls.Add(this.PlayerBox);
            this.Controls.Add(this.Enemy);
            this.Controls.Add(this.PlatformMain);
            this.Name = "Form1";
            this.Text = "Platform Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.PlatformMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlatformSide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PlatformMain;
        private System.Windows.Forms.PictureBox Enemy;
        private System.Windows.Forms.PictureBox PlayerBox;
        private System.Windows.Forms.PictureBox PlatformSide;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label scoreLabel;
    }
}

