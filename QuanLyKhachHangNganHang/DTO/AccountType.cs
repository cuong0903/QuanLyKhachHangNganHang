using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachHangNganHang.DTO
{
    public class AccountType
    {
        public AccountType(int accountTypeID, string accountTypeName, string accountTypeDescription, string interestRate)
        {
            this.AccountTypeID = accountTypeID;
            this.AccountTypeName = accountTypeName;
            this.AccountTypeDescription = accountTypeDescription;
            this.InterestRate = interestRate;
          


        }
        public AccountType(DataRow row)
        {
            this.AccountTypeID = (int)row["AccountTypeID"];
            this.AccountTypeName = row["AccountTypeName"].ToString();
            this.AccountTypeDescription = row["AccountTypeDescription"].ToString();
            this.InterestRate = row["InterestRate"].ToString();
            
        }
        
        private string interestRate;
        public string InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }
        private string accountTypeDescription;
        public string AccountTypeDescription
        {
            get { return accountTypeDescription; }
            set { accountTypeDescription = value; }
        }

        private string accountTypeName;
        public string AccountTypeName
        {
            get { return accountTypeName; }
            set { accountTypeName = value; }
        }

        private int accountTypeID;
        public int AccountTypeID
        {
            get { return accountTypeID; } 
            set { accountTypeID = value; } 
        }
    }
}
