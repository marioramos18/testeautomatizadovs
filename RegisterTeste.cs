using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ExactSales
{
    [TestClass]
    public class RegisterTeste
    {
        [TestMethod]
        public void Teste1()
        {   

            //Validar Cadastro
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://demo.automationtesting.in/Register.html");
            driver.Manage().Window.Maximize();
            

            RegisterPage register = new RegisterPage(driver);
            register.CampoFirtsName("Mario");
            register.CampoLastName("Ramos");
            register.CampoAndress("Heriberto Hulse");
            register.CampoEmail("marionick19@gmail.com");
            register.CampoTelephone("7999655519");
            register.RadioGender();
            register.CheckboxHobbies();
            register.SelectLanguages();
            register.SelectSkills();
            register.SelectCoutry();
            register.SelectCoutry2();
            register.BirthDay();
            register.CampoFirstPassword("Mario18");
            register.CampoSecondPassword("Mario18");
            register.BntSubmit();

            register.EsperaPaginaCarregar(50);

            string url = driver.Url;
            Console.Out.Write(" Url da página"  + url);
            Assert.IsTrue(url.Contains("http://demo.automationtesting.in/WebTable.html"));
            Console.Out.Write(" Teste Passou");

            driver.Close();

        }

        [TestMethod]
        public void Teste2()
        {
            //Validar se o site permite registrar usuário com e-mail repetido
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://demo.automationtesting.in/Register.html");
            driver.Manage().Window.Maximize();


            RegisterPage register = new RegisterPage(driver);
            register.BntRefresh();
            register.CampoFirtsName("Mario");
            register.CampoLastName("Ramos");
            register.CampoAndress("Heriberto Hulse");
            register.CampoEmail("marioramos18@gmail.com");
            register.CampoTelephone("1234325978");
            register.RadioGender();
            register.CheckboxHobbies();
            register.SelectLanguages();
            register.SelectSkills();
            register.SelectCoutry();
            register.SelectCoutry2();
            register.BirthDay();
            register.CampoFirstPassword("Mario18");
            register.CampoSecondPassword("Mario18");
            register.BntSubmit();

            Assert.IsTrue(driver.FindElement(By.XPath("/html/body/section/div[1]/div/div")).Displayed);


            Console.Out.Write(" Teste Passou");

            driver.Close();
            

        }

        [TestMethod]
        public void Teste3()
        {
            //Validar telefone repetido
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://demo.automationtesting.in/Register.html");
            driver.Manage().Window.Maximize();


            RegisterPage register = new RegisterPage(driver);
            register.BntRefresh();
            register.CampoFirtsName("Mario");
            register.CampoLastName("Ramos");
            register.CampoAndress("Heriberto Hulse");
            register.CampoEmail("marionick19@gmail.com");
            register.CampoTelephone("7999655510");
            register.RadioGender();
            register.CheckboxHobbies();
            register.SelectLanguages();
            register.SelectSkills();
            register.SelectCoutry();
            register.SelectCoutry2();
            register.BirthDay();
            register.CampoFirstPassword("Mario18");
            register.CampoSecondPassword("Mario18");
            register.BntSubmit();

            Assert.IsTrue(driver.FindElement(By.XPath("/html/body/section/div[1]")).Displayed);


            Console.Out.Write(" Teste Passou");

            driver.Close();


        }
    }
}
