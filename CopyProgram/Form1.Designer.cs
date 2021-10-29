
namespace CopyProgram
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
            this.lboxTextSave = new System.Windows.Forms.ListBox();
            this.CMStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.공백제거ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.클립보드ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장하기ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.불러오기ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.모두삭제ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.프로그램정보ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblActivation = new System.Windows.Forms.Label();
            this.cboxActivation = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.btnTextAdd = new System.Windows.Forms.Button();
            this.tbox = new System.Windows.Forms.TextBox();
            this.MStrip = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장하기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.불러오기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도구ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.공백제거ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.모두삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.프로그램정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CMStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.MStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lboxTextSave
            // 
            this.lboxTextSave.ContextMenuStrip = this.CMStrip;
            this.lboxTextSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lboxTextSave.FormattingEnabled = true;
            this.lboxTextSave.HorizontalScrollbar = true;
            this.lboxTextSave.ItemHeight = 15;
            this.lboxTextSave.Location = new System.Drawing.Point(3, 53);
            this.lboxTextSave.Name = "lboxTextSave";
            this.lboxTextSave.Size = new System.Drawing.Size(465, 231);
            this.lboxTextSave.TabIndex = 0;
            this.lboxTextSave.SelectedIndexChanged += new System.EventHandler(this.lboxTextSave_SelectedIndexChanged);
            this.lboxTextSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbox_KeyDown);
            // 
            // CMStrip
            // 
            this.CMStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CMStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.공백제거ToolStripMenuItem1,
            this.클립보드ToolStripMenuItem,
            this.모두삭제ToolStripMenuItem1,
            this.toolStripSeparator2,
            this.프로그램정보ToolStripMenuItem1});
            this.CMStrip.Name = "CMStrip";
            this.CMStrip.Size = new System.Drawing.Size(174, 106);
            // 
            // 공백제거ToolStripMenuItem1
            // 
            this.공백제거ToolStripMenuItem1.Name = "공백제거ToolStripMenuItem1";
            this.공백제거ToolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
            this.공백제거ToolStripMenuItem1.Text = "공백제거";
            this.공백제거ToolStripMenuItem1.Click += new System.EventHandler(this.공백제거ToolStripMenuItem1_Click);
            // 
            // 클립보드ToolStripMenuItem
            // 
            this.클립보드ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.저장하기ToolStripMenuItem1,
            this.불러오기ToolStripMenuItem1});
            this.클립보드ToolStripMenuItem.Name = "클립보드ToolStripMenuItem";
            this.클립보드ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.클립보드ToolStripMenuItem.Text = "클립보드";
            // 
            // 저장하기ToolStripMenuItem1
            // 
            this.저장하기ToolStripMenuItem1.Name = "저장하기ToolStripMenuItem1";
            this.저장하기ToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.저장하기ToolStripMenuItem1.Text = "저장하기";
            this.저장하기ToolStripMenuItem1.Click += new System.EventHandler(this.저장하기ToolStripMenuItem1_Click);
            // 
            // 불러오기ToolStripMenuItem1
            // 
            this.불러오기ToolStripMenuItem1.Name = "불러오기ToolStripMenuItem1";
            this.불러오기ToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.불러오기ToolStripMenuItem1.Text = "불러오기";
            this.불러오기ToolStripMenuItem1.Click += new System.EventHandler(this.불러오기ToolStripMenuItem1_Click);
            // 
            // 모두삭제ToolStripMenuItem1
            // 
            this.모두삭제ToolStripMenuItem1.Name = "모두삭제ToolStripMenuItem1";
            this.모두삭제ToolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
            this.모두삭제ToolStripMenuItem1.Text = "모두삭제";
            this.모두삭제ToolStripMenuItem1.Click += new System.EventHandler(this.모두삭제ToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(170, 6);
            // 
            // 프로그램정보ToolStripMenuItem1
            // 
            this.프로그램정보ToolStripMenuItem1.Name = "프로그램정보ToolStripMenuItem1";
            this.프로그램정보ToolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
            this.프로그램정보ToolStripMenuItem1.Text = "프로그램 정보";
            this.프로그램정보ToolStripMenuItem1.Click += new System.EventHandler(this.프로그램정보ToolStripMenuItem1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lboxTextSave, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(471, 337);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblActivation);
            this.panel1.Controls.Add(this.cboxActivation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 44);
            this.panel1.TabIndex = 1;
            // 
            // lblActivation
            // 
            this.lblActivation.AutoSize = true;
            this.lblActivation.Location = new System.Drawing.Point(221, 14);
            this.lblActivation.Name = "lblActivation";
            this.lblActivation.Size = new System.Drawing.Size(183, 15);
            this.lblActivation.TabIndex = 1;
            this.lblActivation.Text = "활성화 상태(Ctrl + C 작업)";
            // 
            // cboxActivation
            // 
            this.cboxActivation.AutoSize = true;
            this.cboxActivation.Checked = true;
            this.cboxActivation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxActivation.Location = new System.Drawing.Point(9, 14);
            this.cboxActivation.Name = "cboxActivation";
            this.cboxActivation.Size = new System.Drawing.Size(93, 19);
            this.cboxActivation.TabIndex = 0;
            this.cboxActivation.Text = "Activation";
            this.cboxActivation.UseVisualStyleBackColor = true;
            this.cboxActivation.CheckedChanged += new System.EventHandler(this.cboxActivation_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.trackBar);
            this.panel2.Controls.Add(this.btnTextAdd);
            this.panel2.Controls.Add(this.tbox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 290);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 44);
            this.panel2.TabIndex = 2;
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(308, 3);
            this.trackBar.Minimum = 2;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(133, 56);
            this.trackBar.TabIndex = 2;
            this.trackBar.Value = 10;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // btnTextAdd
            // 
            this.btnTextAdd.Location = new System.Drawing.Point(217, 5);
            this.btnTextAdd.Name = "btnTextAdd";
            this.btnTextAdd.Size = new System.Drawing.Size(64, 31);
            this.btnTextAdd.TabIndex = 1;
            this.btnTextAdd.Text = "등록";
            this.btnTextAdd.UseVisualStyleBackColor = true;
            this.btnTextAdd.Click += new System.EventHandler(this.btnTextAdd_Click);
            // 
            // tbox
            // 
            this.tbox.Location = new System.Drawing.Point(3, 8);
            this.tbox.Name = "tbox";
            this.tbox.Size = new System.Drawing.Size(208, 25);
            this.tbox.TabIndex = 0;
            this.tbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbox_KeyDown_Enter);
            // 
            // MStrip
            // 
            this.MStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.도구ToolStripMenuItem,
            this.프로그램정보ToolStripMenuItem});
            this.MStrip.Location = new System.Drawing.Point(0, 0);
            this.MStrip.Name = "MStrip";
            this.MStrip.Size = new System.Drawing.Size(471, 28);
            this.MStrip.TabIndex = 2;
            this.MStrip.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.저장하기ToolStripMenuItem,
            this.불러오기ToolStripMenuItem,
            this.toolStripSeparator1,
            this.종료ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 저장하기ToolStripMenuItem
            // 
            this.저장하기ToolStripMenuItem.Name = "저장하기ToolStripMenuItem";
            this.저장하기ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.저장하기ToolStripMenuItem.Text = "저장하기";
            this.저장하기ToolStripMenuItem.Click += new System.EventHandler(this.저장하기ToolStripMenuItem_Click);
            // 
            // 불러오기ToolStripMenuItem
            // 
            this.불러오기ToolStripMenuItem.Name = "불러오기ToolStripMenuItem";
            this.불러오기ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.불러오기ToolStripMenuItem.Text = "불러오기";
            this.불러오기ToolStripMenuItem.Click += new System.EventHandler(this.불러오기ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // 도구ToolStripMenuItem
            // 
            this.도구ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.공백제거ToolStripMenuItem,
            this.모두삭제ToolStripMenuItem});
            this.도구ToolStripMenuItem.Name = "도구ToolStripMenuItem";
            this.도구ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.도구ToolStripMenuItem.Text = "편집";
            // 
            // 공백제거ToolStripMenuItem
            // 
            this.공백제거ToolStripMenuItem.Name = "공백제거ToolStripMenuItem";
            this.공백제거ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.공백제거ToolStripMenuItem.Text = "공백제거";
            this.공백제거ToolStripMenuItem.Click += new System.EventHandler(this.공백제거ToolStripMenuItem_Click);
            // 
            // 모두삭제ToolStripMenuItem
            // 
            this.모두삭제ToolStripMenuItem.Name = "모두삭제ToolStripMenuItem";
            this.모두삭제ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.모두삭제ToolStripMenuItem.Text = "모두삭제";
            this.모두삭제ToolStripMenuItem.Click += new System.EventHandler(this.모두삭제ToolStripMenuItem_Click);
            // 
            // 프로그램정보ToolStripMenuItem
            // 
            this.프로그램정보ToolStripMenuItem.Name = "프로그램정보ToolStripMenuItem";
            this.프로그램정보ToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.프로그램정보ToolStripMenuItem.Text = "프로그램 정보";
            this.프로그램정보ToolStripMenuItem.Click += new System.EventHandler(this.프로그램정보ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(471, 365);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.MStrip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CMStrip.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.MStrip.ResumeLayout(false);
            this.MStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboxTextSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblActivation;
        private System.Windows.Forms.CheckBox cboxActivation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Button btnTextAdd;
        private System.Windows.Forms.TextBox tbox;
        private System.Windows.Forms.MenuStrip MStrip;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장하기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 불러오기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도구ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 공백제거ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 모두삭제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 프로그램정보ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip CMStrip;
        private System.Windows.Forms.ToolStripMenuItem 공백제거ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 클립보드ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장하기ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 불러오기ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 모두삭제ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 프로그램정보ToolStripMenuItem1;
    }
}

