using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            string strTextBox = tbox.Text;
            if (e.Control && e.KeyCode == Keys.C && cboxActivation.Checked)
            {
                Thread.Sleep(1000);  //잠시 세웠다가 해야 클립보드가 정확하게 저장할 시간을 줌
                lboxTextSave.Items.Add(Clipboard.GetData(System.Windows.Forms.DataFormats.UnicodeText).ToString());  //Clipboard.GetData
            }
        }

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


        //textbox에 text치고 엔터 누르면 등록되게
        private void tbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataSave();
            }
        }

        //등록 버튼
        private void btnTextAdd_Click(object sender, EventArgs e)
        {
            DataSave(); 
        }


        //엔터,등록버튼 => 중복 아니여야 넣어줌
        private void DataSave()
        {
            string strTextBox = tbox.Text;

            if (!string.IsNullOrEmpty(strTextBox) && !lboxTextSave.Items.Contains(strTextBox))
            {
               lboxTextSave.Items.Add(strTextBox);
               tbox.Text = "";
            }
          
            
        }

        private void lbox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                lboxTextSave.Items.RemoveAt(lboxTextSave.SelectedIndex);
            }
        }
    }
}
