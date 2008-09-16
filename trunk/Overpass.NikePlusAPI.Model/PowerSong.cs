using System;
using System.Collections.Generic;
using System.Text;

namespace Overpass.NikePlusAPI.Model
{
    public class PowerSong : IPowerSong
    {
        private string _artist;
        private string _album;
        private string _title;

        public PowerSong() { }

        public PowerSong(string Artist, string Album, string Title)
        {
            _artist = Artist;
            _album = Album;
            _title = Title;
        }

        #region IPowerSong Members

        public string Artist
        {
            get
            {
                return _artist;
            }
            set
            {
                _artist = value;
            }
        }

        public string Album
        {
            get
            {
                return _album;
            }
            set
            {
                _album = value;
            }
        }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }

        #endregion
    }
}
