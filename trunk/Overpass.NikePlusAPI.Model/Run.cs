using System;
using System.Collections.Generic;
using System.Text;

namespace Overpass.NikePlusAPI.Model
{
    public class Run : IRun
    {
        #region Internals
        private string _id;
        private string _name;
        private string _description;
        private string _templateName;
        private float _weight;
        private string _device;
        private string _empedID;
        private DateTime _startTime;
        private DateTime _syncTime;
        private IRunSummary _runSummary = new RunSummary();
        private string _bestComparableRun;
        List<ISnapShot> _userClickSnapshot = new List<ISnapShot>();
        List<ISnapShot> _stopSnapshot = new List<ISnapShot>();
        List<ISnapShot> _pauseSnapshot = new List<ISnapShot>();
        IPowerSong _powerSong = new PowerSong();
        #endregion

        public Run()
        {
        }



        #region IRun Members

        public string ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id =value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name =value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }

        public string TemplateName
        {
            get
            {
                return _templateName;
            }
            set
            {
                _templateName =value;
            }
        }

        public float Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                _weight =value;
            }
        }

        public string Device
        {
            get
            {
                return _device;
            }
            set
            {
                _device = value;
            }
        }

        public string EmpedID
        {
            get
            {
                return _empedID;
            }
            set
            {
                _empedID = value;
            }
        }

        public DateTime StartTime
        {
            get
            {
                return _startTime;
            }
            set
            {
                _startTime =value;
            }
        }

        public DateTime SyncTime
        {
            get
            {
                return _syncTime;
            }
            set
            {
                _syncTime = value;
            }
        }

        public IRunSummary RunSummary
        {
            get
            {
                return _runSummary;
            }
            set
            {
                _runSummary = value;
            }
        }

        public string BestComparableRun
        {
            get
            {
                return _bestComparableRun;
            }
            set
            {
                _bestComparableRun = value;
            }
        }

        public List<ISnapShot> UserClickSnapshot
        {
            get
            {
                return _userClickSnapshot ;
            }
            set
            {
                _userClickSnapshot = value;
            }
        }

        public List<ISnapShot> StopSnapShot
        {
            get
            {
                return _stopSnapshot;
            }
            set
            {
                _stopSnapshot = value;
            }
        }

        public List<ISnapShot> PauseSnapShot
        {
            get
            {
                return _pauseSnapshot;
            }
            set
            {
                _pauseSnapshot = value;
            }
        }

        public IPowerSong PowerSong
        {
            get { return _powerSong; }
            set { _powerSong = value; }
        }

        #endregion
    }
}
