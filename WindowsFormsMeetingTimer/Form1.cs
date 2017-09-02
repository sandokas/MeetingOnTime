using org.meetingontime;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace org.meetingontime.ui.wf
{
    public partial class Form1 : Form
    {
        private MeetingTimer time;
        private TimeSpan timeSpan;
        private System.Timers.Timer timer;
        public Form1()
        {
            InitializeComponent();
            timeBox.Text = "00:05:00";
            SetTimeSpan("00:05:00");

            time = new MeetingTimer();
            time.SetTimeSpan(timeSpan);

            timer = new System.Timers.Timer(100);
            timer.Elapsed += HandleTimer;
        }

        private void HandleTimer(Object source, ElapsedEventArgs e)
        {
            timeSpan = time.GetTimeSpan();
            
            SetText(timeSpan);
        }

        private void SetTimeSpan (string text)
        {
            TimeSpan.TryParse(text, out timeSpan);
        }

        private void startStopButton_Click(object sender, EventArgs e)
        {
            if(time.IsRunning())
            {
                time.Stop();
                timer.Stop();
                EnableButtons();
            }
            else
            {
                SetTimeSpan(timeBox.Text);
                time.Start(timeSpan);
                timer.Start();
                DisableButtons();
            }
        }
        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.timeBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.timeBox.Text = text;
            }
        }

        private void SetText(TimeSpan timeSpan)
        {
            string text = timeSpan.ToString();
            text = text.Substring(0,text.LastIndexOf("."));
            SetText(text);
        } 

        private void DisableButtons()
        {
            timeBox.Enabled = false;
            startStopButton.Text = "Stop";
        }

        private void EnableButtons()
        {
            timeBox.Enabled = true;
            startStopButton.Text = "Start";
        }

        private void increasetime_Click(object sender, EventArgs e)
        {
            time.AddMilliseconds(600000);
            timeSpan = time.GetTimeSpan();
            SetText(timeSpan);
        }

        private void decreasetime_Click(object sender, EventArgs e)
        {
            time.AddMilliseconds(-600000);
            timeSpan = time.GetTimeSpan();
            SetText(timeSpan);
        }
    }
}
