namespace IPValidation
{
    using System;

    public class Solution
    {
        public bool IsValidIP(string IP)
        {
            string[] parts = IP.Split('.');

            if (parts.Length != 4)
            {
                return false;
            }

            foreach (string part in parts)
            {
                int number;

                // Check if the part is a number.
                if (!int.TryParse(part, out number))
                {
                    return false;
                }

                // Check if the number is in the correct range.
                if (number < 0 || number > 255)
                {
                    return false;
                }

                // Check if the part has leading zeros.
                if (part.Length > 1 && part.StartsWith("0"))
                {
                    return false;
                }
            }

            return true;
        }
    }
    public static class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            try
            {
                Console.WriteLine(solution.IsValidIP("192.168.1.1"));  // It should print: True
                Console.WriteLine(solution.IsValidIP("255.255.255.255"));  // It should print: True
                Console.WriteLine(solution.IsValidIP("192.168.1.256"));  // It should print: False
                Console.WriteLine(solution.IsValidIP("192.168.01.1"));  // It should print: False
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
        }
    }
   

}