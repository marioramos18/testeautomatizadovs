using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    class RegisterPage
    {

        IWebDriver driver;

        By FirstName = By.XPath("/html/body/section/div/div/div[2]/form/div[1]/div[1]/input");
        By LastName = By.XPath("/html/body/section/div/div/div[2]/form/div[1]/div[2]/input");
        By  Andress = By.XPath("/html/body/section/div/div/div[2]/form/div[2]/div/textarea");
        By Email = By.XPath("/html/body/section/div/div/div[2]/form/div[3]/div[1]/input");
        By Telephone = By.XPath("/html/body/section/div/div/div[2]/form/div[4]/div/input");
        By Gender = By.Name("radiooptions");
        By Hobbies = By.Id("checkbox1");
        By Languages = By.Id("msdd");
        By LanguagesSelect = By.XPath("/html/body/section/div/div/div[2]/form/div[7]/div/multi-select/div[2]/ul/li[2]/a");
        By Skills = By.Id("Skills");
        By SkillAPI = By.XPath("/html/body/section/div/div/div[2]/form/div[8]/div/select/option[6]");
        By CountryAfghanistan = By.XPath("/html/body/section/div/div/div[2]/form/div[9]/div/select/option[2]");
        By CampoSelectCountryAustralia = By.XPath("/html/body/section/div/div/div[2]/form/div[10]/div/select/option[2]");
        By BirthDateYear = By.XPath("/html/body/section/div/div/div[2]/form/div[11]/div[3]/select/option[19]");
        By BirthDateMonth = By.XPath("/html/body/section/div/div/div[2]/form/div[11]/div[2]/select/option[7]");
        By BirthDateDay = By.XPath("/html/body/section/div/div/div[2]/form/div[11]/div[1]/select/option[72]");
        By FirtsPassword = By.Id("firstpassword");
        By SecondPassword = By.Id("secondpassword");
        By Submit = By.Id("submitbtn");
        By Refresh = By.Id("Button1");


        public RegisterPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void CampoFirtsName( string Firtsname)
        {
            driver.FindElement(FirstName).SendKeys(Firtsname);
        }

        public void CampoLastName(string Lastname)
        {
            driver.FindElement(LastName).SendKeys(Lastname);
        }

        public void CampoAndress( string andress)
        {
            driver.FindElement(Andress).SendKeys(andress);
        }

        public void CampoEmail( string email)
        {
            driver.FindElement(Email).SendKeys(email);
        }


        public void CampoTelephone(string telefone)
        {
            driver.FindElement(Telephone).SendKeys(telefone);
        }


        public void RadioGender()
        {
            driver.FindElement(Gender).Click();
        }

        public void CheckboxHobbies()
        {
            driver.FindElement(Hobbies).Click();
            
        }

        public void SelectLanguages()
        {
            driver.FindElement(Languages).Click();
            driver.FindElement(LanguagesSelect).Click();
        }

        public void SelectSkills()
        {
            driver.FindElement(SkillAPI).Click();
        }

        public void SelectCoutry()
        {
            driver.FindElement(CountryAfghanistan).Click();

        }

        public void SelectCoutry2()
        {
            driver.FindElement(CampoSelectCountryAustralia).Click();

        }

        public void BirthDay()
        {

            driver.FindElement(BirthDateDay).Click();
            driver.FindElement(BirthDateMonth).Click();
            driver.FindElement(BirthDateYear).Click();
        }

        public void CampoFirstPassword(string password)
        {
            driver.FindElement(FirtsPassword).SendKeys(password);
        }

        public void CampoSecondPassword(string confirmpassword)
        {
            driver.FindElement(SecondPassword).SendKeys(confirmpassword);
        }

        public void BntSubmit()
        {
            driver.FindElement(Submit).Click();
           
        }

        public void BntRefresh()
        {
            driver.FindElement(Refresh).Click();
        }

        public void EsperaPaginaCarregar( int seconds)
        {
            System.Threading.Thread.Sleep(seconds * 100);
        }

    }
}
