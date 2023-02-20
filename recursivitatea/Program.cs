using System;


namespace recursivitate;


class math
{

    static int Main(string[] args)
    {
        int number;

        TextPrintUsers();


        number = int.Parse(Console.WriteLine);


        Factorial(number)

       return 0;
    }
    static void TextPrintUsers()

    {

        Console.WriteLine(" type the number ");


    }

    static int Factorial(int number)
    {
        if (number == 0)
        {
            return 1;
        }

        else
        {

            return (number - 1) * number;
        }





    }




}

// Scrieti o functie recursiva care va calcula al n lea element din sirul lui Fibonacci , n fiind citit de la tastatura , apelati o si aflati rezultatul 



using System;

namespace recursivitatea;

class Fibonacci
{

    static int Main(string[] args)
    {

        int number;

        TextPrintUsers();

        number = int.Parse(Console.ReadLine());

        //Afișăm al n-lea termen

        Console.WriteLine(fibonacci(number));

        return 0;

    }

    static void TextPrintUsers()
    {

        Console.WriteLine(" Type the number ");
    }
    static int fibonacci(int number)
    {
        if (number == 1 || number == 2)
        {
            return 1;
        }
        return fibonacci(number - 1) + fibonacci(number - 2);
    }


}