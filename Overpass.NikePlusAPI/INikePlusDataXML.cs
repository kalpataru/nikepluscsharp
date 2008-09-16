using System;
namespace Overpass.NikePlusAPI
{
    public interface INikePlusDataXML
    {
        System.Xml.XmlDocument getChallengesXML();
        System.Xml.XmlDocument getGoalsXML();
        System.Xml.XmlDocument getRunDetailXML(string RunID);
        System.Xml.XmlDocument getRunsXML();
        System.Xml.XmlDocument getUserDetailsXML();
        bool Authenticate();
    }
}
