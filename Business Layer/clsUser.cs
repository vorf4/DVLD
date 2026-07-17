using System;
using System.Data;
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

        //public set and get methods for the private variables
        public int UserId { get => _UserId; set => _UserId = value; }
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
            this.UserId = -1;

        }

        public static clsUser Find(string username, string password)
        {

            return FindUserByUsernameAndPassword(username, password);

        }

        public static clsUser Find(int UserID)
        {

            return FindUserById(UserID);

        }


    }
}