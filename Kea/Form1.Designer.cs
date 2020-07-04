namespace Kea
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
            this.HandleBar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.URLTextbox = new System.Windows.Forms.RichTextBox();
            this.exitBtn = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.addToQueueBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.processInfo = new System.Windows.Forms.TextBox();
            this.QueueGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueueTextbox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.HandleBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueueGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // HandleBar
            // 
            this.HandleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HandleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.HandleBar.Location = new System.Drawing.Point(0, 0);
            this.HandleBar.Name = "HandleBar";
            this.HandleBar.Size = new System.Drawing.Size(544, 33);
            this.HandleBar.TabIndex = 0;
            this.HandleBar.TabStop = false;
            this.HandleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HandleBar_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "enter URLs below";
            // 
            // URLTextbox
            // 
            this.URLTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.URLTextbox.Location = new System.Drawing.Point(12, 62);
            this.URLTextbox.Name = "URLTextbox";
            this.URLTextbox.Size = new System.Drawing.Size(520, 96);
            this.URLTextbox.TabIndex = 3;
            this.URLTextbox.Text = "";
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Silver;
            this.exitBtn.Location = new System.Drawing.Point(511, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(33, 19);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.TabStop = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(12, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "options";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(9, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "queue";
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.White;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11.25F, System.Drawing.FontStyle.Bold);
            this.startBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.startBtn.Location = new System.Drawing.Point(12, 438);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(107, 26);
            this.startBtn.TabIndex = 8;
            this.startBtn.Text = "start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.White;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11.25F, System.Drawing.FontStyle.Bold);
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cancelBtn.Location = new System.Drawing.Point(425, 438);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(107, 26);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.White;
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 472);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(544, 20);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 10;
            // 
            // addToQueueBtn
            // 
            this.addToQueueBtn.BackColor = System.Drawing.Color.White;
            this.addToQueueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToQueueBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11.25F, System.Drawing.FontStyle.Bold);
            this.addToQueueBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addToQueueBtn.Location = new System.Drawing.Point(350, 164);
            this.addToQueueBtn.Name = "addToQueueBtn";
            this.addToQueueBtn.Size = new System.Drawing.Size(182, 26);
            this.addToQueueBtn.TabIndex = 11;
            this.addToQueueBtn.Text = "add all to queue";
            this.addToQueueBtn.UseVisualStyleBackColor = false;
            this.addToQueueBtn.Click += new System.EventHandler(this.addToQueueBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(12, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "currently processing";
            // 
            // processInfo
            // 
            this.processInfo.Location = new System.Drawing.Point(12, 412);
            this.processInfo.Name = "processInfo";
            this.processInfo.ReadOnly = true;
            this.processInfo.Size = new System.Drawing.Size(520, 20);
            this.processInfo.TabIndex = 13;
            // 
            // QueueGrid
            // 
            this.QueueGrid.AllowUserToAddRows = false;
            this.QueueGrid.AllowUserToDeleteRows = false;
            this.QueueGrid.AllowUserToResizeColumns = false;
            this.QueueGrid.AllowUserToResizeRows = false;
            this.QueueGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QueueGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.QueueGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QueueGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.QueueGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.QueueGrid.Location = new System.Drawing.Point(12, 226);
            this.QueueGrid.MultiSelect = false;
            this.QueueGrid.Name = "QueueGrid";
            this.QueueGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.QueueGrid.Size = new System.Drawing.Size(520, 165);
            this.QueueGrid.TabIndex = 14;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 160;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "start at chapter";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 159;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "End at chapter";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 160;
            // 
            // QueueTextbox
            // 
            this.QueueTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QueueTextbox.Location = new System.Drawing.Point(12, 226);
            this.QueueTextbox.Name = "QueueTextbox";
            this.QueueTextbox.ReadOnly = true;
            this.QueueTextbox.Size = new System.Drawing.Size(520, 40);
            this.QueueTextbox.TabIndex = 7;
            this.QueueTextbox.Text = "";
            this.QueueTextbox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(544, 492);
            this.Controls.Add(this.QueueGrid);
            this.Controls.Add(this.processInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addToQueueBtn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.QueueTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.URLTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HandleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Kea";
            ((System.ComponentModel.ISupportInitialize)(this.HandleBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueueGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox HandleBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox URLTextbox;
        private System.Windows.Forms.PictureBox exitBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button addToQueueBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox processInfo;
        private System.Windows.Forms.DataGridView QueueGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.RichTextBox QueueTextbox;
    }
}

