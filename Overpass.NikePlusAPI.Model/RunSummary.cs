using System;
using System.Collections.Generic;
using System.Text;

namespace Overpass.NikePlusAPI.Model
{
    public  class RunSummary : IRunSummary
    {
        #region Internals
        private float _distance;
        private long _duration;
        private float _calories; 
        #endregion


        #region Constructors
        public RunSummary() { }

        public RunSummary(float Distance, long Duration, long Calories)
        {
            _distance = Distance;
            _duration = Duration;
            _calories = Calories;
        } 
        #endregion

        #region IRunSummary Members

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
                _duration =value;
            }
        }

        public float Calories
        {
            get
            {
                return _calories;
            }
            set
            {
                _calories =value;
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
                    return (System.Math.Round(miles,2));
                }
                else {
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
                    return (System.Math.Round(decimal.Parse(_distance.ToString()),2));
                }
                else
                {
                    return 0;
                }
            }
        }

        #endregion
    }
}
