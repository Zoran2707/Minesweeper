namespace Minesweeper
{
    partial class frmAdmin
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
            this.pnlAction = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlPlayers = new System.Windows.Forms.Panel();
            this.dgwPlayers = new System.Windows.Forms.DataGridView();
            this.pnlAction.SuspendLayout();
            this.pnlPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAction
            // 
            this.pnlAction.BackColor = System.Drawing.Color.Yellow;
            this.pnlAction.Controls.Add(this.btnEdit);
            this.pnlAction.Controls.Add(this.btnDelete);
            this.pnlAction.Controls.Add(this.btnAdd);
            this.pnlAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAction.Location = new System.Drawing.Point(0, 450);
            this.pnlAction.Name = "pnlAction";
            this.pnlAction.Size = new System.Drawing.Size(522, 100);
            this.pnlAction.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEdit.Location = new System.Drawing.Point(369, 19);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(141, 55);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelete.Location = new System.Drawing.Point(191, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(141, 55);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdd.Location = new System.Drawing.Point(12, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(141, 55);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlPlayers
            // 
            this.pnlPlayers.BackColor = System.Drawing.Color.Cyan;
            this.pnlPlayers.Controls.Add(this.dgwPlayers);
            this.pnlPlayers.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPlayers.Location = new System.Drawing.Point(0, 0);
            this.pnlPlayers.Name = "pnlPlayers";
            this.pnlPlayers.Size = new System.Drawing.Size(522, 444);
            this.pnlPlayers.TabIndex = 1;
            // 
            // dgwPlayers
            // 
            this.dgwPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwPlayers.Location = new System.Drawing.Point(0, 0);
            this.dgwPlayers.Name = "dgwPlayers";
            this.dgwPlayers.RowTemplate.Height = 25;
            this.dgwPlayers.Size = new System.Drawing.Size(522, 444);
            this.dgwPlayers.TabIndex = 0;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 550);
            this.Controls.Add(this.pnlPlayers);
            this.Controls.Add(this.pnlAction);
            this.Name = "frmAdmin";
            this.Text = "Administration form";
            this.Activated += new System.EventHandler(this.Init1);
            this.pnlAction.ResumeLayout(false);
            this.pnlPlayers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPlayers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlAction;
        private Panel pnlPlayers;
        private DataGridView dgwPlayers;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnAdd;
    }
}