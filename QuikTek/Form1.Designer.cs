namespace QuikTek
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            control = new Button();
            restartbtn = new Button();
            sysinfo = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            button4 = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // control
            // 
            control.Location = new Point(12, 12);
            control.Name = "control";
            control.Size = new Size(124, 29);
            control.TabIndex = 0;
            control.Text = "control panel";
            control.UseVisualStyleBackColor = true;
            control.Click += control_Click;
            // 
            // restartbtn
            // 
            restartbtn.BackColor = Color.OrangeRed;
            restartbtn.Location = new Point(738, 390);
            restartbtn.Name = "restartbtn";
            restartbtn.Size = new Size(124, 29);
            restartbtn.TabIndex = 1;
            restartbtn.Text = "Restart PC";
            restartbtn.UseVisualStyleBackColor = false;
            restartbtn.Click += restartbtn_Click;
            // 
            // sysinfo
            // 
            sysinfo.Location = new Point(142, 12);
            sysinfo.Name = "sysinfo";
            sysinfo.Size = new Size(124, 29);
            sysinfo.TabIndex = 2;
            sysinfo.Text = "systeminfo";
            sysinfo.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(349, 12);
            button2.Name = "button2";
            button2.Size = new Size(112, 29);
            button2.TabIndex = 4;
            button2.Text = "whats my IP?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Orange;
            button3.Location = new Point(738, 355);
            button3.Name = "button3";
            button3.Size = new Size(124, 29);
            button3.TabIndex = 5;
            button3.Text = "Shutdown";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(467, 14);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(241, 27);
            textBox1.TabIndex = 6;
            // 
            // button4
            // 
            button4.Location = new Point(714, 14);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 7;
            button4.Text = "Get IP";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = SystemColors.ActiveCaptionText;
            linkLabel1.Location = new Point(642, 56);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(85, 20);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Address is...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(961, 450);
            Controls.Add(linkLabel1);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(sysinfo);
            Controls.Add(restartbtn);
            Controls.Add(control);
            Name = "Form1";
            Text = "Quiktek";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button control;
        private Button restartbtn;
        private Button sysinfo;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private Button button4;
        private LinkLabel linkLabel1;
    }
}