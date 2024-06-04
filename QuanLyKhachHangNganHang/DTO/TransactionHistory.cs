using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachHangNganHang.DTO
{
    public class TransactionHistory
    {
        public TransactionHistory(int TransactionID, string AccountID, int ServiceID, DateTime? TransactionDate, int TransactionAmount, string TransactionDescription)
        {
            this.TransactionID = TransactionID;
            this.AccountID = AccountID; 
            this.ServiceID = ServiceID;
            this.TransactionDate = TransactionDate;
            this.TransactionAmount = TransactionAmount;

            this.TransactionDescription = TransactionDescription;



        }
        public TransactionHistory(DataRow row)
        {
            this.TransactionID = (int)row["TransactionID"];
            this.AccountID = row["AccountID"].ToString();
            this.ServiceID = (int)row["ServiceID"];
            var dateCheckOutTemp = row["TransactionDate"];
            if (dateCheckOutTemp.ToString() != "")
            {
                this.TransactionDate = (DateTime?)dateCheckOutTemp;
            }
            // Assigning Balance from DataRow
            this.TransactionAmount = (int)row["TransactionAmount"];
            this.TransactionDescription = row["TransactionDescription"].ToString();


        }
        

        private string transactionDescription;
        public string TransactionDescription
        {
            get { return transactionDescription; }
            set { transactionDescription = value; }
        }


        private int transactionAmount;
        public int TransactionAmount
        {
            get { return transactionAmount; }
            set { transactionAmount = value; }
        }

        private DateTime? transactionDate;
        public DateTime? TransactionDate
        {
            get { return transactionDate; }
            set { transactionDate = value; }
        }
        private int serviceID;
        public int ServiceID
        {
            get { return serviceID; }
            set { serviceID = value; }
        }

        private string accountID;
        public string AccountID
        {
            get { return accountID; }
            set { accountID = value; }
        }

        private int transactionID;
        public int TransactionID
        {
            get { return transactionID; }
            set { transactionID = value; }
        }
    }
}
