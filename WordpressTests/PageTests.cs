﻿
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordPressAutomation;

namespace WordpressTests
{
    [TestClass]
    public class PageTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }


        [TestMethod]
        public void CanEditAPage()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs("LOGIN").WithPassword("PASSWORD").Login();

            ListPostsPage.GoTo(PostType.Page);
            ListPostsPage.SelectPost("Sample Page");

            Assert.IsTrue(NewPostPage.IsInEditMode(), "Wasn't in edit mode");
            Assert.AreEqual("Sample Page", NewPostPage.Title, "Title did not match");
        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}
