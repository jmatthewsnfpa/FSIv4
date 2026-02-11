using System.ComponentModel.DataAnnotations;

namespace FSIv4.Data.Models
{
    public class EnumList
    {
        public enum Ambulance
        {
            Unknown,
            No,
            Yes
        }

        public enum RecordType
        {
            Unknown,
            [Display(Name = "Department That Only Provides Record Keeping")]
            Department_That_Only_Provides_Record_Keeping,
            [Display(Name = "Department That Provides Suppression And Record Keeping")]
            Department_That_Provides_Suppression_And_Record_Keeping,
            [Display(Name = "Department That Provides Only Suppression")]
            Department_That_Provides_Only_Suppression,
            [Display(Name = "Office Of The Fire Marshal Or State Or Forestry Commissioner")]
            Office_Of_The_Fire_Marshal_Or_State_Or_Forestry_Commissioner,
            [Display(Name = "Maryland Counties And Undetermined")]
            Maryland_Counties_And_Undetermined,
            [Display(Name = "Counties With County Seats")]
            Counties_With_County_Seats
        }

        public enum CodeEnforcement
        {
            Unknown,
            None,
            [Display(Name = "County/Regional Fire Marshal Office")]
            County_Or_Regional_Fire_Marshal_Office,
            [Display(Name = "Department Fire Marshal Office")]
            Department_Fire_Marshal_Office,
            [Display(Name = "Local Fire Prevention Office")]
            Local_Fire_Prevention_Office,
            [Display(Name = "Other Municipal Agency")]
            Other_Municipal_Agency,
            Private,
            [Display(Name = "State Fire Marshal Office")]
            State_Fire_Marshal_Office
        }

        public enum Community
        {
            Unknown,
            [Display(Name = "Airport Authority")]
            Airport_Authority,
            Borough,
            [Display(Name = "City/Town Plus Surrounding Area")]
            City_Town_Plus_Surr_Area,
            [Display(Name = "Correctional Facility")]
            Correctional_Facility,
            [Display(Name = "Entire County")]
            Entire_County,
            [Display(Name = "Fire District")]
            Fire_District,
            Hospital,
            [Display(Name = "Incorporated City/Town")]
            Incorporated_City_Town,
            [Display(Name = "Indian Reservation")]
            Indian_Reservation,
            Industrial,
            Island,
            Military,
            [Display(Name = "Portion Of County")]
            Portion_Of_County,
            School,
            State,
            Township,
            [Display(Name = "Two or More City/Town")]
            Two_Or_More_City_Town,
            [Display(Name = "Unincorporated Area")]
            Unincorporated_Area,
            [Display(Name = "Undetermined Government")]
            Undetermined_Government,
            Village,
            [Display(Name = "Portion of City/Town")]
            Portion_Of_City_Town,
            [Display(Name = "Federal Excluding Military")]
            Federal_Excluding_Military
        }

        public enum Country
        {
            USA,
            Canada,
            Mexico,
            Other
        }

        public enum Dispatch
        {
            Unknown,
            No,
            Yes,
            [Display(Name = "Another Fire Dept")]
            Another_Fire_Dept,
            [Display(Name = "Communication Center")]
            Communication_Center,
            [Display(Name = "Law Enforcement Center")]
            Law_Enforcement_Center
        }

        public enum Ems
        {
            Unknown,
            None,
            EMS,
            [Display(Name = "EMS and ALS")]
            EMS_and_ALS
        }

        public enum PopInt
        {
            Unknown,
            [Display(Name = "1,000,000 or more")]
            One_Million_or_More,
            [Display(Name = "500,000 to 999,999")]
            Five_Hundred_Thousand_to_Nine_Hundred_Ninety_Nine_Thousand_Nine_Hundred_Ninety_Nine,
            [Display(Name = "250,000 to 499,999")]
            Two_Hundred_Fifty_Thousand_to_Four_Hundred_Ninety_Nine_Thousand_Nine_Hundred_Ninety_Nine,
            [Display(Name = "100,000 to 249,999")]
            One_Hundred_Thousand_to_Two_Hundred_Forty_Nine_Thousand_Nine_Hundred_Ninety_Nine,
            [Display(Name = "50,000 to 99,999")]
            Fifty_Thousand_to_Ninety_Nine_Thousand_Nine_Hundred_Ninety_Nine,
            [Display(Name = "25,000 to 49,999")]
            Twenty_Five_Thousand_to_Forty_Nine_Thousand_Nine_Hundred_Ninety_Nine,
            [Display(Name = "10,000 to 24,999")]
            Ten_Thousand_to_Twenty_Four_Thousand_Nine_Hundred_Ninety_Nine,
            [Display(Name = "5,000 to 9,999")]
            Five_Thousand_to_Nine_Thousand_Nine_Hundred_Ninety_Nine,
            [Display(Name = "2,500 to 4,999")]
            Two_Thousand_Five_Hundred_to_Four_Thousand_Nine_Hundred_Ninety_Nine,
            [Display(Name = "Less than 2,500")]
            Less_Than_Two_Thousand_Five_Hundred
        }

