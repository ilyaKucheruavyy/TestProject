﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;
using System.Linq;

namespace TestProjectEtsy.Pages
{
    public  class SearchResultPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class = 'search__title']")]
        public IWebElement SearchResultTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'catalog-title']//h1")]
        public IWebElement CategoryTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'search-sidebar-checklist__collapse link']")]
        public IWebElement ShowAllManufacturer { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'tabs-item flex center-xs middle-xs active']")]
        public IWebElement AllFilters { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'tabs-item flex center-xs middle-xs']")]
        public IWebElement SelectedFilters { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[@class = 'page page--next']")]
        public IWebElement NextPage { get; set; }

        public List<IWebElement> GetListFoundProduct()
        {
            return Driver.FindElements(By.XPath(".//a[contains(@class,'list-item__title')]")).ToList();
        }
    }
}
