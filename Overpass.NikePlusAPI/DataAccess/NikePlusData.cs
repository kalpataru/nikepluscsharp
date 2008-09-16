using System;
using System.Collections.Generic;
using System.Text;
using Overpass.NikePlusAPI.Model;
using Overpass.NikePlusAPI.Mappers;
using System.Net;
using System.IO;
using System.Xml;


///Client test applicaton
///In addition to the unit tests, this app will check for 
///basic functionality of the application
///
namespace Overpass.NikePlusAPI.DataAccess
{



    public class NikePlusData : Overpass.NikePlusAPI.INikePlusData
    {

        INikePlusDataXML _dataSource;

        public NikePlusData(INikePlusDataXML DataSource)
        {
            _dataSource = DataSource;
        }

        public void Login()
        {
            _dataSource.Authenticate();
        }


 

       public IUserDetails getUserDetails()
        {

            return DataMapper.mapUserDetails(_dataSource.getUserDetailsXML());
        }

        public List<IRun> getRuns()
        {
            
            return DataMapper.mapRuns(_dataSource.getRunsXML());
        }

        public IRun getRunDetail(string RunID)
        {
            return DataMapper.mapRun(_dataSource.getRunDetailXML(RunID));
        }
    }
}
