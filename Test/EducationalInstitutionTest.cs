using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace Test
{
    public class EducationalInstitutionTest
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
        public void TestEducationalInstitution()
        {
            // Открыть страницу логина
            _driver.Navigate().GoToUrl("https://a30860-84e6.x.d-f.pw");

            // Найти элементы для ввода логина и пароля
            var linkEducationalInstitution = _driver.FindElement(By.XPath("//a[text()='Учебные заведения']"));// Ссылка

            // Нажать на ссылку
            linkEducationalInstitution.Click();

            // Проверка начичия карточек
            var cards = _driver.FindElements(By.ClassName("card")); // Используйте FindElements, чтобы получить список

            // Проверяем, есть ли карточки на странице
            Assert.That(cards.Count, Is.GreaterThanOrEqualTo(0), "Элемент 'card' не найден.");

        }
        //[Test]
        //public void TestEducationalInstitutionNotNull()
        //{
        //    // Открыть страницу логина
        //    _driver.Navigate().GoToUrl("https://a30860-84e6.x.d-f.pw");

        //    // Найти элементы для ввода логина и пароля
        //    var linkEducationalInstitution = _driver.FindElement(By.XPath("//a[text()='Учебные заведения']"));// Ссылка

        //    // Нажать на ссылку
        //    linkEducationalInstitution.Click();

        //    // Проверка начичия карточек
        //    var cards = _driver.FindElements(By.ClassName("card")); // Используйте FindElements, чтобы получить список

        //    // Проверяем, есть ли карточки на странице
        //    Assert.That(cards.Count, Is.GreaterThanOrEqualTo(0), "Элемент 'card' не найден.");
        //    Assert.That(cards.Count, Is.EqualTo(0), "Элемент 'card' найден.");

        //}


        [TearDown]
        public void TearDown()
        {
            // Закрытие браузера
            _driver.Quit();
        }
    }
}

