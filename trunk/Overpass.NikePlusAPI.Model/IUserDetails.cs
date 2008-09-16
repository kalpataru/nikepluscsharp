using System;
using System.Collections.Generic;
using System.Text;

namespace Overpass.NikePlusAPI.Model
{
    public interface IUserDetails: IRunSummary
    {
        string UserID { get; set; }
        string Status { get; set; }
        string Gender { get; set; }
        string Email { get; set; }
        string City { get; set; }
        string Country { get; set; }

        int TotalRuns { get; set; }
        

        string ScreenName { get; set; }
        string distanceUnit { get; set; }
        string DateFormat { get; set; }
        string StartOfWeek { get; set; }
        string Avatar { get; set; }
        string UploadedAvatar { get; set; }
        bool IsPublic { get; set; }

        IPowerSong PowerSong { get; set; }

        IRun MostRecentRun { get; set; }
        
    }
}
