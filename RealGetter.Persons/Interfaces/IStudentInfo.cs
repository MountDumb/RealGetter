using System;

namespace RealGetter.Lib.Interfaces
{
    public interface IStudentInfo
    {
        TypeOfAbsence Absence { get; }
        LevelOfActivity ActivityLevel { get; }
        string Comment { get; }
        DateTime DateOfInfo { get; }

        void SetAbsenceType(TypeOfAbsence typeOfAbsence);
        void SetComment(string comment);
        void SetLevelOfActivity(LevelOfActivity levelOfActivty);
    }
}