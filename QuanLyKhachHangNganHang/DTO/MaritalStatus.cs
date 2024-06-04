using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachHangNganHang.DTO
{
    public class MaritalStatus
    {
        public MaritalStatus(int maritalStatusID, string maritalStatusName)
        {
            this.MaritalStatusID = maritalStatusID;
            this.MaritalStatusName = maritalStatusName;

        }
        public MaritalStatus(DataRow row)
        {
            this.MaritalStatusID = (int)row["maritalStatusID"];
            this.MaritalStatusName = row["maritalStatusName"].ToString();
        }

        private string maritalStatusName;
        public string MaritalStatusName
        {
            get { return maritalStatusName; }
            set { maritalStatusName = value; }
        }

        private int maritalStatusID;
        public int MaritalStatusID
        {
            get { return maritalStatusID; }
            set { maritalStatusID = value; }
        }
    
}
}
