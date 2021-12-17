
namespace RESTMovie
{
    partial class TicketsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketsForm));
            this.add_button = new System.Windows.Forms.Button();
            this.upd_button = new System.Windows.Forms.Button();
            this.del_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.streamTimeBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.movieIdBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.movieTitleBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ticketIdLabel = new System.Windows.Forms.Label();
            this.TicketsGrid = new System.Windows.Forms.DataGridView();
            this.ticketIdBox = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TicketsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.DarkRed;
            this.add_button.ForeColor = System.Drawing.Color.White;
            this.add_button.Location = new System.Drawing.Point(697, 243);
            this.add_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(181, 22);
            this.add_button.TabIndex = 18;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // upd_button
            // 
            this.upd_button.BackColor = System.Drawing.Color.DarkRed;
            this.upd_button.ForeColor = System.Drawing.Color.White;
            this.upd_button.Location = new System.Drawing.Point(697, 283);
            this.upd_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.upd_button.Name = "upd_button";
            this.upd_button.Size = new System.Drawing.Size(181, 22);
            this.upd_button.TabIndex = 17;
            this.upd_button.Text = "Update";
            this.upd_button.UseVisualStyleBackColor = false;
            this.upd_button.Click += new System.EventHandler(this.upd_button_Click);
            // 
            // del_button
            // 
            this.del_button.BackColor = System.Drawing.Color.DarkRed;
            this.del_button.ForeColor = System.Drawing.Color.White;
            this.del_button.Location = new System.Drawing.Point(697, 326);
            this.del_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.del_button.Name = "del_button";
            this.del_button.Size = new System.Drawing.Size(181, 22);
            this.del_button.TabIndex = 16;
            this.del_button.Text = "Delete";
            this.del_button.UseVisualStyleBackColor = false;
            this.del_button.Click += new System.EventHandler(this.del_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkRed;
            this.groupBox2.Controls.Add(this.ticketIdBox);
            this.groupBox2.Controls.Add(this.streamTimeBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.movieIdBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.movieTitleBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ticketIdLabel);
            this.groupBox2.Location = new System.Drawing.Point(610, 27);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(335, 212);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ticket properties";
            // 
            // streamTimeBox
            // 
            this.streamTimeBox.BackColor = System.Drawing.Color.Maroon;
            this.streamTimeBox.Location = new System.Drawing.Point(90, 146);
            this.streamTimeBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.streamTimeBox.Name = "streamTimeBox";
            this.streamTimeBox.Size = new System.Drawing.Size(154, 23);
            this.streamTimeBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Stream Time:";
            // 
            // movieIdBox
            // 
            this.movieIdBox.BackColor = System.Drawing.Color.Maroon;
            this.movieIdBox.Location = new System.Drawing.Point(90, 67);
            this.movieIdBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.movieIdBox.Name = "movieIdBox";
            this.movieIdBox.Size = new System.Drawing.Size(154, 23);
            this.movieIdBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Movie id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 3;
            // 
            // movieTitleBox
            // 
            this.movieTitleBox.BackColor = System.Drawing.Color.Maroon;
            this.movieTitleBox.Location = new System.Drawing.Point(90, 106);
            this.movieTitleBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.movieTitleBox.Name = "movieTitleBox";
            this.movieTitleBox.Size = new System.Drawing.Size(154, 23);
            this.movieTitleBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Movie Title:";
            // 
            // ticketIdLabel
            // 
            this.ticketIdLabel.AutoSize = true;
            this.ticketIdLabel.ForeColor = System.Drawing.Color.White;
            this.ticketIdLabel.Location = new System.Drawing.Point(22, 35);
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
            this.TicketsGrid.Location = new System.Drawing.Point(-145, 20);
            this.TicketsGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TicketsGrid.Name = "TicketsGrid";
            this.TicketsGrid.RowHeadersWidth = 51;
            this.TicketsGrid.RowTemplate.Height = 29;
            this.TicketsGrid.Size = new System.Drawing.Size(749, 410);
            this.TicketsGrid.TabIndex = 14;
            this.TicketsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TicketsGrid_CellClick);
            // 
            // ticketIdBox
            // 
            this.ticketIdBox.BackColor = System.Drawing.Color.Maroon;
            this.ticketIdBox.Location = new System.Drawing.Point(90, 35);
            this.ticketIdBox.Name = "ticketIdBox";
            this.ticketIdBox.Size = new System.Drawing.Size(154, 23);
            this.ticketIdBox.TabIndex = 9;
            // 
            // TicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(958, 471);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.upd_button);
            this.Controls.Add(this.del_button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.TicketsGrid);
            this.Name = "TicketsForm";
            this.Text = "TicketsForm";
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
        private System.Windows.Forms.TextBox streamTimeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox movieIdBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox movieTitleBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ticketIdLabel;
        private System.Windows.Forms.DataGridView TicketsGrid;
        private System.Windows.Forms.TextBox ticketIdBox;
    }
}