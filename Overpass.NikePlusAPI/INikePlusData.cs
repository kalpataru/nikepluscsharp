using System;
namespace Overpass.NikePlusAPI
{
    public interface INikePlusData
    {
        Overpass.NikePlusAPI.Model.IRun getRunDetail(string RunID);
        System.Collections.Generic.List<Overpass.NikePlusAPI.Model.IRun> getRuns();
        Overpass.NikePlusAPI.Model.IUserDetails getUserDetails();
        void Login();
    }
}
