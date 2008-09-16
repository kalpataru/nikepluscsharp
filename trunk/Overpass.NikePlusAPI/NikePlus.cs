using System;
using System.Collections.Generic;
using System.Text;

namespace Overpass.NikePlusAPI
{
    public class NikePlus
    {
        NikeDataType _apiType = NikeDataType.Web;

        public NikePlus()
        {
        }

        public NikePlus(NikeDataType NikeType)
        {
            _apiType = NikeType;
        }

        public INikePlusData GetAPI(string UserName, string Password)
        {
            if (_apiType == NikeDataType.Web)
            {

                return new DataAccess.NikePlusData(new DataAccess.NikePlusDataWeb(UserName,Password));
            }
            else
            {
                return new DataAccess.NikePlusData(new DataAccess.NikePlusDataMock());
            }
        }

        public enum NikeDataType
        {
            Web,Mock
        }

    }
}
