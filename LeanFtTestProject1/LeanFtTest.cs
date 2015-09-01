using System;
using NUnit.Framework;
using HP.LFT.SDK;
using HP.LFT.SDK.Web;
using System.Diagnostics;

namespace LeanFtTestProject1
{
    [TestFixture]
    public class LeanFtTest : UnitTestClassBase
    {
        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
            // Setup once per fixture
        }

        [SetUp]
        public void SetUp()
        {
            // Before each test
        }

        [Test]
        public void Test()
        {
            IBrowser browser = BrowserFactory.Launch(BrowserType.InternetExplorer);
            browser.Navigate("http://newtours.demoaut.com/");

           // IBrowser browser = BrowserFactory.Launch(BrowserType.InternetExplorer);

           // ApplicationModel1 appmodel = new ApplicationModel1(browser);
            // Navigate to a webpage
           // browser.Navigate("http://newtours.demoaut.com/");

            //Enter Text
            browser.Describe<IEditField>(new EditFieldDescription
            {
                Type = @"text",
                TagName = @"INPUT",
                Name = @"userName"
            }).SetValue("tutorial");

            browser.Describe<IEditField>(new EditFieldDescription
            {
                Type = @"password",
                TagName = @"INPUT",
                Name = @"password"
            }).SetValue("tutorial");





            // appmodel.WelcomeMercuryToursPage.SignInImage.Click();

            ////Click a button
            browser.Describe<IImage>(new ImageDescription
            {
                Alt = @"Sign-In",
                Type = HP.LFT.SDK.Web.ImageType.Button,
                TagName = @"INPUT"
            }).Click();
            browser.Close();
        }

        static BrowserType[] browserStyle = new BrowserType[] { BrowserType.Chrome, BrowserType.Firefox, BrowserType.InternetExplorer };

       

        [Test, TestCaseSource("browserStyle")]
        public void Test(BrowserType browserStyle)
        {
            // Display the browser style in the output window
            Debug.WriteLine("Browser Style = " + browserStyle);

            // Launch the browser based on browserStyle
            IBrowser browser = BrowserFactory.Launch(browserStyle);

            browser.Navigate("http://newtours.demoaut.com/");

            // IBrowser browser = BrowserFactory.Launch(BrowserType.InternetExplorer);

            // ApplicationModel1 appmodel = new ApplicationModel1(browser);
            // Navigate to a webpage
            // browser.Navigate("http://newtours.demoaut.com/");

            //Enter Text
            browser.Describe<IEditField>(new EditFieldDescription
            {
                Type = @"text",
                TagName = @"INPUT",
                Name = @"userName"
            }).SetValue("tutorial");

            browser.Describe<IEditField>(new EditFieldDescription
            {
                Type = @"password",
                TagName = @"INPUT",
                Name = @"password"
            }).SetValue("tutorial");





            // appmodel.WelcomeMercuryToursPage.SignInImage.Click();

            ////Click a button
            browser.Describe<IImage>(new ImageDescription
            {
                Alt = @"Sign-In",
                Type = HP.LFT.SDK.Web.ImageType.Button,
                TagName = @"INPUT"
            }).Click();
            browser.Close();
        }
        [TearDown]
        public void TearDown()
        {
            // Clean up after each test
        }

        [TestFixtureTearDown]
        public void TestFixtureTearDown()
        {
            // Clean up once per fixture
        }
    }
}
