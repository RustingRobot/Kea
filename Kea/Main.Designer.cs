namespace Kea
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.HandleBar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.URLTextbox = new System.Windows.Forms.RichTextBox();
            this.exitBtn = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.addToQueueBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.processInfo = new System.Windows.Forms.TextBox();
            this.QueueGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueueTextbox = new System.Windows.Forms.RichTextBox();
            this.savepathTB = new System.Windows.Forms.TextBox();
            this.selectFolderBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cartoonFoldersCB = new System.Windows.Forms.CheckBox();
            this.chapterFoldersCB = new System.Windows.Forms.CheckBox();
            this.minimizeBtn = new System.Windows.Forms.PictureBox();
            this.removeAllBtn = new System.Windows.Forms.Button();
            this.removeSelectedBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.helpBtn = new System.Windows.Forms.Button();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.saveAsOption = new System.Windows.Forms.ComboBox();
            this.cbOneFile = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.HandleBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueueGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HandleBar
            // 
            this.HandleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(14)))));
            this.HandleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.HandleBar.Location = new System.Drawing.Point(0, 0);
            this.HandleBar.Name = "HandleBar";
            this.HandleBar.Size = new System.Drawing.Size(544, 30);
            this.HandleBar.TabIndex = 0;
            this.HandleBar.TabStop = false;
            this.HandleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HandleBar_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
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
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(14)))));
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.Location = new System.Drawing.Point(510, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(34, 30);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.TabStop = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            this.exitBtn.MouseEnter += new System.EventHandler(this.exitBtn_MouseEnter);
            this.exitBtn.MouseLeave += new System.EventHandler(this.exitBtn_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.label3.Location = new System.Drawing.Point(9, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "queue";
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(165)))), ((int)(((byte)(157)))));
            this.startBtn.FlatAppearance.BorderSize = 0;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.startBtn.Location = new System.Drawing.Point(12, 496);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(520, 26);
            this.startBtn.TabIndex = 8;
            this.startBtn.Text = "start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.White;
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(0, 554);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(544, 20);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 10;
            // 
            // addToQueueBtn
            // 
            this.addToQueueBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(165)))), ((int)(((byte)(157)))));
            this.addToQueueBtn.FlatAppearance.BorderSize = 0;
            this.addToQueueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToQueueBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToQueueBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.addToQueueBtn.Location = new System.Drawing.Point(12, 164);
            this.addToQueueBtn.Name = "addToQueueBtn";
            this.addToQueueBtn.Size = new System.Drawing.Size(122, 26);
            this.addToQueueBtn.TabIndex = 11;
            this.addToQueueBtn.Text = "add all to queue";
            this.addToQueueBtn.UseVisualStyleBackColor = false;
            this.addToQueueBtn.Click += new System.EventHandler(this.addToQueueBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.label4.Location = new System.Drawing.Point(9, 530);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "currently processing:";
            // 
            // processInfo
            // 
            this.processInfo.Location = new System.Drawing.Point(154, 528);
            this.processInfo.Name = "processInfo";
            this.processInfo.ReadOnly = true;
            this.processInfo.Size = new System.Drawing.Size(378, 20);
            this.processInfo.TabIndex = 13;
            // 
            // QueueGrid
            // 
            this.QueueGrid.AllowUserToAddRows = false;
            this.QueueGrid.AllowUserToDeleteRows = false;
            this.QueueGrid.AllowUserToResizeColumns = false;
            this.QueueGrid.AllowUserToResizeRows = false;
            this.QueueGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(165)))), ((int)(((byte)(157)))));
            this.QueueGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QueueGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.QueueGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QueueGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.QueueGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.QueueGrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.QueueGrid.Location = new System.Drawing.Point(12, 221);
            this.QueueGrid.MultiSelect = false;
            this.QueueGrid.Name = "QueueGrid";
            this.QueueGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.QueueGrid.Size = new System.Drawing.Size(520, 146);
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
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 159;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "End at chapter";
            this.Column3.Name = "Column3";
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 160;
            // 
            // QueueTextbox
            // 
            this.QueueTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QueueTextbox.Location = new System.Drawing.Point(12, 221);
            this.QueueTextbox.Name = "QueueTextbox";
            this.QueueTextbox.ReadOnly = true;
            this.QueueTextbox.Size = new System.Drawing.Size(520, 63);
            this.QueueTextbox.TabIndex = 7;
            this.QueueTextbox.Text = "";
            this.QueueTextbox.Visible = false;
            // 
            // savepathTB
            // 
            this.savepathTB.Location = new System.Drawing.Point(12, 397);
            this.savepathTB.Name = "savepathTB";
            this.savepathTB.ReadOnly = true;
            this.savepathTB.Size = new System.Drawing.Size(483, 20);
            this.savepathTB.TabIndex = 15;
            // 
            // selectFolderBtn
            // 
            this.selectFolderBtn.BackColor = System.Drawing.Color.White;
            this.selectFolderBtn.FlatAppearance.BorderSize = 0;
            this.selectFolderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectFolderBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11.25F, System.Drawing.FontStyle.Bold);
            this.selectFolderBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.selectFolderBtn.Image = ((System.Drawing.Image)(resources.GetObject("selectFolderBtn.Image")));
            this.selectFolderBtn.Location = new System.Drawing.Point(501, 394);
            this.selectFolderBtn.Name = "selectFolderBtn";
            this.selectFolderBtn.Size = new System.Drawing.Size(31, 26);
            this.selectFolderBtn.TabIndex = 16;
            this.selectFolderBtn.UseVisualStyleBackColor = false;
            this.selectFolderBtn.Click += new System.EventHandler(this.selectFolderBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.label2.Location = new System.Drawing.Point(9, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "use sub-folders for:";
            // 
            // cartoonFoldersCB
            // 
            this.cartoonFoldersCB.AutoSize = true;
            this.cartoonFoldersCB.Checked = true;
            this.cartoonFoldersCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cartoonFoldersCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartoonFoldersCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.cartoonFoldersCB.Location = new System.Drawing.Point(154, 429);
            this.cartoonFoldersCB.Name = "cartoonFoldersCB";
            this.cartoonFoldersCB.Size = new System.Drawing.Size(105, 20);
            this.cartoonFoldersCB.TabIndex = 18;
            this.cartoonFoldersCB.Text = "each cartoon";
            this.cartoonFoldersCB.UseVisualStyleBackColor = true;
            // 
            // chapterFoldersCB
            // 
            this.chapterFoldersCB.AutoSize = true;
            this.chapterFoldersCB.Enabled = false;
            this.chapterFoldersCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chapterFoldersCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.chapterFoldersCB.Location = new System.Drawing.Point(280, 429);
            this.chapterFoldersCB.Name = "chapterFoldersCB";
            this.chapterFoldersCB.Size = new System.Drawing.Size(105, 20);
            this.chapterFoldersCB.TabIndex = 19;
            this.chapterFoldersCB.Text = "each chapter";
            this.chapterFoldersCB.UseVisualStyleBackColor = true;
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(14)))));
            this.minimizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.minimizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("minimizeBtn.Image")));
            this.minimizeBtn.Location = new System.Drawing.Point(477, 0);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(34, 30);
            this.minimizeBtn.TabIndex = 20;
            this.minimizeBtn.TabStop = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            this.minimizeBtn.MouseEnter += new System.EventHandler(this.minimizeBtn_MouseEnter);
            this.minimizeBtn.MouseLeave += new System.EventHandler(this.minimizeBtn_MouseLeave);
            // 
            // removeAllBtn
            // 
            this.removeAllBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(165)))), ((int)(((byte)(157)))));
            this.removeAllBtn.FlatAppearance.BorderSize = 0;
            this.removeAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeAllBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.removeAllBtn.Location = new System.Drawing.Point(409, 164);
            this.removeAllBtn.Name = "removeAllBtn";
            this.removeAllBtn.Size = new System.Drawing.Size(123, 26);
            this.removeAllBtn.TabIndex = 21;
            this.removeAllBtn.Text = "remove all";
            this.removeAllBtn.UseVisualStyleBackColor = false;
            this.removeAllBtn.Click += new System.EventHandler(this.removeAllBtn_Click);
            // 
            // removeSelectedBtn
            // 
            this.removeSelectedBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(165)))), ((int)(((byte)(157)))));
            this.removeSelectedBtn.FlatAppearance.BorderSize = 0;
            this.removeSelectedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSelectedBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.removeSelectedBtn.Location = new System.Drawing.Point(280, 164);
            this.removeSelectedBtn.Name = "removeSelectedBtn";
            this.removeSelectedBtn.Size = new System.Drawing.Size(123, 26);
            this.removeSelectedBtn.TabIndex = 22;
            this.removeSelectedBtn.Text = "remove selected";
            this.removeSelectedBtn.UseVisualStyleBackColor = false;
            this.removeSelectedBtn.Click += new System.EventHandler(this.removeSelectedBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.label5.Location = new System.Drawing.Point(9, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "save chapters as:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.label6.Location = new System.Drawing.Point(9, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "options";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(14)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(44, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Kea";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(14)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(8, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // helpBtn
            // 
            this.helpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(193)))), ((int)(((byte)(185)))));
            this.helpBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.helpBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.helpBtn.FlatAppearance.BorderSize = 0;
            this.helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.helpBtn.Location = new System.Drawing.Point(377, 36);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.helpBtn.Size = new System.Drawing.Size(155, 26);
            this.helpBtn.TabIndex = 29;
            this.helpBtn.Text = "help, how do I use this ?";
            this.helpBtn.UseVisualStyleBackColor = false;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // saveAsOption
            // 
            this.saveAsOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.saveAsOption.FormattingEnabled = true;
            this.saveAsOption.Items.AddRange(new object[] {
            "PDF file",
            "CBZ file",
            "multiple images",
            "one image (may be lower in quality)"});
            this.saveAsOption.Location = new System.Drawing.Point(154, 455);
            this.saveAsOption.Name = "saveAsOption";
            this.saveAsOption.Size = new System.Drawing.Size(230, 24);
            this.saveAsOption.TabIndex = 30;
            this.saveAsOption.Text = "PDF file";
            this.saveAsOption.SelectedIndexChanged += new System.EventHandler(this.saveAsOption_SelectedIndexChanged);
            // 
            // cbOneFile
            // 
            this.cbOneFile.AutoSize = true;
            this.cbOneFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOneFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.cbOneFile.Location = new System.Drawing.Point(409, 457);
            this.cbOneFile.Name = "cbOneFile";
            this.cbOneFile.Size = new System.Drawing.Size(117, 20);
            this.cbOneFile.TabIndex = 31;
            this.cbOneFile.Text = "One PDF for all";
            this.cbOneFile.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(193)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(544, 574);
            this.Controls.Add(this.cbOneFile);
            this.Controls.Add(this.saveAsOption);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.removeSelectedBtn);
            this.Controls.Add(this.removeAllBtn);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.chapterFoldersCB);
            this.Controls.Add(this.cartoonFoldersCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectFolderBtn);
            this.Controls.Add(this.savepathTB);
            this.Controls.Add(this.QueueGrid);
            this.Controls.Add(this.processInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addToQueueBtn);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.QueueTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.URLTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HandleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Kea";
            ((System.ComponentModel.ISupportInitialize)(this.HandleBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueueGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox HandleBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox URLTextbox;
        private System.Windows.Forms.PictureBox exitBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button addToQueueBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox processInfo;
        private System.Windows.Forms.DataGridView QueueGrid;
        private System.Windows.Forms.RichTextBox QueueTextbox;
        private System.Windows.Forms.TextBox savepathTB;
        private System.Windows.Forms.Button selectFolderBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cartoonFoldersCB;
        private System.Windows.Forms.CheckBox chapterFoldersCB;
        private System.Windows.Forms.PictureBox minimizeBtn;
        private System.Windows.Forms.Button removeAllBtn;
        private System.Windows.Forms.Button removeSelectedBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ToolTip toolTips;
        private System.Windows.Forms.ComboBox saveAsOption;
        private System.Windows.Forms.CheckBox cbOneFile;
    }
}

