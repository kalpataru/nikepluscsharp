using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Overpass.NikePlusAPI;
using Overpass.NikePlusAPI.Model;

namespace Overpass.NikePlusAPI.Tests
{
    [TestFixture]    
    public class NikePlusTests
    {
        INikePlusData _api;

        [SetUp]
        public void TestLogin()
        {
            NikePlus nikePlus = new NikePlus(NikePlus.NikeDataType.Web);
            
            _api = nikePlus.GetAPI("", "");
            _api.Login();

                       
        }

        [Test]
        public void TestGetUserInfo()
        {
            IUserDetails user = _api.getUserDetails();
            Assert.AreEqual(user.Email, "eric.wroolie@overpass.co.uk");
            Assert.AreEqual(user.City, "Wantage");
            Assert.AreEqual(user.Country, "GB");
            Assert.AreEqual(user.Gender, "male");
            Assert.AreEqual(user.TotalRuns,95);

        }

        [Test]
        public void TestGetRuns()
        {
            List<IRun> runs = _api.getRuns();
            Assert.AreEqual(runs.Count, 95);
            

        }

        [Test]
        public void TestGetRunDetails()
        {
            IRun run = _api.getRunDetail("2");
            Assert.AreEqual(run.PowerSong.Title,"07. Survivor - Eye Of The Tiger (1982)");

           
            Assert.AreEqual(5.17,run.Kilometers);
            Assert.AreEqual(3.21, run.Miles);
            
        }

        [TearDown]
        public void TearDown()
        {
            _api = null; 
        }


        [Test]
        public void TestJoin()
        {
            List<IRun> runs = _api.getRuns();
           
        }

    }
}
