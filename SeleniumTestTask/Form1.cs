using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;



namespace SeleniumTestTask
{
    public partial class Form1 : Form
    {
        IWebDriver Browser;
        bool _isEnglishLang = false;
        bool _isRussianLang = false;

        public Form1()
        {
            InitializeComponent();
            //Select browser by default
            _radioChrome.Checked = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Initialize browser regarding to choise
            if (_radioChrome.Checked)
            {
                Browser = new OpenQA.Selenium.Chrome.ChromeDriver();
            }
            if (_radioMozilla.Checked)
            {
                Browser = new OpenQA.Selenium.Firefox.FirefoxDriver();
            }
            Browser.Manage().Window.Maximize();
            _logBox.AppendText("Browser object initialized. Type: " + Browser.GetType().ToString());
            #endregion

            bool _isTestSuiteFinishedOK = false;
            #region Try to run set of actions
            try
            {
                #region Login
                _logBox.AppendText("Try go to facebook.\n");
                Browser.Navigate().GoToUrl("https://www.facebook.com/");

                //Login
                IWebElement insertmail = Browser.FindElement(By.Id("email"));
                if (insertmail != null)
                    _logBox.AppendText("Found where to input email\n");
                insertmail.SendKeys("olegseleniumtest@i.ua");

                IWebElement isertpass = Browser.FindElement(By.Id("pass"));
                if (isertpass != null)
                    _logBox.AppendText("Found where to input pass\n");
                isertpass.SendKeys("seleniumtesttask");

                IWebElement LoginButton = Browser.FindElement(By.Id("loginbutton"));
                LoginButton.Click();
                _logBox.AppendText("Loging in.\n");
                #endregion
                #region  Check activated language from 2 options: English and Russian
                IWebElement checkElement;
                try
                {
                    checkElement = Browser.FindElement(By.PartialLinkText("Home")); //if it will initialize language is English
                    _isEnglishLang = true;
                }
                catch
                {
                    _isRussianLang = true;
                }
                finally
                {
                    if (!_isEnglishLang && !_isRussianLang)
                    {
                        _logBox.AppendText("Something wrong with languages.\n");
                    }
                }

                //if (checkElement == null) //in case if not, i will take Russian as default, such a twist
                //{
                   
                //}
                

                if (_isEnglishLang)
                {
                    _logBox.AppendText("Current language - English.\n");
                }
                else
                {
                    _logBox.AppendText("Current language - Russian.\n");
                }
                
               
                #endregion
                #region Change lang
                //this time i will not seek for element, i can go directly to url, why not? 
                _logBox.AppendText("Try to go to language settings.\n");
                Browser.Navigate().GoToUrl("https://www.facebook.com/settings?tab=language&section=account");


                string languageSelectByText = string.Empty;
                string languageSelectByValue = string.Empty;
                if (_isEnglishLang)
                {
                    languageSelectByText = "Русский";
                    languageSelectByValue = "ru_RU";
                }
                else //I will use this a bit later just to demonstrate2 ways
                {
                    if (_isRussianLang)
                    {
                        languageSelectByText = "English";
                        languageSelectByValue = "en_US";
                    }
                    else
                    {
                        _logBox.AppendText("Whaaat? Something wrong with languages! ");
                        throw new Exception("TS failed by Olegs laziness.");
                    }
                }
                    
                

                
                IWebElement changelangDropList = Browser.FindElement(By.Name("new_language"));
                SelectElement selectLanguage = new SelectElement(changelangDropList);

                //Just to show different ways
                if (_isEnglishLang)
                    selectLanguage.SelectByText(languageSelectByText);
                else
                    selectLanguage.SelectByValue(languageSelectByValue);
                _logBox.AppendText("Language option changed to: " + languageSelectByText + "\n");

                //Save Changes
                //Here i got problems with clicking. As i found on forums - delay should help. It didnt.
                //So i defined id of button for each language 
                //string buttonSubmitId = string.Empty;
                //if (_isEnglishLang)
                //{
                //    buttonSubmitId ="u_0_7";
                //}
                //if (_isRussianLang)
                //{
                //    buttonSubmitId = "u_4_2";
                //}
                string submitButtonXPATH = "//input[@type='submit']";
                IWebElement submit = Browser.FindElement(By.XPath(submitButtonXPATH));
                //problem is here-->             
                submit.Click();
                _logBox.AppendText("Changes Submitted.\n");

                #endregion
                #region Final
                _isTestSuiteFinishedOK = true;
                #endregion
            }
            catch (Exception runex)
            {
                _logBox.AppendText("\n\n" + runex.Message);
            }
            #endregion
            MessageBox.Show("Test suite result: " + _isTestSuiteFinishedOK);
        }

        private void _radioChrome_CheckedChanged(object sender, EventArgs e)
        {
            bool isCheckedC = _radioChrome.Checked;
        }

        private void _radioChrome_Click(object sender, EventArgs e)
        {
            _radioMozilla.Checked = false;
            _radioChrome.Checked = true;
            _logBox.AppendText("Chrome selected.\n");
        }
        private void _radioMozilla_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void _radioMozilla_Click(object sender, EventArgs e)
        {
            _radioMozilla.Checked = true;
            _radioChrome.Checked = false;
            _logBox.AppendText("Mozarella selected.\n");           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Browser.Quit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Browser.Quit();
            Application.Exit();
        }
    }
}
