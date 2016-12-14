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

            string json = new WebClient().DownloadString("http://ethpool.org/api/miner_new/9F551A32e971b7B7fa4e1Aa1349bd5dAc1f25F41");
            Console.WriteLine(json);
            string json1 = json;
            string test;

            JToken token = JToken.Parse(json1);
            test = token.SelectToken("credits[0].credit").Value<string>();
            creditLabel.Text = test;
            Account acct = JsonConvert.DeserializeObject<Account>(json);            
            addLabel.Text = acct.address;
            hashLabel.Text = acct.hashRate;          
            reportHashLabel.Text = acct.reportedHashRate;            
           
            
            
        }
    }
}
