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
    public class CreatePostTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }


        [TestMethod]
        public void CanCreateABasicPost()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs("LOGIN").WithPassword("PASSWORD").Login();

            NewPostPage.GoTo();
            NewPostPage.CreatePost("This is the test post title").
                WithBody("Hi, this is the body").
                Publish();
        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }

    }
}
