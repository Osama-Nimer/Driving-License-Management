using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using DataLayer;

namespace BuisnessLayer
{
    public class ApplicationTypes
    {
        public int ApplicationTypeID { get; set; }

        public string ApplicationTypeTitle { get; set; }

        public float ApplicationFees { get; set; }

        public ApplicationTypes()
        {
            this.ApplicationTypeID = -1;
            this.ApplicationTypeTitle = "";
            this.ApplicationFees = 0;
        }

        private ApplicationTypes(int ApplicationTypeID ,string ApplicationTypeTitle ,float ApplicationFees)
        {
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationTypeTitle = ApplicationTypeTitle;
            this.ApplicationFees = ApplicationFees;
        }



        public static ApplicationTypes _GetApplicationTypeByID(int ApplicationTypeID){
            string ApplicationTypeTitle = "";
            float ApplicationFees = 0 ;

            bool IsFound = ApplicationTypesDataAccess.GetApplicationTypeByID(ApplicationTypeID ,ref ApplicationTypeTitle
            ,ref ApplicationFees);
            if(IsFound)
                return new ApplicationTypes(ApplicationTypeID ,ApplicationTypeTitle,ApplicationFees);
            else
                return null;
        }



        public static DataTable _GetAllApplicationTypes(){
            return ApplicationTypesDataAccess.GetAllApplicationTypes();
        }
    }
}