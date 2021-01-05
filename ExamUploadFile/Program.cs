using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExamUploadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://the-internet.herokuapp.com/upload";


            driver.FindElement(By.Id("file-upload")).SendKeys(@"C:\Users\nermin.mitkov\Desktop\All Assignments 2019-2020\GiftShop\template\images\dbz-jacket.jpg");

            driver.FindElement(By.Id("file-submit")).Click();
            Thread.Sleep(3000);
            driver.Quit();

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://the-internet.herokuapp.com/upload";


            driver.FindElement(By.Id("file-upload")).SendKeys(@"C:\Users\nermin.mitkov\Downloads\variant5-20\1915082.docx");

            driver.FindElement(By.Id("file-submit")).Click();
            Thread.Sleep(3000);
            driver.Quit();

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://the-internet.herokuapp.com/upload";


            driver.FindElement(By.Id("file-upload")).SendKeys(@"E:\02. Awareness\04. The Journey.mp4");

            driver.FindElement(By.Id("file-submit")).Click();
            Thread.Sleep(3000);
            driver.Quit();


        }
    }
}
