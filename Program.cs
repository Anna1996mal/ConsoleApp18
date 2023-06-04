using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("mutq tiv");
            int tiv = Convert.ToInt32(Console.ReadLine());
            bool check = false; 


                int count =0;
            
                    int sum = 0;
            int tiv2 = 1;

            while (tiv!=0)
            {
                int mnacord;
                
               
                mnacord= tiv % 10;


                tiv = tiv / 10;

                count++;


                for (int i = 1; i <= count; i++)
                {

                    
                    tiv2= tiv2 * mnacord;
                   
                  sum += tiv2;
                    
                   
                     
                } 
                
            }

            if (tiv==sum)
            {
                check = true;
                
            }
            Console.WriteLine(check);

            

        }
    }
}