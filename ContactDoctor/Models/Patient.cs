namespace ContactDoctor.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime dataTime { get; set; }
        public TimeSpan timespan { get; set; }

        public string DoctorName { get; set; }
    
    }
}
