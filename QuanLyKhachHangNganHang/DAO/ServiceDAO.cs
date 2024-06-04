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
    public class ServiceDAO
    {
        private static ServiceDAO instance;

        public static ServiceDAO Instance
        {
            get { if (instance == null) instance = new ServiceDAO(); return ServiceDAO.instance; }
            private set { ServiceDAO.instance = value; }
        }
        private ServiceDAO() { }
        public List<Service> GetListService()
        {
            List<Service> list = new List<Service>();

            string query = "SELECT * FROM dbo.tblService";


            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Service service = new Service(item);
                list.Add(service);
            }
            return list;
        }
        public bool InsertService(string ServiceName, int ServicePrice, string ServiceDescription, string ServiceStatus)
        {
            // Tạo mảng các tham số
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@ServiceName", ServiceName),
            new SqlParameter("@ServicePrice", ServicePrice),
            new SqlParameter("@ServiceDescription", ServiceDescription),
            new SqlParameter("@ServiceStatus", ServiceStatus)
            };

            // Query SQL với các tham số đã tạo
            string query = "INSERT INTO dbo.tblService (ServiceName, ServicePrice, ServiceDescription, ServiceStatus) VALUES (@ServiceName, @ServicePrice, @ServiceDescription, @ServiceStatus)";

            // Thực thi phương thức ExcuteNonQuery với query và parameters
            int result = DataProvider.Instance.ExcuteNonQuery(query, parameters);

            // Trả về true nếu có hàng được ảnh hưởng, ngược lại trả về false
            return result > 0;
        }

        public bool UpdateService(int ServiceID, string ServiceName, int ServicePrice, string ServiceDescription, string ServiceStatus)
        {
            // Tạo mảng các tham số
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@ServiceID", ServiceID),
            new SqlParameter("@ServiceName", ServiceName),
            new SqlParameter("@ServicePrice", ServicePrice),
            new SqlParameter("@ServiceDescription", ServiceDescription),
            new SqlParameter("@ServiceStatus", ServiceStatus)
            };

            // Query SQL với các tham số đã tạo
            string query = "UPDATE dbo.tblService SET ServiceName = @ServiceName, ServicePrice = @ServicePrice, ServiceDescription = @ServiceDescription, ServiceStatus = @ServiceStatus WHERE ServiceID = @ServiceID";

            // Thực thi phương thức ExecuteNonQuery với query và parameters
            int result = DataProvider.Instance.ExcuteNonQuery(query, parameters);

            // Trả về true nếu có hàng được ảnh hưởng, ngược lại trả về false
            return result > 0;
        }

        public bool DeleteService(int ServiceID)
        {


            // Tạo mảng các tham số
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@ServiceID", ServiceID)
            };

            // Query SQL với các tham số đã tạo
            string query = "DELETE FROM tblService WHERE ServiceID = @ServiceID";

            // Thực thi phương thức ExcuteNonQuery với query và parameters
            int result = DataProvider.Instance.ExcuteNonQuery(query, parameters);

            // Trả về true nếu có hàng được ảnh hưởng, ngược lại trả về false
            return result > 0;
        }

        internal List<Service> SearchService(string serviceSearch)
        {
            List<Service> list = new List<Service>();

            string query = string.Format("SELECT * FROM tblService WHERE  ServiceID LIKE N'%{0}%'     OR ServiceName LIKE N'%{0}%'     OR ServiceID LIKE N'%{0}%'     OR ServicePrice LIKE N'%{0}%'     OR ServiceDescription LIKE N'%{0}%'     OR ServiceStatus LIKE N'%{0}%';", serviceSearch);


            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Service service = new Service(item);
                list.Add(service);
            }
            return list;
        }
        public Service GetServiceByID(int serviceID)
        {
            string query = "SELECT * FROM dbo.tblService WHERE ServiceID = @ServiceID";
            Dictionary<string, object> parameters = new Dictionary<string, object>
    {
        { "@ServiceID", serviceID }
    };

            DataTable data = DataProvider.Instance.ExcuteQuery(query, parameters);
            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                return new Service(row);
            }
            return null;
        }


    }
}
