using Mission.Entities.ViewModels.MissionSkill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MissionSkillResponseModel : UpsertMissionSkillRequestModel
{
    public MissionSkillResponseModel() { }

    public MissionSkillResponseModel(Mission.Entities.Models.MissionSkill missionSkill)
    {
        Id = missionSkill.Id;
        SkillName = missionSkill.SkillName;
        Status = missionSkill.Status;
    }
}
