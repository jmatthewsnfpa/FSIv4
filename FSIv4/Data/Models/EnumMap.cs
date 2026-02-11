using static FSIv4.Data.Models.EnumList;

namespace FSIv4.Data.Models
{
    public static class EnumMaps
    {

        public static readonly Dictionary<StateList, int> StateMap = new()
        {
            { StateList.AL, 1},
            { StateList.AK, 2},
            { StateList.AS, 3}, // US Territory
            { StateList.AZ, 4},
            { StateList.AR, 5},
            { StateList.CA, 6},
            { StateList.CZ, 7 }, // ???
            { StateList.CO, 8},
            { StateList.CT, 9},
            { StateList.DE, 10},
            { StateList.DC, 11},
            { StateList.FL, 12},
            { StateList.GA, 13},
            { StateList.GU, 14 }, // US Territory
            { StateList.HI, 15},
            { StateList.ID, 16},
            { StateList.IL, 17},
            { StateList.IN, 18},
            { StateList.IA, 19},
            { StateList.KS, 20},
            { StateList.KY, 21},
            { StateList.LA, 22},
            { StateList.ME, 23},
            { StateList.MD, 24},
            { StateList.MA, 25},
            { StateList.MI, 26},
            { StateList.MN, 27},
            { StateList.MS, 28},
            { StateList.MO, 29},
            { StateList.MT, 30},
            { StateList.NE, 31},
            { StateList.NV, 32},
            { StateList.NH, 33},
            { StateList.NJ, 34},
            { StateList.NM, 35},
            { StateList.NY, 36},
            { StateList.NC, 37},
            { StateList.ND, 38},
            { StateList.OH, 39},
            { StateList.OK, 40},
            { StateList.OR, 41},
            { StateList.PA, 42},
            { StateList.PR, 43}, // US Territory
            { StateList.RI, 44},
            { StateList.SC, 45},
            { StateList.SD, 46},
            { StateList.TN, 47},
            { StateList.TX, 48},
            { StateList.UT, 49},
            { StateList.VT, 50},
            { StateList.VA, 51},
            { StateList.VI, 53}, // US Territory
            { StateList.WA, 52},
            { StateList.WV, 54},
            { StateList.WI, 55},
            { StateList.WY, 56},
            { StateList.AB, 60 }, // Canadian Province
            { StateList.BC, 61 }, // Canadian Province
            { StateList.MB, 62 }, // Canadian Province
            { StateList.NB, 63 }, // Canadian Province
            { StateList.NL, 64 }, // Canadian Province
            { StateList.NS, 65 }, // Canadian Province
            { StateList.NT, 71 }, // Canadian Province
            { StateList.NU, 72 }, // Canadian Province
            { StateList.ON, 66 }, // Canadian Province
            { StateList.PE, 67 }, // Canadian Province
            { StateList.QC, 68 }, // Canadian Province
            { StateList.SK, 69 }, // Canadian Province
            { StateList.YT, 70 }, // Canadian Province
            { StateList.Other, 99 } // Other
        };

