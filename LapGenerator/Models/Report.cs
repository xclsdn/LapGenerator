namespace LapGenerator.Models
{
    public class Report
    {
        public string Name { get; set; }
        public int AverageTime { get; set; }

        public int LapCount { get; set; }
        public int MaxTime { get; set; }
        public int MinTime { get; set; }
    }
}
