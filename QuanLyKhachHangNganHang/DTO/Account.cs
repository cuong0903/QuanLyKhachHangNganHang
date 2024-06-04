using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachHangNganHang.DTO
{
    public class Account
    {
            public Account(int accountID, int accountOwnerID, int accountTypeID, string accountStatus, DateTime? accountOpenDate, int balance, string accountNumber)
            {
                this.AccountID = accountID;
                this.AccountOwnerID = accountOwnerID;
                this.AccountTypeID = accountTypeID;
                this.AccountStatus = accountStatus;
                this.AccountOpenDate = accountOpenDate;
                this.Balance = balance;
                this.AccountNumber = accountNumber;



            }
        public Account()
        {
            // Constructor không chứa đối số
        }
        public Account(DataRow row)
            {
                this.AccountID =(int)row["AccountID"];
                this.AccountOwnerID = (int)row["AccountOwnerID"];
                this.AccountTypeID = (int)row["AccountTypeID"];
                this.AccountStatus = row["AccountStatus"].ToString();
                var accountOpenDateObj = row["AccountOpenDate"];
                if (accountOpenDateObj != DBNull.Value && DateTime.TryParse(accountOpenDateObj.ToString(), out DateTime accountOpenDate))
                {
                    this.AccountOpenDate = accountOpenDate;
                }

                // Assigning Balance from DataRow
                this.Balance = (int)row["Balance"];
                this.AccountNumber = row["AccountNumber"].ToString();


            }
            private string accountNumber;
            public string AccountNumber
            {
                get { return accountNumber; }
                set { accountNumber = value; }
            }

            private int balance;
            public int Balance
            {
                get { return balance; }
                set { balance = value; }
            }
            private DateTime? accountOpenDate;
            public DateTime? AccountOpenDate
            {
                get { return accountOpenDate; }
                set { accountOpenDate = value; }
            }

            private string accountStatus;
            public string AccountStatus
            {
                get { return accountStatus; }
                set { accountStatus = value; }
            }
            private int accountTypeID;
            public int AccountTypeID
            {
                get { return accountTypeID; }
                set { accountTypeID = value; }
            }


            private int accountOwnerID;
            public int AccountOwnerID
            {
                get { return accountOwnerID; }
                set { accountOwnerID = value; }
            }

            private int accountID;
            public int AccountID
            {
                get { return accountID; }
                set { accountID = value; }
            }
    }
}

