
namespace RESTMovie
{
    partial class SoldTicketsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoldTicketsForm));
            this.add_button = new System.Windows.Forms.Button();
            this.upd_button = new System.Windows.Forms.Button();
            this.del_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.IdStoreLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userIdBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ticketIdBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ticketIdLabel = new System.Windows.Forms.Label();
            this.TicketsGrid = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TicketsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.DarkRed;
            this.add_button.ForeColor = System.Drawing.Color.White;
            this.add_button.Location = new System.Drawing.Point(809, 236);
            this.add_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(181, 22);
            this.add_button.TabIndex = 23;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // upd_button
            // 
            this.upd_button.BackColor = System.Drawing.Color.DarkRed;
            this.upd_button.ForeColor = System.Drawing.Color.White;
            this.upd_button.Location = new System.Drawing.Point(809, 276);
            this.upd_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.upd_button.Name = "upd_button";
            this.upd_button.Size = new System.Drawing.Size(181, 22);
            this.upd_button.TabIndex = 22;
            this.upd_button.Text = "Update";
            this.upd_button.UseVisualStyleBackColor = false;
            this.upd_button.Click += new System.EventHandler(this.upd_button_Click);
            // 
            // del_button
            // 
            this.del_button.BackColor = System.Drawing.Color.DarkRed;
            this.del_button.ForeColor = System.Drawing.Color.White;
            this.del_button.Location = new System.Drawing.Point(809, 319);
            this.del_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.del_button.Name = "del_button";
            this.del_button.Size = new System.Drawing.Size(181, 22);
            this.del_button.TabIndex = 21;
            this.del_button.Text = "Delete";
            this.del_button.UseVisualStyleBackColor = false;
            this.del_button.Click += new System.EventHandler(this.del_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkRed;
            this.groupBox2.Controls.Add(this.IdStoreLabel);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.userIdBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ticketIdBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ticketIdLabel);
            this.groupBox2.Location = new System.Drawing.Point(722, 20);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(335, 212);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ticket properties";
            // 
            // IdStoreLabel
            // 
            this.IdStoreLabel.AutoSize = true;
            this.IdStoreLabel.ForeColor = System.Drawing.Color.White;
            this.IdStoreLabel.Location = new System.Drawing.Point(94, 36);
            this.IdStoreLabel.Name = "IdStoreLabel";
            this.IdStoreLabel.Size = new System.Drawing.Size(38, 15);
            this.IdStoreLabel.TabIndex = 13;
            this.IdStoreLabel.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Id:";
            // 
            // userIdBox
            // 
            this.userIdBox.BackColor = System.Drawing.Color.Maroon;
            this.userIdBox.ForeColor = System.Drawing.Color.White;
            this.userIdBox.Location = new System.Drawing.Point(94, 111);
            this.userIdBox.Name = "userIdBox";
            this.userIdBox.Size = new System.Drawing.Size(154, 23);
            this.userIdBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "User Id:";
            // 
            // ticketIdBox
            // 
            this.ticketIdBox.BackColor = System.Drawing.Color.Maroon;
            this.ticketIdBox.ForeColor = System.Drawing.Color.White;
            this.ticketIdBox.Location = new System.Drawing.Point(94, 76);
            this.ticketIdBox.Name = "ticketIdBox";
            this.ticketIdBox.Size = new System.Drawing.Size(154, 23);
            this.ticketIdBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 3;
            // 
            // ticketIdLabel
            // 
            this.ticketIdLabel.AutoSize = true;
            this.ticketIdLabel.ForeColor = System.Drawing.Color.White;
            this.ticketIdLabel.Location = new System.Drawing.Point(26, 75);
            this.ticketIdLabel.Name = "ticketIdLabel";
            this.ticketIdLabel.Size = new System.Drawing.Size(54, 15);
            this.ticketIdLabel.TabIndex = 0;
            this.ticketIdLabel.Text = "Ticket Id:";
            // 
            // TicketsGrid
            // 
            this.TicketsGrid.BackgroundColor = System.Drawing.Color.DarkRed;
            this.TicketsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TicketsGrid.GridColor = System.Drawing.Color.White;
            this.TicketsGrid.Location = new System.Drawing.Point(12, 20);
            this.TicketsGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TicketsGrid.Name = "TicketsGrid";
            this.TicketsGrid.RowHeadersWidth = 51;
            this.TicketsGrid.RowTemplate.Height = 29;
            this.TicketsGrid.Size = new System.Drawing.Size(636, 410);
            this.TicketsGrid.TabIndex = 19;
            this.TicketsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TicketsGrid_CellClick);
            // 
            // SoldTicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1098, 468);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.upd_button);
            this.Controls.Add(this.del_button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.TicketsGrid);
            this.Name = "SoldTicketsForm";
            this.Text = "SoldTicketsForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TicketsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button upd_button;
        private System.Windows.Forms.Button del_button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox userIdBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ticketIdBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ticketIdLabel;
        private System.Windows.Forms.DataGridView TicketsGrid;
        private System.Windows.Forms.Label IdStoreLabel;
        private System.Windows.Forms.Label label2;
    }
}