using System;
using System.Collections.Generic;
using System.Text;

namespace Overpass.NikePlusAPI.Model
{
    public class Snapshot : ISnapShot
    {

        #region Internals
        private string _id;
        private float _distance;
        private long _duration;
        private long _pace;
        private string _event; 
        #endregion

        #region ISnapShot Members

        public string ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public float Distance
        {
            get
            {
                return _distance;
            }
            set
            {
                _distance  = value;
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

        public long Pace
        {
            get
            {
                return _pace;
            }
            set
            {
                _pace =value;
            }
        }

        public string Event
        {
            get { return _event; }
            set { _event = value; }
        }

        #endregion
    }
}