        public static readonly Dictionary<StateList, int> StateGroupData = new()
        {
            // Group 1
            { StateList.CA, 1 },
            { StateList.IN, 1 },
            { StateList.IA, 1 },
            { StateList.KS, 1 },
            { StateList.KY, 1 },
            { StateList.MI, 1 },
            { StateList.MN, 1 },
            { StateList.MO, 1 },
            { StateList.MT, 1 },
            { StateList.ND, 1 },
            { StateList.NM, 1 },
            { StateList.NV, 1 },
            { StateList.OK, 1 },
            { StateList.OR, 1 },
            { StateList.SD, 1 },
            { StateList.UT, 1 },
            { StateList.WA, 1 },
            { StateList.WY, 1 },

            // Group 2
            { StateList.AL, 2 },
            { StateList.CT, 2 },
            { StateList.DE, 2 },
            { StateList.GA, 2 },
            { StateList.HI, 2 },
            { StateList.MA, 2 },
            { StateList.MD, 2 },
            { StateList.NC, 2 },
            { StateList.NJ, 2 },
            { StateList.NY, 2 },
            { StateList.OH, 2 },
            { StateList.RI, 2 },
            { StateList.SC, 2 },
            { StateList.TN, 2 },
            { StateList.VA, 2 },
            { StateList.VT, 2 },
            { StateList.WV, 2 },

            // Group 3
            { StateList.AK, 3 },
            { StateList.AR, 3 },
            { StateList.AZ, 3 },
            { StateList.CO, 3 },
            { StateList.FL, 3 },
            { StateList.ID, 3 },
            { StateList.IL, 3 },
            { StateList.LA, 3 },
            { StateList.ME, 3 },
            { StateList.MS, 3 },
            { StateList.NE, 3 },
            { StateList.NH, 3 },
            { StateList.PA, 3 },
            { StateList.TX, 3 },
            { StateList.WI, 3 },

            // Group 4
            { StateList.AB, 4 }, // Canada
            { StateList.AS, 4 }, // US Territory
            { StateList.BC, 4 }, // Canada
            { StateList.CZ, 4 }, // ???
            { StateList.DC, 4},
            { StateList.GU, 4 }, // US Territory
            //{ StateList.FR, 4 }, // ???
            { StateList.MB, 4 }, // Canada
            { StateList.NB, 4 }, // Canada
            //{ StateList.NF, 4 }, // Old postal code for NL
            { StateList.NL, 4 }, // Canada
            { StateList.NS, 4 }, // Canada
            { StateList.NT, 4 }, // Canada
            { StateList.NU, 4 }, // Canada
            { StateList.ON, 4 }, // Canada
            { StateList.Other, 4 },
            { StateList.PE, 4 }, // Canada
            { StateList.PR, 4 }, // US Territory
            { StateList.QC, 4 }, // Canada
            { StateList.SK, 4 }, // Canada
            { StateList.VI, 4 }, // US Territory
            { StateList.YT, 4 }, // Canada
        };


        //***************** NEED TO FIX THIS - NOT USING IT CURRENTLY needs to be adjusted to use int for Region enum

        //public static readonly Dictionary<StateList, Region> StateRegionData = new()
        //{
        //    // US States
        //    { StateList.AL, Region.South },
        //    { StateList.AK, Region.West },
        //    { StateList.AZ, Region.West },
        //    { StateList.AR, Region.South },
        //    { StateList.CA, Region.West },
        //    { StateList.CO, Region.West },
        //    { StateList.CT, Region.Northeast },
        //    { StateList.DE, Region.Northeast },
        //    { StateList.DC, Region.Northeast },
        //    { StateList.FL, Region.South },
        //    { StateList.GA, Region.South },
        //    { StateList.HI, Region.West },
        //    { StateList.ID, Region.West },
        //    { StateList.IL, Region.Midwest },
        //    { StateList.IN, Region.Midwest },
        //    { StateList.IA, Region.Midwest },
        //    { StateList.KS, Region.Midwest },
        //    { StateList.KY, Region.South },
        //    { StateList.LA, Region.South },
        //    { StateList.ME, Region.Northeast },
        //    { StateList.MD, Region.Northeast },
        //    { StateList.MA, Region.Northeast },
        //    { StateList.MI, Region.Midwest },
        //    { StateList.MN, Region.Midwest },
        //    { StateList.MS, Region.South },
        //    { StateList.MO, Region.Midwest },
        //    { StateList.MT, Region.West },
        //    { StateList.NE, Region.Midwest },
        //    { StateList.NV, Region.West },
        //    { StateList.NH, Region.Northeast },
        //    { StateList.NJ, Region.Northeast },
        //    { StateList.NM, Region.West },
        //    { StateList.NY, Region.Northeast },
        //    { StateList.NC, Region.South },
        //    { StateList.ND, Region.Midwest },
        //    { StateList.OH, Region.Midwest },
        //    { StateList.OK, Region.South },
        //    { StateList.OR, Region.West },
        //    { StateList.PA, Region.Northeast },
        //    { StateList.RI, Region.Northeast },
        //    { StateList.SC, Region.South },
        //    { StateList.SD, Region.Midwest },
        //    { StateList.TN, Region.South },
        //    { StateList.TX, Region.South },
        //    { StateList.UT, Region.West },
        //    { StateList.VT, Region.Northeast },
        //    { StateList.VA, Region.South },
        //    { StateList.WA, Region.West },
        //    { StateList.WV, Region.Northeast },
        //    { StateList.WI, Region.Midwest },
        //    { StateList.WY, Region.West },

