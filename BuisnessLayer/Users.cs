using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer;

namespace BuisnessLayer
{
    public class Users
    {
        public enum enMode{
            AddNew = 0,
            Update = 1
        }

        public enMode Mode = enMode.AddNew;

        public int UserID { get; set; }
        public int PersonID { get; set; }

        public clsPepoleBuisness personInfo ;
        public string UserName { get; set; }

        public string Password { get; set; }

        public bool IsActive { get; set; }

        public Users()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.UserName = "";
            this.Password = "";
            this.IsActive = true;
            Mode = enMode.AddNew;
        }

        private Users(int UserID , int PersonID ,string UserName ,string Password ,bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.personInfo = clsPepoleBuisness.Find(PersonID);
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;
            Mode = enMode.Update;
        }


        private bool _AddNewUser(){
            this.UserID = UserDataAccess.AddNewUser(this.PersonID,this.UserName,this.Password,this.IsActive);
            return (UserID !=-1); 
        }

        private bool _UpdatePerson(){
            return UserDataAccess.UpdateUser(this.UserID,this.PersonID,this.UserName,this.Password,this.IsActive);
        }

        public bool Save(){
            switch(Mode){
                case enMode.AddNew :
                    if(_AddNewUser()){
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    return _UpdatePerson();
                }
            return false;
        } 

        
    }
}