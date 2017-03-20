using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeReview.Models
{
    public class EmployeeModel
    {
       
        public string EmpName { get; set; }
        public Designation EmpDesignation { get; set; }
        public DevSkillScale EmpDevSkillScale { get; set; }
        public static List<EmployeeModel> EmpDetails { get; set; }
        public DevSkills EmpDevSkills { get; set; }

        public enum DevSkills
        {
            CodingSkills,
            TroubleShootingSkills,
            QualityAssurance,
            TimeLogging
        }
        public enum Designation
        {
            JuniorDeveloper,
            SeniorDeveloper,
            TeamLead,
            TeamManager

        }

        public enum DevSkillScale
        {
            Unsatisfactory,
            NeedsImprovement,
            MeetsExpectations,
            AboveExpectations,
            Outstanding
        }

        static EmployeeModel()
        {
            EmpDetails = new List<EmployeeModel> { };
        }
    }
}