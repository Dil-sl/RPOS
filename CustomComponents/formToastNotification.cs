using Dine360.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dine360.CustomComponents
{
    public partial class formToastNotification : Form
    {
        private Constants.NotificationAction action;
        private int x, y;
        public formToastNotification()
        {
            InitializeComponent();
        }

        private void timerDisplayTime_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case Constants.NotificationAction.wait:
                    timerDisplayTime.Interval = 5000;
                    action = Constants.NotificationAction.close;
                    break;
                case Constants.NotificationAction.start:
                    this.timerDisplayTime.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = Constants.NotificationAction.wait;
                        }
                    }
                    break;
                case Constants.NotificationAction.close:
                    timerDisplayTime.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        private void picBoxClose_Click(object sender, EventArgs e)
        {
            timerDisplayTime.Interval = 1;
            action = Constants.NotificationAction.close;
        }

        public void showAlert(string msg, Constants.NotificationType type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                formToastNotification frm = (formToastNotification)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;

                }

            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch (type)
            {
                case Constants.NotificationType.Connected:
                    // this.picBoxIcon.Image = SMS360.Properties.Resources.Wi_Fi_on;
                    this.BackColor = Color.FromArgb(59, 189, 159);
                    break;
                case Constants.NotificationType.Disconnected:
                    // this.picBoxIcon.Image = SMS360.Properties.Resources.Wi_Fi_off;
                    this.BackColor = Color.FromArgb(255, 81, 87);
                    break;
                case Constants.NotificationType.Successful:
                    // this.picBoxIcon.Image = SMS360.Properties.Resources.IconSuccess;
                    this.BackColor = Color.FromArgb(76, 175, 80);
                    break;
            }


            this.lblMessage.Text = msg;

            this.Show();
            this.action = Constants.NotificationAction.start;
            this.TopMost = true;
            this.timerDisplayTime.Interval = 1;
            this.timerDisplayTime.Start();
        }
    }
}
