using System;

/* TT0200 Olio-ohjelmointi Kevät 2020
 * T4-Palindromi
 * Programmed: Joonas Pietilä 03.06.2020
 */



namespace T4_Palindromi
{
   class Program
    {
        static void Main(string[] args)
        {
            string _inputstr, _reversestr = string.Empty;
            Console.Write("Enter a string : ");
            _inputstr = Console.ReadLine();
            if (_inputstr != null)
            {
                for (int i = _inputstr.Length - 1; i >= 0; i--)
                {
                    _reversestr += _inputstr[i].ToString();
                }
                if (_reversestr == _inputstr)
                {
                    Console.WriteLine("String is Palindrome Input = {0} and Output= {1}", _inputstr, _reversestr);
                }
                else
                {
                    Console.WriteLine("String is not Palindrome Input = {0} and Output= {1}", _inputstr, _reversestr);
                }
            }
            Console.ReadLine();
        }
    }
}
