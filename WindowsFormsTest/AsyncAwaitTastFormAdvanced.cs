using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTest
{
    public partial class AsyncAwaitTastFormAdvanced : Form
    {
        CancellationTokenSource cts;

        public AsyncAwaitTastFormAdvanced()
        {
            InitializeComponent();
        }

        private void syncExecuteBtn_Click(object sender, EventArgs e)
        {
            resultTBox.Text = "";
            Stopwatch watch = Stopwatch.StartNew();

            var results = DemoMethods.RunDownloadSync();
            PrintResults(results);

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            resultTBox.Text += $"Total execution time: { elapsedMs }";
        }

        private void parallelSyncExecute_Click(object sender, EventArgs e)
        {
            resultTBox.Text = "";
            Stopwatch watch = Stopwatch.StartNew();

            var results = DemoMethods.RunDownloadParallelSync();
            PrintResults(results);

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            resultTBox.Text += $"Total execution time: { elapsedMs }";
        }

        private async void parallelAsyncExecute2_Click(object sender, EventArgs e)
        {
            var progress = new Progress<ProgressReportModel>();
            progress.ProgressChanged += (sender1, e1) => 
            {
                progressBar1.Value = e1.PercentageComplete;
                PrintResults(e1.SitesDownloaded);
            };

            resultTBox.Text = "";
            Stopwatch watch = Stopwatch.StartNew();

            var results = await DemoMethods.RunDownloadParallelAsync2(progress);
            PrintResults(results);

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            resultTBox.Text += $"Total execution time: { elapsedMs }";
        }

        private async void asyncExecuteBtn_Click(object sender, EventArgs e)
        {
            var progress = new Progress<ProgressReportModel>();
            progress.ProgressChanged += (sender1, e1) => 
            {
                progressBar1.Value = e1.PercentageComplete;
                PrintResults(e1.SitesDownloaded);
            };

            resultTBox.Text = "";
            Stopwatch watch = Stopwatch.StartNew();

            try
            {
                cts = new CancellationTokenSource();
                var results = await DemoMethods.RunDownloadAsync(progress, cts.Token);
                PrintResults(results);

            }
            catch (OperationCanceledException)
            {
                resultTBox.Text += $"The async donwload was cancelled. { Environment.NewLine }";
            }

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            resultTBox.Text += $"Total execution time: { elapsedMs }";
        }

        private async void parallelAsyncExecuteBtn_Click(object sender, EventArgs e)
        {
            resultTBox.Text = "";
            Stopwatch watch = Stopwatch.StartNew();

            var results = await DemoMethods.RunDownloadParallelAsync();
            PrintResults(results);

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            resultTBox.Text += $"Total execution time: { elapsedMs }";

        }

        private void cancelAsyncBtn_Click(object sender, EventArgs e)
        {
            if(cts != null)
            {
                cts.Cancel();
            }
        }

        private void PrintResults(List<WebsiteDataModel> results)
        {
            resultTBox.Text = "";
            foreach(var item in results)
            {
                resultTBox.Text += $"{ item.WebsiteUrl } downloaded: { item.WebsiteData.Length } characters long. { Environment.NewLine }";
            }
        }

    }
}
