using System;
using System.Collections.Generic;
using System.Text;

namespace Overpass.NikePlusAPI.Model
{
    public interface IRunSummary
    {
        float Distance { get; set; }
        long Duration { get; set; }

        long Calories { get; set; }

        decimal Miles { get;}
        decimal Kilometers { get; }
    }
}
