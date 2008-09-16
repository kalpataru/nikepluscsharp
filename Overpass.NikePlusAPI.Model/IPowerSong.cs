using System;
using System.Collections.Generic;
using System.Text;

namespace Overpass.NikePlusAPI.Model
{
    public interface IPowerSong
    {
        string Artist { get; set; }
        string Album { get; set; }
        string Title { get; set; }
    }
}
