using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dine360.Service
{
    internal class APIConnections
    {
        private static APIConnections _instance;
        private const string noInternet = "No internet connection detected. Your computer seems offline.";
        private int successfull = (int)Constants.ResponseStatements.Successful, unsuccessful = (int)Constants.ResponseStatements.Unsuccessful, failed = (int)Constants.ResponseStatements.Failed;
        public static APIConnections accessAPIConnections
        {
            get
            {
                if (_instance == null)
                    _instance = new APIConnections();
                return _instance;
            }
            set
            {
                _instance = value;
            }
        }
        private void displayRequestResultMessage(int respCode, string message = null, HttpResponseMessage resp = null)
        {

            if (respCode == (int)Constants.ResponseStatements.Successful)
            {

            }
            else if (respCode == (int)Constants.ResponseStatements.Unsuccessful)
                MessageBox.Show(message, "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

            else if (respCode == (int)Constants.ResponseStatements.Failed)
                SMSDialogHelper.instance.ShowOKDialog(SMSDialog_OK.DialogType.Error, "Something went wrong - " + (int)resp.StatusCode + " " + resp.StatusCode.ToString() + "", "Please contact support to find out more details about what happened.");
            /*
            if (respCode == (int)Constants.ResponseStatements.Unauthorized)
            {
                DialogResult result = MessageBox.Show("You have been logged out! Please log back in.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.OK)
                {
                    Util.logout();
                    formMain_BO.useForm.formClosedForNewInst = true;
                    formMain_BO.useForm.Close();

                }
            }*/
        }

        /*    private HttpClient CreateHttpClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(AppSettings.Default.auth.token);
            client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json; charset=utf-8");

            return client;
        }*/
        //use auth token  for every services after log exclude exception post method it use custom token
        private HttpClient CreateHttpClient()
        {
            HttpClient client = new HttpClient();

            // Retrieve the user token from AppSettings
            string authToken = AppSettings.Default.token;
            string userToken = AppSettings.Default.userCode;

            // Add authorization header if user token is not null or empty
            if (!string.IsNullOrEmpty(authToken))
            {
                client.DefaultRequestHeaders.Add("AuthToken", authToken);
                client.DefaultRequestHeaders.Add("UserToken", userToken);
            }

            client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json; charset=utf-8");

            return client;
        }
    }
}
