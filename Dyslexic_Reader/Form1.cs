using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Dyslexic_Reader
{
    public partial class Form1 : Form
    {
        SpeechLib.ISpeechVoice oVoice;
        public Form1()
        {
            oVoice = new SpeechLib.SpVoiceClass();            
            InitializeComponent();
            Read_Resources();
            txt_ToRead.Text = System.Windows.Forms.Clipboard.GetText().Trim();
        }

        private void Read_Resources() {
            cmd_Read.Text = Dyslexic_Reader.Properties.Resources.STR_BUTTON_READ;
            cmd_Stop.Text = Dyslexic_Reader.Properties.Resources.STR_BUTTON_STOP;
            check_clip.Text = Dyslexic_Reader.Properties.Resources.STR_CHECK_WATCH;
            this.Text = Dyslexic_Reader.Properties.Resources.STR_FORM_TITLE;
        }

        private void cmd_Read_Click(object sender, EventArgs e)
        {
            cmd_Stop_Click(sender, e);
            string temp = txt_ToRead.Text;
            if (temp != null && temp.Equals("") == false) {
                SpeechLib.SpeechVoiceSpeakFlags SpFlags = SpeechLib.SpeechVoiceSpeakFlags.SVSFlagsAsync;
                oVoice.Speak(temp, SpFlags);
            }
        }

        private void check_clip_CheckedChanged(object sender, EventArgs e)
        {
            Boolean temp = (check_clip.CheckState == System.Windows.Forms.CheckState.Checked);
            tm_clip.Enabled = temp;            
        }

        private void cmd_Stop_Click(object sender, EventArgs e)
        {

            while (oVoice.Status.RunningState == SpeechLib.SpeechRunState.SRSEIsSpeaking)
            {
                oVoice.Skip("SENTENCE", 1000);
            }
            oVoice.WaitUntilDone(4000);
        }

        private void tm_clip_Tick(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Clipboard.ContainsText() == true)
            {
                string temp = System.Windows.Forms.Clipboard.GetText().Trim();
                if (txt_ToRead.Text.Trim().Equals(temp) == false)
                {
                    txt_ToRead.Text = temp;
                    cmd_Read_Click(sender, e);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();

            string filename = saveFileDialog1.FileName;
            saveFileDialog1.FileName = "";
            if (string.IsNullOrEmpty(filename) == false)
            {
                cmd_Stop_Click(sender, e);
                string temp = txt_ToRead.Text;
                if (temp != null && temp.Equals("") == false)
                {

                    SpeechLib.SpFileStream cpFileStream = new SpeechLib.SpFileStream();
                    SpeechLib.SpeechVoiceSpeakFlags SpFlags = SpeechLib.SpeechVoiceSpeakFlags.SVSFDefault;

                    cpFileStream.Open(filename, SpeechLib.SpeechStreamFileMode.SSFMCreateForWrite, false);
                    oVoice.AudioOutputStream = cpFileStream;
                    oVoice.Speak(temp, SpFlags);
                    cpFileStream.Close();

                    //oVoice.Speak(temp, SpFlags);
                }

            }
        }
    }
}