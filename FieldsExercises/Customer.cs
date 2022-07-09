namespace FieldsExercises
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>(); // requires initialization into an empty list
        // Order list will be initialized to an empty list regardless what constructor is called
        //public Customer() // another way of initialization of a list
        //{
        //    Orders = new List<Order>();
        //}
        public Customer(int id)
        {
            this.Id = id;
        }
        public Customer(int id, string name) : this(id) //this(id) means we don't need
                                                        //to write this.Id = id; in this constructo
        {
            this.Name = name;
        }
        public void Promote()
        {
            Orders = new List<Order>();
            // ....
        }
    }
}