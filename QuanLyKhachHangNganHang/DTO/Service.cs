using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachHangNganHang.DTO
{
    public class Service
    {
        public Service(int serviceID, string serviceName, int servicePrice, string serviceDescription, string serviceStatus)
        {
            this.ServiceID = serviceID;
            this.ServiceName = serviceName;
            this.ServicePrice = servicePrice;
            this.ServiceDescription = serviceDescription;
            this.ServiceStatus = serviceStatus;

        }
        public Service(DataRow row)
        {
            this.ServiceID = (int)row["ServiceID"];
            this.ServiceName = row["ServiceName"].ToString();
            this.ServicePrice = (int)row["ServicePrice"];
            this.ServiceDescription = row["ServiceDescription"].ToString();
            this.ServiceStatus = row["ServiceStatus"].ToString();
        }

        private string serviceStatus;
        public string ServiceStatus
        {
            get { return serviceStatus; }
            set { serviceStatus = value; }
        }

        private string serviceDescription;
        public string ServiceDescription
        {
            get { return serviceDescription; }
            set { serviceDescription = value; }
        }
        private int servicePrice;
        public int ServicePrice
        {
            get { return servicePrice; }
            set { servicePrice = value; }
        }

        private string serviceName;
        public string ServiceName
        {
            get { return serviceName; }
            set { serviceName = value; }
        }

        private int serviceID;
        public int ServiceID
        {
            get { return serviceID; }
            set { serviceID = value; }
        }
    }
}
