
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
            this.lboxTextSave = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblActivation = new System.Windows.Forms.Label();
            this.cboxActivation = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.btnTextAdd = new System.Windows.Forms.Button();
            this.tbox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // lboxTextSave
            // 
            this.lboxTextSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lboxTextSave.FormattingEnabled = true;
            this.lboxTextSave.HorizontalScrollbar = true;
            this.lboxTextSave.ItemHeight = 15;
            this.lboxTextSave.Location = new System.Drawing.Point(3, 53);
            this.lboxTextSave.Name = "lboxTextSave";
            this.lboxTextSave.Size = new System.Drawing.Size(442, 215);
            this.lboxTextSave.TabIndex = 0;
            this.lboxTextSave.SelectedIndexChanged += new System.EventHandler(this.lboxTextSave_SelectedIndexChanged);
            this.lboxTextSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbox_KeyDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lboxTextSave, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(448, 321);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblActivation);
            this.panel1.Controls.Add(this.cboxActivation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 44);
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
            this.cboxActivation.Location = new System.Drawing.Point(12, 12);
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
            this.panel2.Location = new System.Drawing.Point(3, 274);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(442, 44);
            this.panel2.TabIndex = 2;
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(308, 3);
            this.trackBar.Minimum = 2;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(107, 56);
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
            this.tbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbox_KeyDown);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(448, 321);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);

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
    }
}

