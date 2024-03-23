using System;
using System.Security.Cryptography;
using System.Text;

class Program
{
    static void Main()
    {
        string originalString = "Your String Here";
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(originalString));
            
            // Convert byte array to a string   
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }
            Console.WriteLine($"The SHA256 hash of {originalString} is: {builder.ToString()}");
        }
    }
}
