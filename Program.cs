using System;
using System.Collections.Generic;

namespace ClsWrkDelegate
{
    class Program
    {
        // Step no 1 : Declaring Delegate
        // Delegate also kind of interfaces ( it is more resemblense to interfaces
        // How you declare the delegate
        // delegate --> keyword
        // int --> output
        // MyDelegate --> the name of delegate
        // (string msg) --> means input parameter
        // when you used ; at the end of method , it means this is non implemntation method --> abstract method
        public delegate void MyDelegate(string msg);
        public delegate int MultipleArgDelegate(int x, int y);

        static void Main(string[] args)
        {
            // //// Step no 2b: Set  an target method

            // // Car car1 = new Car();
            // //option no 1
            // // del object reference name
            // // MyDelegate del = TargetMethod;
            // //   input parameters => body of expression ( return type as well included)

            // // this is the way of lambda expression
            //  MyDelegate del = (string msg) =>  Console.WriteLine(msg); 

            // // Step no 3 : Invoking Delegate

            // del("Hello world");

            // Console.WriteLine("----------------------------------");
            // // (x,y) means input parameters of MultipleArgDelegate 
            // //MultipleArgDelegate multipleArs = (x, y) => {
            // //    Console.WriteLine($"X * X: {x * y}");
            // //    return x * y;
            // //};

            ////var result = multipleArs(2, 2);
            //// Console.WriteLine("Result is:" + result);


            // // Here I am replacing the MultipleArgDelegate delegate with the Func delegate
            // Func<int , int, string> multipleArs = (x, y) => {
            //     //Console.WriteLine($"X * X: {x * y}");
            //     return $"X * X: {x * y}";
            // };
            // var result = multipleArs(2, 2);
            // Console.WriteLine("Result is:" + result);


            List<Student> sList = new List<Student>() {

               new Student("Toni" ,  24, 10),
               new Student("adriana",20,12),
               new Student("ahbabul",24, 2),
               new Student("Alexandru", 24, 7),
               new Student("Alexis" , 21, 4),
               new Student("Andrei" , 24, 4),
               new Student("Arthus" , 25, 10),
               new Student("Bojan" ,  26, 2),
               new Student("David" ,  27, 10),
               new Student("Edem" ,   28, 7),
               new Student("Gabor" ,  29, 4),
               new Student("Georgi" , 20, 10),
               new Student("Kristaps",20, 7),
               new Student("Natalie", 19, 2),
               new Student("Nathan" , 23, 4),
               new Student("Niko"   , 27, 12),
               new Student("Nohely" , 29, 4),
               new Student("Okan"   , 29, 4),
               new Student("Paula"  ,  21, 7),
               new Student("Paulina" , 20, 10),
               new Student("Pedro" , 21, 10),
               new Student("Razu" , 37, 12),
               new Student("Radu" , 21, 7),
               new Student("Sara" , 38, 7),
               new Student("vladimir" , 21, 4),
               new Student("wenqi" , 19, 4),
               new Student("Zdenek" , 18, 4),
               new Student("Ziaullah" , 25, 4),
                };

            Console.WriteLine("search Name which age is less than 21..................");

            // Lambda expression - lambda operator =>
            Func<Student, bool> ageLessThan21 = (Student s) => s.Age < 21;
            Func<Student, bool> nameStartWithJ = (Student s) => s.Name.StartsWith("P");
            Func<Student, bool> ageLessThan21AndGrade7 = (Student s) => s.Age < 21 && s.Grade > 4;

            //Predicate<Student> age30 = (Student s) => s.Age > 30;


            var o1 =  FilterAlgorithm.FilterStudent(sList, ageLessThan21);
            PrintStudentName(o1);

            Console.WriteLine(" Name  start with J................................");
            var o2 = FilterAlgorithm.FilterStudent(sList, nameStartWithJ);
            PrintStudentName(o2);

            Console.WriteLine(" Age less than 21 and grade more than 4................................");
            var o3 = FilterAlgorithm.FilterStudent(sList, ageLessThan21AndGrade7);
            PrintStudentName(o3);

            

            //int grade = 4;

            // No need to extra method for search Criteria ........
            //Console.WriteLine("search Name which age is less than 21 and grade is greater than 4");
            //var o2 = FilterAlgorithm.FilterStudentByAgeGrade(sList, sAge , grade);
            //PrintStudentName(o2);

            Console.ReadKey();
            
        }
        //// Step no 2a: Create your target method
        // Set my Target method
        // Target method signature always the same to delegate signature 
        // This method we use for referring the delegate
        static void TargetMethod(string msg)
        {
            Console.WriteLine(msg);           
        }

        static void PrintStudentName(List<Student> sList)
        {
            foreach (var s in sList)
            {
                Console.WriteLine(s.Name);
            }
        }

        
        
    }
}
