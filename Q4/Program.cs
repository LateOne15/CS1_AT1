// Lleyton Eggins, 30128198
// 07/08/2025, 14/08/2025
// AT1_Q4_Twin_Primes_Perfect_Number, V1.0
// Question 4. Debug existing code and format to CITE/VS standards, then make improvements requested.
// Program determines perfect numbers amd twin primes up to a specificed range

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provide a maximum range to determine perfect numbers up to.");
            Console.Write("Input Max: ");
            int max1 = Convert.ToInt32(Console.ReadLine()); 
            PerfectNumber(max1);

            Console.WriteLine("Provide a maximum range to determine twin primes up to.");
            Console.Write("Input Max: ");
            int max2 = Convert.ToInt32(Console.ReadLine());
            TwinPrimes(max2); 
            
            Console.WriteLine("\n\nEnd of Program");
            Console.ReadKey();
        }
        #region PerfectNumber
        static void PerfectNumber(int uppperLimit)  //determines perfect numbers up to a range. Perfect numbers are equal to the sum of their factors other than themselves
        {
            int divisor, sum;

            for (int counter = 1; counter < uppperLimit; counter++) //iterates through integers up to limit
            {

                sum = 0; 
                for (divisor = 1; divisor < counter; divisor++) //iterates through divisors to find factors, stopping before reaching the counter itself
                {

                    if (counter % divisor == 0) //if counter % divisor is zero, the divisor is a factor of the counter
                    {
                        sum = sum + divisor; //sum all factors
                    }
                }

                if (sum == counter) //check if sum is equal to the number
                {
                    Console.WriteLine("A perfect number is {0}", counter); //displays successful perfect numbers
                }
            }
        }
        #endregion PerfectNumber

        #region TwinPrimes
        static void TwinPrimes(int upperLimit) //determine twin primes up to a limit. Twin primes are primes numbers two integers apart
        {
            int secondPrime;
            int count1 = 0, count2 = 0;

            for (int i = 3; i < upperLimit; i++) //iterates through all numbers up to limit
            {

                for (int j = 2; j < i; j++) //iterates through divisors below the currently evaluated number
                {
                    if (i % j == 0) //if the modulus of the evaluated number and divisor is zero, the number is not prime. end the for loop there
                    {
                        count1++; //if >0, composite number
                        break;
                    }
                }
                secondPrime = i + 2; //twin prime must be two ints above current evaluated number

                for (int k = 2; k < i; k++) //iterates through the divisors below the currently evaluated number
                {
                    if (secondPrime % k == 0) //same check but with the second number. both numbers must be prime to be twin primes
                    {
                        count2++; //if >0, composite number
                        break;
                    }
                }
                if (count1 == 0 && count2 == 0)  //ensures both numbers are actually prime
                { 
                    Console.WriteLine("Two twin primes are {0}, {1}", i, i + 2); //says any successful numbers
                }
                count1 = 0; count2 = 0; //resets the prime check
            }
        }
        #endregion TwinPrimes
    }
}