using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Runtime.Serialization;
using System.new


namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            string json = new WebClient().DownloadString("http://ethpool.org/api/miner_new/9F551A32e971b7B7fa4e1Aa1349bd5dAc1f25F41");
            Console.WriteLine(json);

            Machine machine = JsonConvert.DeserializeObject<Machine>(json);
            Console.WriteLine("Adress: " + machine.address);
            Console.WriteLine("HashRate: " + machine.hashRate);
            Console.WriteLine(machine.reportedHashRate);
            Console.WriteLine(machine.credit);

        }
    }
}
