using System;
class program
{
    public static void Main()
    {
        char[] password = new char[10];
        char[] username = new char[10];
        char ch;
        int i;
 
        Console.WriteLine("Enter User name < 3 characters > : ");
        for (int x = 0; x < 8; x++)
        {
            username[x] = Convert.ToChar(Console.Read());
        }
        Console.WriteLine("Enter the password < any 8 characters>: ");
        for (i = 0; i < 8; i++)
        {
            ch = Convert.ToChar(Console.Read());
            password[i] = ch;
            ch = '*';
            Console.WriteLine("{0}", ch);
        }
        password[i] = '\0';
        Console.WriteLine("\n Your Password is :");
        for (i = 0; i < 8; i++)
        {
            Console.Write("{0}", password[i]);
        }
        Console.ReadLine();
        Console.ReadLine();
    }
}
