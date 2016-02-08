namespace WumpusTest
{
    partial class PlayGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayGame));
            this.roomLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.coinCount = new System.Windows.Forms.Label();
            this.messageBox = new System.Windows.Forms.Label();
            this.bats = new System.Windows.Forms.PictureBox();
            this.wumpus = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.northeast = new System.Windows.Forms.PictureBox();
            this.north = new System.Windows.Forms.PictureBox();
            this.southeast = new System.Windows.Forms.PictureBox();
            this.south = new System.Windows.Forms.PictureBox();
            this.southwest = new System.Windows.Forms.PictureBox();
            this.northwest = new System.Windows.Forms.PictureBox();
            this.neDoor = new System.Windows.Forms.PictureBox();
            this.nDoor = new System.Windows.Forms.PictureBox();
            this.nwDoor = new System.Windows.Forms.PictureBox();
            this.swDoor = new System.Windows.Forms.PictureBox();
            this.sDoor = new System.Windows.Forms.PictureBox();
            this.seDoor = new System.Windows.Forms.PictureBox();
            this.arrow1 = new System.Windows.Forms.PictureBox();
            this.arrowCountUI = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wumpus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northeast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.north)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.southeast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.south)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.southwest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow1)).BeginInit();
            this.SuspendLayout();
            // 
            // roomLabel
            // 
            this.roomLabel.AutoSize = true;
            this.roomLabel.Location = new System.Drawing.Point(18, 625);
            this.roomLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roomLabel.Name = "roomLabel";
            this.roomLabel.Size = new System.Drawing.Size(65, 20);
            this.roomLabel.TabIndex = 22;
            this.roomLabel.Text = "Room 1";
            this.roomLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 726);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(18, 746);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 24;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // coinCount
            // 
            this.coinCount.AutoSize = true;
            this.coinCount.Location = new System.Drawing.Point(18, 657);
            this.coinCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.coinCount.Name = "coinCount";
            this.coinCount.Size = new System.Drawing.Size(49, 20);
            this.coinCount.TabIndex = 25;
            this.coinCount.Text = "Coins";
            this.coinCount.Click += new System.EventHandler(this.label3_Click);
            // 
            // messageBox
            // 
            this.messageBox.AutoSize = true;
            this.messageBox.Location = new System.Drawing.Point(18, 723);
            this.messageBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(348, 20);
            this.messageBox.TabIndex = 28;
            this.messageBox.Text = "Welcome to the game! To move, press a, w, d, s.";
            this.messageBox.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // bats
            // 
            this.bats.BackColor = System.Drawing.Color.OliveDrab;
            this.bats.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bats.BackgroundImage")));
            this.bats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bats.Location = new System.Drawing.Point(510, 374);
            this.bats.Margin = new System.Windows.Forms.Padding(0);
            this.bats.Name = "bats";
            this.bats.Size = new System.Drawing.Size(63, 78);
            this.bats.TabIndex = 29;
            this.bats.TabStop = false;
            // 
            // wumpus
            // 
            this.wumpus.BackColor = System.Drawing.Color.OliveDrab;
            this.wumpus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wumpus.BackgroundImage")));
            this.wumpus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.wumpus.Location = new System.Drawing.Point(510, 374);
            this.wumpus.Margin = new System.Windows.Forms.Padding(0);
            this.wumpus.Name = "wumpus";
            this.wumpus.Size = new System.Drawing.Size(63, 78);
            this.wumpus.TabIndex = 27;
            this.wumpus.TabStop = false;
            // 
            // player
            // 
            this.player.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("player.BackgroundImage")));
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.player.Location = new System.Drawing.Point(447, 374);
            this.player.Margin = new System.Windows.Forms.Padding(0);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(63, 78);
            this.player.TabIndex = 11;
            this.player.TabStop = false;
            // 
            // northeast
            // 
            this.northeast.BackColor = System.Drawing.Color.Transparent;
            this.northeast.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("northeast.BackgroundImage")));
            this.northeast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.northeast.Location = new System.Drawing.Point(639, 0);
            this.northeast.Margin = new System.Windows.Forms.Padding(0);
            this.northeast.Name = "northeast";
            this.northeast.Size = new System.Drawing.Size(320, 409);
            this.northeast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.northeast.TabIndex = 13;
            this.northeast.TabStop = false;
            this.northeast.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // north
            // 
            this.north.BackColor = System.Drawing.Color.Transparent;
            this.north.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("north.BackgroundImage")));
            this.north.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.north.Location = new System.Drawing.Point(320, 0);
            this.north.Margin = new System.Windows.Forms.Padding(0);
            this.north.Name = "north";
            this.north.Size = new System.Drawing.Size(320, 409);
            this.north.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.north.TabIndex = 9;
            this.north.TabStop = false;
            this.north.Click += new System.EventHandler(this.north_Click);
            // 
            // southeast
            // 
            this.southeast.BackColor = System.Drawing.Color.Transparent;
            this.southeast.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("southeast.BackgroundImage")));
            this.southeast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.southeast.Location = new System.Drawing.Point(639, 409);
            this.southeast.Margin = new System.Windows.Forms.Padding(0);
            this.southeast.Name = "southeast";
            this.southeast.Size = new System.Drawing.Size(320, 409);
            this.southeast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.southeast.TabIndex = 16;
            this.southeast.TabStop = false;
            this.southeast.Click += new System.EventHandler(this.southeast_Click_1);
            // 
            // south
            // 
            this.south.BackColor = System.Drawing.Color.Transparent;
            this.south.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("south.BackgroundImage")));
            this.south.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.south.Location = new System.Drawing.Point(320, 409);
            this.south.Margin = new System.Windows.Forms.Padding(0);
            this.south.Name = "south";
            this.south.Size = new System.Drawing.Size(320, 409);
            this.south.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.south.TabIndex = 15;
            this.south.TabStop = false;
            // 
            // southwest
            // 
            this.southwest.BackColor = System.Drawing.Color.Transparent;
            this.southwest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("southwest.BackgroundImage")));
            this.southwest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.southwest.Location = new System.Drawing.Point(0, 409);
            this.southwest.Margin = new System.Windows.Forms.Padding(0);
            this.southwest.Name = "southwest";
            this.southwest.Size = new System.Drawing.Size(320, 409);
            this.southwest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.southwest.TabIndex = 14;
            this.southwest.TabStop = false;
            // 
            // northwest
            // 
            this.northwest.BackColor = System.Drawing.Color.Transparent;
            this.northwest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("northwest.BackgroundImage")));
            this.northwest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.northwest.Location = new System.Drawing.Point(0, 0);
            this.northwest.Margin = new System.Windows.Forms.Padding(0);
            this.northwest.Name = "northwest";
            this.northwest.Size = new System.Drawing.Size(320, 409);
            this.northwest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.northwest.TabIndex = 8;
            this.northwest.TabStop = false;
            this.northwest.Click += new System.EventHandler(this.northwest_Click);
            // 
            // neDoor
            // 
            this.neDoor.Location = new System.Drawing.Point(704, 215);
            this.neDoor.Name = "neDoor";
            this.neDoor.Size = new System.Drawing.Size(81, 108);
            this.neDoor.TabIndex = 12;
            this.neDoor.TabStop = false;
            // 
            // nDoor
            // 
            this.nDoor.Location = new System.Drawing.Point(447, 45);
            this.nDoor.Name = "nDoor";
            this.nDoor.Size = new System.Drawing.Size(81, 108);
            this.nDoor.TabIndex = 20;
            this.nDoor.TabStop = false;
            // 
            // nwDoor
            // 
            this.nwDoor.Location = new System.Drawing.Point(176, 189);
            this.nwDoor.Name = "nwDoor";
            this.nwDoor.Size = new System.Drawing.Size(81, 108);
            this.nwDoor.TabIndex = 19;
            this.nwDoor.TabStop = false;
            // 
            // swDoor
            // 
            this.swDoor.Location = new System.Drawing.Point(176, 503);
            this.swDoor.Name = "swDoor";
            this.swDoor.Size = new System.Drawing.Size(81, 108);
            this.swDoor.TabIndex = 18;
            this.swDoor.TabStop = false;
            // 
            // sDoor
            // 
            this.sDoor.Location = new System.Drawing.Point(447, 671);
            this.sDoor.Name = "sDoor";
            this.sDoor.Size = new System.Drawing.Size(81, 108);
            this.sDoor.TabIndex = 21;
            this.sDoor.TabStop = false;
            // 
            // seDoor
            // 
            this.seDoor.Location = new System.Drawing.Point(690, 503);
            this.seDoor.Name = "seDoor";
            this.seDoor.Size = new System.Drawing.Size(81, 108);
            this.seDoor.TabIndex = 17;
            this.seDoor.TabStop = false;
            // 
            // arrow1
            // 
            this.arrow1.BackColor = System.Drawing.Color.OliveDrab;
            this.arrow1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("arrow1.BackgroundImage")));
            this.arrow1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.arrow1.Location = new System.Drawing.Point(34, 22);
            this.arrow1.Margin = new System.Windows.Forms.Padding(0);
            this.arrow1.Name = "arrow1";
            this.arrow1.Size = new System.Drawing.Size(33, 36);
            this.arrow1.TabIndex = 30;
            this.arrow1.TabStop = false;
            // 
            // arrowCountUI
            // 
            this.arrowCountUI.AutoSize = true;
            this.arrowCountUI.Location = new System.Drawing.Point(18, 690);
            this.arrowCountUI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.arrowCountUI.Name = "arrowCountUI";
            this.arrowCountUI.Size = new System.Drawing.Size(58, 20);
            this.arrowCountUI.TabIndex = 31;
            this.arrowCountUI.Text = "Arrows";
            this.arrowCountUI.Click += new System.EventHandler(this.arrowCount_Click);
            // 
            // PlayGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(938, 874);
            this.Controls.Add(this.arrowCountUI);
            this.Controls.Add(this.arrow1);
            this.Controls.Add(this.bats);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.wumpus);
            this.Controls.Add(this.coinCount);
            this.Controls.Add(this.player);
            this.Controls.Add(this.northeast);
            this.Controls.Add(this.north);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roomLabel);
            this.Controls.Add(this.southeast);
            this.Controls.Add(this.south);
            this.Controls.Add(this.southwest);
            this.Controls.Add(this.northwest);
            this.Controls.Add(this.neDoor);
            this.Controls.Add(this.nDoor);
            this.Controls.Add(this.nwDoor);
            this.Controls.Add(this.swDoor);
            this.Controls.Add(this.sDoor);
            this.Controls.Add(this.seDoor);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PlayGame";
            this.Text = "playGame";
            this.Load += new System.EventHandler(this.PlayGame_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.bats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wumpus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northeast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.north)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.southeast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.south)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.southwest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox northwest;
        private System.Windows.Forms.PictureBox north;
        private System.Windows.Forms.PictureBox neDoor;
        private System.Windows.Forms.PictureBox northeast;
        private System.Windows.Forms.PictureBox southwest;
        private System.Windows.Forms.PictureBox south;
        private System.Windows.Forms.PictureBox southeast;
        private System.Windows.Forms.PictureBox seDoor;
        private System.Windows.Forms.PictureBox swDoor;
        private System.Windows.Forms.PictureBox nwDoor;
        private System.Windows.Forms.PictureBox nDoor;
        private System.Windows.Forms.PictureBox sDoor;
        private System.Windows.Forms.Label roomLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Label coinCount;
        private System.Windows.Forms.PictureBox wumpus;
        private System.Windows.Forms.Label messageBox;
        private System.Windows.Forms.PictureBox bats;
        private System.Windows.Forms.PictureBox arrow1;
        private System.Windows.Forms.Label arrowCountUI;
    }
}