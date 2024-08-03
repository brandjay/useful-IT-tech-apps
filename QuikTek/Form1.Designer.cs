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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
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
            restartbtn.Location = new Point(12, 381);
            restartbtn.Name = "restartbtn";
            restartbtn.Size = new Size(124, 29);
            restartbtn.TabIndex = 1;
            restartbtn.Text = "Restart PC";
            restartbtn.UseVisualStyleBackColor = true;
            restartbtn.Click += restartbtn_Click;
            // 
            // sysinfo
            // 
            sysinfo.Location = new Point(165, 12);
            sysinfo.Name = "sysinfo";
            sysinfo.Size = new Size(124, 29);
            sysinfo.TabIndex = 2;
            sysinfo.Text = "systeminfo";
            sysinfo.UseVisualStyleBackColor = true;
            sysinfo.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 73);
            button1.Name = "button1";
            button1.Size = new Size(115, 29);
            button1.TabIndex = 3;
            button1.Text = "ending script";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(324, 12);
            button2.Name = "button2";
            button2.Size = new Size(112, 29);
            button2.TabIndex = 4;
            button2.Text = "whats my IP?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(653, 381);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 5;
            button3.Text = "Shutdown";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(sysinfo);
            Controls.Add(restartbtn);
            Controls.Add(control);
            Name = "Form1";
            Text = "Quiktek";
            ResumeLayout(false);
        }

        #endregion

        private Button control;
        private Button restartbtn;
        private Button sysinfo;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}