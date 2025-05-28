namespace ReactServer.Models
{
    public class Randomator
    {
        public int Min { get; set; }
        public int Max { get; set; }
        public int Random => new Random().Next(Min, Max + 1);
    }
}
