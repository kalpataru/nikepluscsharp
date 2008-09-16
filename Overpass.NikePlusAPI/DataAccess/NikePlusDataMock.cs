using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System.Configuration;

namespace Overpass.NikePlusAPI.DataAccess
{
    public class NikePlusDataMock : Overpass.NikePlusAPI.INikePlusDataXML
    {

        public NikePlusDataMock()
        { }

        public NikePlusDataMock(string Username, string Password)
        {
            
        }

     

        public bool Authenticate() {
            return true;
        }

        #region INikePlusData Members

        public System.Xml.XmlDocument getChallengesXML()
        {
            throw new NotImplementedException();
        }

        public System.Xml.XmlDocument getGoalsXML()
        {
            XmlDocument doc = new XmlDocument();

            doc.Load(ConfigurationSettings.AppSettings["MockDataDir"].ToString() + "goals.xml");

            return doc;
        }

       
        public System.Xml.XmlDocument getRunDetailXML(string RunID)
        {
            XmlDocument doc = new XmlDocument();

            doc.Load(ConfigurationSettings.AppSettings["MockDataDir"].ToString() + "runDetails.xml");

            return doc;
        }

      
        public System.Xml.XmlDocument getRunsXML()
        {
            XmlDocument doc = new XmlDocument();

            doc.Load(ConfigurationSettings.AppSettings["MockDataDir"].ToString() + "runs.xml");
            
            return doc;
        }

       

        public System.Xml.XmlDocument getUserDetailsXML()
        {
            XmlDocument doc = new XmlDocument();
            


            doc.Load(ConfigurationSettings.AppSettings["MockDataDir"].ToString() + "userDetails.xml");
            return doc;
            
        }

      

        #endregion
    }
}
