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

        private void button1_Click(object sender, EventArgs e)
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
            intervalTextBox.ReadOnly = true;        //Makes textbox read only
            //while (intervalTextBox.ReadOnly == true)
            //{                
            //    int time;  // timer taken from text box.

            //    if (Int32.TryParse(intervalTextBox.Text, out time))
            //        ;
            //    else
            //        MessageBox.Show("An error has occurred, please try again!");

            //    time = time * 1000;
            //    System.Timers.Timer timer = new System.Timers.Timer();
            //    timer.Elapsed += new ElapsedEventHandler(button1_Click);
            //    timer.Interval = time;
            //    timer.Enabled = true;
                
            //}
        }

        private void stopTimerButton_Click(object sender, EventArgs e)
        {
            intervalTextBox.ReadOnly = false;                       
        }
    }
}
