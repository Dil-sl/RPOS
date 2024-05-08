using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine360.Service
{
    public class Constants
    {

        public static string baseURL = "http://app360dev-001-site23.anytempurl.com/api/";
        public static string authTokenLogin = "App360Instabuzz_Backend6fcdsf4sf14sdf414sfd611adbwqe76rt7nxeqinuxnqry698EWRNXRWRXuyiuefnsadyiuaw634HJAD8486BjkhkjsandhHYUyuKNKyyntIfu6R674sS42dy";
        public static string authTokenException = "App360Instabuzz_BackendeEyJ1c2VybmFtZSI6ImpvaG5fZG9lIn0WYKlskBzKkLOfz4KrfnWpguCE2rxrKaejI8CNNGIC7UExceptions4574224asdasvasvdbnad2as24da8wqd";
        public static string authTokenSignUp = "App360Instabuzz_BackendeEyJzdWIiOiIasd23dJnnJnNKxMjM0NTY3ODkwIiwibmFtZSI6IkpvaGasjd56af681wdsad16daasd2656adds54asd4ad4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ";

        //pagination row count
        public static int rowCount = 30;
        public static string posExpectedDateTimeFormat = "yyyy/MM/dd h:mm:ss tt";
        public enum APIRespStatus
        {
            Success,
            Fail,
            Unauthorized

        }
        public static bool CheckLocalDateTimeFormatOfPc()
        {
            DateTime date = DateTime.Now;
            string expectedFormat = posExpectedDateTimeFormat;
            string dateString = date.ToString(expectedFormat);
            if (dateString == date.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public enum NotificationAction
        {
            wait,
            start,
            close
        }
        public enum Nature
        {
            add,
            edit,
            view,
            delete
        }
        public enum NotificationType
        {
            Connected,
            Disconnected,
            Successful
        }
        public enum ResponseStatements
        {
            Unspecified = 0,
            Successful = 1,
            Unsuccessful = 2,
            Failed = 3,
            InternetUnavailable = 4,
            Unauthorized = 5
        }
        public enum ActionTypes
        {
            created,
            searched,
            Booked,
            Hold,
            Paid,
            deleted,
            updated,
            viewed,
            loaded,
            sync,
            loggedIn,
            loggedOut
        }

        public enum Platform
        {
            Main_FE,
            Login_FE,
            BackOffice_BO,
            Menu_FE
        }

        //AlerBox messages
        public static string createdSuccess = "Created Successfully!";
        public static string scheduleSucceess = "Scheduled Successfully!";
        public static string transferedSuccess = "Transfered Successfully!";
        public static string roomBooked = "Room Booked!";
        public static string roomFaild = "Room Faild!";
        public static string saveToDraft = "Message Saved to Draft!";
        public static string updatedSuccess = "Updated Successfully!";
        public static string updatedFail = "Updated Faild!";
        public static string mergedSuccess = "Merged Successfully!";
        public static string deletedSuccess = "Deleted Successfully!";
        public static string blacklistSuccess = "Blacklisted Successfully!";
        public static string unblacklistSuccess = "Unblacklisted Successfully!";
        public static string ResetSuccess = "Reset Successfully!";
        public static string sessionClosedSuccess = "Terminal Closed Successfully!";
        public static string ineternetDisconnected = "Internet Disconnected!";
        public static string internetConnected = "Internet Connected Successfully!";


        //AlertBox colors
        public static Color succesCreateColor = Color.Green;
        public static Color succesUpdateColor = Color.FromArgb(0, 120, 215);
        public static Color succesDeleteColor = Color.Green;
        public static Color unblackllistColor = Color.Black;
        public static Color warningColor = Color.Orange;
        public static Color errorColorr = Color.Red;

        //AlertBox icons
        //public static Bitmap successIcon = SMS360.Properties.Resources.Toast1;
        //public static Bitmap errorIcon = SMS360.Properties.Resources.Toast2;
        //public static Bitmap warningIcon = SMS360.Properties.Resources.IconWarning;
    }
}
