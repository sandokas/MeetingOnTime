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
            timeBox.Text = (DateTime.Now.AddMinutes(5)-DateTime.Now).ToString();
            time = new MeetingTimer();
            TimeSpan.TryParse(timeBox.Text, out timeSpan);

            timer = new System.Timers.Timer(1000);
            timer.Elapsed += HandleTimer;
        }

        private void HandleTimer(Object source, ElapsedEventArgs e)
        {
            timeSpan = time.GetTimeSpan();
            
            SetText(timeSpan.ToString());
        }

        private void startStopButton_Click(object sender, EventArgs e)
        {
            if(time.IsRunning())
            {
                time.Stop();
                timeBox.Enabled = true;
                timer.Stop();
            } else
            {
                time.Start(timeSpan);
                timeBox.Enabled = false;
                timer.Start();
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
    }
}
