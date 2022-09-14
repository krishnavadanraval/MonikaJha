using System;
namespace Diamond
{
    public class DiamondClass
    {

        public static void DiamondFunc(string userinput)
        {
            try
            {

                string str = userinput;
                int length = str.Length;
                if (length > 1)
                {
                    Console.WriteLine("You have entered more than one letter, please try again..");
                    
                }
                else
                {
                    char ch = str[0];
                    int val = (int)ch;
                    if (val >= 65 && val <= 90)

                    {
                        int number = val - 65;
                        //Console.WriteLine(val);
                        ch = 'A';
                        for (int i = 0; i <= number; i++)
                        {
                            for (int j = 0; j < (number - i); j++)
                                Console.Write(" ");

                            Console.Write(ch);

                            for (int j = 1; j <= i; j++)
                                Console.Write(" ");

                            for (int k = 1; k < i; k++)
                                Console.Write(" ");

                            if (i >= 1)                        
                                Console.Write(ch);                        

                            ch++;
                            Console.WriteLine();
                        }
                        ch--;

                        for (int i = number - 1; i >= 0; i--)
                        {
                            ch--;
                            for (int j = 0; j < (number - i); j++)
                                Console.Write(" ");

                            Console.Write(ch);

                            for (int j = 1; j <= i; j++)
                                Console.Write(" ");

                            for (int k = 1; k < i; k++)
                                Console.Write(" ");

                            if (i >= 1)
                                Console.Write(ch);
                            
                            Console.WriteLine();
                           
                        }
                    }
                    else
                    {
                        Console.WriteLine("Hi,There you did not enter Capital letter.Try again..");
                        
                    }                    
                }               
            }
            catch(Exception ex)
            {
              Console.WriteLine(ex.ToString());
            }
}
        

        public static void Main(string[] args)
        {
            string user_input = "";
            Console.WriteLine("Enter the Capital letter");
            user_input = Console.ReadLine();
            DiamondClass.DiamondFunc(user_input);
            Console.ReadLine();
            //userinput_method();

        }

    }
}

