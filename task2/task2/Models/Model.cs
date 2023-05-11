namespace task2.Models
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CarId { get; set; }

        public Car Car { get; set; }

        public int MarkaId { get; set; }

        public Marka Marka { get; set; }


    }
}
