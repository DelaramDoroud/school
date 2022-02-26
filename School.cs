namespace school
{
    public class School
    {
        public static double total;
        public static List<double> All_avrage { get; set; } = new List<double>();
        public List<Basic> Classes = new List<Basic>();
        public static double Sum = 0;
        public static int Count_of_averages = 0;
        public void total_average(double ave)
        {
            Sum += ave;
            Count_of_averages++;
        }
        public void get_avarages(double ave)
        {
            All_avrage.Add(ave);

        }
    }
}
