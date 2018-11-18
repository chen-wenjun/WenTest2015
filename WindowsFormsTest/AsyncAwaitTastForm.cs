using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTest
{
    public partial class AsyncAwaitTastForm : Form
    {
        public AsyncAwaitTastForm()
        {
            InitializeComponent();
        }

        private void syncExecuteBtn_Click(object sender, EventArgs e)
        {
            Stopwatch watch = Stopwatch.StartNew();

            runDownloadSync();

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            resultTBox.Text += $"Total execution time: { elapsedMs }";
        }

        private async void asyncExecuteBtn_Click(object sender, EventArgs e)
        {
            Stopwatch watch = Stopwatch.StartNew();

            await runDownloadAsync();

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            resultTBox.Text += $"Total execution time: { elapsedMs }";
        }

        private List<string> PrepData()
        {
            List<string> output = new List<string>();

            resultTBox.Text = "";

            output.Add("https://www.yahoo.com");
            output.Add("https://www.google.com");
            output.Add("https://www.microsoft.com");
            output.Add("https://www.cnn.com");
            output.Add("https://www.codeproject.com");
            output.Add("https://www.stackoverflow.com");

            return output;
        }
        private void runDownloadSync()
        {
            List<string> websites = PrepData();

            foreach(string site in websites)
            {
                WebsiteDataModel results = DownloadWebsite(site);
                ReportWebsiteInfo(results);
            }
        }

        private async Task runDownloadAsync()
        {
            List<string> websites = PrepData();

            foreach(string site in websites)
            {
                await Task.Delay(3000);
                WebsiteDataModel results = await Task.Run(() => DownloadWebsite(site));
                ReportWebsiteInfo(results);
            }
        }

        private WebsiteDataModel DownloadWebsite(string websiteURL)
        {
            WebsiteDataModel output = new WebsiteDataModel();
            WebClient client = new WebClient();

            output.WebsiteUrl = websiteURL;
            output.WebsiteData = client.DownloadString(websiteURL);

            return output;
        }

        private void ReportWebsiteInfo(WebsiteDataModel data)
        {
            resultTBox.Text += $"{ data.WebsiteUrl } downloaded: { data.WebsiteData.Length } characters long. { Environment.NewLine }";
        }




    }
}
