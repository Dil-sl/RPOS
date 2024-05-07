using Dine360.View.Login;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dine360.Service
{
    internal class Util
    {
        public static async void sendOccurredException(string fncName, string stackTrace, string message, string platform)
        {
            SMSException posExc = new SMSException();
            posExc.MethodName = fncName;
            posExc.Details = stackTrace;
            posExc.Message = message;
            posExc.Platform = platform;
            posExc.User = CurrentUserName();

            if (posExc.Message.Contains("A task was canceled"))
            {
                return;
            }
            else
            {
                SMSExceptionResponse allInfo = await APIConnections.accessAPIConnections.ExceptionController(posExc);
            }
        }
        [System.Runtime.InteropServices.DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);
        public static bool pingStatus()
        {
            int desc;
            return InternetGetConnectedState(out desc, 0);
        }
        public static void Alert(string msg, Constants.NotificationType type)
        {
            formToastNotification frm = new formToastNotification();
            frm.showAlert(msg, type);
        }
        public static void MinimizeForm(Form form)
        {
            form.WindowState = FormWindowState.Minimized;
        }
        public static string ConvertDate(DateTime? date)
        {
            return Convert.ToDateTime(date).ToString("yyyy-MM-dd hh:mm:tt");//change date time format from yyyy/MM/dd
        }
        public static DateTime? ConvertStringToDate(string dateString)
        {
            DateTime parsedDate;
            if (DateTime.TryParseExact(dateString, "yyyy-MM-dd hh:mm:tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate))//changed date format 2024-03-07
            {
                return parsedDate;
            }
            else
            {
                return null;
            }
        }
        public static string CurrentUserName()
        {
            return (AppSettings.Default.userName);
        }
        public static string CurrentUserCode()
        {
            return (AppSettings.Default.userCode);
        }
        public static async void AnyFormClosing(object sender, FormClosingEventArgs e, bool formClosedForNewInst)
        {
            if (e.CloseReason == CloseReason.UserClosing && !formClosedForNewInst)
            {
                if (MessageBox.Show("This will quit the application. Continue?", "Quit POS360?", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    e.Cancel = true;

                else
                {
                    //wait Util.CallRemoveDeviceOnStageAPI();
                    AppSettings.Default.Reset();
                    Application.Exit();
                }
            }

        }
        public async static void logout()
        {
            //log
            string logDescription = "" + Util.CurrentUserName() + " logged out";
            ActivityLogHandle.setLogObject(Constants.ActionTypes.loggedOut.ToString(), logDescription);
            AppSettings.Default.Reset();
            formLogin.useForm.Visible = true;
        }
    }
}
