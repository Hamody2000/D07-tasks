namespace taskD07
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Point[] points = new Point[] { new Point(10, 20), new Point(3, 4), new Point(5,6), new Point(-5,4), new Point(2,2) };

            //Array.Sort(points);

            //foreach (Point item in points) {

            //    Console.WriteLine(item.ToString());
            //}


            //Point3D point1 = new Point3D(10, 20,30);
            //Point3D point2 = new Point3D(3, 4, 5);

            //Console.WriteLine(point1.GetHashCode());
            //Console.WriteLine(point2.GetHashCode());

            //point1 = point2;


            //point1 = (Point3D)point2.Clone();
            //Console.WriteLine(point1.GetHashCode());
            //Console.WriteLine(point2.GetHashCode());


            #region EmpArr

            Employee[] employees = new Employee[3];


            for (int i = 0; i < employees.Length; i++)
            {
                
                employees[i] = new Employee();
                employees[i].HD = new HiringDate();
                
                Console.WriteLine("enter id");

                int id;
                while (!int.TryParse(Console.ReadLine(), out id))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
                employees[i].Id = id;

                Console.WriteLine("enter name");
                employees[i].Name = Console.ReadLine();
  
                Console.WriteLine("enter salary");
                decimal salary;
                while (!decimal.TryParse(Console.ReadLine(), out salary))
                {
                    Console.WriteLine("Invalid input. Please enter a valid decimal for Salary.");
                }
                employees[i].Salary = salary;

                Console.WriteLine("enter gender");
                Gender gender;
                while (!Enum.TryParse(Console.ReadLine(), true, out gender) )
                {
                    Console.WriteLine("Invalid input. Please enter a valid Gender (Male or Female).");
                }
                employees[i].Gen = gender;

                Console.WriteLine("enter Security Level");
                SecurrityLevel scl;
                while (!Enum.TryParse(Console.ReadLine(), true, out scl) )
                {
                    Console.WriteLine("Invalid input. Please enter a valid Security Level.");
                }
                employees[i].SCL = scl;


                Console.WriteLine("enter hire year");
                int year; 
                while (!int.TryParse(Console.ReadLine() , out year) )
                {
                    Console.WriteLine("Invalid input, please enter a valid year");
                }
                employees[i].HD.Year = year;

                Console.WriteLine("enter hire month");
                int month;
                while (!int.TryParse(Console.ReadLine(), out month) || month < 1 || month > 12)
                {
                    Console.WriteLine("Invalid input. Please enter a valid month (1-12).");
                }
                employees[i].HD.Month = month;

                Console.WriteLine("enter hire day");
                int day;
                while (!int.TryParse (Console.ReadLine() , out day) || day < 1 || day > 31)
                {
                    Console.WriteLine("invalid");
                }
                employees[i].HD.Day = day;
         
            }

            Array.Sort( employees );

            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine(employees[i]);
            }

            #endregion

        }
    }
}
