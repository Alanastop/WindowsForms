namespace DcProgrammingTutorial
{
    partial class MainListForm
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
            this.CreateDocumentButton = new System.Windows.Forms.Button();
            this.CreteDocumentButton = new System.Windows.Forms.Button();
            this.DeleteDocumentButton = new System.Windows.Forms.Button();
            this.enterButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.calculateBalanceButton = new System.Windows.Forms.Button();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.averageBalanceButton = new System.Windows.Forms.Button();
            this.averageBalanceTextBox = new System.Windows.Forms.TextBox();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.asfdsfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateDocumentButton
            // 
            this.CreateDocumentButton.Location = new System.Drawing.Point(-178, 345);
            this.CreateDocumentButton.Name = "CreateDocumentButton";
            this.CreateDocumentButton.Size = new System.Drawing.Size(144, 23);
            this.CreateDocumentButton.TabIndex = 5;
            this.CreateDocumentButton.Text = "CREATE DOCUMENT";
            this.CreateDocumentButton.UseVisualStyleBackColor = true;
            // 
            // CreteDocumentButton
            // 
            this.CreteDocumentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreteDocumentButton.Location = new System.Drawing.Point(26, 512);
            this.CreteDocumentButton.Name = "CreteDocumentButton";
            this.CreteDocumentButton.Size = new System.Drawing.Size(138, 27);
            this.CreteDocumentButton.TabIndex = 7;
            this.CreteDocumentButton.Text = "CREATE DOCUMENT";
            this.CreteDocumentButton.UseVisualStyleBackColor = true;
            this.CreteDocumentButton.Click += new System.EventHandler(this.CreteDocumentButtonClick);
            // 
            // DeleteDocumentButton
            // 
            this.DeleteDocumentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteDocumentButton.Location = new System.Drawing.Point(762, 579);
            this.DeleteDocumentButton.Name = "DeleteDocumentButton";
            this.DeleteDocumentButton.Size = new System.Drawing.Size(176, 27);
            this.DeleteDocumentButton.TabIndex = 8;
            this.DeleteDocumentButton.Text = "DELETE DOCUMENT";
            this.DeleteDocumentButton.UseVisualStyleBackColor = true;
            this.DeleteDocumentButton.Click += new System.EventHandler(this.DeleteDocumentButtonClick);
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(351, 519);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 13;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Visible = false;
            this.enterButton.Click += new System.EventHandler(this.EnterButtonClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyNameDataGridViewTextBoxColumn,
            this.Id,
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.creationDateDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.documentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(965, 478);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1CellMouseDoubleClick);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(188, 519);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(122, 20);
            this.nameTextBox.TabIndex = 14;
            this.nameTextBox.Text = "Type document name";
            this.nameTextBox.Visible = false;
            // 
            // calculateBalanceButton
            // 
            this.calculateBalanceButton.Location = new System.Drawing.Point(26, 555);
            this.calculateBalanceButton.Name = "calculateBalanceButton";
            this.calculateBalanceButton.Size = new System.Drawing.Size(138, 23);
            this.calculateBalanceButton.TabIndex = 15;
            this.calculateBalanceButton.Text = "CALCULATE TAX";
            this.calculateBalanceButton.UseVisualStyleBackColor = true;
            this.calculateBalanceButton.Click += new System.EventHandler(this.CalculateTaxButtonClick);
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Location = new System.Drawing.Point(188, 558);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.ReadOnly = true;
            this.balanceTextBox.Size = new System.Drawing.Size(122, 20);
            this.balanceTextBox.TabIndex = 16;
            this.balanceTextBox.Text = "TAX";
            // 
            // averageBalanceButton
            // 
            this.averageBalanceButton.Location = new System.Drawing.Point(26, 586);
            this.averageBalanceButton.Name = "averageBalanceButton";
            this.averageBalanceButton.Size = new System.Drawing.Size(138, 23);
            this.averageBalanceButton.TabIndex = 17;
            this.averageBalanceButton.Text = "AVERAGE BALANCE";
            this.averageBalanceButton.UseVisualStyleBackColor = true;
            this.averageBalanceButton.Click += new System.EventHandler(this.AverageBalanceButtonClick);
            // 
            // averageBalanceTextBox
            // 
            this.averageBalanceTextBox.Location = new System.Drawing.Point(188, 589);
            this.averageBalanceTextBox.Name = "averageBalanceTextBox";
            this.averageBalanceTextBox.ReadOnly = true;
            this.averageBalanceTextBox.Size = new System.Drawing.Size(122, 20);
            this.averageBalanceTextBox.TabIndex = 18;
            this.averageBalanceTextBox.Text = "AVERAGE BALANCE";
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            this.companyNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // creationDateDataGridViewTextBoxColumn
            // 
            this.creationDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.creationDateDataGridViewTextBoxColumn.DataPropertyName = "CreationDate";
            this.creationDateDataGridViewTextBoxColumn.HeaderText = "CreationDate";
            this.creationDateDataGridViewTextBoxColumn.Name = "creationDateDataGridViewTextBoxColumn";
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            // 
            // documentBindingSource
            // 
            this.documentBindingSource.DataSource = typeof(DcProgrammingTutorialLibrary.Document);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asfdsfToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(964, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // asfdsfToolStripMenuItem
            // 
            this.asfdsfToolStripMenuItem.Name = "asfdsfToolStripMenuItem";
            this.asfdsfToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.asfdsfToolStripMenuItem.Text = "EXIT";
            this.asfdsfToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 654);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.averageBalanceTextBox);
            this.Controls.Add(this.averageBalanceButton);
            this.Controls.Add(this.balanceTextBox);
            this.Controls.Add(this.calculateBalanceButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.DeleteDocumentButton);
            this.Controls.Add(this.CreteDocumentButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CreateDocumentButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CreateDocumentButton;
        private System.Windows.Forms.Button CreteDocumentButton;
        private System.Windows.Forms.Button DeleteDocumentButton;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource documentBindingSource;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button calculateBalanceButton;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.Button averageBalanceButton;
        private System.Windows.Forms.TextBox averageBalanceTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem asfdsfToolStripMenuItem;
    }
}

