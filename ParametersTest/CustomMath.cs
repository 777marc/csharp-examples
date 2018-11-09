namespace csharp_examples.ParametersTest
{
    public class CustomMath
    {
        public CustomMath() { }

        public static int Add(params int[] values)
        {
            int result = 0;
            
            for(int i = 0; i <= values.Length; i++)    
            {
                result += i;
            }

            return result;
        }

    }
}