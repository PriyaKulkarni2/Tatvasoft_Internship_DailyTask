using Mission.Entities.ViewModels.MissionSkill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MissionThemeResponseModel : UpsertMissionSkillRequestModel
{


    public MissionThemeResponseModel(Mission.Entities.Models.MissionTheme missionTheme)
    {
        Id = missionTheme.Id;
        SkillName = missionTheme.ThemeName;
        Status = missionTheme.Status;
    }
}
