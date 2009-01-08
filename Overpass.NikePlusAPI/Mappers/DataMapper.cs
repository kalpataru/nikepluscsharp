using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using Overpass.NikePlusAPI.Model;

namespace Overpass.NikePlusAPI.Mappers
{
    class DataMapper
    {
        internal static IUserDetails mapUserDetails(XmlDocument xml)
        {
            UserDetails user = new UserDetails();

            user.City = xml.SelectSingleNode("//city").InnerText;
            user.Status = xml.SelectSingleNode("//status").InnerText;
            user.Gender = xml.SelectSingleNode("//gender").InnerText;
            user.Email = xml.SelectSingleNode("//email").InnerText;
            user.Country = xml.SelectSingleNode("//country").InnerText;
            user.TotalRuns = int.Parse(xml.SelectSingleNode("//totalRuns").InnerText);
            
            user.Distance = int.Parse(xml.SelectSingleNode("//totalDistance").InnerText);
            user.Duration = long.Parse(xml.SelectSingleNode("//totalDuration").InnerText);
            user.Calories = long.Parse(xml.SelectSingleNode("//totalCalories").InnerText);
            

            user.ScreenName = xml.SelectSingleNode("//screenName").InnerText;
            user.distanceUnit = xml.SelectSingleNode("//distanceUnit").InnerText;
            user.DateFormat = xml.SelectSingleNode("//dateFormat").InnerText;
            user.StartOfWeek = xml.SelectSingleNode("//startWeek").InnerText;
            user.Avatar = xml.SelectSingleNode("//avatar").InnerText;
            user.UploadedAvatar = xml.SelectSingleNode("//uploadedAvatar").InnerText;
            user.IsPublic = bool.Parse(xml.SelectSingleNode("//isPublic").InnerText);
            //powersong
            user.PowerSong = new PowerSong(xml.SelectSingleNode("//powerSong/artist").InnerText,
                xml.SelectSingleNode("//powerSong/album").InnerText,
                xml.SelectSingleNode("//powerSong/title").InnerText);
            //recentrun

            return user;
        }

        internal static List<IRun> mapRuns(XmlDocument xml)
        {
            List<IRun> runs = new List<IRun>();

            foreach (XmlNode node in xml.SelectNodes("//run") )
            {
                IRun newRun = new Run();
                newRun.ID = node.SelectSingleNode("@id").InnerText;
                newRun.StartTime = DateTime.Parse(node.SelectSingleNode("startTime").InnerText);
                newRun.SyncTime = DateTime.Parse(node.SelectSingleNode("syncTime").InnerText);
                newRun.Name = node.SelectSingleNode("name").InnerText;
                newRun.Description = node.SelectSingleNode("description").InnerText;
<<<<<<< .mine
                newRun.RunSummary.Calories = float.Parse(node.SelectSingleNode("calories").InnerText);
                newRun.RunSummary.Duration = long.Parse(node.SelectSingleNode("duration").InnerText);
                newRun.RunSummary.Distance = float.Parse(node.SelectSingleNode("distance").InnerText);
=======
                newRun.Calories = long.Parse(node.SelectSingleNode("calories").InnerText);
                newRun.Duration = long.Parse(node.SelectSingleNode("duration").InnerText);
                newRun.Distance = float.Parse(node.SelectSingleNode("distance").InnerText);
>>>>>>> .r3
                runs.Add(newRun);
            }

            return runs;
        }

        internal static IRun mapRun(XmlDocument xml)
        {
            IRun run = new Run();
            run.TemplateName = xml.SelectSingleNode("//templateName").InnerText;
            run.Weight = float.Parse(xml.SelectSingleNode("//weight").InnerText);
            run.Device = xml.SelectSingleNode("//device").InnerText;
            run.EmpedID = xml.SelectSingleNode("//empedID").InnerText;
            run.StartTime = DateTime.Parse(xml.SelectSingleNode("//startTime").InnerText);
            run.Description = xml.SelectSingleNode("//description").InnerText;
            run.Calories = long.Parse(xml.SelectSingleNode("//calories").InnerText);
            run.Duration = long.Parse(xml.SelectSingleNode("//duration").InnerText);
            run.Distance = float.Parse(xml.SelectSingleNode("//distance").InnerText);
            run.BestComparableRun = xml.SelectSingleNode("//bestComparableRun").InnerText;

            //powersong
            run.PowerSong.Artist = xml.SelectSingleNode("//powerSong/artist").InnerText;
            run.PowerSong.Title = xml.SelectSingleNode("//powerSong/title").InnerText;
            run.PowerSong.Album = xml.SelectSingleNode("//powerSong/album").InnerText;



            //userClick snapshot
            foreach (XmlNode node in xml.SelectNodes("//snapShotList[@snapShotType='userClick']/snapShot"))
            {
                ISnapShot shot = new Snapshot();
                shot.Distance = float.Parse(node.SelectSingleNode("distance").InnerText);
                shot.Duration = long.Parse(node.SelectSingleNode("duration").InnerText);
                shot.Pace = long.Parse(node.SelectSingleNode("pace").InnerText);
                shot.ID = node.SelectSingleNode("@id").InnerText;
                shot.Event = node.SelectSingleNode("@event").InnerText;
            }

            //kmSplit snapshot
            foreach (XmlNode node in xml.SelectNodes("//snapShotList[@snapShotType='kmSplit']/snapShot"))
            {
                ISnapShot shot = new Snapshot();
                shot.Distance = float.Parse(node.SelectSingleNode("distance").InnerText);
                shot.Duration = long.Parse(node.SelectSingleNode("duration").InnerText);
                shot.Pace = long.Parse(node.SelectSingleNode("pace").InnerText);
                shot.ID = node.SelectSingleNode("@id").InnerText;
                shot.Event = node.SelectSingleNode("@event").InnerText;
            }

            //mileSplit snapshot
            foreach (XmlNode node in xml.SelectNodes("//snapShotList[@snapShotType='mileSplit']/snapShot"))
            {
                ISnapShot shot = new Snapshot();
                shot.Distance = float.Parse(node.SelectSingleNode("distance").InnerText);
                shot.Duration = long.Parse(node.SelectSingleNode("duration").InnerText);
                shot.Pace = long.Parse(node.SelectSingleNode("pace").InnerText);
                shot.ID = node.SelectSingleNode("@id").InnerText;
                shot.Event = node.SelectSingleNode("@event").InnerText;
            }


            return run;
        }
    }
}
