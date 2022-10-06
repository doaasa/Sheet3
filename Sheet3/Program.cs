using System;
using System.Collections.Generic;

namespace Sheet3
{
    static class helperEX
    {
        public static List<Program.Student> Filter(this List<Program.Student> ls)
        {
            List<Program.Student> temp = new List<Program.Student> { };
            return temp;
        }
    }
    class Program
    {
        
       public class Student
        {
            public int age;
            public double GPA;
            public string Name;
            public void setAge(int Age)
            {
                age = Age;
            }
            public int getAge()
            {
                return age;
            }
            public void setGPA(double gpa)
            {
                GPA = gpa;
            }
            public double getGPA()
            {
                return GPA;
            }
            public void setName(string name)
            {
                Name = name;
            }
            public string getName()
            {
                return Name;
            }
        }
        static void Main(string[] args)
        {
            /*1-Write a program that reads a list of students {name, age, GPA },
             * and prints the list in alphabetical order.*/

            // tostring function (convert class object to string)
            Student st1 = new Student();
            st1.setAge(21);
            st1.setGPA(3.5);
            st1.setName("Doaa");

            Student st2 = new Student();
            st2.setAge(25);
            st2.setGPA(2.5);
            st2.setName("Rania");

            Student st3 = new Student();
            st3.setAge(15);
            st3.setGPA(4);
            st3.setName("Rahma");

            Student st4 = new Student();
            st4.setAge(20);
            st4.setGPA(3.1);
            st4.setName("Yara");

            List<Student> st = new List<Student> { };
            st.Add(st1);
            st.Add(st2);
            st.Add(st3);
            st.Add(st4);
            st.Add(st1);
            st.Add(st1);
            st.Add(st1);

            //Console.WriteLine("SORTING ALPHABITICALLY");
            //for (int i = 0; i < st.Count; i++)
            //{
            //    for (int j = i + 1; j < st.Count; j++)
            //    {
            //        if (st[i].Name.CompareTo(st[j].Name) == 1)
            //        {
            //            Student temp = st[i];
            //            st[i] = st[j];
            //            st[j] = temp;
            //        }
            //    }
            //}
            //st.Sort((x, y) => string.Compare(x.Name, y.Name));  //to sort
            //foreach (Student stu in st)
            //{
            //    Console.WriteLine(stu.getName());
            //    Console.WriteLine(stu.getGPA());
            //    Console.WriteLine(stu.getAge());
            //}

            /* 2-Write a program that reads a list of students {name, age, GPA }, 
             * and prints the top 3 older student */

            Console.WriteLine("SORTING NUMERICALLY");
            for(int i=0;i<st.Count; i++)
            {
                for(int j=i+1; j<st.Count; j++)
                {
                    if (st[i].age.CompareTo(st[j].age) == -1)
                    {
                        Student temp = st[i];
                        st[i] = st[j];
                        st[j] = temp;
                    }
                }
            }
            //st.Sort((x, y) => x.age.CompareTo(y.age));  //to sort
            //st.Reverse();  // to get the great number
            int k = 0;
            //foreach (Student stu in st)
            //{
            //    Console.WriteLine(stu.getName());
            //    Console.WriteLine(stu.getGPA());
            //    Console.WriteLine(stu.getAge());
            //    k++;
            //    if (k == 3)
            //    {
            //        break;
            //    }
            //}

            //  /*3-Write a program that reads a list of student {name, age, GPA }, 
            //   * and filter student with GPA > 3.0 and age =20*/

            Console.WriteLine("SORTING GPA AND AGE");
            foreach (Student stu in st)
            {
                if (stu.age == 20 && stu.GPA > 3.0)
                {
                    Console.WriteLine(stu.getName());
                    Console.WriteLine(stu.getGPA());
                    Console.WriteLine(stu.getAge());
                }
            }


            //  /*5-Write a program that reads a list of students {name, age, GPA }, 
            //   * and prints the most 3 names duplicate */

            Console.WriteLine("Count Duplicate");  //prob: print as number of dublicate
            for (int i = 0; i < st.Count; i++)
            {
                int count = 0;
                int index = 0;
                for (int j = 1; j < st.Count; j++)
                {
                    if (st[i].Name == st[j].Name)
                    {
                        count++;
                    }
                }
                if (count > 3)
                {
                    index = i;
                }
                if (index > 0)
                {
                    Console.WriteLine(st[index].Name);
                    Console.WriteLine(count);
                }
            }


            string x;
            ConsoleKey.Enter.ToString();
            x = ConsoleKey.Enter.ToString();

           char b= Console.ReadKey().KeyChar;
            string[] arr = new string[] { };
            int i = 0;
           
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                arr[i] = Console.ReadLine();
            }
        }
    }

}
