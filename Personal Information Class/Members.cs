namespace Personal_Information_Class
{
    public class Members
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public Members()
        {
            Name = "Jane";
            Address = "Waterloo";
            Age = 24;
            PhoneNumber = "1234-1234";
        }
        public Members(string name, string address, int age, string phoneNumber)
        {
            Name = name;
            Address = address;
            Age = age;
            PhoneNumber = phoneNumber;
        }
    }
}