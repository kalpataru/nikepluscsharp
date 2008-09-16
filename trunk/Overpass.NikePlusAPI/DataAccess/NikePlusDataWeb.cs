using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Net;
using System.IO;
using System.Configuration;


namespace Overpass.NikePlusAPI.DataAccess
{
    public class NikePlusDataWeb : Overpass.NikePlusAPI.INikePlusDataXML
    {
        private string _userName;
        private string _passWord;
        private string _authenticationCookie;

        public NikePlusDataWeb(string Username, string Password)
        {
            _userName = Username;
            _passWord = Password;
        }



        public  bool Authenticate()
        {

            string authURI = String.Format(ConfigurationSettings.AppSettings["CreateSession"].ToString()+"?login={0}&password={1}",
                    _userName, _passWord);

            WebRequest objRequest = System.Net.HttpWebRequest.Create(authURI);

            WebResponse objResponse = objRequest.GetResponse();

            //a cookie will be returned for authentication-- catch it here
            _authenticationCookie = objResponse.Headers["SET-COOKIE"].ToString();

            StreamReader webResponse = new StreamReader(objResponse.GetResponseStream());

            XmlDocument dataDoc = new XmlDocument();
            dataDoc.LoadXml(webResponse.ReadToEnd());

            if (dataDoc.SelectSingleNode("//status").InnerText == "success")
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        private XmlDocument getAdditionalDetails(string uri)
        {
            WebRequest objRequest = System.Net.HttpWebRequest.Create(uri);

            //return the authorization cookie
            objRequest.Headers.Add("Cookie", _authenticationCookie);

            WebResponse objResponse = objRequest.GetResponse();

            StreamReader webResponse = new StreamReader(objResponse.GetResponseStream());

            XmlDocument dataDoc = new XmlDocument();
            dataDoc.LoadXml(webResponse.ReadToEnd());

            return dataDoc;
        }


        public XmlDocument getRunsXML() {
            string runsUri = ConfigurationSettings.AppSettings["Runs"].ToString();
            return getAdditionalDetails(runsUri);
        }


        public XmlDocument getRunDetailXML(string RunID)
        {
            string runsUri = ConfigurationSettings.AppSettings["RunDetails"].ToString() + RunID;
            return getAdditionalDetails(runsUri);
        }

        public XmlDocument getUserDetailsXML()
        {
            string dataUri = ConfigurationSettings.AppSettings["UserDetails"].ToString();
            return getAdditionalDetails(dataUri);
        }

        
        public XmlDocument getGoalsXML()
        {
            string uri = ConfigurationSettings.AppSettings["Goals"].ToString();
            return getAdditionalDetails(uri);
        }

        public XmlDocument getChallengesXML()
        {
            string uri = ConfigurationSettings.AppSettings["Challenges"].ToString();
            return getAdditionalDetails(uri);
        }


        
     
    }
}