        //    // US Territories
        //    { StateList.PR, Region.US_Territory },
        //    { StateList.VI, Region.US_Territory },
        //    { StateList.GU, Region.US_Territory },
        //    { StateList.AS, Region.US_Territory },
        //    { StateList.CZ, Region.Other }, // ???
        //    { StateList.Other, Region.Other },
        //    //{ StateList.FR, Region.Other }, // ???


        //    // Canadian Provinces/Territories
        //    { StateList.SK, Region.Canada_Prairie },
        //    { StateList.AB, Region.Canada_Prairie },
        //    { StateList.MB, Region.Canada_Prairie },
        //    { StateList.ON, Region.Canada_Central },
        //    { StateList.QC, Region.Canada_Central },
        //    { StateList.PE, Region.Canada_Atlantic },
        //    { StateList.NL, Region.Canada_Atlantic },
        //    { StateList.NS, Region.Canada_Atlantic },
        //    { StateList.NB, Region.Canada_Atlantic },
        //    { StateList.BC, Region.Canada_West_Coast },
        //    { StateList.YT, Region.Canada_North },
        //    { StateList.NT, Region.Canada_North },
        //    { StateList.NU, Region.Canada_North }
        //};

        public static readonly Dictionary<Training, int> TrainingMap = new()
        {
            { Training.Unknown, 0 },
            { Training.None, 2 },
            { Training.County_or_Regional, 4 },
            { Training.Fire_Department, 1 },
            { Training.State, 3 }
        };

        public static readonly Dictionary<Ems, int> EmsMap = new()
        {
            { Ems.Unknown, 0 },
            { Ems.None, 2 },
            { Ems.EMS, 1 },
            { Ems.EMS_and_ALS, 3 }
        };

        public static readonly Dictionary<Dispatch, int> DispatchMap = new()
        {
            { Dispatch.Unknown, 0 },
            { Dispatch.Another_Fire_Dept, 5 },
            { Dispatch.Communication_Center, 3 },
            { Dispatch.Law_Enforcement_Center, 4 },
            { Dispatch.No, 2 },
            { Dispatch.Yes, 1 }
        };

        public static readonly Dictionary<EmployeeType, int> TypeEmpMap = new()
        {
            { EmployeeType.Unknown, 0 },
            { EmployeeType.All_Paid_Employees, 1 },
            { EmployeeType.All_Volunteer, 3 },
            { EmployeeType.Over_Half_Paid_Employees, 4 },
            { EmployeeType.Under_Half_Paid_Employees, 2 }
        };

        public static readonly Dictionary<CodeEnforcement, int> CodeEnforcementMap = new()
        {
            { CodeEnforcement.Unknown, 0 },
            { CodeEnforcement.None, 1 },
            { CodeEnforcement.County_Or_Regional_Fire_Marshal_Office, 4 },
            { CodeEnforcement.Department_Fire_Marshal_Office, 3 },
            { CodeEnforcement.Local_Fire_Prevention_Office, 6 },
            { CodeEnforcement.Other_Municipal_Agency, 5 },
            { CodeEnforcement.Private, 7 },
            { CodeEnforcement.State_Fire_Marshal_Office, 2 }
        };

