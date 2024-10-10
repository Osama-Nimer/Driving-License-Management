﻿namespace BuisnessLayer;

using System.Data;
using System.Data.SqlClient;
using DataLayer;
public class clsPepoleBuisness
{
    public enum enMode { AddNew = 0, Update = 1 };
    public enMode Mode = enMode.AddNew;

    public int PersonID { set; get; }
    public string FirstName { set; get; }
    public string SecondName { set; get; }
    public string ThirdName { set; get; }
    public string LastName { set; get; }
    public string FullName
    {
        get { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; }

    }
    public string NationalNo { set; get; }
    public DateTime DateOfBirth { set; get; }
    public short Gendor { set; get; }
    public string Address { set; get; }
    public string Phone { set; get; }
    public string Email { set; get; }
    public int NationalityCountryID { set; get; }

    public Country CountryInfo;

    private string _ImagePath;
        
    public string ImagePath   
    {
        get { return _ImagePath; }   
        set { _ImagePath = value; }  
    }


    public clsPepoleBuisness()
    {
        this.PersonID = -1;
        this.FirstName = "";
        this.SecondName = "";
        this.ThirdName = "";
        this.LastName = "";
        this.DateOfBirth = DateTime.Now;
        this.Address = "";
        this.Phone = "";
        this.Email = "";
        this.NationalityCountryID = -1;
        this.ImagePath = "";

        Mode = enMode.AddNew;
    }

    private clsPepoleBuisness(int PersonID, string FirstName,string SecondName, string ThirdName,
        string LastName,string NationalNo, DateTime DateOfBirth,short Gendor,
        string Address, string Phone, string Email,
        int NationalityCountryID, string ImagePath)
        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.SecondName= SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.NationalNo = NationalNo;   
            this.DateOfBirth = DateOfBirth;
            this.Gendor= Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;
            this.CountryInfo = Country._Find(NationalityCountryID);
            Mode = enMode.Update;
        }

public static clsPepoleBuisness Find(int PersonID)
{

    string FirstName = "", SecondName = "", ThirdName = "", LastName = "",NationalNo="", Email = "", Phone = "", Address = "", ImagePath = "";
    DateTime DateOfBirth = DateTime.Now;
    int NationalityCountryID = -1;
    short Gendor = 0;

    bool IsFound = clsPepoleData.GetPersonInfoByID 
                        (
                            PersonID, ref FirstName, ref SecondName,
                            ref ThirdName, ref LastName, ref NationalNo, ref DateOfBirth,
                            ref Gendor, ref Address, ref Phone, ref Email,
                            ref NationalityCountryID, ref ImagePath
                        );

    if (IsFound)
        //we return new object of that person with the right data
        return new clsPepoleBuisness(PersonID, FirstName,SecondName ,ThirdName, LastName,
                  NationalNo, DateOfBirth,Gendor, Address, Phone, Email,NationalityCountryID, ImagePath);
    else
        return null;
}


public static clsPepoleBuisness Find(String NationalNo)
{
    int PersonID =-1;
    string FirstName = "", SecondName = "", ThirdName = "", LastName = "", Email = "", Phone = "", Address = "", ImagePath = "";
    DateTime DateOfBirth = DateTime.Now;
    int NationalityCountryID = -1;
    short Gendor = 0;

    bool IsFound = clsPepoleData.GetPersonInfoByNationalNo 
                        (
                            NationalNo ,ref PersonID, ref FirstName, ref SecondName,
                            ref ThirdName, ref LastName, ref DateOfBirth,
                            ref Gendor, ref Address, ref Phone, ref Email,
                            ref NationalityCountryID, ref ImagePath
                        );

    if (IsFound)
        //we return new object of that person with the right data
        return new clsPepoleBuisness(PersonID, FirstName,SecondName ,ThirdName, LastName,
                  NationalNo, DateOfBirth,Gendor, Address, Phone, Email,NationalityCountryID, ImagePath);
    else
        return null;
}


private bool _AddNewPerson(){
    this.PersonID = clsPepoleData.AddNewPerson(
    this.FirstName,this.SecondName ,this.ThirdName,
    this.LastName,this.NationalNo,
    this.DateOfBirth, this.Gendor, this.Address, this.Phone, this.Email,
    this.NationalityCountryID, this.ImagePath);
    return (PersonID != -1 );
}

        private bool _UpdatePerson(){
            return clsPepoleData.UpdatePerson(
            this.PersonID, this.FirstName,this.SecondName,this.ThirdName,
            this.LastName, this.NationalNo, this.DateOfBirth, this.Gendor,
            this.Address, this.Phone, this.Email, 
            this.NationalityCountryID, this.ImagePath);
        }

            public bool Save(){
                switch(Mode){
                    case enMode.AddNew : 
                        if(_AddNewPerson())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                        case enMode.Update :
                            return _UpdatePerson();
                }
                return false;
            }

        public static bool _DeletePerson(int PersonID){
            
           return(clsPepoleData.DeletePersonById(PersonID));
        }


        public static DataTable _GetAllPepole(){
            return clsPepoleData.GetAllPepole();
        }

        public static bool _IsPresonExist(int PersonID){
            return clsPepoleData.IsPresonExist(PersonID);
        }

        public static bool _IsPresonExist(String NationalNo){
            return clsPepoleData.IsPresonExist(NationalNo);
        }
}
