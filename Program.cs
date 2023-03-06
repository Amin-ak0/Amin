
string ch;
ConsoleKeyInfo digit;
int number;

do
{
    do
    {
        Console.WriteLine("Enter student score 0 to 20 :");
        number = 0;
        do
        {
            locknum();
            Calculatenum();

        } while (digit.Key.ToString() != "Enter");
        Console.WriteLine();
    } while (number < 0 || number > 20);
    Console.WriteLine();

    Calculaterank();

    percentwithlockYN();

    continuewithlock();


} while (ch.ToLower() == "y");
Console.WriteLine("Thanks for using this program ._.");



void Calculaterank()
{

    if (number >= 17)
    {
        Console.WriteLine("Rank A ");
        Console.WriteLine("------------------------------------------------");

    }

    else if (number >= 15)
    {
        Console.WriteLine("Rank B ");
        Console.WriteLine("------------------------------------------------");

    }

    else if (number >= 10)
    {
        Console.WriteLine("Rank c ");
        Console.WriteLine("------------------------------------------------");

    }

    else if (number >= 0)
    {
        Console.WriteLine("Faild");
        Console.WriteLine("------------------------------------------------");

    }
}

void percentwithlockYN()
{
    Console.WriteLine("do you want to see your percent ??? (y/n) ");
    do
    {
        ch = Console.ReadKey(true).KeyChar.ToString();

    } while (ch.ToLower() != "y" && ch.ToLower() != "n");

    if (ch.ToLower() == "y")
    {
        number *= 5;
        Console.WriteLine(number);
    }

}
void locknum()
{
    do
    {
        digit = Console.ReadKey(true);

    } while (digit.KeyChar.ToString() != "0" && digit.KeyChar.ToString() != "1" &&
        digit.KeyChar.ToString() != "2" && digit.KeyChar.ToString() != "3" &&
        digit.KeyChar.ToString() != "4" && digit.KeyChar.ToString() != "5" &&
        digit.KeyChar.ToString() != "6" && digit.KeyChar.ToString() != "7" &&
        digit.KeyChar.ToString() != "8" && digit.KeyChar.ToString() != "9" &&
        digit.Key.ToString() != "Enter");
}
void Calculatenum()
{
    if (digit.Key.ToString() != "Enter")
    {
        number = number * 10 + Convert.ToInt32(digit.KeyChar.ToString());
        Console.Write(digit.KeyChar);
    }
}
void continuewithlock()
{
    Console.WriteLine("Do you want to enter another score ???(y/n)");
    do
    {
        ch = Console.ReadKey(true).KeyChar.ToString();

    } while (ch.ToLower() != "y" && ch.ToLower() != "n");
}