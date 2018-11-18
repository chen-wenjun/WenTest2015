﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsTest
{
    public static class DemoMethods
    {
        private static List<string> PrepData()
        {
            List<string> output = new List<string>();

            output.Add("https://www.yahoo.com");
            output.Add("https://www.google.com");
            output.Add("https://www.microsoft.com");
            output.Add("https://www.cnn.com");
            output.Add("https://www.amazon.com");
            output.Add("https://www.facebook.com");
            output.Add("https://www.twitter.com");
            output.Add("https://www.codeproject.com");
            output.Add("https://www.stackoverflow.com");
            output.Add("https://en.wikipedia.org/wiki/.NET_Framework");

            return output;
        }
        public static List<WebsiteDataModel> RunDownloadSync()
        {
            List<string> websites = PrepData();
            var output = new List<WebsiteDataModel>();

            foreach(string site in websites)
            {
                WebsiteDataModel results = DownloadWebsite(site);
                output.Add(results);
            }

            return output;
        }

        public static List<WebsiteDataModel> RunDownloadParallelSync()
        {
            List<string> websites = PrepData();
            var output = new List<WebsiteDataModel>();

            Parallel.ForEach(websites, site => 
            {
                WebsiteDataModel results = DownloadWebsite(site);
                output.Add(results);
            });

            return output;
        }

        public static async Task<List<WebsiteDataModel>> RunDownloadParallelAsync2(IProgress<ProgressReportModel> progress)
        {
            List<string> websites = PrepData();
            var output = new List<WebsiteDataModel>();
            ProgressReportModel report = new ProgressReportModel();

            await Task.Run(() =>
            {
                Parallel.ForEach(websites, site => 
                {
                    WebsiteDataModel results = DownloadWebsite(site);
                    output.Add(results);

                    report.SitesDownloaded = output;
                    report.PercentageComplete = output.Count * 100 / websites.Count;
                    progress.Report(report);
                });
            });

            return output;
        }

        public static async Task<List<WebsiteDataModel>> RunDownloadAsync(IProgress<ProgressReportModel> progress, CancellationToken cancellationToken)
        {
            List<string> websites = PrepData();
            var output = new List<WebsiteDataModel>();
            var report = new ProgressReportModel();

            foreach(string site in websites)
            {
                WebsiteDataModel results = await DownloadWebsiteAsync(site);
                output.Add(results);

                cancellationToken.ThrowIfCancellationRequested();

                report.SitesDownloaded = output;
                report.PercentageComplete = output.Count * 100 / websites.Count;
                progress.Report(report);
            }

            return output;
        }

        public static async Task<List<WebsiteDataModel>> RunDownloadParallelAsync()
        {
            List<string> websites = PrepData();
            var tasks = new List<Task<WebsiteDataModel>>();

            foreach(string site in websites)
            {
                tasks.Add(DownloadWebsiteAsync(site));
            }

            WebsiteDataModel[] results = await Task.WhenAll(tasks);

            return new List<WebsiteDataModel>(results);
        }

        private static WebsiteDataModel DownloadWebsite(string websiteURL)
        {
            WebsiteDataModel output = new WebsiteDataModel();
            WebClient client = new WebClient();

            System.Threading.Thread.Sleep(500);
            output.WebsiteUrl = websiteURL;
            output.WebsiteData = client.DownloadString(websiteURL);

            return output;
        }

        private static async Task<WebsiteDataModel> DownloadWebsiteAsync(string websiteURL)
        {
            WebsiteDataModel output = new WebsiteDataModel();
            WebClient client = new WebClient();

            await Task.Delay(500);
            output.WebsiteUrl = websiteURL;
            output.WebsiteData = await client.DownloadStringTaskAsync(websiteURL);

            return output;
        }
    }
}
