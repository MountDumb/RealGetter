using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealGetter.Lib
{
    public enum TypeOfAbsence
    {
        Illness,
        LeaveExtraordinary,
        AbsenceIllegal,
        IllnessCaution,
        Late,
        LeftEarly,
        LateAndLeftEarly,
        ChristmasSealHome,
        Internship,
        None
    }

    public enum LevelOfActivity
    {
        NotSet,
        Low,
        LowMed,
        Medium,
        MedHigh,
        High
    }
    public class Absence
    {
        TypeOfAbsence typeOfAbsence;
        LevelOfActivity levelOfActivity;
        string comment;
        

        public Absence()
        {
            typeOfAbsence = TypeOfAbsence.None;
            levelOfActivity = LevelOfActivity.NotSet;
            comment = "";
            
        }
    }
    
}
