using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachHangNganHang.DTO
{
    public class Employee
    {
        public Employee(int employeeID, string employeeName, string displayName, string password, int position)
        {
            this.EmployeeID = employeeID;
            this.EmployeeName = employeeName;
            this.DisplayName = displayName; 
            this.Password = password;
            this.Position = position;

        }
        public Employee(DataRow row)
        {
            this.EmployeeID = (int)row["EmployeeID"];
            this.EmployeeName = row["EmployeeName"].ToString();
            this.DisplayName = row["DisplayName"].ToString();
            this.Password = row["Password"].ToString();
            this.Position = (int)row["Position"];
        }



        private int position;
        public int Position
        {
            get { return position; }
            set { position = value; }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private string displayName;
        public string DisplayName
        {
            get { return displayName; }
            set { displayName = value; }
        }

        private string employeeName;
        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }

        private int employeeID;
        public int EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }
    }
}
