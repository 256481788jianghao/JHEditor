namespace JHEditor
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.默认参数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultEncodingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aSCIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uTF8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uTF16ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gBKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_Context = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.treeView_search_list = new System.Windows.Forms.TreeView();
            this.contextMenuStrip_mulutreeview = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.普通文本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.加密文本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.contextMenuStrip_richbox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.文本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字体设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.binFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer_main = new System.Windows.Forms.Timer(this.components);
            this.toolStripMenuItem_timer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.contextMenuStrip_mulutreeview.SuspendLayout();
            this.contextMenuStrip_richbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_timer,
            this.默认参数ToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 默认参数ToolStripMenuItem
            // 
            this.默认参数ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.字体ToolStripMenuItem,
            this.defaultEncodingToolStripMenuItem});
            this.默认参数ToolStripMenuItem.Name = "默认参数ToolStripMenuItem";
            this.默认参数ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.默认参数ToolStripMenuItem.Text = "默认参数";
            // 
            // 字体ToolStripMenuItem
            // 
            this.字体ToolStripMenuItem.Name = "字体ToolStripMenuItem";
            this.字体ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.字体ToolStripMenuItem.Text = "默认字体";
            this.字体ToolStripMenuItem.Click += new System.EventHandler(this.字体ToolStripMenuItem_Click);
            // 
            // defaultEncodingToolStripMenuItem
            // 
            this.defaultEncodingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aSCIIToolStripMenuItem,
            this.uTF8ToolStripMenuItem,
            this.uTF16ToolStripMenuItem,
            this.gBKToolStripMenuItem});
            this.defaultEncodingToolStripMenuItem.Name = "defaultEncodingToolStripMenuItem";
            this.defaultEncodingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.defaultEncodingToolStripMenuItem.Text = "默认编码";
            // 
            // aSCIIToolStripMenuItem
            // 
            this.aSCIIToolStripMenuItem.Name = "aSCIIToolStripMenuItem";
            this.aSCIIToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.aSCIIToolStripMenuItem.Text = "ASCII";
            this.aSCIIToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // uTF8ToolStripMenuItem
            // 
            this.uTF8ToolStripMenuItem.Name = "uTF8ToolStripMenuItem";
            this.uTF8ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.uTF8ToolStripMenuItem.Text = "UTF8";
            this.uTF8ToolStripMenuItem.Click += new System.EventHandler(this.uTF8ToolStripMenuItem_Click);
            // 
            // uTF16ToolStripMenuItem
            // 
            this.uTF16ToolStripMenuItem.Name = "uTF16ToolStripMenuItem";
            this.uTF16ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.uTF16ToolStripMenuItem.Text = "UTF16";
            this.uTF16ToolStripMenuItem.Click += new System.EventHandler(this.uTF16ToolStripMenuItem_Click);
            // 
            // gBKToolStripMenuItem
            // 
            this.gBKToolStripMenuItem.Name = "gBKToolStripMenuItem";
            this.gBKToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.gBKToolStripMenuItem.Text = "GBK";
            this.gBKToolStripMenuItem.Click += new System.EventHandler(this.gBKToolStripMenuItem_Click);
            // 
            // panel_Context
            // 
            this.panel_Context.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Context.Location = new System.Drawing.Point(0, 0);
            this.panel_Context.Name = "panel_Context";
            this.panel_Context.Size = new System.Drawing.Size(603, 425);
            this.panel_Context.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel_Context);
            this.splitContainer1.Size = new System.Drawing.Size(800, 425);
            this.splitContainer1.SplitterDistance = 193;
            this.splitContainer1.TabIndex = 3;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(193, 425);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.treeView_search_list);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(185, 399);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "目录";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // treeView_search_list
            // 
            this.treeView_search_list.ContextMenuStrip = this.contextMenuStrip_mulutreeview;
            this.treeView_search_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_search_list.Location = new System.Drawing.Point(3, 3);
            this.treeView_search_list.Name = "treeView_search_list";
            this.treeView_search_list.Size = new System.Drawing.Size(179, 393);
            this.treeView_search_list.TabIndex = 0;
            this.treeView_search_list.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView_search_list_BeforeExpand);
            this.treeView_search_list.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_search_list_NodeMouseClick);
            this.treeView_search_list.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_search_list_NodeMouseDoubleClick);
            // 
            // contextMenuStrip_mulutreeview
            // 
            this.contextMenuStrip_mulutreeview.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem});
            this.contextMenuStrip_mulutreeview.Name = "contextMenuStrip_mulutreeview";
            this.contextMenuStrip_mulutreeview.Size = new System.Drawing.Size(101, 26);
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.普通文本ToolStripMenuItem,
            this.加密文本ToolStripMenuItem});
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.新建ToolStripMenuItem.Text = "新建";
            this.新建ToolStripMenuItem.Click += new System.EventHandler(this.新建ToolStripMenuItem_Click);
            // 
            // 普通文本ToolStripMenuItem
            // 
            this.普通文本ToolStripMenuItem.Name = "普通文本ToolStripMenuItem";
            this.普通文本ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.普通文本ToolStripMenuItem.Text = "普通文本";
            this.普通文本ToolStripMenuItem.Click += new System.EventHandler(this.普通文本ToolStripMenuItem_Click);
            // 
            // 加密文本ToolStripMenuItem
            // 
            this.加密文本ToolStripMenuItem.Name = "加密文本ToolStripMenuItem";
            this.加密文本ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.加密文本ToolStripMenuItem.Text = "加密文本";
            this.加密文本ToolStripMenuItem.Click += new System.EventHandler(this.加密文本ToolStripMenuItem_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(185, 399);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip_richbox
            // 
            this.contextMenuStrip_richbox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文本ToolStripMenuItem,
            this.toolStripMenuItem1});
            this.contextMenuStrip_richbox.Name = "contextMenuStrip_richbox";
            this.contextMenuStrip_richbox.Size = new System.Drawing.Size(101, 48);
            this.contextMenuStrip_richbox.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_richbox_Opening);
            // 
            // 文本ToolStripMenuItem
            // 
            this.文本ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.字体设置ToolStripMenuItem});
            this.文本ToolStripMenuItem.Name = "文本ToolStripMenuItem";
            this.文本ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.文本ToolStripMenuItem.Text = "文本";
            // 
            // 字体设置ToolStripMenuItem
            // 
            this.字体设置ToolStripMenuItem.Name = "字体设置ToolStripMenuItem";
            this.字体设置ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.字体设置ToolStripMenuItem.Text = "字体设置";
            this.字体设置ToolStripMenuItem.Click += new System.EventHandler(this.字体设置ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binFormatToolStripMenuItem,
            this.sourceFormatToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItem1.Text = "转换";
            // 
            // binFormatToolStripMenuItem
            // 
            this.binFormatToolStripMenuItem.Name = "binFormatToolStripMenuItem";
            this.binFormatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.binFormatToolStripMenuItem.Text = "以二进制展示";
            this.binFormatToolStripMenuItem.Click += new System.EventHandler(this.binFormatToolStripMenuItem_Click);
            // 
            // sourceFormatToolStripMenuItem
            // 
            this.sourceFormatToolStripMenuItem.Name = "sourceFormatToolStripMenuItem";
            this.sourceFormatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sourceFormatToolStripMenuItem.Text = "以原编码展示";
            this.sourceFormatToolStripMenuItem.Click += new System.EventHandler(this.sourceFormatToolStripMenuItem_Click);
            // 
            // timer_main
            // 
            this.timer_main.Interval = 30000;
            this.timer_main.Tick += new System.EventHandler(this.timer_main_Tick);
            // 
            // toolStripMenuItem_timer
            // 
            this.toolStripMenuItem_timer.Name = "toolStripMenuItem_timer";
            this.toolStripMenuItem_timer.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem_timer.Text = "自动保存";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "JHEditor";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormMain_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.contextMenuStrip_mulutreeview.ResumeLayout(false);
            this.contextMenuStrip_richbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel_Context;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TreeView treeView_search_list;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_mulutreeview;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_richbox;
        private System.Windows.Forms.ToolStripMenuItem 文本ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 字体设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 默认参数ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 字体ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultEncodingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uTF8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uTF16ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gBKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aSCIIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 普通文本ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 加密文本ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem binFormatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sourceFormatToolStripMenuItem;
        private System.Windows.Forms.Timer timer_main;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_timer;
    }
}

