using System;
using System.Linq;

namespace ClassroomDatabaseEFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (ClassContext context = new ClassContext())
            //{
            //    //Student = new Student();
            //    //.Name = "";
            //    //.Food = "";
            //    //.Hometown = "";

            //    Student one = new Student();
            //    one.Name = "Justin";
            //    one.Food = "Baja Blast";
            //    one.Hometown = "Wyoming, MI";

            //    Student two = new Student();
            //    two.Name = "Matt";
            //    two.Food = "Hot Wings";
            //    two.Hometown = "Flint, MI";

            //    Student three = new Student();
            //    three.Name = "Logan";
            //    three.Food = "Funyons";
            //    three.Hometown = "Plymouth, MI";

            //    Student four = new Student();
            //    four.Name = "Raston";
            //    four.Food = "Vanilla Instant Pudding";
            //    four.Hometown = "Zeeland, MI";

            //    Student five = new Student();
            //    five.Name = "Yousif";
            //    five.Food = "Deep Dish Pizza";
            //    five.Hometown = "Oak Park, MI";

            //    Student six = new Student();
            //    six.Name = "Yash";
            //    six.Food = "Detroit";
            //    six.Hometown = "Hot Cheeto Puffs";

            //    Student seven = new Student();
            //    seven.Name = "Chris";
            //    seven.Food = "Novi, MI";
            //    seven.Hometown = "Tacos";

            //    Student eight = new Student();
            //    eight.Name = "Radeen";
            //    eight.Food = "Warren, MI";
            //    eight.Hometown = "Mexican";

            //    Student nine = new Student();
            //    nine.Name = "Josh";
            //    nine.Food = "Northville, MI";
            //    nine.Hometown = "Nalesniki";

            //    Student ten = new Student();
            //    ten.Name = "Aron";
            //    ten.Food = "Sushi";
            //    ten.Hometown = "Berea, KY";

            //    Student eleven = new Student();
            //    eleven.Name = "Kasean";
            //    eleven.Food = "Detroit";
            //    eleven.Hometown = "Steak";

            //    Student twelve = new Student();
            //    twelve.Name = "Scott";
            //    twelve.Food = "Nashville Chicken";
            //    twelve.Hometown = "Lansing, MI";

            //    Student thirteen = new Student();
            //    thirteen.Name = "Brandon";
            //    thirteen.Food = "Novi, MI";
            //    thirteen.Hometown = "Sushi";

            //    context.Students.Add(one);
            //    context.Students.Add(two);
            //    context.Students.Add(three);
            //    context.Students.Add(four);
            //    context.Students.Add(five);
            //    context.Students.Add(six);
            //    context.Students.Add(seven);
            //    context.Students.Add(eight);
            //    context.Students.Add(nine);
            //    context.Students.Add(ten);
            //    context.Students.Add(eleven);
            //    context.Students.Add(twelve);
            //    context.Students.Add(thirteen);
            //    context.SaveChanges();

            //}
            bool runProgram = true;
            while (runProgram)
            {
                DisplayAllDB();
                DisplayStudentDB();
                runProgram = Validator.Validator.getContinue();
            }

            //method to display
            static void DisplayAllDB()
            {
                ClassContext context = new ClassContext();
                foreach (Student i in context.Students)
                {
                    Console.WriteLine($"{i.StudentId}. {i.Name}.");
                }
            }

            //method two
            static void DisplayStudentDB()
            {
                ClassContext context = new ClassContext();
                Console.WriteLine("Please select a student by their corresponding ID.");
                int input = (int)Validator.Validator.GetNumber(1, context.Students.Count());

                //does input match a student id? find student
                Student i = context.Students.Find(input);
                Console.WriteLine($"Favorite food: {i.Food}. Hometown: {i.Hometown}.");
            }
        }
    }
}
