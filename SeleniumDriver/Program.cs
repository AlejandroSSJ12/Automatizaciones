using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumDriver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://serviciosdigitales.imss.gob.mx/gestionAsegurados-web-externo/asignacionNSS;JSESSIONIDASEGEXTERNO=YcnN2HPPtlakpaemtgNNquv9B0f6Afs1QKoXpXEW620MKtwVvAsJ!1912979910";
            IWindow window = driver.Manage().Window;
            window.Maximize();
            IWebElement lbl1 = driver.FindElement(By.Id("registroCurp"));
            lbl1.SendKeys("HETD030602HMCRLRA8");
            IWebElement lbl2 = driver.FindElement(By.Id("correoInput"));
            lbl2.SendKeys("meisster0@gmail.com");
            IWebElement lbl3 = driver.FindElement(By.Id("correoConfirmacionInput"));
            lbl3.SendKeys("meisster0@gmail.com");
            Thread.Sleep(12000);
            IWebElement btnContinuar = driver.FindElement(By.Id("continuar"));
            btnContinuar.Click();
            
        }
    }
}


//--------Forma 1--------------------------------------
//driver.Navigate().GoToUrl("https://www.google.com");
// o 
//INavigation navigate = driver.Navigate();
//navigate.Back();
//navigate.Forward();
//navigate.Refresh();
//-------Forma 1 ---------------------------------
//driver.Manage().Window.FullScreen();



