﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Overpass.NikePlusAPI.Model
{
    public interface IRun
    {
        string ID { get; set; }
        string Name { get; set; }
        string Description { get; set; }

        string TemplateName  { get; set; }
        float Weight { get; set; }
        string Device { get; set; }
        string EmpedID { get; set; }

        DateTime StartTime { get; set; }
        DateTime SyncTime { get; set; }
        
        IRunSummary RunSummary { get; set; }

        string BestComparableRun { get; set; }

        List<ISnapShot> UserClickSnapshot { get; set; }
        List<ISnapShot> StopSnapShot { get; set; }
        List<ISnapShot> PauseSnapShot { get; set; }

        IPowerSong PowerSong { get; set; }

    }
}
