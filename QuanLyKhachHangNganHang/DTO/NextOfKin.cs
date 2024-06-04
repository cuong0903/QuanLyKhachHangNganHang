using System.Data;

public class NextOfKin
{
    public NextOfKin(int nextOfKinID, int customerID, string nextOfKinName, string nextOfKinRelationship, string nextOfKinPhone, string nextOfKinAddress)
    {
        this.NextOfKinID = nextOfKinID;
        this.CustomerID = customerID;
        this.NextOfKinName = nextOfKinName;
        this.NextOfKinRelationship = nextOfKinRelationship;
        this.NextOfKinPhone = nextOfKinPhone;
        this.NextOfKinAddress = nextOfKinAddress;
      
    }

    public NextOfKin(DataRow row)
    {
        this.NextOfKinID = (int)row["NextOfKinID"];
        this.CustomerID = (int)row["CustomerID"];
        this.NextOfKinName = row["NextOfKinName"].ToString();
        this.NextOfKinRelationship = row["NextOfKinRelationship"].ToString();
        this.NextOfKinPhone = row["NextOfKinPhone"].ToString();
        this.NextOfKinAddress = row["NextOfKinAddress"].ToString();
        
    }

 
    public string NextOfKinAddress { get; set; }
    public string NextOfKinPhone { get; set; }
    public string NextOfKinRelationship { get; set; }
    public string NextOfKinName { get; set; }
    public int CustomerID { get; set; }
    public int NextOfKinID { get; set; }
}
