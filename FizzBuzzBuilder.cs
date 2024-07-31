

namespace RemainderBuilder
{
    public class FizzBuzzBuilder
    {

        public static List<Outputs> GetFizzBuzz(int upperLimit, string firstOutputVal, string secondOutputVal)
        {
            var resultSet = new List<Outputs>();
            for (int i = 1; i < upperLimit; i++)
            {
              
                if (i % 3 == 0 && i % 5 == 0)
                {
                    resultSet.Add(new Outputs { Key = i, StringVal = $"{firstOutputVal}{secondOutputVal}" });
                    //Console.WriteLine("FizzBuzz");
                } //divisible by 3 = firstval
                else if (i % 3 == 0)
                {
                    resultSet.Add(new Outputs { Key = i, StringVal = $"{firstOutputVal}" });
                    //Console.WriteLine("Fizz");
                }

                else if (i % 5 == 0)
                {
                    resultSet.Add(new Outputs { Key = i, StringVal = $"{secondOutputVal}" });
                    //Console.WriteLine("Buzz");
                }
                else
                {
                    resultSet.Add(new Outputs { Key = i, StringVal = i.ToString() });
                    //Console.WriteLine(i);
                }


            }
            return resultSet;
        }
    }
}
