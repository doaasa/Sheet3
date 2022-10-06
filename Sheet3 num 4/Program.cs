using System;
using System.Collections.Generic;
using System.Linq;
namespace Sheet3_num_4
{
    class Program
    {
        /* 4 - Write a program that reads a list of students { name, age, GPA },
          * and teachers { name, age, salary }
          and print the students and teachers in alphabetical order 
         Using selection sort is better */
     public class person
        {
            public int age;
            public string Name;
            public void setAge(int Age)
            {
                age = Age;
            }
            public int getAge()
            {
                return age;
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
       public class Student: person
        {

            public double GPA;
           
            public void setGPA(double gpa)
            {
                GPA = gpa;
            }
            public double getGPA()
            {
                return GPA;
            }
         
        }
        public class Teacher: person
        {
           
            public double Salary;
            public void setSalary(double sal)
            {
                Salary = sal;
            }
            public double getSalary()
            {
                return Salary;
            }
          
        }
        //public static bool operator <(Student s, Teacher t)
        //{
          
        //        return true;
        //}
        static void Main(string[] args)
        {
   
            Console.WriteLine("Selection Sort");
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

            Teacher t1 = new Teacher();
            t1.setAge(21);
            t1.setSalary(3.5);
            t1.setName("aaa");

            Teacher t2 = new Teacher();
            t2.setAge(21);
            t2.setSalary(3.5);
            t2.setName("ccc");

            Teacher t3 = new Teacher();
            t3.setAge(21);
            t3.setSalary(3.5);
            t3.setName("bbb");

            Teacher t4 = new Teacher();
            t4.setAge(21);
            t4.setSalary(3.5);
            t4.setName("ggg");

            List<person> st = new List<person> { };
            st.Add(st1);
            st.Add(st2);
            st.Add(st3);
            st.Add(st4);
            st.Add(t1);
            st.Add(t2);
            st.Add(t3);
            st.Add(t4);

            for (int i = 0; i < st.Count; i++)
            {
                for (int j = i + 1; j < st.Count; j++)
                {
                    if (st[i].Name.CompareTo(st[j].Name) == 1)
                    {
                        person temp = st[i];
                        st[i] = st[j];
                        st[j] = temp;
                    }
                }
            }

            foreach (person stu in st)
            {
                //Console.WriteLine(stu);
                Console.WriteLine(stu.getName());
                //Console.WriteLine(stu.getGPA()); //parent class canot access child class
                //Console.WriteLine(stu.getSalary());
                Console.WriteLine(stu.getAge());
            }
            //int num = 0;
            //for (int i=0;i<st.Count; i++)
            //{
            //    num = i;
            //    for (int j = i + 1; j < i; j++)
            //    {
            //        if (st[j] < st[num])
            //        {
            //        }
            //    }
            //}



            /*6-Write a program that reads a list of students {name, age, GPA }, 
          * and teachers {name, age, salary }
          * .remove duplicate teachers with the same salary
          * and print the reminded */


        }
    }
}
