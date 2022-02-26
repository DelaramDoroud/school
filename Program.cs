using System;

namespace school
{   
   
    public class Program
    {
        public static void Main(string[] args)
        {
            School school = new School();
            Double i;        
            Basic new_student = new Basic();
            Basic stu = new Basic();           
            string answer = "null";
            Boolean check = true;
            double num_of_menu;
            while (check ==true)
            {
                Console.WriteLine("**************");
                Console.WriteLine("what d you want do? \n 1.show grades \n 2.show all students \n " +
                    "3.show all avereges \n 4.show information of any grade that you want \n " +
                    "5.show total average of school \n 6.show all students with average equal or biger than toatal average" +
                    "\n 7.add grade \n 8.show all classes");
                num_of_menu = Convert.ToDouble(Console.ReadLine());
                switch (num_of_menu)
                {
                    case 1:
                        if (school.Classes.Count() == 0)
                            Console.WriteLine("there is no class. first, you need to add a class");
                        else
                        {                          
                            foreach (var el in school.Classes)
                            {
                                
                                Console.WriteLine(el.St[0].Grade);

                            }
                              
                        }
                        break;      
                    case 2:
                        if (school.Classes.Count() == 0)
                            Console.WriteLine("there is no student. first, you need to add a class");
                        else
                        {
                            foreach (var el in school.Classes)
                            {
                                for (int n = 0; n < el.St.Count(); n++)
                                    Console.WriteLine(el.St[n].Name + " " + el.St[n].Family);                              
                            }
                                
                        }                        
                        break;
                    case 3:
                        if (school.Classes.Count() == 0)
                            Console.WriteLine("there is no mark. first, you need to add a class");
                        else
                        {
                            foreach (var el in school.Classes)
                            {
                                for (int n = 0; n < el.St.Count(); n++)
                                    Console.WriteLine(el.St[n].Avrg);                               
                            }
                                
                        }
                        break;
                    case 4:
                        if (school.Classes.Count() == 0)
                            Console.WriteLine("there is no class. first, you need to add a class");
                        else
                            Console.WriteLine("which grade do you want information about?");
                        i = Convert.ToDouble(Console.ReadLine());
                        foreach (var el in school.Classes)
                            if (el.St[0].Grade == i)
                            {
                                for (int n = 0; n < el.St.Count(); n++)
                                {
                                    
                                    Console.WriteLine("name & family : {0}", el.St[n].Name + " " + el.St[n].Family);
                                    Console.WriteLine("average : {0}", el.St[n].Avrg);
                                }
                                Console.WriteLine("average of class : {0}", el.St[el.St.Count()-1].Avrg_of_class);

                            }
                                break;
                    case 5:
                        if (school.Classes.Count() == 0)
                            Console.WriteLine("oops! there is no class.");
                        else
                            Console.WriteLine("total average : {0}", School.total);
                        break;
                    case 6: // mohasebeye moadel haye bozorg tar az moadele kol
                            
                        if (School.All_avrage.Count() == 0)
                            Console.WriteLine("oops! there is no class.");
                        else
                        {
                            var finall = from m in School.All_avrage
                                         where m >= School.total
                                         select m;
                            foreach (var el in finall)
                            {

                                foreach (var ell in school.Classes)
                                {
                                    for (int b = 0; b < ell.St.Count(); b++)
                                    {
                                        if (ell.St[b].Avrg == el)
                                            stu.print2(ell.St[b]);
                                    }
                                }
                                

                            }
                        }                           
                        break;
                    case 7:
                        Console.WriteLine("how many classes do you want to add ?");
                        int num_of_class = Convert.ToInt32(Console.ReadLine());
                        num_of_class += Student.Count_of_grade;
                        for (int g = Student.Count_of_grade + 1; g <= num_of_class; g++)
                        {
                            Basic cls = new Basic();
                            Console.WriteLine("grade :{0}", g);
                            Console.WriteLine("how many students do you want to add ?");
                            double num_of_stud = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("enter student's properties of classes");
                            for (int i4 = 0; i4 < num_of_stud; i4++)
                            {
                                Student stt = new Student();
                                School stu1 = new School();
                                Student.Count_of_grade = g;
                                stt.Grade = Student.Count_of_grade;
                                Console.WriteLine("enter name");
                                stt.Name = Console.ReadLine();
                                Console.WriteLine("enter family");
                                stt.Family = Console.ReadLine();
                                Console.WriteLine("enter avrg");
                                stt.Avrg = Convert.ToDouble(Console.ReadLine());
                                school.total_average(stt.Avrg);                               
                                cls.add_student(stt);
                                stu1.get_avarages(stt.Avrg);                                
                                // List<Basic> test = new List<Basic>();
                                //test.Add(stt);                                

                            }
                            school.Classes.Add(cls);
                        }
                        //if (school.classes.Count()!= 0)
                        //string dd = school.classes[0].st[2].family;
                        //school.classes[0].



                        /*double num_of_class;
                        double num_of_students;
                        Console.WriteLine("how many classes do you want to add ?");
                        num_of_class = Convert.ToDouble(Console.ReadLine());
                        num_of_class += Student.count_of_grade;                      
                        for (int g = Student.count_of_grade + 1 ; g <= num_of_class; g++)
                        {
                            List<string> full_name = new List<string>();
                            List<double> marks = new List<double>();
                            Console.WriteLine("grade :{0}", g);
                            School.grades.Add(g);
                            Console.WriteLine("how many students do you want to add ?");
                            num_of_students = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("enter student's properties of classes");
                            for (int j = 0; j < num_of_students; j++)
                            {
                                Student stu = new Student();
                                Student stu1 = new Student();
                                Console.WriteLine("enter name");
                                Student.count_of_grade = g;
                                stu.grade = Student.count_of_grade;
                                stu.name = Console.ReadLine();
                                Console.WriteLine("enter family");
                                stu.family = Console.ReadLine();
                                //full_name.Add(stu.name + " " + stu.family);
                                School.students.Add(stu.name + " " + stu.family);
                                Console.WriteLine("enter avrg");
                                stu.avrg = Convert.ToDouble(Console.ReadLine());
                                //marks.Add(stu.avrg);
                                School.all_marks.Add(stu.avrg);
                                sum += stu.avrg;
                                count_of_averages++;
                                new_student.get_student(stu);
                                stu1.get_avarages(stu.avrg);

                            }
                            //School.students.Add(g, full_name);
                            //School.all_marks.Add(g, marks);

                        }*/

                        // mohasebeye moadele kol----------------------------
                        School.total = School.Sum / School.Count_of_averages;
                        /*for (int f = 0; f < Student.all_avrage.Count(); f++)
                            Console.WriteLine(Student.all_avrage[f].Value);*/
                        break;
                    case 8:
                        if (school.Classes.Count() == 0)
                            Console.WriteLine("there is no mark. first, you need to add a class");
                        else
                        {
                            
                            foreach (var el in school.Classes)
                            {
                                for (int n = 0; n < el.St.Count(); n++)
                                    stu.print2(el.St[n]);
                                Console.WriteLine("average of class : {0} \n ************", el.St[el.St.Count()-1].Avrg_of_class);


                            }

                        }                    
                        break;
                }     
                
                Console.WriteLine("do you want to continue ?");
                answer = Console.ReadLine();
                if (answer == "no")             
                    check = false; 
            }            
        
        }
    }
}
