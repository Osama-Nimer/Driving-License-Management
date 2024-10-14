using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using DataLayer;

namespace BuisnessLayer
{
    public class User
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

        public User()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.UserName = "";
            this.Password = "";
            this.IsActive = true;
            Mode = enMode.AddNew;
        }

        private User(int UserID , int PersonID ,string UserName ,string Password ,bool IsActive)
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

        public static User FindUserbyUserID(int UserID){
            int PersonID = -1;
            string UserName = "", Password = "";
            bool IsActive = false;

            bool IsFound = UserDataAccess.GetUserByUserID
                                ( UserID,ref PersonID, ref UserName,ref Password,ref IsActive);

            if (IsFound)
                return new User(UserID,PersonID,UserName,Password,IsActive);
            else
                return null;
            
        } 

        public static User FindUserbyPersonID(int PersonID){
            int UserID = -1;
            string UserName = "", Password = "";
            bool IsActive = false;

            bool IsFound = UserDataAccess.GetUserByPersonID
                                ( PersonID,ref UserID, ref UserName,ref Password,ref IsActive);

            if (IsFound)
                return new User(UserID,PersonID,UserName,Password,IsActive);
            else
                return null;
            
        } 
        
        public static User FindUserbyUserNameAndPassword(string UserName, string Password ){
            int PersonID = -1;
            int UserID = -1;
            bool IsActive = false;

            bool IsFound = UserDataAccess.GetUserByUserNameAndPassword
                                (UserName, Password,ref UserID,ref PersonID,ref IsActive);

            if (IsFound)
                return new User(UserID,PersonID,UserName,Password,IsActive);
            else
                return null;
            
        } 


        public static DataTable _GetAllUser(){
            return UserDataAccess.GetAllUsers();
        }

        public static bool _DeleteUesr(int UserID){
            return UserDataAccess.DeleteUser(UserID);
        }

        public static bool _IsUserExist(int UserID){
            return UserDataAccess.IsUserExist(UserID);
        }

        public static bool _IsUserExist(string UserName){
            return UserDataAccess.IsUserExist(UserName);
        }


        public static bool _isUserExistForPersonID(int PersonID){
            return UserDataAccess.IsUserExistForPersonID(PersonID);
        }
    }
}