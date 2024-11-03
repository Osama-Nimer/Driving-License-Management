using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer
{
    public class TestAppointment
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int TestAppointmentID { set; get; }
        public TestTyps.enTestType TestTypeID { set; get; }
        public int LocalDrivingLicenseApplicationID { set; get; }
        public DateTime AppointmentDate { set; get; }
        public float PaidFees { set; get; }
        public int CreatedByUserID { set; get; }
        public bool IsLocked { set; get; }
        public int RetakeTestApplicationID { set; get; }
        public Application RetakeTestAppInfo { set; get; }

        public int TestID
        {
            get { return _GetTestID(); }

        }

        public TestAppointment()

        {
            this.TestAppointmentID = -1;
            this.TestTypeID = TestTyps.enTestType.VisionTest;
            this.AppointmentDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = -1;
            this.RetakeTestApplicationID = -1;
            Mode = enMode.AddNew;

        }

        public TestAppointment(int TestAppointmentID, TestTyps.enTestType TestTypeID,
           int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, float PaidFees,
           int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)

        {
            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked;
            this.RetakeTestApplicationID = RetakeTestApplicationID;
            this.RetakeTestAppInfo = Application.FindBaseApplication(RetakeTestApplicationID);
            Mode = enMode.Update;
        }

        private bool _AddNewTestAppointment()
        {
            //call DataAccess Layer 

            this.TestAppointmentID = TestAppointmentData.AddNewTestAppointment((int)this.TestTypeID, this.LocalDrivingLicenseApplicationID,
                this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.RetakeTestApplicationID);

            return (this.TestAppointmentID != -1);
        }

        private bool _UpdateTestAppointment()
        {
            //call DataAccess Layer 

            return TestAppointmentData.UpdateTestAppointment(this.TestAppointmentID, (int)this.TestTypeID, this.LocalDrivingLicenseApplicationID,
                this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked, this.RetakeTestApplicationID);
        }

        public static TestAppointment Find(int TestAppointmentID)
        {
            int TestTypeID = 1; int LocalDrivingLicenseApplicationID = -1;
            DateTime AppointmentDate = DateTime.Now; float PaidFees = 0;
            int CreatedByUserID = -1; bool IsLocked = false; int RetakeTestApplicationID = -1;

            if (TestAppointmentData.GetTestAppointmentInfoByID(TestAppointmentID, ref TestTypeID, ref LocalDrivingLicenseApplicationID,
            ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked, ref RetakeTestApplicationID))

                return new TestAppointment(TestAppointmentID, (TestTyps.enTestType)TestTypeID, LocalDrivingLicenseApplicationID,
             AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);
            else
                return null;

        }

        public static TestAppointment GetLastTestAppointment(int LocalDrivingLicenseApplicationID, TestTyps.enTestType TestTypeID)
        {
            int TestAppointmentID = -1;
            DateTime AppointmentDate = DateTime.Now; float PaidFees = 0;
            int CreatedByUserID = -1; bool IsLocked = false; int RetakeTestApplicationID = -1;

            if (TestAppointmentData.GetLastTestAppointment(LocalDrivingLicenseApplicationID, (int)TestTypeID,
                ref TestAppointmentID, ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked, ref RetakeTestApplicationID))

                return new TestAppointment(TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID,
             AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);
            else
                return null;

        }

        public static DataTable GetAllTestAppointments()
        {
            return TestAppointmentData.GetAllTestAppointments();

        }

        public DataTable GetApplicationTestAppointmentsPerTestType(TestTyps.enTestType TestTypeID)
        {
            return TestAppointmentData.GetApplicationTestAppointmentsPerTestType(this.LocalDrivingLicenseApplicationID, (int)TestTypeID);

        }

        public static DataTable GetApplicationTestAppointmentsPerTestType(int LocalDrivingLicenseApplicationID, TestTyps.enTestType TestTypeID)
        {
            return TestAppointmentData.GetApplicationTestAppointmentsPerTestType(LocalDrivingLicenseApplicationID, (int)TestTypeID);

        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTestAppointment())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateTestAppointment();

            }

            return false;
        }

        private int _GetTestID()
        {
            return TestAppointmentData.GetTestID(TestAppointmentID);
        }
    }
}
