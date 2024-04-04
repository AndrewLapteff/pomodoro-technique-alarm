namespace Alarm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            button2 = new Button();
            notifyIcon1 = new NotifyIcon(components);
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 40F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(69, 136);
            label1.MinimumSize = new Size(110, 40);
            label1.Name = "label1";
            label1.Size = new Size(308, 89);
            label1.TabIndex = 0;
            label1.Text = "00:00:00";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(79, 297);
            button1.Name = "button1";
            button1.Size = new Size(132, 49);
            button1.TabIndex = 1;
            button1.Text = "Почати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(230, 297);
            button2.Name = "button2";
            button2.Size = new Size(132, 49);
            button2.TabIndex = 2;
            button2.Text = "Скинути";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(105, 352);
            button3.Name = "button3";
            button3.Size = new Size(232, 49);
            button3.TabIndex = 3;
            button3.Text = "Вимкнути звук";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BG;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(439, 477);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Alarm";
            Load += Form1_Load;
            Resize += Form1_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private Button button2;
        private NotifyIcon notifyIcon1;
        private Button button3;
    }
}