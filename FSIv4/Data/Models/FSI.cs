using System.ComponentModel.DataAnnotations;

namespace FSIv4.Data.Models
{
    public class FSI
    {

        [Key]
        public int NfpaFdid { get; set; } // FileMaker - fdid //
        public string? NfirsId { get; set; }
        [Required(ErrorMessage = "The Fire Department Name field is required.")]
        public string FdName { get; set; } = "";
        [Required]
        [DataType(DataType.Date)]
        public DateTime CreatedDt { get; set; } = DateTime.Now;
        [Required]
        [DataType(DataType.Date)]
        public DateTime UpdatedDt { get; set; } = DateTime.Now; // FileMaker - modification_dt //
        public string? Street { get; set; }
        public string? Street2 { get; set; }
        public string? City { get; set; }
        public int? CountyNo { get; set; }

        [Required(ErrorMessage = "The State field is required.")]
        public EnumList.StateList State { get; set; }
        public int StateId { get; set; }
        public int StateGroup { get; set; }
        public int? StateGroupOverride { get; set; } // Primary use is to include some non-US states in survey mailings //

        [DataType(DataType.PostalCode)]
        public string? Zipcode { get; set; }
        [DataType(DataType.PostalCode)]
        public string? Zipcode2 { get; set; }
        [Required(ErrorMessage = "The Region field is required.")]
        public EnumList.Region Region { get; set; }
        [Required(ErrorMessage = "The Country field is required.")]
        public EnumList.Country Country { get; set; }
        [Required(ErrorMessage = "The Address Date field is required.")]
        [DataType(DataType.Date)]
        public DateTime AddressDt { get; set; } = DateTime.Now;

        [DataType(DataType.PhoneNumber)]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "The Phone Date field is required.")]
        [DataType(DataType.Date)]
        public DateTime PhoneDt { get; set; } = DateTime.Now;

        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        [Required(ErrorMessage = "The Email Date field is required.")]
        [DataType(DataType.Date)]
        public DateTime EmailDt { get; set; } = DateTime.Now;

        [DataType(DataType.PhoneNumber)]
        public string? Fax { get; set; }
        [Required(ErrorMessage = "The Fax date field is required.")]
        [DataType(DataType.Date)]
        public DateTime FaxDt { get; set; } = DateTime.Now;

        //[Required(ErrorMessage = "The Contact Name field is required.")]
        public string? ContactName { get; set; }
        [Required(ErrorMessage = "The Contact Rank field is required.")]
        public EnumList.Rank ContactRank { get; set; } // FileMaker - rank_desc //
        public int? ContactRankId { get; set; }

        [Required(ErrorMessage = "The Contact Date field is required.")]
        [DataType(DataType.Date)]
        public DateTime ContactDt { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "The Record Type field is required.")]
        public EnumList.RecordType RecordType { get; set; }
        public int? RecordTypeId { get; set; }

        [Required(ErrorMessage = "The Record Status field is required.")]
        public EnumList.Status RecordStatus { get; set; }

        public int? CrossRefId { get; set; }  // FileMaker - cross_ref_id //

        public int? SmSa { get; set; }
        //[Required(ErrorMessage = "The Data Source field is required.")]
        public string? DataSource { get; set; }

        public int? SquareMiles { get; set; }
        [Required(ErrorMessage = "The Community Type field is required.")]
        public EnumList.Community Community { get; set; } // FileMaker - community_desc //
        public int? CommunityId { get; set; }

        public int? Population { get; set; } = null;

        public EnumList.PopInt PopInterval { get; set; }
        public int? PopIntervalId { get; set; }

        [Required(ErrorMessage = "The Employee Type field is required.")]
        public EnumList.EmployeeType TypeEmps { get; set; } // FileMaker - employee_type_desc //
        public int? TypeEmpsId { get; set; }

        public int? PaidEmps { get; set; }
        // original file from filemaker has paidempswomen switched with paidemps. 
        public int? PaidEmpsWomen { get; set; }
        public int? WorkWeek { get; set; }
        public int? EmpsPerShift { get; set; }

        [Required(ErrorMessage = "The Volunteer Compensation field is required.")]
        public EnumList.VolunteersCompensation VolsComp { get; set; }

        public int? Vols { get; set; }
        public int? VolsWomen { get; set; }

        public int? Pumpers { get; set; }
        public int? Ladders { get; set; }
        public int? Combo { get; set; }
        public int? MarineVessels { get; set; }
        public int? OtherSupport { get; set; }
        public int? OtherVehicles { get; set; }
        public int? ThermalEquipment { get; set; }
        public int? Stations { get; set; }

        [Required(ErrorMessage = "The EMS field is required.")]
        public EnumList.Ems Ems { get; set; } // FileMaker - ems_desc //
        public int? EmsId { get; set; }  // FileMaker - ems //

        [Required(ErrorMessage = "The Ambulance field is required.")]
        public EnumList.Ambulance Ambulance { get; set; }

        [Required(ErrorMessage = "The Dispatch field is required.")]
        public EnumList.Dispatch Dispatch { get; set; } // FileMaker - dispatch_desc //
        public int? DispatchId { get; set; }  // FileMaker - dispatch //

        [Required(ErrorMessage = "The Training field is required.")]
        public EnumList.Training Training { get; set; } // FileMaker - training_desc //
        public int? TrainingId { get; set; }  // FileMaker - training //

        [Required(ErrorMessage = "The Code Enforcement field is required.")]
        public EnumList.CodeEnforcement CodeEnforcement { get; set; } // FileMaker - code_enforcement_desc //
        public int? CodeEnforcementId { get; set; }  // FileMaker - code_enforcement //

        [Range(1970, 2099, ErrorMessage = "Please enter a valid year between 1970 and 2099.")]
        public int? LastReturned { get; set; } // FileMaker - last_returned //
        [Range(1970, 2099, ErrorMessage = "Please enter a valid year between 1970 and 2099.")]
        public int? LastSent { get; set; } // FileMaker - last_sent //  

        [DataType(DataType.MultilineText)]
        public string? Notes { get; set; } // FileMaker - comments //

        public int? FdSurveyStatus1 { get; set; }
        public int? FdSurveyStatus2 { get; set; }
        public int? FdSurveyStatus3 { get; set; }
        public int? FdSurveyStatus4 { get; set; }
        public int? FdSurveyStatus5 { get; set; }
        public int? FdSurveyStatus6 { get; set; }
        public int? FdSurveyStatus7 { get; set; }
        public int? FdSurveyYears1 { get; set; }
        public int? FdSurveyYears2 { get; set; }
        public int? FdSurveyYears3 { get; set; }
        public int? FdSurveyYears4 { get; set; }
        public int? FdSurveyYears5 { get; set; }
        public int? FdSurveyYears6 { get; set; }
        public int? FdSurveyYears7 { get; set; }
    }
}
