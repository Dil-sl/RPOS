using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dine360.View.Main
{
    public partial class formMain : Form
    {
        private static formMain _instance;
        public bool formClosedForNewInst = false;
        public formMain()
        {
            InitializeComponent();
        }
        public static formMain useForm
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new formMain();
                return _instance;
            }
        }
        public void setPanel(Form obj)
        {
            pnlMain.Controls.Clear();
            obj.TopLevel = false;
            obj.TopMost = true;
            obj.Dock = DockStyle.Fill;
            obj.Show();
            pnlMain.Controls.Add(obj);
        }
        async void CloseForm()
        {
            formClosedForNewInst = true;
            this.Close();
            useForm.Close();
            useForm.Dispose();
        }
        private async void menuBar_RBtn_Clicked(object sender, EventArgs e)
        {
            RadioButton radioBtn = sender as RadioButton;

            /* if (radioBtn.Name == rBtnDashboard.Name)
             {
                 formDashboard.useForm.Close();
                 setPanel(formDashboard.useForm);
             }
             if (radioBtn.Name == rBtnNewSMS.Name)
             {
                 formSendSMS.useForm.Close();
                 setPanel(formSendSMS.useForm);
             }
             if (radioBtn.Name == rBtnDraftSMS.Name)
             {
                 formDraftSMS.useForm.Close();
                 setPanel(formDraftSMS.useForm);
             }
             if (radioBtn.Name == rBtnScheduleSMS.Name)
             {
                 formScheduledSMS.useForm.Close();
                 setPanel(formScheduledSMS.useForm);
             }
             if (radioBtn.Name == rBtnSendBox.Name)
             {
                 formSentBox.useForm.Close();
                 setPanel(formSentBox.useForm);
             }
             if (radioBtn.Name == rBtnTrash.Name)
             {
                 formTrash.useForm.Close();
                 setPanel(formTrash.useForm);
             }
             if (radioBtn.Name == rBtnContact.Name)
             {
                 formContact.useForm.Close();
                 setPanel(formContact.useForm);
             }
             if (radioBtn.Name == rBtnOutBox.Name)
             {
                 formOutBox.useForm.Close();
                 setPanel(formOutBox.useForm);
             }*/

        }
        private void LoadUi()
        {
            /*_timer.Enabled = true;
            _timer.Interval = 1000;
            _timer.Tick += Timer_Tick;
            btnHeaderUserName.Text = Util.CurrentUserName();*/
        }
        public void DisableAll(bool state)
        {/*
            btnHeaderUserName.Enabled = state;
            picBoxClose.Enabled = state;
            picBoxMinimize.Enabled = state;
            rBtnContact.Enabled = state;
            rBtnDashboard.Enabled = state;
            rBtnDraftSMS.Enabled = state;
            rBtnNewSMS.Enabled = state;
            rBtnScheduleSMS.Enabled = state;
            rBtnSendBox.Enabled = state;
            rBtnOutBox.Enabled = state;*/
        }
    }
}
