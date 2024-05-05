using System;
using System.Collections.Concurrent;
using System.IO;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleCrawler
{
    class SimpleCrawler
    {
        private ConcurrentDictionary<string, bool> urls = new ConcurrentDictionary<string, bool>();
        private int count = 0;

        static async Task Main(string[] args)
        {
            SimpleCrawler myCrawler = new SimpleCrawler();
            string startUrl = "http://www.cnblogs.com/dstang2000/";
            if (args.Length >= 1) startUrl = args[0];
            myCrawler.urls.TryAdd(startUrl, false); // Add initial URL
            await myCrawler.CrawlAsync();
        }

        private async Task CrawlAsync()
        {
            Console.WriteLine("开始爬行了.... ");
            while (true)
            {
                string current = null;
                foreach (var url in urls.Keys)
                {
                    if (!urls[url])
                    {
                        current = url;
                        break;
                    }
                }

                if (current == null || count > 10) break;
                Console.WriteLine("爬行" + current + "页面!");

                try
                {
                    string html = await DownLoadAsync(current); // Asynchronously download
                    urls[current] = true;
                    count++;
                    Parse(html); // Parse and add new links
                    Console.WriteLine("爬行结束");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error crawling {current}: {ex.Message}");
                }
            }
        }

        public async Task<string> DownLoadAsync(string url)
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    HttpResponseMessage response = await httpClient.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string html = await response.Content.ReadAsStringAsync();
                    string fileName = count.ToString();
                    await File.WriteAllTextAsync(fileName, html);
                    return html;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        private void Parse(string html)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                            .Trim('"', '\"', '#', '>');
                if (strRef.Length > 0)
                {
                    urls.TryAdd(strRef, false);
                }
            }
        }
    }
}
