namespace BussinessObject
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public override string ToString()
        {
            return ContactName;
        }
    }
}
