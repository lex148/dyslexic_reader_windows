namespace Dyslexic_Reader
{
    partial class Form1
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
            this.cmd_Read = new System.Windows.Forms.Button();
            this.cmd_Stop = new System.Windows.Forms.Button();
            this.txt_ToRead = new System.Windows.Forms.TextBox();
            this.check_clip = new System.Windows.Forms.CheckBox();
            this.tm_clip = new System.Windows.Forms.Timer(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // cmd_Read
            // 
            this.cmd_Read.Location = new System.Drawing.Point(12, 13);
            this.cmd_Read.Name = "cmd_Read";
            this.cmd_Read.Size = new System.Drawing.Size(75, 23);
            this.cmd_Read.TabIndex = 0;
            this.cmd_Read.Text = "Read";
            this.cmd_Read.UseVisualStyleBackColor = true;
            this.cmd_Read.Click += new System.EventHandler(this.cmd_Read_Click);
            // 
            // cmd_Stop
            // 
            this.cmd_Stop.Location = new System.Drawing.Point(13, 42);
            this.cmd_Stop.Name = "cmd_Stop";
            this.cmd_Stop.Size = new System.Drawing.Size(34, 23);
            this.cmd_Stop.TabIndex = 1;
            this.cmd_Stop.Text = "Stop";
            this.cmd_Stop.UseVisualStyleBackColor = true;
            this.cmd_Stop.Click += new System.EventHandler(this.cmd_Stop_Click);
            // 
            // txt_ToRead
            // 
            this.txt_ToRead.Location = new System.Drawing.Point(95, 13);
            this.txt_ToRead.Multiline = true;
            this.txt_ToRead.Name = "txt_ToRead";
            this.txt_ToRead.Size = new System.Drawing.Size(360, 72);
            this.txt_ToRead.TabIndex = 2;
            // 
            // check_clip
            // 
            this.check_clip.AutoSize = true;
            this.check_clip.Checked = true;
            this.check_clip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_clip.Location = new System.Drawing.Point(13, 73);
            this.check_clip.Name = "check_clip";
            this.check_clip.Size = new System.Drawing.Size(55, 17);
            this.check_clip.TabIndex = 3;
            this.check_clip.Text = "watch";
            this.check_clip.UseVisualStyleBackColor = true;
            this.check_clip.CheckedChanged += new System.EventHandler(this.check_clip_CheckedChanged);
            // 
            // tm_clip
            // 
            this.tm_clip.Enabled = true;
            this.tm_clip.Interval = 1000;
            this.tm_clip.Tick += new System.EventHandler(this.tm_clip_Tick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(53, 42);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(33, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 97);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.check_clip);
            this.Controls.Add(this.txt_ToRead);
            this.Controls.Add(this.cmd_Stop);
            this.Controls.Add(this.cmd_Read);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Clipboard Reader";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_Read;
        private System.Windows.Forms.Button cmd_Stop;
        private System.Windows.Forms.TextBox txt_ToRead;
        private System.Windows.Forms.CheckBox check_clip;
        private System.Windows.Forms.Timer tm_clip;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

