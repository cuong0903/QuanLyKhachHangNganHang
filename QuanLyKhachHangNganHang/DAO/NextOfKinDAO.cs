using QuanLyKhachHangNganHang.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachHangNganHang.DAO
{
    public class NextOfKinDAO
    {
        public string CustomerName { get; }

        private static NextOfKinDAO instance;

        public static NextOfKinDAO Instance
        {
            get { if (instance == null) instance = new NextOfKinDAO(); return NextOfKinDAO.instance; }
            private set { NextOfKinDAO.instance = value; }
        }
        private NextOfKinDAO() { }


        // Phương thức lấy danh sách Next of Kin
        public List<NextOfKin> GetListNextOfKin()
        {
            List<NextOfKin> list = new List<NextOfKin>();

            string query = "SELECT * FROM dbo.tblNextOfKin";


            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                NextOfKin service = new NextOfKin(item);
                list.Add(service);
            }
            return list;
        }
        // Phương thức thêm Next of Kin mới vào cơ sở dữ liệu
        public bool InsertNextOfKin(int CustomerID, string NextOfKinName, string NextOfKinRelationship, string NextOfKinPhone, string NextOfKinAddress)
        {
            // Kiểm tra xem CustomerID có tồn tại hay không
            if (!CustomerDAO.Instance.CustomerExists(CustomerID))
            {
                // CustomerID không tồn tại, trả về false
                return false;
            }
            // Tạo mảng các tham số
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@CustomerID", CustomerID),
            new SqlParameter("@NextOfKinName", NextOfKinName),
            new SqlParameter("@NextOfKinRelationship", NextOfKinRelationship),
            new SqlParameter("@NextOfKinPhone", NextOfKinPhone),
            new SqlParameter("@NextOfKinAddress", NextOfKinAddress)
            };

            // Query SQL với các tham số đã tạo
            string query = "INSERT INTO dbo.tblNextOfKin (CustomerID, NextOfKinName, NextOfKinRelationship, NextOfKinPhone, NextOfKinAddress) VALUES (@CustomerID, @NextOfKinName, @NextOfKinRelationship, @NextOfKinPhone, @NextOfKinAddress)";

            // Thực thi phương thức ExcuteNonQuery với query và parameters
            int result = DataProvider.Instance.ExcuteNonQuery(query, parameters);

            // Trả về true nếu có hàng được ảnh hưởng, ngược lại trả về false
            return result > 0;
        }
        // Phương thức cập nhật thông tin Next of Kin
        public bool UpdateNextOfKin(int NextOfKinID, int CustomerID, string NextOfKinName, string NextOfKinRelationship, string NextOfKinPhone, string NextOfKinAddress)
        {
            // Tạo mảng các tham số
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@NextOfKinID", NextOfKinID),
            new SqlParameter("@CustomerID", CustomerID),
            new SqlParameter("@NextOfKinName", NextOfKinName),
            new SqlParameter("@NextOfKinRelationship", NextOfKinRelationship),
            new SqlParameter("@NextOfKinPhone", NextOfKinPhone),
            new SqlParameter("@NextOfKinAddress", NextOfKinAddress)
            };

            // Query SQL với các tham số đã tạo
            string query = "UPDATE dbo.tblNextOfKin SET CustomerID = @CustomerID, NextOfKinName = @NextOfKinName, NextOfKinRelationship = @NextOfKinRelationship, NextOfKinPhone = @NextOfKinPhone, NextOfKinAddress = @NextOfKinAddress WHERE NextOfKinID = @NextOfKinID";

            // Thực thi phương thức ExecuteNonQuery với query và parameters
            int result = DataProvider.Instance.ExcuteNonQuery(query, parameters);

            // Trả về true nếu có hàng được ảnh hưởng, ngược lại trả về false
            return result > 0;
        }
        // Phương thức xóa Next of Kin khỏi cơ sở dữ liệu
        public bool DeleteNextOfKin(int NextOfKinID)
        {

            // Tạo mảng các tham số
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@NextOfKinID", NextOfKinID)
            };

            // Query SQL với các tham số đã tạo
            string query = "DELETE FROM tblNextOfKin WHERE NextOfKinID = @NextOfKinID";

            // Thực thi phương thức ExcuteNonQuery với query và parameters
            int result = DataProvider.Instance.ExcuteNonQuery(query, parameters);

            // Trả về true nếu có hàng được ảnh hưởng, ngược lại trả về false
            return result > 0;
        }
        // Phương thức lấy danh sách Next of Kin dựa trên ID của khách hàng
        public List<NextOfKin> GetListNextOfKinByCustomerID(int customerID)
        {
            List<NextOfKin> nextOfKinList = new List<NextOfKin>();

            string query = "SELECT * FROM tblNextOfKin WHERE CustomerID = @CustomerID";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@CustomerID", customerID);

            DataTable data = DataProvider.Instance.ExcuteQuery(query, parameters);
            foreach (DataRow item in data.Rows)
            {
                NextOfKin nextOfKin = new NextOfKin(item);
                nextOfKinList.Add(nextOfKin);
            }
            return nextOfKinList;
        }
    }
}