        public enum Rank
        {
            Unknown,
            [Display(Name = "No Contact")]
            No_Contact,
            Administrator,
            [Display(Name = "Assistant Fire Chief")]
            Assistant_Fire_Chief,
            Coordinator,
            [Display(Name = "Deputy Fire Chief")]
            Deputy_Fire_Chief,
            Director,
            [Display(Name = "Fire Chief")]
            Fire_Chief,
            [Display(Name = "Fire Marshal")]
            Fire_Marshal,
            [Display(Name = "Fire Prevention Officer")]
            Fire_Prevention_Officer,
            [Display(Name = "Forest Supervisor")]
            Forest_Supervisor,
            President,
            [Display(Name = "Division Fire Chief")]
            Division_Fire_Chief,
            [Display(Name = "Assistant Fire Commissioner")]
            Assistant_Fire_Commissioner,
            Lieutenant,
            [Display(Name = "Fire Prevention Inspector")]
            Fire_Prevention_Inspector,
            Captain,
            [Display(Name = "Town Manager")]
            Town_Manager,
            [Display(Name = "Battalion Fire Chief")]
            Battalion_Fire_Chief,
            [Display(Name = "District Fire Chief")]
            District_Fire_Chief,
            Sergeant,
            Engineer,
            [Display(Name = "Training Staff")]
            Training_Staff
        }

        public enum Region
        {
            Unknown,
            Other,
            [Display(Name = "Canada Atlantic")]
            Canada_Atlantic,
            [Display(Name = "Canada Central")]
            Canada_Central,
            [Display(Name = "Canada North")]
            Canada_North,
            [Display(Name = "Canada Prairie")]
            Canada_Prairie,
            [Display(Name = "Canada West Coast")]
            Canada_West_Coast,
            Central,
            Northeast,
            South,
            [Display(Name = "US Territory")]
            US_Territory,
            West
        }

        public enum StateList
        {
            AB, //0
            AK, //1
            AL, //2
            AR, //3
            AS, //4
            AZ, //5
            BC, //6
            CA, //7
            CO, //8
            CT, //9
            CZ, //10
            DC, //11
            DE, //12
            FL, //13
            FM, //14
            GA, //15
            GU, //16
            HI, //17
            IA, //18
            ID, //19
            IL, //20
            IN, //21
            KS, //22
            KY, //23
            LA, //24
            MA, //25
            MB, //26
            MD, //27
            ME, //28
            MH, //29
            MI, //30
            MN, //31
            MO, //32
            MP, //33
            MS, //34
            MT, //35
            NB, //36
            NC, //37
            ND, //38
            NE, //39
            NH, //40
            NJ, //41
            NL, //42
            NM, //43
            NS, //44
            NT, //45
            NU, //46
            NV, //47
            NY, //48
            OH, //49
            OK, //50
            ON, //51
            OR, //52
            PA, //53
            PE, //54
            PR, //55
            PW, //56
            QC, //57
            RI, //58
            SC, //59
            SD, //60
            SK, //61
            TN, //62
            TX, //63
            UT, //64
            VA, //65
            VI, //66
            VT, //67
            WA, //68
            WI, //69
            WV, //70
            WY, //71
            YT, //72
            Other //73
        }

        public enum Status
        {
            Unknown,
            Active,
            Inactive
        }

        public enum Training
        {
            Unknown,
            None,
            [Display(Name = "County or Regional")]
            County_or_Regional,
            [Display(Name = "Fire Department")]
            Fire_Department,
            State
        }

        public enum EmployeeType
        {
            Unknown,
            [Display(Name = "All Paid Employees")]
            All_Paid_Employees,
            [Display(Name = "All Volunteer")]
            All_Volunteer,
            [Display(Name = "Over Half Paid Employees")]
            Over_Half_Paid_Employees,
            [Display(Name = "Under Half Paid Employees")]
            Under_Half_Paid_Employees
        }

        public enum VolunteersCompensation
        {
            Unknown,
            No,
            Yes
        }
    }
}
