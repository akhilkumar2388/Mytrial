using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
namespace selenium
{
    class Program
    {
        static void Main(string[] args)
        {
            try { meth1(); }
            catch (Exception ex) { Console.WriteLine(ex.StackTrace); }

            Console.WriteLine("MY APP");
//#if DEBUG
//            Console.WriteLine("hello there ,this is DEBUG code");
//#endif
            Console.ReadKey();
        }

         public static void meth1()
        {
            try { meth2(); }
            catch (Exception ex) { throw ex; }
        }
        public static void meth2()
        {
            try { throw new Exception("trial exception"); }
            catch (Exception ex) { throw; }
        }
    }
        // driver.TakeScreenshot().SaveAsFile(@"C:\Users\desktop\error.jpg",ScreenshotImageFormat.Jpeg);

    struct abc
    {
        int a;
    }
    class trialclass
    {
        int a;


    }
}
    
  

