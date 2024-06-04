using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachHangNganHang.DTO
{
    public class Customer
    {
        public Customer(int customerID, string customerName, string cCCD, string address, string customerPhone, string email, string gender, int nextOfKin, DateTime? dateOfBirth, int occupationID, decimal averageIncome, int maritalStatusID, int debt, int loans, string creditTerm)
        {
            this.CustomerID = customerID;
            this.CustomerName = customerName;
            this.CCCD = cCCD;
            this.Address = address;
            this.CustomerPhone = customerPhone;
            this.Email = email;
            this.Gender = gender;
            this.NextOfKin = nextOfKin;
            this.DateOfBirth = dateOfBirth;
            this.OccupationID = occupationID;
            this.AverageIncome = averageIncome;
            this.MaritalStatusID = maritalStatusID;
            this.Debt = debt;
            this.Loans = loans;
            this.CreditTerm = creditTerm;

        }
        public Customer()
        {
            // Không cần khởi tạo gì nếu không muốn
        }

        public Customer(DataRow row)
        {
            this.CustomerID = (int)row["customerID"];
            this.CustomerName = row["customerName"].ToString();
            this.CCCD = row["CCCD"].ToString();
            this.Address = row["address"].ToString();
            this.CustomerPhone = row["customerPhone"].ToString();
            this.Email = row["email"].ToString();
            this.Gender = row["gender"].ToString();
            this.NextOfKin = (int)row["nextOfKin"];
            var dateCheckOutTemp = row["dateOfBirth"];
            if (dateCheckOutTemp.ToString() != "")
            {
                this.DateOfBirth = (DateTime?)dateCheckOutTemp;
            }

            this.OccupationID = (int)row["occupationID"];
            this.AverageIncome = (decimal)row["averageIncome"];
            this.MaritalStatusID = (int)row["maritalStatusID"];
            this.Debt = (int)row["debt"];
            this.Loans = (int)row["loans"];
            this.CreditTerm = row["creditTerm"].ToString();
        }
        private string cCCD;
        public string CCCD
        {
            get { return cCCD; }
            set { cCCD = value; }
        }
        private string creditTerm;
        public string CreditTerm
        {
            get { return creditTerm; }
            set { creditTerm = value; }
        }
        private int loans;
        public int Loans
        {
            get { return loans; }
            set { loans = value; }
        }

        private int debt;
        public int Debt
        {
            get { return debt; }
            set { debt = value; }
        }

        private int maritalStatusID;
        public int MaritalStatusID
        {
            get { return maritalStatusID; }
            set { maritalStatusID = value; }
        }

        private decimal averageIncome;
        public decimal AverageIncome
        {
            get { return averageIncome; }
            set { averageIncome = value; }
        }
        private int occupationID;
        public int OccupationID
        {
            get { return occupationID; }
            set { occupationID = value; }
        }
        private DateTime? dateOfBirth;
        public DateTime? DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
        private int nextOfKin;
        public int NextOfKin
        {
            get { return nextOfKin; }
            set { nextOfKin = value; }
        }
        private string gender;
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string customerPhone;
        public string CustomerPhone
        {
            get { return customerPhone; }
            set { customerPhone = value; }
        }
        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        private string customerName;
        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        private int customerID;
        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }
    }
}
