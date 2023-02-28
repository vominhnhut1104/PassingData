namespace PassingData.Models
{
    public class Customer
    {
        public int CustomerId { get; set; } 

        public string Name { get; set; }

        public string Address { get; set; } 

        public Customer()
        {
            CustomerId = 1;
            Name = "Nhut";
            Address = "HCM";
        }


    }
}
