using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace abcd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<student> students = new List<student>();

            Console.WriteLine("name :");
            string name = Console.ReadLine();

            Console.WriteLine("username");
            string uname = Console.ReadLine();

            Console.WriteLine("Password");
            string password = Console.ReadLine();

            student s = new student(name, uname, password);
            

            if(File.Exists("username.txt"))
            {
                StreamWriter ss = File.AppendText(@"C:\New folder\username.txt");
                ss.WriteLine($"{s.name},{s.username},{s.password}");
                ss.Close();
            }
            else
            {
                var myfile = File.Create(@"C:\New folder\username.txt");
                myfile.Close();

                StreamWriter ss = File.AppendText(@"C:\New folder\username.txt");
                ss.WriteLine($"{s.name},{s.username},{s.password}");
                ss.Close();
            }


            string path = @"C:\New folder\username.txt";
            StreamReader srr = new StreamReader(path);

            //read firstline
            string strr = srr.ReadLine();
            
            //looping untill null
            while (strr != null)
            {
                string[] stu = strr.Split(',');
                string readname = stu[0];
                string readuname = stu[1];
                string readpassword = stu[2];

                student ww = new student(readname, readuname, readpassword);
                students.Add(ww);

                //fetching next line
                strr = srr.ReadLine();
            }

            srr.Close();    

            foreach(student st in students)
            {
                Console.WriteLine($"{st.name}\t\t{st.username}\t\t{st.password}");
            }

            Console.ReadLine();

        }
    }
}
