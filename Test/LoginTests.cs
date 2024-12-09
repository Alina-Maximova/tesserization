using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace Test
{
    public class LoginTests
    {
        private IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            // Инициализация драйвера
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
        }

        [Test]
        public void TestLogin()
        {
            // Открыть страницу логина
            _driver.Navigate().GoToUrl("https://a30860-84e6.x.d-f.pw/Account/Login");

            // Найти элементы для ввода логина и пароля
            var usernameField = _driver.FindElement(By.Name("UserName")); // Замените на актуальный ID
            var passwordField = _driver.FindElement(By.Name("Password")); // Замените на актуальный ID
            var loginButton = _driver.FindElement(By.CssSelector("button[type='submit']"));

            // Ввести данные для авторизации
            usernameField.SendKeys("Admin");
            passwordField.SendKeys("1234567Cc@");

            // Замените на актуальный ID
            loginButton.Click();

            // Проверка успешной авторизации, например, наличие элемента на странице
            var welcomeMessage = _driver.FindElement(By.Id("navbarDropdown")); // Замените на актуальный ID
            Console.WriteLine(welcomeMessage);
            Assert.That(welcomeMessage.Text, Is.EqualTo("Hello, Admin!"), "Пользователь авторизовался");
        }
        [Test]
        public void TestLoginFalse()
        {
            // Открыть страницу логина
            _driver.Navigate().GoToUrl("https://a30860-84e6.x.d-f.pw/Account/Login");

            // Найти элементы для ввода логина и пароля
            var usernameField = _driver.FindElement(By.Name("UserName")); // Замените на актуальный ID
            var passwordField = _driver.FindElement(By.Name("Password")); // Замените на актуальный ID
            var loginButton = _driver.FindElement(By.CssSelector("button[type='submit']"));

            // Ввести данные для авторизации
            usernameField.SendKeys("Admin");
            passwordField.SendKeys("12345678Cc@");

            // Замените на актуальный ID
            loginButton.Click();

            // Проверка успешной авторизации, например, наличие элемента на странице
            var welcomeMessage = _driver.FindElement(By.ClassName("validation-summary-errors")); // Замените на актуальный ID
            Console.WriteLine(welcomeMessage);
            Assert.That(welcomeMessage.Text, Is.EqualTo("Неправильный логин и (или) пароль"),"Пользователь ввел неверные данные");
        }

        [TearDown]
        public void TearDown()
        {
            // Закрытие браузера
            _driver.Quit();
        }
    }
}

