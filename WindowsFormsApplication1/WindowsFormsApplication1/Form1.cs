using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Timers;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {            
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string json;        //Value used for parsing JSON data                     
            string creditVal;   //string used for credit value text on form
            double credDouble;  //Double used for the credit value
            double divisionConst = 1000000000000.00;    //Const used to divde credDouble, so total shows like ethpool shows
            string wallet = "9F551A32e971b7B7fa4e1Aa1349bd5dAc1f25F41"; //Wallet address, hardcoded for now
            string jsonStr; //string used for url
            double maxCredit;  //Max current credits by any user, used to calculate percent complete
            double perCompDou;  //Double used to calculate percentage complted            

            jsonStr = ("http://ethpool.org/api/miner_new/" + wallet);   //Adds address to url         
            json = new WebClient().DownloadString(jsonStr); //downloads JSON as string
            JToken token = JToken.Parse(json);  //Parses the JSON using JToken, so values can be found
            credDouble = token.SelectToken("credits[0].credit").Value<double>();    //gets value for credit converts it to a double
            perCompDou = credDouble;
            credDouble = (credDouble / divisionConst);  //Divides by the const value to get it to the correct values
            creditVal = credDouble.ToString();  //Converts credDouble to a string
            creditLabel.Text = creditVal;   //Changes label text

            maxCredit = token.SelectToken("credits[0].maxCredit").Value<double>(); //Gets value of MaxCredit and converts it to a double
            perCompDou = ((perCompDou / maxCredit) * 100);      //Calculates percentage
            perCompDou = System.Math.Round(perCompDou, 3);  //Rounds Value to only 3 places after decimal
            percentComLabel.Text = (perCompDou.ToString() + "%");  // Changes label and adds a percent sign
            Account acct = JsonConvert.DeserializeObject<Account>(json);    //Sets values to the account class             
            addLabel.Text = acct.address;
            hashLabel.Text = acct.hashRate;
            reportHashLabel.Text = acct.reportedHashRate;
        }


        //If About is clicked, a popup shows the author
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by KB Bountyhunter!");
        }

        public void startTimerButton_Click(object sender, EventArgs e)
        {
            string timeStr;
            int timeInt;

            intervalTextBox.ReadOnly = true;        //Makes textbox read only
            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            timeStr = intervalTextBox.Text;
            timeInt = (Int32.Parse(timeStr) * 1000);            
            aTimer.Interval = timeInt;
            aTimer.Enabled = true;

            while (intervalTextBox.ReadOnly != false) ;           
        }

        private void stopTimerButton_Click(object sender, EventArgs e)
        {
            intervalTextBox.ReadOnly = false;
                             
        }

        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            genInfo();
        }

        private static void genInfo()
        {
            MessageBox.Show("Test");
            //string json1;        //Value used for parsing JSON data                     
            //string creditVal1;   //string used for credit value text on form
            //double credDouble1;  //Double used for the credit value
            //double divisionConst1 = 1000000000000.00;    //Const used to divde credDouble, so total shows like ethpool shows
            //string wallet1 = "9F551A32e971b7B7fa4e1Aa1349bd5dAc1f25F41"; //Wallet address, hardcoded for now
            //string jsonStr1; //string used for url
            //double maxCredit1;  //Max current credits by any user, used to calculate percent complete
            //double perCompDou1;  //Double used to calculate percentage complted            

            //jsonStr1 = ("http://ethpool.org/api/miner_new/" + wallet1);   //Adds address to url         
            //json1 = new WebClient().DownloadString(jsonStr1); //downloads JSON as string
            //JToken token = JToken.Parse(json1);  //Parses the JSON using JToken, so values can be found
            //credDouble1 = token.SelectToken("credits[0].credit").Value<double>();    //gets value for credit converts it to a double
            //perCompDou1 = credDouble1;
            //credDouble1 = (credDouble1 / divisionConst1);  //Divides by the const value to get it to the correct values
            //creditVal1 = credDouble1.ToString();  //Converts credDouble to a string
            //creditLabel.Text = creditVal1;   //Changes label text

            //maxCredit1 = token.SelectToken("credits[0].maxCredit").Value<double>(); //Gets value of MaxCredit and converts it to a double
            //perCompDou1 = ((perCompDou1 / maxCredit1) * 100);      //Calculates percentage
            //perCompDou1 = System.Math.Round(perCompDou1, 3);  //Rounds Value to only 3 places after decimal
            //percentComLabel.Text = (perCompDou1.ToString() + "%");  // Changes label and adds a percent sign
            //Account acct = JsonConvert.DeserializeObject<Account>(json1);    //Sets values to the account class             
            //addLabel.Text = acct.address;
            //hashLabel.Text = acct.hashRate;
            //reportHashLabel.Text = acct.reportedHashRate;
            //Form1.
        }
    }
}
