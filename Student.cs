
namespace school
{
    public class Student
    {
        public string Name { set; get; }
        public string Family { set; get; }
        public static int Count_of_grade = 0;
        public int Grade { set; get; }
        public double Avrg { set; get; }
        public double Avrg_of_class { set; get; }

        public void display()
        {
            Console.WriteLine("class : {0}", this.Grade);
            Console.WriteLine("name & family of student : {0}", this.Name + " " + this.Family);
            Console.WriteLine("average: {0}", this.Avrg);
            Console.WriteLine("\n");
        }

    }
}
