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
                using (StreamReader sr = new StreamReader("staff.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
                        string[] substrings = result.Split(separator, StringSplitOptions.None)
                    }
                    sr.Close();
                }
            }
            else
            {
                Console.WriteLine("Reading text file didn't work.");
            }

            return <List>myStaff;
        }
    }
}