        public static readonly Dictionary<Community, int> CommunityMap = new()
        {
            { Community.Unknown, 0 },
            { Community.Indian_Reservation, 1 },
            { Community.Two_Or_More_City_Town, 2 },
            { Community.Military, 3 },
            { Community.Industrial, 4 },
            { Community.Portion_Of_County, 5 },
            { Community.Fire_District, 6 },
            { Community.School, 7 },
            { Community.Airport_Authority, 8 },
            { Community.Unincorporated_Area, 9 },
            { Community.City_Town_Plus_Surr_Area, 10 },
            { Community.Hospital, 11 },
            { Community.Township, 12 },
            { Community.Borough, 13 },
            { Community.Correctional_Facility, 14 },
            { Community.Undetermined_Government, 15 },
            { Community.Incorporated_City_Town, 16 },
            { Community.State, 17 },
            { Community.Village, 18 },
            { Community.Entire_County, 19 },
            { Community.Island, 20 },
            { Community.Portion_Of_City_Town, 21 },
            { Community.Federal_Excluding_Military, 22 }
        };

        public static readonly Dictionary<Rank, int> RankMap = new()
        {
            { Rank.Unknown, 0 },
            { Rank.No_Contact, 1 },
            { Rank.Administrator, 2 },
            { Rank.Assistant_Fire_Chief, 3 },
            { Rank.Coordinator, 4 },
            { Rank.Deputy_Fire_Chief, 5 },
            { Rank.Director, 6 },
            { Rank.Fire_Chief, 7 },
            { Rank.Fire_Marshal, 8 },
            { Rank.Fire_Prevention_Officer, 9 },
            { Rank.Forest_Supervisor, 10 },
            { Rank.President, 11 },
            { Rank.Division_Fire_Chief, 12 },
            { Rank.Assistant_Fire_Commissioner, 13 },
            { Rank.Lieutenant, 14 },
            { Rank.Fire_Prevention_Inspector, 15 },
            { Rank.Captain, 16 },
            { Rank.Town_Manager, 17 },
            { Rank.Battalion_Fire_Chief, 18 },
            { Rank.District_Fire_Chief, 19 },
            { Rank.Sergeant, 20 },
            { Rank.Engineer, 21 },
            { Rank.Training_Staff, 22 }
        };

        public static readonly Dictionary<PopInt, int> PopIntMap = new()
        {
            { PopInt.Unknown, 0 },
            { PopInt.One_Million_or_More, 1 },
            { PopInt.Five_Hundred_Thousand_to_Nine_Hundred_Ninety_Nine_Thousand_Nine_Hundred_Ninety_Nine, 2 },
            { PopInt.Two_Hundred_Fifty_Thousand_to_Four_Hundred_Ninety_Nine_Thousand_Nine_Hundred_Ninety_Nine, 3 },
            { PopInt.One_Hundred_Thousand_to_Two_Hundred_Forty_Nine_Thousand_Nine_Hundred_Ninety_Nine, 4 },
            { PopInt.Fifty_Thousand_to_Ninety_Nine_Thousand_Nine_Hundred_Ninety_Nine, 5 },
            { PopInt.Twenty_Five_Thousand_to_Forty_Nine_Thousand_Nine_Hundred_Ninety_Nine, 6 },
            { PopInt.Ten_Thousand_to_Twenty_Four_Thousand_Nine_Hundred_Ninety_Nine, 7 },
            { PopInt.Five_Thousand_to_Nine_Thousand_Nine_Hundred_Ninety_Nine, 8 },
            { PopInt.Two_Thousand_Five_Hundred_to_Four_Thousand_Nine_Hundred_Ninety_Nine, 9 },
            { PopInt.Less_Than_Two_Thousand_Five_Hundred, 10 }
        };

        public static readonly Dictionary<RecordType, int> RecordTypeMap = new()
        {
            { RecordType.Unknown, 0 },
            { RecordType.Department_That_Only_Provides_Record_Keeping, 1 },
            { RecordType.Department_That_Provides_Suppression_And_Record_Keeping, 2 },
            { RecordType.Department_That_Provides_Only_Suppression, 3 },
            { RecordType.Office_Of_The_Fire_Marshal_Or_State_Or_Forestry_Commissioner, 4 },
            { RecordType.Maryland_Counties_And_Undetermined, 5 },
            { RecordType.Counties_With_County_Seats, 6 }
        };

    }
}
