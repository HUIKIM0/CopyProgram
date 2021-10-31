using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyProgram
{
    public partial class Form1 : Form
    {

        KeyboardHook _kbh = new KeyboardHook();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _kbh.hook();        //후킹
            _kbh.KeyDown += _kbh_KeyDown;
        }


        // Ctrl + C + 체크박스 활성화 해야 작업
        private void _kbh_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Control && e.KeyCode == Keys.C && cboxActivation.Checked)
                {
                    Thread.Sleep(1000);  //잠시 세웠다가 해야 클립보드가 정확하게 저장할 시간을 줌
                    lboxTextSave.Items.Add(Clipboard.GetData(System.Windows.Forms.DataFormats.UnicodeText).ToString());  //Clipboard.GetData
                }
            }
            catch (Exception)
            {

                
            }
            
        }

        //ListBox의 내용 클릭 시 클립보드에 들어감(컨트롤+C상태)
        private void lboxTextSave_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxTextSave.SelectedIndex != -1)
            {
                Clipboard.SetData(System.Windows.Forms.DataFormats.UnicodeText, lboxTextSave.SelectedItem.ToString());
            }

        }


        //체크박스
        private void cboxActivation_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxActivation.Checked == true)
            {
                lblActivation.Text = "활성화 상태(Ctrl + C 작업)";
                lblActivation.Enabled = true;
                tbox.Enabled = true;
                btnTextAdd.Enabled = true;
            }
            else
            {
                lblActivation.Text = "비 활성화 상태(붙여넣기만 가능)";
                lblActivation.Enabled = false;
                tbox.Enabled = false;
                btnTextAdd.Enabled = false;
            }

        }

        //Form투명도 trackBar로 조절
        private void trackBar_Scroll(object sender, EventArgs e)
        {
            this.Opacity = trackBar.Value / 10.0;
        }


        //등록 버튼
        private void btnTextAdd_Click(object sender, EventArgs e)
        {
            DataSave();
        }

        //textbox에 text치고 엔터 누르면 등록되게
        private void tbox_KeyDown_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataSave();
            }
        }



        //엔터,등록버튼 => 중복 아니여야 넣어줌
        private void DataSave()
        {
            string strTextBox = tbox.Text;

               //!String.IsNullOrEmpty(strText)
            if (strTextBox != "" && !lboxTextSave.Items.Contains(strTextBox))
            {
               lboxTextSave.Items.Add(strTextBox);
               tbox.Text = "";
            }
          
            
        }

        private void lbox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                if(lboxTextSave.Items.Count > 0)
                lboxTextSave.Items.RemoveAt(lboxTextSave.SelectedIndex);
            }
        }



        #region MenuStrip(MStrip)

        private void 저장하기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fFileSave();
        }

        private void 불러오기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fFileLoad();
        }

        private void 공백제거ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fEmptyDelete();
        }

        private void 모두삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAllDelete();
        }

        private void 프로그램정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fProgramInfo();
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fExit();
        }

        #endregion

        #region ContextMenuStrip(CMStrip)

        private void 공백제거ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fEmptyDelete();
        }

        private void 저장하기ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fFileSave();
        }

        private void 불러오기ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fFileLoad();
        }

        private void 모두삭제ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fAllDelete();
        }

        private void 프로그램정보ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fProgramInfo();
        }

        #endregion


        #region Event Function

        ///<summary>
        ///ListBox에 들어있는 요소들의 앞,뒤 불필요한 공백제거용 함수
        ///</summary>
        private void fEmptyDelete()
        {
            int iCount = lboxTextSave.Items.Count;

            for (int i = 0; i < iCount; i++)
            {
                lboxTextSave.Items[i] = lboxTextSave.Items[i].ToString().Trim();
            }
        }

        ///<summary>
        ///모두삭제용 함수
        ///</summary>
        private void fAllDelete()
        {
            //MessageBoxButtons.YesNo 기능에서 Yes누르면
            if (DialogResult.Yes == MessageBox.Show("등록되어 있는 Data를 초기화 합니다.", "ListBox Item Clear", MessageBoxButtons.YesNo))
            {
                lboxTextSave.Items.Clear();
            }
        }



        ///<summary>
        ///저장하기용 함수
        /// </summary> 
        private void fFileSave()
        {
            SaveFileDialog SFDialog = new SaveFileDialog();

            int ilbCount = lboxTextSave.Items.Count;
            string strFilePath = string.Empty;

            SFDialog.InitialDirectory = Application.StartupPath;
            SFDialog.FileName = "*.txt";
            SFDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            try
            {
                if (SFDialog.ShowDialog() == DialogResult.OK)
                {
                    strFilePath = SFDialog.FileName;
                    StreamWriter swSFDialog = new StreamWriter(strFilePath);

                    for (int i = 0; i < ilbCount; i++)
                    {
                        swSFDialog.WriteLine(lboxTextSave.Items[i].ToString());
                    }
                    swSFDialog.Close();
                    MessageBox.Show("저장이 완료 되었습니다.");
                }
            }
            catch
            {
            }

        }


        ///<summary>
        ///불러오기용 함수
        /// </summary>
        private void fFileLoad()
        {
            OpenFileDialog OFDialog = new OpenFileDialog();

            string strFilePath = string.Empty;

            OFDialog.InitialDirectory = Application.StartupPath;
            OFDialog.FileName = "*.txt";
            OFDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            try
            {
                if (OFDialog.ShowDialog() == DialogResult.OK)
                {
                    strFilePath = OFDialog.FileName;
                    StreamReader srOFDialog = new StreamReader(strFilePath, Encoding.UTF8, true);

                    while (srOFDialog.EndOfStream == false)
                    {
                        lboxTextSave.Items.Add(srOFDialog.ReadLine());
                    }
                }
            }
            catch
            {
            }
        }


        ///<summary>
        ///종료 함수
        /// </summary>
        private void fExit()
        {
            this.Close();
        }


        ///<summary>
        /// 프로그램 정보 함수
        /// </summary>
        private void fProgramInfo()
        {
            string strProgramInfo = "Ctrl + C / Ctrl + V 반복작업을 수월하게!\n" +
                                    "ListBox 안의 내용 클릭 시 자동으로 Ctrl + C 됩니다 ";
            MessageBox.Show(strProgramInfo);
        }


        #endregion


    }


}

