namespace Minesweeper
{
    partial class Game
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
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.pnlVideo = new System.Windows.Forms.Panel();
            this.pnlGameAction = new System.Windows.Forms.Panel();
            this.lblGameName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.pnlGameFilds = new System.Windows.Forms.Panel();
            this.gbTotlaScoreOfPlayer = new System.Windows.Forms.GroupBox();
            this.txtTotalScore = new System.Windows.Forms.TextBox();
            this.txtNumberOfGamesForThisPlayer = new System.Windows.Forms.TextBox();
            this.lblTotalScore = new System.Windows.Forms.Label();
            this.lblNumberOfGamesForThisPlayer = new System.Windows.Forms.Label();
            this.gbThisGameScore = new System.Windows.Forms.GroupBox();
            this.txtScoreInThisGame = new System.Windows.Forms.TextBox();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.lblNameOfPlayer = new System.Windows.Forms.Label();
            this.lblScoreInThisGame = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblPlayerID = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.pnlVideo.SuspendLayout();
            this.pnlGameAction.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlGameFilds.SuspendLayout();
            this.gbTotlaScoreOfPlayer.SuspendLayout();
            this.gbThisGameScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(181, 414);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(59, 15);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Full name";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(12, 414);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(92, 15);
            this.lblPlayer.TabIndex = 1;
            this.lblPlayer.Text = "Player full name";
            // 
            // pnlVideo
            // 
            this.pnlVideo.Controls.Add(this.pnlGameAction);
            this.pnlVideo.Controls.Add(this.pnlGameFilds);
            this.pnlVideo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVideo.Location = new System.Drawing.Point(0, 0);
            this.pnlVideo.Name = "pnlVideo";
            this.pnlVideo.Size = new System.Drawing.Size(800, 395);
            this.pnlVideo.TabIndex = 2;
            // 
            // pnlGameAction
            // 
            this.pnlGameAction.BackColor = System.Drawing.SystemColors.Info;
            this.pnlGameAction.Controls.Add(this.lblGameName);
            this.pnlGameAction.Controls.Add(this.tableLayoutPanel1);
            this.pnlGameAction.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlGameAction.Location = new System.Drawing.Point(384, 0);
            this.pnlGameAction.Name = "pnlGameAction";
            this.pnlGameAction.Size = new System.Drawing.Size(416, 395);
            this.pnlGameAction.TabIndex = 1;
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.Location = new System.Drawing.Point(178, 19);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(77, 15);
            this.lblGameName.TabIndex = 1;
            this.lblGameName.Text = "Minesweeper";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.06438F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.93562F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label11, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label12, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label14, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label15, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label16, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label17, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label18, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label19, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label20, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label21, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label22, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label23, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label24, 2, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(42, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(334, 281);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(4, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 60);
            this.label10.TabIndex = 0;
            this.label10.Text = "label10";
            this.label10.Click += new System.EventHandler(this.label1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(103, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 60);
            this.label11.TabIndex = 1;
            this.label11.Text = "label11";
            this.label11.Click += new System.EventHandler(this.label1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(223, 1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 60);
            this.label12.TabIndex = 2;
            this.label12.Text = "label12";
            this.label12.Click += new System.EventHandler(this.label1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(4, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 60);
            this.label13.TabIndex = 3;
            this.label13.Text = "label13";
            this.label13.Click += new System.EventHandler(this.label1_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(103, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 60);
            this.label14.TabIndex = 4;
            this.label14.Text = "label14";
            this.label14.Click += new System.EventHandler(this.label1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(223, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 60);
            this.label15.TabIndex = 5;
            this.label15.Text = "label15";
            this.label15.Click += new System.EventHandler(this.label1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Location = new System.Drawing.Point(4, 123);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 51);
            this.label16.TabIndex = 6;
            this.label16.Text = "label16";
            this.label16.Click += new System.EventHandler(this.label1_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Location = new System.Drawing.Point(103, 123);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(113, 51);
            this.label17.TabIndex = 7;
            this.label17.Text = "label17";
            this.label17.Click += new System.EventHandler(this.label1_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Location = new System.Drawing.Point(223, 123);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(107, 51);
            this.label18.TabIndex = 8;
            this.label18.Text = "label18";
            this.label18.Click += new System.EventHandler(this.label1_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Location = new System.Drawing.Point(4, 175);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 50);
            this.label19.TabIndex = 9;
            this.label19.Text = "label19";
            this.label19.Click += new System.EventHandler(this.label1_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Location = new System.Drawing.Point(103, 175);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(113, 50);
            this.label20.TabIndex = 10;
            this.label20.Text = "label20";
            this.label20.Click += new System.EventHandler(this.label1_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Location = new System.Drawing.Point(223, 175);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(107, 50);
            this.label21.TabIndex = 11;
            this.label21.Text = "label21";
            this.label21.Click += new System.EventHandler(this.label1_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.Location = new System.Drawing.Point(4, 226);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(92, 54);
            this.label22.TabIndex = 12;
            this.label22.Text = "label22";
            this.label22.Click += new System.EventHandler(this.label1_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label23.Location = new System.Drawing.Point(103, 226);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(113, 54);
            this.label23.TabIndex = 13;
            this.label23.Text = "label23";
            this.label23.Click += new System.EventHandler(this.label1_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label24.Location = new System.Drawing.Point(223, 226);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(107, 54);
            this.label24.TabIndex = 14;
            this.label24.Text = "label24";
            this.label24.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlGameFilds
            // 
            this.pnlGameFilds.Controls.Add(this.gbTotlaScoreOfPlayer);
            this.pnlGameFilds.Controls.Add(this.gbThisGameScore);
            this.pnlGameFilds.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlGameFilds.Location = new System.Drawing.Point(0, 0);
            this.pnlGameFilds.Name = "pnlGameFilds";
            this.pnlGameFilds.Size = new System.Drawing.Size(378, 395);
            this.pnlGameFilds.TabIndex = 0;
            // 
            // gbTotlaScoreOfPlayer
            // 
            this.gbTotlaScoreOfPlayer.BackColor = System.Drawing.SystemColors.Info;
            this.gbTotlaScoreOfPlayer.Controls.Add(this.txtTotalScore);
            this.gbTotlaScoreOfPlayer.Controls.Add(this.txtNumberOfGamesForThisPlayer);
            this.gbTotlaScoreOfPlayer.Controls.Add(this.lblTotalScore);
            this.gbTotlaScoreOfPlayer.Controls.Add(this.lblNumberOfGamesForThisPlayer);
            this.gbTotlaScoreOfPlayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbTotlaScoreOfPlayer.Location = new System.Drawing.Point(0, 207);
            this.gbTotlaScoreOfPlayer.Name = "gbTotlaScoreOfPlayer";
            this.gbTotlaScoreOfPlayer.Size = new System.Drawing.Size(378, 188);
            this.gbTotlaScoreOfPlayer.TabIndex = 3;
            this.gbTotlaScoreOfPlayer.TabStop = false;
            this.gbTotlaScoreOfPlayer.Text = "TotlaScoreOfPlayer";
            // 
            // txtTotalScore
            // 
            this.txtTotalScore.Location = new System.Drawing.Point(204, 105);
            this.txtTotalScore.Name = "txtTotalScore";
            this.txtTotalScore.Size = new System.Drawing.Size(100, 23);
            this.txtTotalScore.TabIndex = 4;
            // 
            // txtNumberOfGamesForThisPlayer
            // 
            this.txtNumberOfGamesForThisPlayer.Location = new System.Drawing.Point(204, 35);
            this.txtNumberOfGamesForThisPlayer.Name = "txtNumberOfGamesForThisPlayer";
            this.txtNumberOfGamesForThisPlayer.Size = new System.Drawing.Size(100, 23);
            this.txtNumberOfGamesForThisPlayer.TabIndex = 3;
            // 
            // lblTotalScore
            // 
            this.lblTotalScore.AutoSize = true;
            this.lblTotalScore.Location = new System.Drawing.Point(19, 113);
            this.lblTotalScore.Name = "lblTotalScore";
            this.lblTotalScore.Size = new System.Drawing.Size(63, 15);
            this.lblTotalScore.TabIndex = 2;
            this.lblTotalScore.Text = "Total score";
            // 
            // lblNumberOfGamesForThisPlayer
            // 
            this.lblNumberOfGamesForThisPlayer.AutoSize = true;
            this.lblNumberOfGamesForThisPlayer.Location = new System.Drawing.Point(19, 43);
            this.lblNumberOfGamesForThisPlayer.Name = "lblNumberOfGamesForThisPlayer";
            this.lblNumberOfGamesForThisPlayer.Size = new System.Drawing.Size(178, 15);
            this.lblNumberOfGamesForThisPlayer.TabIndex = 1;
            this.lblNumberOfGamesForThisPlayer.Text = "Number of games for this player";
            // 
            // gbThisGameScore
            // 
            this.gbThisGameScore.Controls.Add(this.txtScoreInThisGame);
            this.gbThisGameScore.Controls.Add(this.txtPlayerName);
            this.gbThisGameScore.Controls.Add(this.lblNameOfPlayer);
            this.gbThisGameScore.Controls.Add(this.lblScoreInThisGame);
            this.gbThisGameScore.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbThisGameScore.Location = new System.Drawing.Point(0, 0);
            this.gbThisGameScore.Name = "gbThisGameScore";
            this.gbThisGameScore.Size = new System.Drawing.Size(378, 189);
            this.gbThisGameScore.TabIndex = 2;
            this.gbThisGameScore.TabStop = false;
            this.gbThisGameScore.Text = "ThisGameScore";
            // 
            // txtScoreInThisGame
            // 
            this.txtScoreInThisGame.Location = new System.Drawing.Point(204, 102);
            this.txtScoreInThisGame.Name = "txtScoreInThisGame";
            this.txtScoreInThisGame.Size = new System.Drawing.Size(100, 23);
            this.txtScoreInThisGame.TabIndex = 3;
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(204, 38);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(100, 23);
            this.txtPlayerName.TabIndex = 2;
            // 
            // lblNameOfPlayer
            // 
            this.lblNameOfPlayer.AutoSize = true;
            this.lblNameOfPlayer.Location = new System.Drawing.Point(19, 41);
            this.lblNameOfPlayer.Name = "lblNameOfPlayer";
            this.lblNameOfPlayer.Size = new System.Drawing.Size(88, 15);
            this.lblNameOfPlayer.TabIndex = 0;
            this.lblNameOfPlayer.Text = "Name of player";
            // 
            // lblScoreInThisGame
            // 
            this.lblScoreInThisGame.AutoSize = true;
            this.lblScoreInThisGame.Location = new System.Drawing.Point(19, 110);
            this.lblScoreInThisGame.Name = "lblScoreInThisGame";
            this.lblScoreInThisGame.Size = new System.Drawing.Size(104, 15);
            this.lblScoreInThisGame.TabIndex = 1;
            this.lblScoreInThisGame.Text = "Score in this game";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(384, 410);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 23);
            this.btnNewGame.TabIndex = 3;
            this.btnNewGame.Text = "New game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // lblPlayerID
            // 
            this.lblPlayerID.AutoSize = true;
            this.lblPlayerID.Location = new System.Drawing.Point(125, 414);
            this.lblPlayerID.Name = "lblPlayerID";
            this.lblPlayerID.Size = new System.Drawing.Size(50, 15);
            this.lblPlayerID.TabIndex = 4;
            this.lblPlayerID.Text = "PlayerID";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(465, 410);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(546, 410);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.lblPlayerID);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.pnlVideo);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblFullName);
            this.Name = "Game";
            this.Text = "Game";
            this.pnlVideo.ResumeLayout(false);
            this.pnlGameAction.ResumeLayout(false);
            this.pnlGameAction.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlGameFilds.ResumeLayout(false);
            this.gbTotlaScoreOfPlayer.ResumeLayout(false);
            this.gbTotlaScoreOfPlayer.PerformLayout();
            this.gbThisGameScore.ResumeLayout(false);
            this.gbThisGameScore.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblFullName;
        private Label lblPlayer;
        private Panel pnlVideo;
        private Panel pnlGameAction;
        private Panel pnlGameFilds;
        private Button btnNewGame;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label lblGameName;
        private GroupBox gbTotlaScoreOfPlayer;
        private TextBox txtTotalScore;
        private TextBox txtNumberOfGamesForThisPlayer;
        private Label lblTotalScore;
        private Label lblNumberOfGamesForThisPlayer;
        private GroupBox gbThisGameScore;
        private TextBox txtScoreInThisGame;
        private TextBox txtPlayerName;
        private Label lblNameOfPlayer;
        private Label lblScoreInThisGame;
        private Label lblPlayerID;
        private Button Cancel;
        private Button btnSettings;
    }
}