using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp20
{
    class Program
    {

        public static int ClassA(int ab)
        {

            switch (ab)
            {
                case 1:
                    Console.WriteLine("                    ------------------------");
                    Console.WriteLine("                      YOU SELECTED MERCEDES");
                    Console.WriteLine("                    ------------------------");
                    Console.WriteLine("     MODEL: 2016");
                    Console.WriteLine("     COLOR: BLACK");
                    Console.WriteLine("     MILEGE: 70000 KM");
                    Console.WriteLine("     PRICE: RS 12000");

                    break;
                case 2:
                    Console.WriteLine("                    ------------------------");
                    Console.WriteLine("                        YOU SELECTED BMW");
                    Console.WriteLine("                    ------------------------");
                    Console.WriteLine("     MODEL: 2018");
                    Console.WriteLine("     COLOR: BLue");
                    Console.WriteLine("     MILEGE: 50000 KM");
                    Console.WriteLine("     PRICE: RS 11000");
                    break;
                case 3:
                    Console.WriteLine("");
                    Console.WriteLine("                    ------------------------");
                    Console.WriteLine("                        YOU SELECTED AUDI");
                    Console.WriteLine("                    ------------------------");
                    Console.WriteLine("     MODEL: 2020");
                    Console.WriteLine("     COLOR: MAROON");
                    Console.WriteLine("     MILEGE: 2000 KM");
                    Console.WriteLine("     PRICE: RS 11500");
                    break;
                case 4:
                    Console.WriteLine("");
                    Console.WriteLine("                    ------------------------");
                    Console.WriteLine("                      YOU SELECTED CIVIC");
                    Console.WriteLine("                    ------------------------");
                    Console.WriteLine("     MODEL: 2016");
                    Console.WriteLine("     COLOR: BLACK");
                    Console.WriteLine("     MILEGE: 20000 KM");
                    Console.WriteLine("     PRICE: RS 10000/6hrs");
                    break;
                case 5:
                    Console.WriteLine("");
                    Console.WriteLine("                    ------------------------");
                    Console.WriteLine("                      YOU SELECTED COROLLA");
                    Console.WriteLine("                    ------------------------");
                    Console.WriteLine("     MODEL: 2016");
                    Console.WriteLine("     COLOR: BLACK");
                    Console.WriteLine("     MILEGE: 2016");
                    Console.WriteLine("     PRICE: RS 10000");
                    break;
                default:
                    Console.WriteLine("WRONG INPUT.");
                    break;
            }
            return ab;
        }
        public static int ClassB(int ab)
        {
            switch (ab)
            {
                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("                    ------------------------");
                    Console.WriteLine("                        YOU SELECTED DAYZ");
                    Console.WriteLine("                    ------------------------");
                    Console.WriteLine("     MODEL: 2015");
                    Console.WriteLine("     COLOR: PEARL WHITE");
                    Console.WriteLine("     MILEGE: 8000KM");
                    Console.WriteLine("     PRICE: RS 7000");
                    break;
                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("                    ------------------------");
                    Console.WriteLine("                        YOU SELECTED AQUA");
                    Console.WriteLine("                    ------------------------");
                    Console.WriteLine("     MODEL: 2017");
                    Console.WriteLine("     COLOR: MATELLIC BLUE");
                    Console.WriteLine("     MILEGE: 22000KM");
                    Console.WriteLine("     PRICE: RS 9000");
                    break;
                case 3:
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("                    ------------------------");
                    Console.WriteLine("                        YOU SELECTED ALTO");
                    Console.WriteLine("                    ------------------------");
                    Console.WriteLine("     MODEL: 2018");
                    Console.WriteLine("     COLOR: GREY");
                    Console.WriteLine("     MILEGE: 15000KM");
                    Console.WriteLine("     PRICE: RS 6000");
                    break;
                case 4:
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("                    ------------------------");
                    Console.WriteLine("                        YOU SELECTED VITZ");
                    Console.WriteLine("                    ------------------------");
                    Console.WriteLine("     MODEL: 2015");
                    Console.WriteLine("     COLOR: BLACK");
                    Console.WriteLine("     MILEGE: 80000KM");
                    Console.WriteLine("     PRICE: RS 7000");
                    break;
                case 5:
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("                    ------------------------");
                    Console.WriteLine("                        YOU SELECTED CULTUS");
                    Console.WriteLine("                    ------------------------");
                    Console.WriteLine("     MODEL: 2019");
                    Console.WriteLine("     COLOR: PEARL WHITE");
                    Console.WriteLine("     MILEGE: 2000KM");
                    Console.WriteLine("     PRICE: RS 6500");
                    break;
                default:
                    Console.WriteLine("WRONG INPUT.");
                    break;

            }
            return ab;
        }
        public static int ClassC(int ab)
        {

            switch (ab)
            {
                case 1:
                    Console.WriteLine("                    ------------------------");
                    Console.WriteLine("                      YOU SELECTED RISHSAW");
                    Console.WriteLine("                    ------------------------");
                    Console.WriteLine("     MAKE: SAZGAR");
                    Console.WriteLine("     MODEL: 2012");
                    Console.WriteLine("     COLOR: YELLOW");
                    Console.WriteLine("     PRICE: RS 3000");

                    break;
                case 2:
                    Console.WriteLine("                    ------------------------");
                    Console.WriteLine("                        YOU SELECTED BIKE");
                    Console.WriteLine("                    ------------------------");
                    Console.WriteLine("     MODEL: 2019");
                    Console.WriteLine("     MAKE:  HONDA");
                    Console.WriteLine("     COLOR: BLACK");
                    Console.WriteLine("     PRICE: RS 2000");
                    break;
                case 3:
                    Console.WriteLine("");
                    Console.WriteLine("                    ------------------------");
                    Console.WriteLine("                        YOU SELECTED PICK-UP");
                    Console.WriteLine("                    ------------------------");
                    Console.WriteLine("     MODEL: 2010");
                    Console.WriteLine("     MAKE:  SUZUKI");
                    Console.WriteLine("     COLOR: WHITE");
                    Console.WriteLine("     PRICE: RS 5000");
                    break;
                case 4:
                    Console.WriteLine("");
                    Console.WriteLine("                    ------------------------");
                    Console.WriteLine("                      YOU SELECTED TRUCK");
                    Console.WriteLine("                    ------------------------");
                    Console.WriteLine("     MODEL: 2012");
                    Console.WriteLine("     MAKE: HYANDAI");
                    Console.WriteLine("     COLOR: BLUE");
                    Console.WriteLine("     PRICE: RS 10000");
                    break;

                default:
                    Console.WriteLine("WRONG INPUT.");
                    break;
            }
            return ab;
        }
        public static void final(string ans)
        {

            while (true)
            {
                if (ans == "YES" || ans == "yes" || ans == "Yes")
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                 ------------------------------------");
                    Console.WriteLine("                                  PLEASE PROVIDE THE PERSONAL DETAIL");
                    Console.WriteLine("                                 ------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("           PROVIDE THE FIRST NAME ONLY, WITHOUT ANY SPACES");
                    Console.WriteLine();
                    Console.Write("                                                   NAME: ");
                    string name = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("                                                   NATIONAL IDENTITY NUMBER: ");
                    string nic = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("                                                   DATE OF BOOKING OF CURRENT MONTH: ");
                    string date = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("                                                   TIME OF REQUIREMENT: ");
                    string time = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("                                                DO YOU ALSO WANT A DRIVER?(yes/no): ");
                    string driver = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("                               PROCESS HAS BEEN MADE SUCCESFULY:)");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                                   AHMED QURESHI, HANI MEHDI, HASSAM KHAN!");
                    Console.WriteLine("                                                            ALL RIGHTS RESERVED");
                    string[] file = new string[5] { "Name: " + name, "Cnic: " + nic, "Date: " + date, "Time: " + time, "Driver: " + driver };
                    File.AppendAllLines("Data.txt", file);
                    break;
                }

                else if (ans == "NO" || ans == "no" || ans == "No")
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                                        PLEASE VISIT US SOON AGAIN");
                    Console.WriteLine();
                    Console.WriteLine("                                                  AHMED QURESHI, HANI MEHDI, HASSAM KHAN!");
                    Console.WriteLine("                                                            ALL RIGHTS RESERVED");
                    break;
                }

            }
        }
        public static char ClassSelection(char dc)
        {

            {
                switch (dc)
                {
                    case 'a':
                    case 'A':
                        Console.WriteLine();
                        Console.WriteLine("                                          WELCOME TO OUR PREMIUM CLASS-EXPERIENCE THE COMFORT LIKE NEVER BEFORE ;)");
                        Cars(dc);
                        break;

                    case 'b':
                    case 'B':
                        Console.WriteLine("                                                 WELCOME TO OUR CLASS B - COMFORT WITH EASE ;)");
                        Cars(dc);
                        break;

                    case 'c':
                    case 'C':
                        Console.WriteLine("                                                WELCOME TO OUR CLASS C - FOR GENERAL USE ;)");
                        Cars(dc);
                        break;

                    case 'n':
                    case 'N':
                        Console.WriteLine("                                                             THANK YOU, VISIT AGAIN SOON!");
                        Cars(dc);
                        break;

                    default:
                        Console.WriteLine("                                                                 WRONG CLASS SELECTED ");
                        break;
                }
            }
            return dc;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("                                      ---------------------------------------------------------------------------------");
            Console.WriteLine("                                                                  HAH CAR RENTAL SYSTEM");
            Console.WriteLine("                                                    SHOP NO-69, Al-HAMARA SOCIETY, NORTH NAZIMABAD, KARACHI");
            Console.WriteLine("                                                                 PHONE-NO # 03351324422");
            Console.WriteLine("                                                                 TIMING:1200-2200 Hours");
            Console.WriteLine("                                      ---------------------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                                              HAH CAR RENTAL SYSTEM LOGIN");
            Console.WriteLine();


          back:  Console.WriteLine("                                                                  PRESS");
            Console.WriteLine("                                                               1- FOR LOGIN");
            Console.WriteLine("                                                               2- FOR SIGNUP");
            int num = int.Parse(Console.ReadLine());
            if (num == 1)
            {
                Login();
            }
            else if (num==2)
            {
                Signup();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("                                                              INVALID INPUT");
                Console.WriteLine();
                goto back;
            }

                
        }

        public static void Signup()
        {
           back: Console.WriteLine("                                                                 CREATE A USERNAME");
            string un=Console.ReadLine().ToUpper();
            Console.WriteLine();
            Console.WriteLine("                                             CREATE A PASSWORD (USERNAME AND PASSWORD SHOULD NOT BE SAME)");
            string pass = Console.ReadLine().ToUpper();
            Console.WriteLine();

             if (pass==un)
            {
                Console.WriteLine("                                                            USERNAME AND PASSWORD SHOULD NOT BE SAME");
                Console.WriteLine();
                goto back;
            }
            Console.WriteLine("                                                                ACCOUNT SUCCESSFULYY CREATED");
            Console.WriteLine();
            
            FileStream fs = new FileStream(@"C:\Users\Pirani\source\repos\ConsoleApp22\ConsoleApp22\bin\Debug\netcoreapp3.1\Login.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(un + ":" + pass);

            sw.Flush();
            sw.Close();
            fs.Close();

        back2:  Console.WriteLine("                                                           DO YOU WANT TO CREATE ANOTHER ACCOUNT:");
            String ans = Console.ReadLine(); 
            switch (ans)
            {
                case "yes":
                case "YES":
                    Console.WriteLine();
                    goto back;

                case "NO":
                case "no":
                    Login();
                    break;

                default:
                    Console.WriteLine("                                                                        INVALID INPUT");
                    goto back2;
            }
         
           
        }
            
           public static void Login()
          {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                                                                      LOGIN PAGE");
            Console.WriteLine();
            string username;
            string password;
            bool check=false;

            int i = 1;
            while(i<=3)
            {
                Console.WriteLine();
                Console.Write("                                                   USERNAME :");
                username = Console.ReadLine().ToUpper();


                Console.Write("                                                   PASSWORD :");
                password = Console.ReadLine().ToUpper();

                FileStream fs = new FileStream(@"C:\Users\Pirani\source\repos\ConsoleApp22\ConsoleApp22\bin\Debug\netcoreapp3.1\Login.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                string str = sr.ReadLine();
                while (str != null)
                {
                    
                    if (str.Contains(username + ":" + password))
                    {

                        Console.WriteLine("                                                                   LOGIN SUCCESSFUL");
                        Class();
                        check = true;
                        break;

                    }
                    str = sr.ReadLine();
                }
                if (check==true)
                {
                    break;
                }
                else if (check == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("                                                              INVALID USERNAME OR PASSWORD");
                    if (i == 3)
                    {
                        Console.WriteLine("                                                              MAXIMUM LIMIT REACHED");
                        break;
                    }
                }
                i++;
            }
            
           }

        public static void Class()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(); ;
            Console.Write("                                                           PLEASE SELECT YOUR DESIRED CLASS : ");
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("     CLASS A - THE PREMIUM ONE.");
            Console.WriteLine();
            Console.WriteLine("     CLASS B - COMFORT WITH EASE.");
            Console.WriteLine();
            Console.WriteLine("     CLASS C - NOT LESS IN COMFORT.");
            Console.WriteLine();
            Console.WriteLine("     PRESS N, TO EXIT.");

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("         PLEASE PRESS THE DESIRED CLASS LETTER : ");
            char dc = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();

            ClassSelection(dc);
        }



        public static void Cars(char dc)
        {
            if (dc == 'a' || dc == 'A')
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("      1. MERCEDES");
                Console.WriteLine();
                Console.WriteLine("      2. BMW");
                Console.WriteLine();
                Console.WriteLine("      3. AUDI");
                Console.WriteLine();
                Console.WriteLine("      4. CIVIC");
                Console.WriteLine();
                Console.WriteLine("      5. COROLLA");
                Console.WriteLine();
                Console.Write("             PLEASE SELECT YOUR CHOICE :");
                int ab = Convert.ToInt16(Console.ReadLine());
                ClassA(ab);

                Console.WriteLine("                        ARE YOU SURE, YOU WANT TO RENT THIS CAR?(yes/no)");
                string ans = Console.ReadLine();
                Program.final(ans);
            }



            else if (dc == 'b' || dc == 'B')
            {
                Console.WriteLine("      1. DAYZ");
                Console.WriteLine();
                Console.WriteLine("      2. AQUA");
                Console.WriteLine();
                Console.WriteLine("      3. ALTO");
                Console.WriteLine();
                Console.WriteLine("      4. VITZ");
                Console.WriteLine();
                Console.WriteLine("      5. CULTUS");
                Console.WriteLine();
                Console.Write("PLEASE SELECT YOUR CHOICE :");
                int ab = Convert.ToInt16(Console.ReadLine());
                ClassB(ab);

                Console.WriteLine("                        ARE YOU SURE, YOU WANT TO RENT THIS CAR?(yes/no)");
                string ans = Console.ReadLine();
                Program.final(ans);
            }
            else if (dc == 'C' || dc == 'c')
            {
                Console.WriteLine("      1. RIKHSHAW");
                Console.WriteLine();
                Console.WriteLine("      2. BIKE");
                Console.WriteLine();
                Console.WriteLine("      3. PICK-UP");
                Console.WriteLine();
                Console.WriteLine("      4. TRUCK");
                Console.WriteLine();
                Console.Write("      PLEASE SELECT YOUR CHOICE :");
                int ab = Convert.ToInt16(Console.ReadLine());
                ClassC(ab);

                Console.WriteLine("                        ARE YOU SURE, YOU WANT TO RENT THIS CAR?(yes/no)");
                string ans = Console.ReadLine();
                Program.final(ans);
            }

        }








    }
}


