using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using DataLayer;

namespace BuisnessLayer
{
    public class TestTyps
    {

        /*
            2 Enums :)
        */
        public int TestTypsID { get; set; }
        public string TestTypeTitle { get; set; }
        public string TestTypeDescription { get; set; }
        public float TestTypeFees { get; set; }
    
    
        public TestTyps()
        {
            this.TestTypsID = 1;
            this.TestTypeTitle = "";
            this.TestTypeDescription = "";
            this.TestTypeFees = 0;
        }

        private TestTyps(int TestTypeID ,string TestTypeTitle ,string TestTypeDescription ,float TestTypeFees)
        {
            this.TestTypsID = TestTypeID;
            this.TestTypeTitle = TestTypeTitle;
            this.TestTypeDescription = TestTypeDescription;
            this.TestTypeFees = TestTypeFees;
        }


        public static TestTyps _GetTestTypeByID(int TestTypeID){
           string TestTypeTitle = "";
           string TestTypeDescription = "";
           float TestTypeFees = 0;

           bool IsFound = TestTypsDataAccess.GetTestTypeByID(TestTypeID , ref TestTypeTitle , ref TestTypeDescription , ref TestTypeFees);
        
            if(IsFound)
                return new TestTyps ( TestTypeID , TestTypeTitle , TestTypeDescription , TestTypeFees);
            else
                return null;
        }


        public static DataTable GetAllTestTypes()
        {
            return TestTypsDataAccess.GetAllTestTyps();
        }

        /*
        Add 
        Update 
        save 
        ....
        */
    }
}