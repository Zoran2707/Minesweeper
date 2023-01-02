namespace Minesweeper
{
    partial class Edit
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
            this.pnlInfoForPlayer = new System.Windows.Forms.Panel();
            this.cbIsPlayerAdmin = new System.Windows.Forms.CheckBox();
            this.numPlayerGames = new System.Windows.Forms.NumericUpDown();
            this.numPlayerScore = new System.Windows.Forms.NumericUpDown();
            this.txtPlayerPass = new System.Windows.Forms.TextBox();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.lblIDValue = new System.Windows.Forms.Label();
            this.lblIsPlayerAdmin = new System.Windows.Forms.Label();
            this.lblNumberOfGames = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.lblPlayerPassword = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.pnlEditAction = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pnlInfoForPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPlayerGames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPlayerScore)).BeginInit();
            this.pnlEditAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInfoForPlayer
            // 
            this.pnlInfoForPlayer.Controls.Add(this.cbIsPlayerAdmin);
            this.pnlInfoForPlayer.Controls.Add(this.numPlayerGames);
            this.pnlInfoForPlayer.Controls.Add(this.numPlayerScore);
            this.pnlInfoForPlayer.Controls.Add(this.txtPlayerPass);
            this.pnlInfoForPlayer.Controls.Add(this.txtPlayerName);
            this.pnlInfoForPlayer.Controls.Add(this.lblIDValue);
            this.pnlInfoForPlayer.Controls.Add(this.lblIsPlayerAdmin);
            this.pnlInfoForPlayer.Controls.Add(this.lblNumberOfGames);
            this.pnlInfoForPlayer.Controls.Add(this.lblPlayerScore);
            this.pnlInfoForPlayer.Controls.Add(this.lblPlayerPassword);
            this.pnlInfoForPlayer.Controls.Add(this.lblPlayerName);
            this.pnlInfoForPlayer.Controls.Add(this.lblID);
            this.pnlInfoForPlayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfoForPlayer.Location = new System.Drawing.Point(0, 0);
            this.pnlInfoForPlayer.Name = "pnlInfoForPlayer";
            this.pnlInfoForPlayer.Size = new System.Drawing.Size(384, 387);
            this.pnlInfoForPlayer.TabIndex = 0;
            // 
            // cbIsPlayerAdmin
            // 
            this.cbIsPlayerAdmin.AutoSize = true;
            this.cbIsPlayerAdmin.Location = new System.Drawing.Point(232, 340);
            this.cbIsPlayerAdmin.Name = "cbIsPlayerAdmin";
            this.cbIsPlayerAdmin.Size = new System.Drawing.Size(109, 19);
            this.cbIsPlayerAdmin.TabIndex = 11;
            this.cbIsPlayerAdmin.Text = "Is  player admin";
            this.cbIsPlayerAdmin.UseVisualStyleBackColor = true;
            // 
            // numPlayerGames
            // 
            this.numPlayerGames.Location = new System.Drawing.Point(232, 270);
            this.numPlayerGames.Name = "numPlayerGames";
            this.numPlayerGames.Size = new System.Drawing.Size(120, 23);
            this.numPlayerGames.TabIndex = 10;
            // 
            // numPlayerScore
            // 
            this.numPlayerScore.Location = new System.Drawing.Point(232, 211);
            this.numPlayerScore.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPlayerScore.Name = "numPlayerScore";
            this.numPlayerScore.Size = new System.Drawing.Size(120, 23);
            this.numPlayerScore.TabIndex = 9;
            // 
            // txtPlayerPass
            // 
            this.txtPlayerPass.Location = new System.Drawing.Point(232, 152);
            this.txtPlayerPass.Name = "txtPlayerPass";
            this.txtPlayerPass.Size = new System.Drawing.Size(100, 23);
            this.txtPlayerPass.TabIndex = 8;
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(232, 95);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(100, 23);
            this.txtPlayerName.TabIndex = 7;
            this.txtPlayerName.Leave += new System.EventHandler(this.txtPlayerName_Leave);
            // 
            // lblIDValue
            // 
            this.lblIDValue.AutoSize = true;
            this.lblIDValue.Location = new System.Drawing.Point(232, 46);
            this.lblIDValue.Name = "lblIDValue";
            this.lblIDValue.Size = new System.Drawing.Size(46, 15);
            this.lblIDValue.TabIndex = 6;
            this.lblIDValue.Text = "IDValue";
            // 
            // lblIsPlayerAdmin
            // 
            this.lblIsPlayerAdmin.AutoSize = true;
            this.lblIsPlayerAdmin.Location = new System.Drawing.Point(40, 344);
            this.lblIsPlayerAdmin.Name = "lblIsPlayerAdmin";
            this.lblIsPlayerAdmin.Size = new System.Drawing.Size(87, 15);
            this.lblIsPlayerAdmin.TabIndex = 5;
            this.lblIsPlayerAdmin.Text = "Is player admin";
            //this.lblIsPlayerAdmin.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblNumberOfGames
            // 
            this.lblNumberOfGames.AutoSize = true;
            this.lblNumberOfGames.Location = new System.Drawing.Point(40, 278);
            this.lblNumberOfGames.Name = "lblNumberOfGames";
            this.lblNumberOfGames.Size = new System.Drawing.Size(103, 15);
            this.lblNumberOfGames.TabIndex = 4;
            this.lblNumberOfGames.Text = "Number of games";
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Location = new System.Drawing.Point(40, 219);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(70, 15);
            this.lblPlayerScore.TabIndex = 3;
            this.lblPlayerScore.Text = "Player score";
            // 
            // lblPlayerPassword
            // 
            this.lblPlayerPassword.AutoSize = true;
            this.lblPlayerPassword.Location = new System.Drawing.Point(40, 160);
            this.lblPlayerPassword.Name = "lblPlayerPassword";
            this.lblPlayerPassword.Size = new System.Drawing.Size(92, 15);
            this.lblPlayerPassword.TabIndex = 2;
            this.lblPlayerPassword.Text = "Player password";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(40, 103);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(72, 15);
            this.lblPlayerName.TabIndex = 1;
            this.lblPlayerName.Text = "Player name";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(40, 46);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(53, 15);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Player ID";
            // 
            // pnlEditAction
            // 
            this.pnlEditAction.Controls.Add(this.btnCancel);
            this.pnlEditAction.Controls.Add(this.btnEdit);
            this.pnlEditAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlEditAction.Location = new System.Drawing.Point(0, 393);
            this.pnlEditAction.Name = "pnlEditAction";
            this.pnlEditAction.Size = new System.Drawing.Size(384, 57);
            this.pnlEditAction.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(232, 27);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(40, 27);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 450);
            this.Controls.Add(this.pnlEditAction);
            this.Controls.Add(this.pnlInfoForPlayer);
            this.Name = "Edit";
            this.Text = "Edit player";
            this.pnlInfoForPlayer.ResumeLayout(false);
            this.pnlInfoForPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPlayerGames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPlayerScore)).EndInit();
            this.pnlEditAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlInfoForPlayer;
        private Label lblIsPlayerAdmin;
        private Label lblNumberOfGames;
        private Label lblPlayerScore;
        private Label lblPlayerPassword;
        private Label lblPlayerName;
        private Label lblID;
        private Panel pnlEditAction;
        private Button btnCancel;
        private Button btnEdit;
        private CheckBox cbIsPlayerAdmin;
        private NumericUpDown numPlayerGames;
        private NumericUpDown numPlayerScore;
        private TextBox txtPlayerPass;
        private TextBox txtPlayerName;
        private Label lblIDValue;
    }
}