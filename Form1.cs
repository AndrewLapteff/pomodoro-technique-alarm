using Microsoft.VisualBasic.Devices;
using System.Media;

namespace Alarm
{
    public partial class Form1 : Form
    {
        TimeSpan workTime = new TimeSpan(1, 0, 0);
        TimeSpan chillTime = new TimeSpan(0, 10, 0);
        TimeSpan end = new TimeSpan(0, 0, 0);
        SoundPlayer player = new SoundPlayer("C:\\Users\\thisi\\source\\repos\\Alarm\\assets\\alarm.wav");
				
        public Form1()
        {
            InitializeComponent();
            button3.Visible = false;
        }

        private void resetTime()
        {
            workTime = new TimeSpan(1, 0, 0);
            chillTime = new TimeSpan(0, 10, 0);
        }

        private void Mute()
        {
            player.Stop();
            button3.Visible = false;
        }
        private void Play()
        {
            player.Play();
            button3.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 1;
            button1.FlatAppearance.BorderColor = Color.Black;
            MaximizeBox = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = timer1.Enabled ? false : true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (workTime == end)
            {
                label1.Text = chillTime.ToString();
                chillTime = chillTime.Subtract(TimeSpan.FromSeconds(1));
                if (chillTime == end)
                {
                    resetTime();
                }
                if (chillTime == new TimeSpan(0, 0, 1))
                {
                    Play();
                }
            }
            else
            {
                label1.Text = workTime.ToString();
                workTime = workTime.Subtract(TimeSpan.FromSeconds(1));
                if (workTime == new TimeSpan(0, 0, 1))
                {
                    Play();
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            resetTime();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mute();
        }
    }
}