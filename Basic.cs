namespace school
{
    public class Basic
    {
        public List<Student> St = new List<Student>();
        public double Avg = 0;
        public void add_student(Student s)
        {

            if (St.Count() == 0)
            {
                Avg = s.Avrg;
            }
            else
            {
                double temp = s.Avrg + (St.Count() * Avg);
                Avg = temp / (St.Count() + 1);

            }
            s.Avrg_of_class = Avg;
            St.Add(s);

        }
        public void print2(Student s)
        {
            s.display();

        }
    }
}
