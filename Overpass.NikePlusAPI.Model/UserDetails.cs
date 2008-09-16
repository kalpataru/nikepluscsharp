using System;
using System.Collections.Generic;
using System.Text;

namespace Overpass.NikePlusAPI.Model
{
    public class UserDetails : IUserDetails
    {
        #region Internals
        private string _userID;
        private string _status;
        private string _gender;
        private string _email;
        private string _city;
        private string _country;
        private int _totalRuns;
        private string _screenName;
        private string _distanceUnit;
        private string _dateFormat;
        private string _startOfWeek;
        private string _avatar;
        private string _uploadedAvatar;
        private bool _isPublic;
        private IPowerSong _powerSong;
        private IRun _mostRecentRun;
        private float _distance;
        private long _duration;
        private long _calories;
        #endregion

        #region IUserDetails Members

        public string UserID
        {
            get
            {
                return _userID;
            }
            set
            {
                _userID = value;
            }
        }

        public string Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }

        public string Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                _gender = value;
            }
        }

        public string Email
        {
            get
            {
                return  _email;
            }
            set
            {
                _email = value ;
            }
        }

        public string City
        {
            get
            {
               return _city;
            }
            set
            {
               _city = value;
            }
        }

        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                _country =value;
            }
        }



        public int TotalRuns
        {
            get
            {
                return _totalRuns;
            }
            set
            {
                _totalRuns =value;
            }
        }

        public string ScreenName
        {
            get
            {
                return _screenName;
            }
            set
            {
                _screenName =value;
            }
        }

        public string distanceUnit
        {
            get
            {
                return _distanceUnit;
            }
            set
            {
                _distanceUnit =value;
            }
        }

        public string DateFormat
        {
            get
            {
                return _dateFormat;
            }
            set
            {
                _dateFormat = value;
            }
        }

        public string StartOfWeek
        {
            get
            {
                return _startOfWeek;
            }
            set
            {
                _startOfWeek = value;
            }
        }

        public string Avatar
        {
            get
            {
                return _avatar;
            }
            set
            {
                _avatar = value;
            }
        }

        public string UploadedAvatar
        {
            get
            {
                return _uploadedAvatar;
            }
            set
            {
                _uploadedAvatar = value;
            }
        }

        public bool IsPublic
        {
            get
            {
                return _isPublic;
            }
            set
            {
                _isPublic = value;
            }
        }

        public IPowerSong PowerSong
        {
            get
            {
                return _powerSong;
            }
            set
            {
                _powerSong = value;
            }
        }

        public IRun MostRecentRun
        {
            get
            {
                return _mostRecentRun;
            }
            set
            {
                _mostRecentRun = value;
            }
        }

        #endregion

        public float Distance
        {
            get
            {
                return _distance;
            }
            set
            {
                _distance = value;
            }
        }

        public long Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                _duration = value;
            }
        }

        public long Calories
        {
            get
            {
                return _calories;
            }
            set
            {
                _calories = value;
            }
        }

        public decimal Miles
        {
            get
            {
                if (_distance > 0)
                {
                    decimal milesConversion = 1.609344M;
                    decimal miles = (decimal.Parse(_distance.ToString()) / milesConversion);
                    return (System.Math.Round(miles, 2));
                }
                else
                {
                    return 0;
                }
            }
        }

        public decimal Kilometers
        {
            get
            {
                if (_distance > 0)
                {
                    return (System.Math.Round(decimal.Parse(_distance.ToString()), 2));
                }
                else
                {
                    return 0;
                }
            }
        }

    }
}
