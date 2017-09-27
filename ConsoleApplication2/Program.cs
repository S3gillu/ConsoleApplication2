using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;




namespace ConsoleApplication2
{


    class Emp
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public long phone { get; set; }
        public int age { get; set; }

  



    }
    class Address
    {
       public string AddressLine  { get; set; }

    }

    class program1
    {
        static void Main(string[] args)
        {

            string json = File.ReadAllText(@"E:\DayUsers\Shubham\Projects\C#\22_07_2017_test_c#\ConsoleApplication2\ConsoleApplication2\bin\New.json");
            List<Emp> result = test(json);

            Console.WriteLine("The Data Fetched From Json File is As : \n");
            foreach (var s in result)
            {
                Console.WriteLine("ID : " + s.id + "  " + "Name : " + s.name + "   " + "Email : " + s.email + "  " + "Phone : " + s.phone + "  " + "  Age : " + s.age);
            }

            Console.WriteLine("\n List count :{0} \n", result.Count());

            Console.WriteLine("Here You Can Perform CRUD  :\n");
            Console.WriteLine();

            int input;
            
            do
            {


                Console.WriteLine("\n Press 1 For  Adding an Employee");
                Console.WriteLine("\n Press 2 To Delte an Employee");
                Console.WriteLine("\n Press 3 To Update an Employee");
                Console.WriteLine("\n Press Enter One Time To Exit \n ");


                input = Convert.ToInt32(Console.ReadLine());




                switch (input)
                {

                    case 1:
                        {
                            Emp s = new Emp();
                            Console.WriteLine("\n Enter ID number :");
                            s.id = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\n Enter the Name : ");
                            s.name = Console.ReadLine();

                            Console.WriteLine("\n Enter the Email : ");
                            s.email = Console.ReadLine();

                            Console.WriteLine("\n Enter the Phone :\n ");
                            s.phone = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\n Enter the Age :\n");
                            s.phone = Convert.ToInt32(Console.ReadLine());
                            result.Add(s);
                            Console.WriteLine();

                            foreach (var p in result)
                            {
                                Console.Write("ID : " + p.id + " " + "Name : " + p.name + " " + "E-mail : " + p.email + " " + "Phone: " + p.phone + " " + " " + "Age : " + p.age);
                                Console.WriteLine();
                            }
                            Console.WriteLine("New List count :{0} ", result.Count);
                            Console.WriteLine();
                            Console.WriteLine("Data Is Created!!!");
                            Console.WriteLine();
                            Console.WriteLine();



                        }
                        break;




                    case 2:

                        {
                            Console.WriteLine("Enter the Id you want to Delete :");
                            int id = Convert.ToInt32(Console.ReadLine());
                            var list = result.FirstOrDefault(x => x.id == id);
                            result.RemoveAll(x => x.id == id);
                            Console.Write("Removed :  " + " ID : " + list.id + " " + "Name : " + list.name + " " + "E-mail : " + list.email + " " + "Phone: " + list.phone + " " + " " + "Age : " + list.age);
                            Console.WriteLine(" \n The Remaining List Is as follows: ");

                            foreach (var k in result)
                            {
                                Console.Write("ID : " + k.id + " " + "Name : " + k.name + " " + "E-mail : " + k.email + " " + "Phone: " + k.phone + " " + " " + "Age : " + k.age);
                                Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("You Can Perform Further perations.....:)");
                            Console.WriteLine();
                            Console.WriteLine();
                        }

                        break;



                    case 3:

                        {
                            Emp p = new Emp();
                            Console.WriteLine("Enter the Name you want to Update the records for:");
                            string sau = Console.ReadLine();
                            var change = result.FirstOrDefault(ss => ss.name == sau);


                            Console.WriteLine("Enter New Name");
                            string newName = (Console.ReadLine());

                            Console.WriteLine("Enter New Id");
                            int newId = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter New Age");
                            int newAge = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter New Phone");
                            long newPhone = Convert.ToInt64(Console.ReadLine());

                            change.name = newName;

                            change.age = newAge;
                            change.id = newId;
                            change.phone = newPhone;
                            Console.WriteLine("");
                            Console.WriteLine(" Updated List is : ");
                            Console.WriteLine();
                            Console.WriteLine("Name : " + change.name + " " + "Age : " + change.age + " " + "Id : " + change.id + " " + "Phone : " + change.phone + " ");
                            Console.WriteLine();
                            Console.WriteLine("Data Updated...");
                            Console.WriteLine();

                            Console.WriteLine();
                        }
                        break;




                    default:
                        {
                            Console.WriteLine(" Sorry !! Wrong Key !!! Please try Again");
                        }
                        break;

                }
            }
            while (input != 5);
            Console.ReadLine();




        }

        private static List<Emp> test(string json)
        {
            return JsonConvert.DeserializeObject<List<Emp>>(json);
        }
    }

}







        




    

