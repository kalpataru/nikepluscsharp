using System;
using System.Collections.Generic;
using System.Text;

namespace Overpass.NikePlusAPI.Model
{
    public interface ISnapShot
    {
        string ID { get; set; }
        float Distance { get; set; }
        long Duration { get; set; }
        long Pace { get; set; }
        string Event { get; set; }
    }
}
