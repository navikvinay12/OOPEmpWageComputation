namespace OOPEmpWageComputation
{
    internal class OOPEmpWage
    {
        const int IS_FULL_TIME = 1;
        public static void Welcome()
        {
            Console.WriteLine("Welcome to EmployeeWage Computation Program");
        }
        public static void EmpPresentAbsent()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
        public static void Main(string[] args)
        {
            Welcome();
            EmpPresentAbsent();
        }
    }
}