namespace Chapter5
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trvDir = new System.Windows.Forms.TreeView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lvwFiles = new System.Windows.Forms.ListView();
            this.colorFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colorFileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colorFileDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.자세히ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.크기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.큰아이콘ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPath);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 50);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lvwFiles);
            this.panel2.Controls.Add(this.splitter1);
            this.panel2.Controls.Add(this.trvDir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(753, 589);
            this.panel2.TabIndex = 1;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(116, 12);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(625, 28);
            this.txtPath.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "전체경로";
            // 
            // trvDir
            // 
            this.trvDir.Dock = System.Windows.Forms.DockStyle.Left;
            this.trvDir.ImageIndex = 0;
            this.trvDir.ImageList = this.imageList1;
            this.trvDir.Location = new System.Drawing.Point(0, 0);
            this.trvDir.Name = "trvDir";
            this.trvDir.SelectedImageIndex = 0;
            this.trvDir.Size = new System.Drawing.Size(121, 589);
            this.trvDir.TabIndex = 0;
            this.trvDir.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.trvDir_BeforeExpand);
            this.trvDir.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.trvDir_BeforeSelect);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(121, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 589);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // lvwFiles
            // 
            this.lvwFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colorFileName,
            this.colorFileSize,
            this.colorFileDate});
            this.lvwFiles.ContextMenuStrip = this.contextMenuStrip1;
            this.lvwFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwFiles.HideSelection = false;
            this.lvwFiles.LargeImageList = this.imageList1;
            this.lvwFiles.Location = new System.Drawing.Point(124, 0);
            this.lvwFiles.Name = "lvwFiles";
            this.lvwFiles.Size = new System.Drawing.Size(629, 589);
            this.lvwFiles.SmallImageList = this.imageList1;
            this.lvwFiles.TabIndex = 2;
            this.lvwFiles.UseCompatibleStateImageBehavior = false;
            this.lvwFiles.DoubleClick += new System.EventHandler(this.lvwFiles_DoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Atsuko_Kagari_Holding_Introducing_Elixir.png");
            this.imageList1.Images.SetKeyName(1, "Official_Elixir_logo.png");
            this.imageList1.Images.SetKeyName(2, "service-why-elixir.png");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.열기ToolStripMenuItem,
            this.자세히ToolStripMenuItem,
            this.크기ToolStripMenuItem,
            this.큰아이콘ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(241, 165);
            // 
            // 열기ToolStripMenuItem
            // 
            this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            this.열기ToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.열기ToolStripMenuItem.Text = "열기";
            this.열기ToolStripMenuItem.Click += new System.EventHandler(this.열기ToolStripMenuItem_Click);
            // 
            // 자세히ToolStripMenuItem
            // 
            this.자세히ToolStripMenuItem.Name = "자세히ToolStripMenuItem";
            this.자세히ToolStripMenuItem.Size = new System.Drawing.Size(174, 32);
            this.자세히ToolStripMenuItem.Text = "자세히";
            // 
            // 크기ToolStripMenuItem
            // 
            this.크기ToolStripMenuItem.Name = "크기ToolStripMenuItem";
            this.크기ToolStripMenuItem.Size = new System.Drawing.Size(174, 32);
            this.크기ToolStripMenuItem.Text = "작은아이콘";
            // 
            // 큰아이콘ToolStripMenuItem
            // 
            this.큰아이콘ToolStripMenuItem.Name = "큰아이콘ToolStripMenuItem";
            this.큰아이콘ToolStripMenuItem.Size = new System.Drawing.Size(174, 32);
            this.큰아이콘ToolStripMenuItem.Text = "큰아이콘";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 639);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lvwFiles;
        private System.Windows.Forms.ColumnHeader colorFileName;
        private System.Windows.Forms.ColumnHeader colorFileSize;
        private System.Windows.Forms.ColumnHeader colorFileDate;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TreeView trvDir;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 자세히ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 크기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 큰아이콘ToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
    }
}

