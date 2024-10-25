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

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int ApplicationTypeID { get; set; }

        public string ApplicationTypeTitle { get; set; }

        public float ApplicationFees { get; set; }

        public ApplicationTypes()
        {
            this.ApplicationTypeID = -1;
            this.ApplicationTypeTitle = "";
            this.ApplicationFees = 0;
            Mode = enMode.AddNew;
        }

        private ApplicationTypes(int ApplicationTypeID ,string ApplicationTypeTitle ,float ApplicationFees)
        {
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationTypeTitle = ApplicationTypeTitle;
            this.ApplicationFees = ApplicationFees;
            Mode = enMode.Update;
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

        private bool _AddNewApplicationType()
        {
            //call DataAccess Layer 

            this.ApplicationTypeID = ApplicationTypesDataAccess.AddNewApplicationType(this.ApplicationTypeTitle, this.ApplicationFees);


            return (this.ApplicationTypeID != -1);
        }

        private bool _UpdateApplicationType()
        {
            //call DataAccess Layer 

            return ApplicationTypesDataAccess.UpdateApplicationType(this.ApplicationTypeID, this.ApplicationTypeTitle, this.ApplicationFees);
        }


        public static DataTable _GetAllApplicationTypes(){
            return ApplicationTypesDataAccess.GetAllApplicationTypes();
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewApplicationType())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateApplicationType();

            }

            return false;
        }

    }
}
