namespace TiffApp_02
{
    partial class mainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.dataGritPanel = new System.Windows.Forms.Panel();
            this.tiffgridview = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.taggridview = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.allTagsGrid = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.browsefilebutton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.browsetiffsdial = new System.Windows.Forms.FolderBrowserDialog();
            this.logPanel = new System.Windows.Forms.Panel();
            this.logBox = new System.Windows.Forms.TextBox();
            this.toolStripPanel = new System.Windows.Forms.Panel();
            this.pathLable = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.dataGritPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tiffgridview)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taggridview)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allTagsGrid)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.logPanel.SuspendLayout();
            this.toolStripPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGritPanel
            // 
            this.dataGritPanel.AutoSize = true;
            this.dataGritPanel.Controls.Add(this.tiffgridview);
            this.dataGritPanel.Controls.Add(this.splitter1);
            this.dataGritPanel.Controls.Add(this.tabControl1);
            this.dataGritPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGritPanel.Location = new System.Drawing.Point(0, 68);
            this.dataGritPanel.Name = "dataGritPanel";
            this.dataGritPanel.Size = new System.Drawing.Size(989, 340);
            this.dataGritPanel.TabIndex = 0;
            // 
            // tiffgridview
            // 
            this.tiffgridview.AllowUserToResizeColumns = false;
            this.tiffgridview.AllowUserToResizeRows = false;
            this.tiffgridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.tiffgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tiffgridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4});
            this.tiffgridview.ContextMenuStrip = this.contextMenuStrip1;
            this.tiffgridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tiffgridview.Location = new System.Drawing.Point(0, 0);
            this.tiffgridview.Name = "tiffgridview";
            this.tiffgridview.ReadOnly = true;
            this.tiffgridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tiffgridview.Size = new System.Drawing.Size(547, 340);
            this.tiffgridview.TabIndex = 0;
            this.tiffgridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.tiffgridview.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 5;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Файлы";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(146, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.toolStripMenuItem1.Text = "Save Selected";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(547, 0);
            this.splitter1.MinimumSize = new System.Drawing.Size(5, 5);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 340);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl1.Location = new System.Drawing.Point(552, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(437, 340);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.taggridview);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(429, 314);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список тегов ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // taggridview
            // 
            this.taggridview.AllowUserToResizeColumns = false;
            this.taggridview.AllowUserToResizeRows = false;
            this.taggridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.taggridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taggridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3});
            this.taggridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taggridview.Location = new System.Drawing.Point(3, 3);
            this.taggridview.Name = "taggridview";
            this.taggridview.ReadOnly = true;
            this.taggridview.Size = new System.Drawing.Size(423, 308);
            this.taggridview.TabIndex = 0;
            this.taggridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.taggridview_CellContentClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Теги";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "значения";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.allTagsGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(429, 314);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Полный список тегов";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // allTagsGrid
            // 
            this.allTagsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allTagsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6});
            this.allTagsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allTagsGrid.Location = new System.Drawing.Point(3, 3);
            this.allTagsGrid.Name = "allTagsGrid";
            this.allTagsGrid.Size = new System.Drawing.Size(423, 308);
            this.allTagsGrid.TabIndex = 0;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Теги";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "значения";
            this.Column6.Name = "Column6";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browsefilebutton,
            this.toolStripSeparator1,
            this.saveButton,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(989, 32);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // browsefilebutton
            // 
            this.browsefilebutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.browsefilebutton.Image = ((System.Drawing.Image)(resources.GetObject("browsefilebutton.Image")));
            this.browsefilebutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.browsefilebutton.Name = "browsefilebutton";
            this.browsefilebutton.Size = new System.Drawing.Size(175, 29);
            this.browsefilebutton.Text = "Загрузить Файлы...";
            this.browsefilebutton.ToolTipText = "Загрузить Файлы";
            this.browsefilebutton.Click += new System.EventHandler(this.browsefilebutton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // saveButton
            // 
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(225, 29);
            this.saveButton.Text = "Сохранить выделенное ";
            this.saveButton.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // logPanel
            // 
            this.logPanel.Controls.Add(this.logBox);
            this.logPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logPanel.Location = new System.Drawing.Point(0, 408);
            this.logPanel.Name = "logPanel";
            this.logPanel.Size = new System.Drawing.Size(989, 189);
            this.logPanel.TabIndex = 2;
            this.logPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.logPanel_Paint);
            // 
            // logBox
            // 
            this.logBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logBox.Location = new System.Drawing.Point(0, 0);
            this.logBox.MaxLength = 1000000;
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logBox.Size = new System.Drawing.Size(989, 189);
            this.logBox.TabIndex = 0;
            this.logBox.WordWrap = false;
            // 
            // toolStripPanel
            // 
            this.toolStripPanel.Controls.Add(this.pathLable);
            this.toolStripPanel.Controls.Add(this.toolStrip1);
            this.toolStripPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.toolStripPanel.Name = "toolStripPanel";
            this.toolStripPanel.Size = new System.Drawing.Size(989, 68);
            this.toolStripPanel.TabIndex = 3;
            // 
            // pathLable
            // 
            this.pathLable.AutoSize = true;
            this.pathLable.BackColor = System.Drawing.SystemColors.Control;
            this.pathLable.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathLable.Location = new System.Drawing.Point(12, 44);
            this.pathLable.Name = "pathLable";
            this.pathLable.Size = new System.Drawing.Size(0, 21);
            this.pathLable.TabIndex = 2;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.SystemColors.Control;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Location = new System.Drawing.Point(0, 398);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(989, 10);
            this.splitter2.TabIndex = 1;
            this.splitter2.TabStop = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 597);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.dataGritPanel);
            this.Controls.Add(this.logPanel);
            this.Controls.Add(this.toolStripPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "mainForm";
            this.Text = "TiffApp";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.dataGritPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tiffgridview)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.taggridview)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.allTagsGrid)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.logPanel.ResumeLayout(false);
            this.logPanel.PerformLayout();
            this.toolStripPanel.ResumeLayout(false);
            this.toolStripPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel dataGritPanel;
        private System.Windows.Forms.DataGridView tiffgridview;
        private System.Windows.Forms.DataGridView taggridview;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton browsefilebutton;
        private System.Windows.Forms.FolderBrowserDialog browsetiffsdial;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel logPanel;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.DataGridView allTagsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Panel toolStripPanel;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label pathLable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}