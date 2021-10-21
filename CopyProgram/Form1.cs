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


        private void _kbh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                Thread.Sleep(1000);  //잠시 세웠다가 해야 클립보드가 정확하게 저장할 시간을 줌

                lboxTextSave.Items.Add(Clipboard.GetData(System.Windows.Forms.DataFormats.UnicodeText).ToString());  //Clipboard.GetData
            }
        }

        private void LboxTextSave_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (lboxTextSave.SelectedIndex != -1)    
            {
                Clipboard.SetData(System.Windows.Forms.DataFormats.UnicodeText, lboxTextSave.SelectedItem.ToString()); //Clipboard.SetData
            }
        }


    }
}
