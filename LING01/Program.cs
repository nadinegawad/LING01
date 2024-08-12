using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LING01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Var - Dynamic
            //var Data01 = "Ahmed";
            ////Data01 = 9; //invalid

            //dynamic Data02 = "Amr";
            //Console.WriteLine(Data02.GetType().Name);

            //Data02 = 9;
            //Console.WriteLine(Data02.GetType().Name);

            //Data02 = 1.5;
            //Console.WriteLine(Data02.GetType().Name);

            //Data02 = new StringBuilder();
            //Console.WriteLine(Data02.GetType().Name);
            #endregion

            #region Extension Methods
            //int x= intextention.reserve(12345);
            // console.writeline(x);

            //int num = 123456789;
            //int result = num.reserve();
            //console.writeline(result); 
            #endregion

            #region Anonymous Type
            //var Emp01 = new  { Id=1,Name="Amr",Salary=17000};
            //var Emp03 = new  { Id=1,First="Amr",Salary=17000};
            //var Emp02 = Emp01 with { Id = 2 };
            //Console.WriteLine(Emp01.GetType().Name);
            //Console.WriteLine(Emp02.GetType().Name);
            //Console.WriteLine(Emp03.GetType().Name);
            //Console.WriteLine(Emp02);
            ////Employee Emp02= new Employee() { Id=1,Name="Ahmed",Salary=17000};
            //Emp01 = Emp02;
            //if(Emp01.Equals(Emp02))
            //{
            //    Console.WriteLine("Equal");
            //}
            //else
            //{
            //    Console.WriteLine("!Equal");

            //} 
            #endregion

            List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            #region Where
            //var Result= Enumerable.Where(Numbers, N => N % 2 == 0);

            #endregion

            #region Any
            //var Result = Enumerable.Any(Numbers);
            //Console.WriteLine(Result); 
            #endregion

            #region Range
            //var Result = Enumerable.Range(1, 10); 
            #endregion


            #region Linq Syntax
            //fluent
            //class member methods
            //var Result = Enumerable.Where(Numbers, N => N % 2 == 0);

            //extention methods
            //var Result = Numbers.Where(N => N % 2 == 0);


            //query

            //var Result = from N in Numbers
            //             where N%2==0
            //             select N;


            //foreach (int n in Result)
            //{
            //    Console.WriteLine(n);
            //} 
            #endregion

            #region Execution Ways
            //differed
            //Immidate

            //differed
            //var Result = Enumerable.Where(Numbers, N => N % 2 == 0);
            //Numbers.AddRange(new int[] { 11, 12, 13, 14 });
            //foreach (int n in Result)
            //{
            //    Console.WriteLine(n);
            //}


            //Immidate
            //var Result = Enumerable.Where(Numbers, N => N % 2 == 0).ToList();
            //Numbers.AddRange(new int[] { 11, 12, 13, 14 });
            //foreach (int n in Result)
            //{
            //    Console.WriteLine(n);
            //}
            #endregion



        }

    }
}
