using Npgsql;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBot
{
    public class AutomationWeb
    {
        public IWebDriver driver;
        private NpgsqlConnection Connection;
        private string? connectionString;

        public AutomationWeb()
        {
            driver = new ChromeDriver();
        }

        public void TestWeb()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless");

            driver.Navigate().GoToUrl("https://10fastfingers.com/typing-test/portuguese");

            IWebElement element1 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[1]"));

            string textodoElemento1 = element1.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento1);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element2 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[2]"));

            string textodoElemento2 = element2.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento2);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element3 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[3]"));

            string textodoElemento3 = element3.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento3);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element4 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[4]"));

            string textodoElemento4 = element4.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento4);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element5 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[5]"));

            string textodoElemento5 = element5.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento5);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element6 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[6]"));

            string textodoElemento6 = element6.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento6);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element7 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[7]"));

            string textodoElemento7 = element7.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento7);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element8 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[8]"));

            string textodoElemento8 = element8.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento8);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element9 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[9]"));

            string textodoElemento9 = element9.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento9);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element10 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[10]"));

            string textodoElemento10 = element10.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento10);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element11 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[11]"));

            string textodoElemento11 = element11.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento11);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element12 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[12]"));

            string textodoElemento12 = element12.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento12);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element13 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[13]"));

            string textodoElemento13 = element13.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento13);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element14 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[14]"));

            string textodoElemento14 = element14.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento14);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element15 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[15]"));

            string textodoElemento15 = element15.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento15);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element16 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[16]"));

            string textodoElemento16 = element16.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento16);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element17 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[17]"));

            string textodoElemento17 = element17.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento17);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element18 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[18]"));

            string textodoElemento18 = element18.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento18);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element19 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[19]"));

            string textodoElemento19 = element19.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento19);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element20 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[20]"));

            string textodoElemento20 = element20.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento20);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element21 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[21]"));

            string textodoElemento21 = element21.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento21);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element22 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[22]"));

            string textodoElemento22 = element22.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento22);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element23 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[23]"));

            string textodoElemento23 = element23.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento23);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element24 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[24]"));

            string textodoElemento24 = element24.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento24);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element25 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[25]"));

            string textodoElemento25 = element25.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento25);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element26 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[26]"));

            string textodoElemento26 = element26.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento26);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element27 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[27]"));

            string textodoElemento27 = element27.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento27);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element28 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[28]"));

            string textodoElemento28 = element28.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento28);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element29 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[29]"));

            string textodoElemento29 = element29.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento29);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element30 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[30]"));

            string textodoElemento30 = element30.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento30);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element31 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[31]"));

            string textodoElemento31 = element31.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento31);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element32 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[32]"));

            string textodoElemento32 = element32.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento32);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element33 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[33]"));

            string textodoElemento33 = element33.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento33);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element34 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[34]"));

            string textodoElemento34 = element34.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento34);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element35 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[35]"));

            string textodoElemento35 = element35.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento35);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element36 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[36]"));

            string textodoElemento36 = element36.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento36);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element37 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[37]"));

            string textodoElemento37 = element37.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento37);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element38 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[38]"));

            string textodoElemento38 = element38.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento38);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element39 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[39]"));

            string textodoElemento39 = element39.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento39);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element40 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[40]"));

            string textodoElemento40 = element40.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento40);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element41 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[41]"));

            string textodoElemento41 = element41.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento41);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element42 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[42]"));

            string textodoElemento42 = element42.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento42);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element43 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[43]"));

            string textodoElemento43 = element43.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento43);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element44 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[44]"));

            string textodoElemento44 = element44.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento44);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element45 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[45]"));

            string textodoElemento45 = element45.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento45);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element46 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[46]"));

            string textodoElemento46 = element46.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento46);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element47 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[47]"));

            string textodoElemento47 = element47.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento47);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element48 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[48]"));

            string textodoElemento48 = element48.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento48);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element49 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[49]"));

            string textodoElemento49 = element49.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento49);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element50 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[50]"));

            string textodoElemento50 = element50.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento50);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element51 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[51]"));

            string textodoElemento51 = element51.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento51);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element52 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[52]"));

            string textodoElemento52 = element52.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento52);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element53 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[53]"));

            string textodoElemento53 = element53.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento53);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element54 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[54]"));

            string textodoElemento54 = element54.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento54);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element55 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[55]"));

            string textodoElemento55 = element55.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento55);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element56 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[56]"));

            string textodoElemento56 = element56.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento56);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element57 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[57]"));

            string textodoElemento57 = element57.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento57);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element58 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[58]"));

            string textodoElemento58 = element58.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento58);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element59 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[59]"));

            string textodoElemento59 = element59.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento59);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element60 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[60]"));

            string textodoElemento60 = element60.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento60);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element61 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[61]"));

            string textodoElemento61 = element61.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento61);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element62 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[62]"));

            string textodoElemento62 = element62.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento62);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element63 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[63]"));

            string textodoElemento63 = element63.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento63);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element64 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[64]"));

            string textodoElemento64 = element64.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento64);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element65 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[65]"));

            string textodoElemento65 = element65.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento65);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element66 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[66]"));

            string textodoElemento66 = element66.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento66);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element67 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[67]"));

            string textodoElemento67 = element67.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento67);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element68 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[68]"));

            string textodoElemento68 = element68.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento68);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element69 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[69]"));

            string textodoElemento69 = element69.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento69);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element70 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[70]"));

            string textodoElemento70 = element70.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento70);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element71 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[71]"));

            string textodoElemento71 = element71.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento71);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element72 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[72]"));

            string textodoElemento72 = element72.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento72);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element73 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[73]"));

            string textodoElemento73 = element73.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento73);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element74 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[74]"));

            string textodoElemento74 = element74.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento74);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element75 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[75]"));

            string textodoElemento75 = element75.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento75);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element76 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[76]"));

            string textodoElemento76 = element76.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento76);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element77 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[77]"));

            string textodoElemento77 = element77.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento77);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element78 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[78]"));

            string textodoElemento78 = element78.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento78);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element79 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[79]"));

            string textodoElemento79 = element79.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento79);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element80 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[80]"));

            string textodoElemento80 = element80.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento80);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element81 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[81]"));

            string textodoElemento81 = element81.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento81);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element82 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[82]"));

            string textodoElemento82 = element82.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento82);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element83 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[83]"));

            string textodoElemento83 = element83.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento83);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element84 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[84]"));

            string textodoElemento84 = element84.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento84);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element85 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[85]"));

            string textodoElemento85 = element85.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento85);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element86 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[86]"));

            string textodoElemento86 = element86.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento86);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element87 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[87]"));

            string textodoElemento87 = element87.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento87);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element88 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[88]"));

            string textodoElemento88 = element88.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento88);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element89 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[89]"));

            string textodoElemento89 = element89.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento89);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element90 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[90]"));

            string textodoElemento90 = element90.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento90);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element91 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[91]"));

            string textodoElemento91 = element91.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento91);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element92 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[92]"));

            string textodoElemento92 = element92.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento92);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element93 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[93]"));

            string textodoElemento93 = element93.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento93);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element94 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[94]"));

            string textodoElemento94 = element94.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento94);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element95 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[95]"));

            string textodoElemento95 = element95.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento95);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element96 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[96]"));

            string textodoElemento96 = element96.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento96);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element97 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[97]"));

            string textodoElemento97 = element97.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento97);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element98 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[98]"));

            string textodoElemento98 = element98.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento98);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element99 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[99]"));

            string textodoElemento99 = element99.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento99);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element100 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[100]"));

            string textodoElemento100 = element100.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento100);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element101 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[101]"));

            string textodoElemento101 = element101.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento101);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element102 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[102]"));

            string textodoElemento102 = element102.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento102);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element103 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[103]"));

            string textodoElemento103 = element103.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento103);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element104 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[104]"));

            string textodoElemento104 = element104.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento104);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element105 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[105]"));

            string textodoElemento105 = element105.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento105);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element106 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[106]"));

            string textodoElemento106 = element106.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento106);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element107 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[107]"));

            string textodoElemento107 = element107.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento107);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element108 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[108]"));

            string textodoElemento108 = element108.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento108);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element109 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[109]"));

            string textodoElemento109 = element109.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento109);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element110 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[110]"));

            string textodoElemento110 = element110.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento110);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element111 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[111]"));

            string textodoElemento111 = element111.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento111);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element112 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[112]"));

            string textodoElemento112 = element112.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento112);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element113 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[113]"));

            string textodoElemento113 = element113.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento113);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element114 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[114]"));

            string textodoElemento114 = element114.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento114);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element115 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[115]"));

            string textodoElemento115 = element115.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento115);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element116 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[116]"));

            string textodoElemento116 = element116.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento116);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element117 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[117]"));

            string textodoElemento117 = element117.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento117);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element118 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[118]"));

            string textodoElemento118 = element118.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento118);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element119 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[119]"));

            string textodoElemento119 = element119.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento119);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element120 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[120]"));

            string textodoElemento120 = element120.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento120);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element121 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[121]"));

            string textodoElemento121 = element121.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento121);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element122 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[122]"));

            string textodoElemento122 = element122.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento122);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element123 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[123]"));

            string textodoElemento123 = element123.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento123);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element124 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[124]"));

            string textodoElemento124 = element124.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento124);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element125 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[125]"));

            string textodoElemento125 = element125.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento125);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element126 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[126]"));

            string textodoElemento126 = element126.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento126);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element127 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[127]"));

            string textodoElemento127 = element127.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento127);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element128 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[128]"));

            string textodoElemento128 = element128.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento128);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element129 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[129]"));

            string textodoElemento129 = element129.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento129);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element130 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[130]"));

            string textodoElemento130 = element130.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento130);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element131 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[131]"));

            string textodoElemento131 = element131.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento131);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element132 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[132]"));

            string textodoElemento132 = element132.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento132);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element133 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[133]"));

            string textodoElemento133 = element133.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento133);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element134 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[134]"));

            string textodoElemento134 = element134.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento134);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element135 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[135]"));

            string textodoElemento135 = element135.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento135);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element136 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[136]"));

            string textodoElemento136 = element136.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento136);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element137 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[137]"));

            string textodoElemento137 = element137.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento137);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element138 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[138]"));

            string textodoElemento138 = element138.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento138);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element139 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[139]"));

            string textodoElemento139 = element139.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento139);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            IWebElement element140 = driver.FindElement(By.XPath("//*[@id=\"row1\"]/span[140]"));

            string textodoElemento140 = element140.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento140);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            //Teste proposital de erro na escrita, para confirmação de insert na tabela. O motivo era ver os erros de escrita mostrando no contador do campo WrongWords
            string infErr1 = element140.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento140);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            string infErr2 = element140.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento140);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            string infErr3 = element140.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento140);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            string infErr4 = element140.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento140);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            string infErr5 = element140.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento140);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            string infErr6 = element140.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento140);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            string infErr7 = element140.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento140);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            string infErr8 = element140.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento140);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            string infErr9 = element140.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento140);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            string infErr10 = element140.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento140);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            string infErr11 = element140.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento140);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            string infErr12 = element140.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento140);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            string infErr13 = element140.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento140);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            string infErr14 = element140.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento140);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            string infErr15 = element140.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento140);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            string infErr16 = element140.Text;

            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(textodoElemento140);
            driver.FindElement(By.XPath("//*[@id=\"inputfield\"]")).SendKeys(" ");

            using (var connection = new NpgsqlConnection(connectionString))
            {
                //String de conexão com o PostgreSQL
                Connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=selenium;User Id=postgres;Password=p@ssw0rdss");

                //Pegando as informações do resultado final para inserir no banco de dados
                //WPM
                IWebElement resultWpm = driver.FindElement(By.XPath("//*[@id=\"wpm\"]/strong"));

                string textResultWPM = resultWpm.Text;

                //KEYSTROKES
                IWebElement resultKeystrokes = driver.FindElement(By.XPath("//*[@id=\"keystrokes\"]/td[2]"));

                string textResultKeystrokes = resultKeystrokes.Text;

                //ACCURACY
                IWebElement resultAccuracy = driver.FindElement(By.XPath("//*[@id=\"accuracy\"]/td[2]"));

                string textResultAccuracy = resultAccuracy.Text;

                //CorrectWords
                IWebElement resultCorrectWords = driver.FindElement(By.XPath("//*[@id=\"correct\"]/td[2]"));

                string textResultCorrectWords = resultCorrectWords.Text;

                //WrongWords
                IWebElement resultWrongWords = driver.FindElement(By.XPath("//*[@id=\"wrong\"]/td[2]/strong"));

                string textResultWrongWords = resultWrongWords.Text;

                //Query para insert na tabela
                string query = "INSERT INTO public.result(wpm, keystrokes, accuracy, correct_words, wrong_words) " +
                                      "VALUES (@textResultWPM, @textResultKeystrokes, @textResultAccuracy, @textResultCorrectWords, @textResultWrongWords);";

                try
                {
                    using (NpgsqlConnection connection1 = new NpgsqlConnection(connectionString))
                    {

                        //Abrindo a conexão
                        connection.Open();

                        //Criando o comando para insert
                        using (NpgsqlCommand command = new NpgsqlCommand(query, Connection))
                        {
                            //Adicionando os parâmetros
                            command.Parameters.AddWithValue("@textResultWPM", resultWpm);
                            command.Parameters.AddWithValue("@textResultKeystrokes", resultKeystrokes);
                            command.Parameters.AddWithValue("@textResultAccuracy", resultAccuracy);
                            command.Parameters.AddWithValue("@textResultCorrectWords", resultCorrectWords);
                            command.Parameters.AddWithValue("@textResultWrongWords", resultWrongWords);

                            //Executar o comando
                            command.ExecuteNonQuery();
                            Console.WriteLine("Dados inseridos com sucesso!");
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocorreu um erro: " + ex.Message);
                }

                Console.ReadLine();

                Connection.Close();
            }
        }

    }
}
