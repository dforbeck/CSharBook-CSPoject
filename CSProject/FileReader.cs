using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSProject
{
    class FileReader
    {
        public List<Staff> ReadFile()
        {
            List<Staff> myStaff = new List<Staff>();
            string[] result = new string[2];
            string path = "staff.txt"; // file is in Debug folder with .exe
            string[] separator = { ", " };

            if (File.Exists("staff.txt"))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (sr.EndOfStream != true)
                    {
                        string employeeLine = sr.ReadLine();
                        result = employeeLine.Split(separator, StringSplitOptions.None);
                        
                        if (result[1] == "Manager")
                        {
                            Manager memberManager = new Manager(result[0]);
                            myStaff.Add(memberManager);
                        }
                        else if (result[1] == "Admin")
                        {
                            Admin memberAdmin = new Admin(result[0]);
                            myStaff.Add(memberAdmin);
                        }
                    }
                    sr.Close();
                }
            }
            else Console.WriteLine("Our test file does not exist.");

            return myStaff;
        }
    }
}
