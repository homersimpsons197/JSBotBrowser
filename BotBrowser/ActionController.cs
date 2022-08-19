using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotBrowser
{
    internal class ActionController
    {
        Form1 f;
        IWebDriver d;

        public async void RunningBrowser()
        {
            await Task.Run(() =>
            {

            f = new Form1();

            try
            {
                var c = new ChromeOptions();
                IJavaScriptExecutor js = (IJavaScriptExecutor)d;

                if (f.ProfileEnabled())
                {
                    c.AddArguments(String.Format(@"--user-data-dir=C:\Users\{0}\AppData\Local\Google\Chrome\User Data", f.GetComputerName()));
                    c.AddArguments(String.Format(@"--profile-directory={0}", f.GetProfile()));
                }
                else
                {
                    c.AddArguments(String.Format(@"--{0}-data-dir=C:\Users\{0}\AppData\Local\Google\Chrome\User Data", f.GetComputerName()));
                }

                if (f.HeadlessEnabled())
                {
                    c.AddArguments("--headless");
                    c.AddArguments("--silent-launch");
                    c.AddArguments("--no-startup-window");
                        c.AddArguments("--plugins=5");
                        //c.AddArguments("--disable-cpu");
                        //c.AddArguments("--no-sandbox");
                        c.AddArguments("--window-size=1920x1080");

                    }

                    c.AddArguments("--no-sandbox");
                    c.AddExcludedArgument("--enable-automation");
                    c.AcceptInsecureCertificates = true;
                    c.AddArguments("--ignore-ssl-errors");
                    //c.AddArgument("start-maximized");
                    c.AddArguments("--lang=en");
                    c.AddArguments("--disable-blink-features=AutomationControlled");
                    c.AddArguments("--user-agent=Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/103.0.0.0 Safari/537.36");
                    var commandTimeout = TimeSpan.FromSeconds(30);

                    if (f.ProxyEnabled())
                    {
                        Proxy p = new Proxy();
                        p.Kind = ProxyKind.Manual;
                        p.IsAutoDetect = false;
                        p.HttpProxy = f.GetProxy();
                        p.SslProxy = f.GetProxy();
                        c.Proxy = p;
                    }

                    d = new ChromeDriver(String.Format(@"C:\Users\{0}\AppData\Local\Google\Chrome\User Data", f.GetComputerName()), c);

                    var wait = new WebDriverWait(d, new TimeSpan(0, 0, 30));

                    if (!f.GetUrl().Contains("https://"))
                    {
                        d.Navigate().GoToUrl(String.Format("https://" + "{0}", f.GetUrl()));
                    }
                    else
                    {
                        d.Navigate().GoToUrl(f.GetUrl());
                        js.ExecuteScript("(navigator, 'plugins', {get: () => [1, 2, 3, 4, 5]});");
                    }
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            });
        }

        public async void Screenshot()
        {
            await Task.Run(() =>
            {
                try
                {
                    Screenshot screenshot = (d as ITakesScreenshot).GetScreenshot();
                    screenshot.SaveAsFile(@"C:\Users\brucebanner\Desktop\screenshot.png", ScreenshotImageFormat.Png);
                }
                catch(Exception ex)
                {

                }
            });
        }
    }
}
