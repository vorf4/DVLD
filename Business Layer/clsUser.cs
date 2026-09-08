using System;
using System.Data;
using System.Runtime.CompilerServices;
using Data_Access_Layer;

namespace Business_Layer
{
    public class clsUser
    {

        //public variables for the class

        public enum enSave
        {

            enAddScc = 0,
            enUpdateScc = 1,
            enfailed = 2

        }

        //private variables for the class
        private enum enMode
        {
            enAddNewUser = 0,
            enUpdateUser = 1,
        }

        private enMode _Mode;
        private int _UserId;
        private int _PersonId;
        private string _UserName;
        private string _Password;
        private bool _IsActive;

        //private methods for the class

        private clsUser(int UserID, int PersonId, string UserName, string Password, bool IsActive)
        {

            this._Mode = enMode.enUpdateUser;
            this._UserId = UserID;
            this._PersonId = PersonId;
            this._UserName = UserName;
            this._Password = Password;
            this._IsActive = IsActive;

        }

        private static clsUser FindUserByUsernameAndPassword(string username, string password)
        {

            int UserID = -1;
            int PersonId = -1;
            bool IsActive = false;
            bool isFound = clsUserTB.GetUserByUsernameAndPassword(username, password, ref UserID, ref PersonId, ref IsActive);
            if (isFound)
            {
                return new clsUser(UserID, PersonId, username, password, IsActive);
            }
            else
            {
                return null; // User not found
            }

        }

        private static clsUser FindUserById(int UserID)
        {
            int PersonId = -1;
            string UserName = "";
            string Password = "";
            bool IsActive = false;
            bool isFound = clsUserTB.GetUserByID(UserID, ref PersonId, ref IsActive, ref UserName, ref Password);
            if (isFound)
            {
                return new clsUser(UserID, PersonId, UserName, Password, IsActive);
            }
            else
            {
                return null; // User not found
            }
        }

        private static DataTable GetAllUsers()
        {
            return clsUserTB.GetAllUsers();
        }

        private void AddNewUser() 
        { 
        
            this._UserId = clsUserTB.AddUser(this._PersonId, this._UserName, this._Password, this._IsActive);

        }

        private void UpdateUser()
        {
            clsUserTB.UpdateUser(this._UserId, this._PersonId, this._UserName, this._Password, this._IsActive);
        }

        private static bool DeleteUserById(int UserID)
        {
            return clsUserTB.DeleteUser(UserID);
        }

        private static bool IsUserExists(int UserID)
        {
            return clsUserTB.IsUserExists(UserID);
        }

        private static bool IsUserExists(string UserName)
        {
            return clsUserTB.IsUsernameExists(UserName);
        }

        private static bool IsPersonIdExists(int PersonId)
        {
            return clsUserTB.IsPersonIdExists(PersonId);
        }

        private static clsUser findUserByPersonId(int PersonId)
        {
            int UserID = -1;
            bool IsActive = false;
            string UserName = "";
            string Password = "";

            if(clsUserTB.GetUserByPersonID(PersonId, ref UserID, ref IsActive, ref UserName, ref Password))
            {
                
                return new clsUser(UserID, PersonId, UserName, Password, IsActive);

            }
            return null;
        }

        private static bool IsNationalIdExists(string NationalId)
        {
            return clsUserTB.IsNationalIdExists(NationalId);
        }

        private static string GetPasswordByID(int UserID)
        {
            return clsUserTB.GetPasswordByID(UserID);
        }

        //public set and get methods for the private variables
        public int UserID { get => _UserId; set => _UserId = value; }
        public int PersonId { get => _PersonId; set => _PersonId = value; }
        public string UserName { get => _UserName; set => _UserName = value; }
        public string Password { get => _Password; set => _Password = value; }
        public bool IsActive { get => _IsActive; set => _IsActive = value; }

        //public methods for the class

        public clsUser()
        {

            this._Mode = enMode.enAddNewUser;
            this._IsActive = false;
            this._Password = "";
            this._UserName = "";
            this._PersonId = -1;
            this.UserID = -1;

        }

        public static clsUser Find(string username, string password)
        {

            return FindUserByUsernameAndPassword(username, password);

        }

        public static clsUser Find(int UserID)
        {

            return FindUserById(UserID);

        }

        public enSave Save()
        {
            if (this._Mode == enMode.enAddNewUser)
            {
                AddNewUser();
                return enSave.enAddScc;
            }
            else if (this._Mode == enMode.enUpdateUser)
            {
                UpdateUser();
                return enSave.enUpdateScc;
            }
            else
            {
                return enSave.enfailed;
            }
        }

        public static DataTable GetAll()
        {
            return GetAllUsers();
        }

        public static bool DeleteUser(int UserID)
        {
            return DeleteUserById(UserID);
        }

        public static bool IsExists(int UserID)
        {
            return IsUserExists(UserID);
        }

        public static bool IsExists(string UserName)
        {
            return IsUserExists(UserName);
        }

        public static bool IsPersonExists(int PersonId)
        {
            return IsPersonIdExists(PersonId);
        }

        public static clsUser FindByPersonId(int PersonId)
        {
            return findUserByPersonId(PersonId);
        }

        public static bool IsNationalNumberExists(string NationalId)
        {
            return IsNationalIdExists(NationalId);
        }

        public static string GetPassword(int UserID)
        {
            return GetPasswordByID(UserID);
        }

    }
}