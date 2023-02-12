using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

Console.WriteLine("Abrindo o Site!");

string UrlMantraNet = "URL";

ChromeOptions options = new ChromeOptions();
options.AddArgument("--disable-blink-features=AutomationControlled");
options.AddArgument("--disable-extensions");
options.AddArgument("disable-infobars");

ChromeDriver driver = new ChromeDriver(options);

driver.Navigate().GoToUrl(UrlMantraNet);

driver.Manage().Window.Maximize();

var fazerLogin = driver.FindElement(By.XPath("/ html / body / div / p[2] / a"));

fazerLogin.Click();

var Login = driver.FindElement(By.Id("ID_CAMPO_EMAIL"));

Login.SendKeys("teste@teste.com.br");

driver.FindElement(By.Id("ID_CAMPO_SENHA")).SendKeys("SENHA");

driver.FindElement(By.Id("ID_CAMPO_SUBMIT")).Click();

Console.ReadKey();
