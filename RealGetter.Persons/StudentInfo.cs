using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealGetter.Lib
{
    public class StudentInfo : RealGetter.Lib.Interfaces.IStudentInfo
    {
        #region Fields
        private string _comment;
        private DateTime _dateOfInfo;
        private TypeOfAbsence _absence;
        private LevelOfActivity _activityLevel;
        #endregion

        #region Properties
        public string Comment
        {
            get { return _comment; }
            //set { _comment = value; }
        }

        public DateTime DateOfInfo
        {
            get { return _dateOfInfo; }
        }

        public TypeOfAbsence Absence
        {
            get { return _absence; }
        }
        public LevelOfActivity ActivityLevel
        {
            get { return _activityLevel; }
        }
        #endregion

        #region Constructors
        public StudentInfo()
        {
            _comment = "";
            _dateOfInfo = DateTime.Now.Date;
            _absence = TypeOfAbsence.None;
            _activityLevel = LevelOfActivity.NotSet;

        }

        public StudentInfo(string comment, DateTime dateTime, TypeOfAbsence absence, LevelOfActivity activityLevel)
        {
            _comment = comment;
            _dateOfInfo = dateTime;
            _absence = absence;
            _activityLevel = activityLevel;

        }
        #endregion

        #region Methods
        public void SetComment(string comment)
        {
            _comment = comment;
        }
       
        public void SetAbsenceType(TypeOfAbsence typeOfAbsence)
        {
            _absence = typeOfAbsence;
        }
        public void SetLevelOfActivity(LevelOfActivity levelOfActivty)
        {
            _activityLevel = levelOfActivty;
        }
    
        #endregion





    }
}
