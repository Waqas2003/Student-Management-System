using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Cnsole
{
    class Program
    {

        public static void Main()
        {
            int character;
            Console.WriteLine("==========================================Student Management System==========================================");
            Console.WriteLine("1: Data Entry Of Students :");
            Console.WriteLine("2: Check Data of the Students :");
            Console.WriteLine("3: Teacher To Input Attendance Of Students : ");
            Console.WriteLine("4: Check Attendance of Students :");
            Console.WriteLine("5: Upload Marks :");
            Console.WriteLine("6: Check Marks:");
            Console.WriteLine("7: Exit");
            Console.WriteLine(" Enter Your Choice :-");
            character = Convert.ToInt32(Console.ReadLine());

            if (character == 1)
            {
                Entry();
            }
            else if (character == 2)
            {
                Data();
            }
            else if (character == 3)
            {
                Teacher();
            }

            else if (character == 4)
            {
                Student();
            }
            else if (character == 5)
            {
                uploadmarks();
            }
            else if (character == 6)
            {
                Checkmarks();
            }
            else
            { Console.WriteLine("Invalid "); }
        }

        public static void Entry()

        {
            string teacher;
            string teacher_pass;

            FileStream fs = new FileStream("text.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Console.Clear();
            Console.WriteLine("\t\t\t\t\tStudent Management System");
            Console.WriteLine("\t\t\t\t\t====login====");

            Console.WriteLine("Enter Username of the Teacher : ");
            teacher = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            teacher_pass = Console.ReadLine();

            string student_name, student_course, student_surname;
            int student_semester, student_rollno, student_age, fees_paid, fees_pending;

            Console.WriteLine("Enter How Many Students data you want to enter: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the name of Student");
                student_name = Console.ReadLine();
                Console.WriteLine("Enter the Surname of Student:");
                student_surname = Console.ReadLine();
                Console.WriteLine("Enter the Roll No of Student");
                student_rollno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Course name of Student");
                student_course = Console.ReadLine();
                Console.WriteLine("Enter the Semester of Student");
                student_semester = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Age of Student");
                student_age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the total fees paid of Student:");
                fees_paid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Pending Fees of Student:");
                fees_pending = Convert.ToInt32(Console.ReadLine());
                if (n > 1)
                { Console.WriteLine("Next Student:-"); }


                sw.WriteLine("student_name:" + student_name);
                sw.WriteLine("student_surname:" + student_surname);
                sw.WriteLine("student_rollno:" + student_rollno);
                sw.WriteLine("student_course:" + student_course);
                sw.WriteLine("student_semester:" + student_semester);
                sw.WriteLine("student_age:" + student_age);
                sw.WriteLine("fees_paid:" + fees_paid);
                sw.WriteLine("fees_pending:" + fees_pending);


            }
            sw.Close();
            fs.Close();
            Console.Clear();
            Main();
        }

        public static void Data()
        {
            FileStream fs = new FileStream("text.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string student_name;
            string student_pass;
            Console.Clear();
            Console.WriteLine("==========================================Student Management System==========================================");

            Console.WriteLine("Enter Username");
            student_name = Console.ReadLine();
            Console.WriteLine("Enter Password");
            student_pass = Console.ReadLine();
            string str1 = sr.ReadLine();
            while (str1 != null)
            {
                Console.WriteLine(str1);
                str1 = sr.ReadLine();
            }


            sr.Close();
            fs.Close();

            FileStream fs1 = new FileStream("text.txt",
                               FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            Console.Write("Enter Name to search ");
            string input = Console.ReadLine();
            string str = sw.ReadLine();
            while (str != null)
            {
                if (str.Contains(input))
                {
                    Console.WriteLine("found" + str);
                }
                str = sw.ReadLine();
            }
            Console.ReadLine();
            sw.Close();
            fs1.Close();

            Main();
        }

        public static void Teacher()
        {
            int no_of_absents, no_of_presents;
            string teacher, teacher_pass, student_name;
            Console.Clear();
            Console.WriteLine("==========================================Student Management System==========================================");

            FileStream fs = new FileStream("text2.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            Console.WriteLine("Enter Username of the Teacher : ");
            teacher = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            teacher_pass = Console.ReadLine();

            Console.WriteLine("How many Student data you want to enter: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {


                Console.WriteLine("Enter name of Student:");
                student_name = Console.ReadLine();
                Console.WriteLine("Enter presents of Students:");
                no_of_presents = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter absents of Students:");
                no_of_absents = Convert.ToInt32(Console.ReadLine());
                if (n > 1)
                { Console.WriteLine("Next Student:-"); }
                sw.WriteLine("Name OF Student:" + student_name);
                sw.WriteLine("Number Of Presents:" + no_of_presents);
                sw.WriteLine("Number Of Absents:" + no_of_absents);
            }

            sw.Close();
            fs.Close();
            Console.Clear();
            Main();

        }

        public static void Student()
        {
            FileStream fs1 = new FileStream("text2.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr1 = new StreamReader(fs1);
            string student_name;
            string student_pass;
            Console.Clear();
            Console.WriteLine("==========================================Student Management System==========================================");

            Console.WriteLine("Enter Username");
            student_name = Console.ReadLine();
            Console.WriteLine("Enter Password");
            student_pass = Console.ReadLine();
            string str1 = sr1.ReadLine();
            while (str1 != null)
            {
                Console.WriteLine(str1);
                str1 = sr1.ReadLine();
            }
            sr1.Close();
            fs1.Close();

            Main();
        }
        public static void uploadmarks()
        {
            string teacher, teacher_pass, student_name, student_course;
            int student_id, student_marks;
            Console.Clear();
            Console.WriteLine("==========================================Student Management System==========================================");

            FileStream fs = new FileStream("text3.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            Console.WriteLine("Enter Username of the Teacher : ");
            teacher = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            teacher_pass = Console.ReadLine();

            Console.WriteLine("How many Student Marks you want to enter: ");
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the name of Student");
                student_name = Console.ReadLine();
                Console.WriteLine("Enter the ID of the Student");
                student_id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Course name of Student");
                student_course = Console.ReadLine();
                Console.WriteLine("Enter the marks of Student");
                student_marks = Convert.ToInt32(Console.ReadLine());

                sw.Write(student_name);
                sw.Write("," + student_id);
                sw.Write("," + student_course);
                sw.Write("," + student_marks);

                if (n > 1)
                { Console.WriteLine("Next Student:-"); }
                sw.Close();
                fs.Close();
                Console.Clear();
                Main();
            }
        }
        public static void Checkmarks()
        {
            FileStream fs1 = new FileStream("text3.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr1 = new StreamReader(fs1);
            string student_name;
            string student_pass;

            Console.WriteLine("==========================================Student Management System==========================================");

            Console.WriteLine("Enter Username");
            student_name = Console.ReadLine();
            Console.WriteLine("Enter Password");
            student_pass = Console.ReadLine();
            string str1 = sr1.ReadLine();
            while (str1 != null)
            {
                Console.WriteLine(str1);
                str1 = sr1.ReadLine();
            }
            sr1.Close();
            fs1.Close();

            Main();

        }
    }
}