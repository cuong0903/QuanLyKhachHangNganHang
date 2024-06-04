using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachHangNganHang.DTO
{
    public class Occupation
    {
        public Occupation(int occupationID, string occupationName, string occupationAbbreviation)
        {
            this.OccupationID = occupationID;
            this.OccupationName = occupationName;
            this.OccupationAbbreviation = occupationAbbreviation;

        }
        public Occupation(DataRow row)
        {
            this.OccupationID = (int)row["occupationID"];
            this.OccupationName = row["occupationName"].ToString();
            this.OccupationAbbreviation = row["occupationAbbreviation"].ToString();

        }


        private string occupationAbbreviation;
        public string OccupationAbbreviation
        {
            get { return occupationAbbreviation; }
            set { occupationAbbreviation = value; }
        }

        private string occupationName;
        public string OccupationName
        {
            get { return occupationName; }
            set { occupationName = value; }
        }

        private int occupationID;
        public int OccupationID
        {
            get { return occupationID; }
            set { occupationID = value; }
        }
    
}
}
