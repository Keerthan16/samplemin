using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LumenWorks.Framework.IO.Csv;
using Miniproject;
using System.IO;
using System.Globalization;

namespace Miniproject
{
    internal class Usgovt
    {
        //C:\Users\Keerthan Rai\Downloads\complaints.csv
        internal Usgovt()
        {

        }
        public void stories(string hdate)
        {
            /*var csvTable = new DataTable();
            using (var csvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead(@"D:\CSVFolder\CSVFile.csv")), true))
            {
                csvTable.Load(csvReader);
            }

            DateTime d = new DateTime(2015,07,10);
            DateTime d1 = new DateTime(2015, 07, 20);
            Console.WriteLine(Convert.ToString((d1.Date - d.Date).TotalDays)); */

            string path = "C:/Users/Keerthan Rai/Downloads/complaints.csv";
            string[] lines = System.IO.File.ReadAllLines(path);
            int x = 0;
            foreach (var r in lines)
            {
                if (x == 0)
                {
                    x++;
                    continue;
                }
                else
                {
                     string[] columns = r.Split(',');
                     columns[0].Trim();
                     string c = columns[0][6..];

                     if (c == hdate)
                     {
                            
                            Console.WriteLine(columns[0] + "------------------ " + columns[1]);
                     }
                }


            }
            
          

        }
        public void stories1(string Bank)
        {
         
            string path = "C:/Users/Keerthan Rai/Downloads/complaints.csv";
            string[] lines = System.IO.File.ReadAllLines(path);
            int x = 0;
            foreach (var r in lines)
            {
                if (x == 0)
                {
                    x++;
                    continue;
                }
                else
                {
                    string[] columns = r.Split(',');
                    columns[5].Trim();
                    string c = columns[5].Trim();

                    if (c == Bank)
                    {
                        
                        Console.WriteLine(columns[5] + "-------------- " + columns[1]);
                    }
                }


            }



        }
        public void custcomplaint(string custid)
        {
            
            string path = "C:/Users/Keerthan Rai/Downloads/complaints.csv";
            string[] lines = System.IO.File.ReadAllLines(path);
            int x = 0;
            foreach (var r in lines)
            {
                if (x == 0)
                {
                    x++;
                    continue;
                }
                else
                {
                    string[] columns = r.Split(',');
                    
                    string c = columns[13].Trim();

                    if (c == custid)
                    {
                        Console.WriteLine(columns[13] + "---------------- " + columns[1]);
                    }
                }


            }
        }
        public void response()
        {

            string path = "C:/Users/Keerthan Rai/Downloads/complaints.csv";
            string[] lines = System.IO.File.ReadAllLines(path);
            int x = 0;
            foreach (var r in lines)
            {
                if (x == 0)
                {
                    x++;
                    continue;
                }
                else
                {
                    string[] columns = r.Split(',');

                    string c = columns[11].Trim();

                    if (c == "Yes")
                    {
                     
                        Console.WriteLine(columns[1] + "-------"+columns[13]+"--------- " + columns[11]);
                    }
                }


            }
        }
        public void close(string closen)
        {
          
            string path = "C:/Users/Keerthan Rai/Downloads/complaints.csv";
            string[] lines = System.IO.File.ReadAllLines(path);
            int x = 0;
            foreach (var r in lines)
            {
                if (x == 0)
                {
                    x++;
                    continue;
                }
                else
                {
                    string[] columns = r.Split(',');

                    string c = columns[10].Trim();

                    if (c.ToLower() == closen)
                    {
                      
                        Console.WriteLine(columns[1] + "-------" + columns[13] + "--------- " + columns[10]);
                    }
                }


            }
        }
        public void getdiff(string custid)
        {
            string path = "C:/Users/Keerthan Rai/Downloads/complaints.csv";
            string[] lines = System.IO.File.ReadAllLines(path);
            int x = 0;
            foreach (var r in lines)
            {
                string[] columns = r.Split(',');


                if (columns[13].Trim() == custid)
                {
                    Console.WriteLine("win");
                    if (columns[0] != null && columns[9] != null)
                    {
                        CultureInfo culture = new CultureInfo("en-US");
                        Console.WriteLine(columns[0] + columns[9]);

                        DateTime d1 = Convert.ToDateTime(columns[0], culture);
                        DateTime d2 = Convert.ToDateTime(columns[9], culture);
                        Console.WriteLine("no of days to resolve");
                        Console.WriteLine(Convert.ToString((d2.Date - d1.Date).TotalDays));
                        break;

                    }

                    else
                    {
                        Console.WriteLine("one of the date is null");
                        break;
                    }
                }
            }

        }

    


    }
    class usgovteg
    {
        public static void Main()
        {
            Usgovt us = new Usgovt();
            Console.WriteLine("enter no");
            Console.WriteLine("1:year\n2:bank\n3:custid\n4:timely response\n5:closing status\n6:get date difference");
            string y = Console.ReadLine();
            switch(y){
                case "1":
                    Console.WriteLine("enter the year toget the complaints of that year");
                    string r = Console.ReadLine();
                    int e = Convert.ToInt32(r);
                    if (e > 2016 && e < 2012)
                    {
                        Console.WriteLine("Invalid year");
                    }
                    else
                    {
                        us.stories(r);

                    }
                    break;
                case "2":
                    Console.WriteLine("enter the BANK toget the complaints of that year");
                    string r1 = Console.ReadLine();
                    us.stories1(r1);
                    break;
                case "3":
                    Console.WriteLine("enter cust id");
                    string r2 = Console.ReadLine();
                    us.custcomplaint(r2);
                    break;
                case "4":
                    us.response();
                    break;
                case "5":
                    Console.WriteLine("enter the closing status details");
                    string r3 = Console.ReadLine();
                    us.close(r3.ToLower());
                    break;
                case "6":
                    Console.WriteLine("enter the cust id for date difference");
                    string r4 = Console.ReadLine().Trim();
                    us.getdiff(r4);
                    break;









            }




        }
    }
}
