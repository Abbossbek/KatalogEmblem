namespace KatalogEmblem
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lvEmblems = new System.Windows.Forms.ListView();
            this.tspMenu = new System.Windows.Forms.ToolStrip();
            this.tsmFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmNewEmblem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTxtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tspMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(128, 128);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lvEmblems
            // 
            this.lvEmblems.Cursor = System.Windows.Forms.Cursors.Default;
            this.lvEmblems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvEmblems.LargeImageList = this.imageList1;
            this.lvEmblems.Location = new System.Drawing.Point(0, 27);
            this.lvEmblems.Name = "lvEmblems";
            this.lvEmblems.Size = new System.Drawing.Size(1033, 606);
            this.lvEmblems.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvEmblems.TabIndex = 0;
            this.lvEmblems.UseCompatibleStateImageBehavior = false;
            // 
            // tspMenu
            // 
            this.tspMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tspMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile,
            this.tsmTxtSearch,
            this.toolStripLabel1});
            this.tspMenu.Location = new System.Drawing.Point(0, 0);
            this.tspMenu.Name = "tspMenu";
            this.tspMenu.Size = new System.Drawing.Size(1033, 27);
            this.tspMenu.TabIndex = 2;
            this.tspMenu.Text = "toolStrip1";
            // 
            // tsmFile
            // 
            this.tsmFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNewEmblem,
            this.newGroupToolStripMenuItem});
            this.tsmFile.Image = ((System.Drawing.Image)(resources.GetObject("tsmFile.Image")));
            this.tsmFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmFile.Name = "tsmFile";
            this.tsmFile.Size = new System.Drawing.Size(46, 24);
            this.tsmFile.Text = "File";
            // 
            // tsmNewEmblem
            // 
            this.tsmNewEmblem.Name = "tsmNewEmblem";
            this.tsmNewEmblem.Size = new System.Drawing.Size(173, 26);
            this.tsmNewEmblem.Text = "New emblem";
            this.tsmNewEmblem.Click += new System.EventHandler(this.newEmblemToolStripMenuItem_Click);
            // 
            // newGroupToolStripMenuItem
            // 
            this.newGroupToolStripMenuItem.Name = "newGroupToolStripMenuItem";
            this.newGroupToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.newGroupToolStripMenuItem.Text = "New Group";
            this.newGroupToolStripMenuItem.Click += new System.EventHandler(this.newGroupToolStripMenuItem_Click);
            // 
            // tsmTxtSearch
            // 
            this.tsmTxtSearch.Name = "tsmTxtSearch";
            this.tsmTxtSearch.Size = new System.Drawing.Size(100, 27);
            this.tsmTxtSearch.TextChanged += new System.EventHandler(this.tsmTxtSearch_TextChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(20, 24);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 633);
            this.Controls.Add(this.lvEmblems);
            this.Controls.Add(this.tspMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tspMenu.ResumeLayout(false);
            this.tspMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStrip tspMenu;
        private System.Windows.Forms.ToolStripDropDownButton tsmFile;
        private System.Windows.Forms.ToolStripMenuItem tsmNewEmblem;
        private System.Windows.Forms.ToolStripTextBox tsmTxtSearch;
        private System.Windows.Forms.ToolStripMenuItem newGroupToolStripMenuItem;
        private System.Windows.Forms.ListView lvEmblems;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}

