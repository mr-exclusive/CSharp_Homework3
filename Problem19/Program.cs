// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

Console.Write("User input: ");
string text = Console.ReadLine();

Check5DigitNumberForPalindrome(text);
//CheckTextForPalindrome(text);

void Check5DigitNumberForPalindrome(string text)
{
    int number;
    
    if (int.TryParse(text, out number) && number > 9999 && number < 100000)
    {
        if (number / 10000 == number % 10)
        {
            if (number / 1000 % 10 == number % 100 / 10)
            {
                Console.WriteLine($"{number} -> It's a palindrome");
                Environment.Exit(0);
            }
        }

        Console.WriteLine($"{number} -> It's NOT a palindrome");
    }
    else
    {
        Console.WriteLine("Invalid input! (expected 5-digit number)");
    }
}

void CheckTextForPalindrome(string text)
{
    if (string.IsNullOrEmpty(text))
    {
        Console.WriteLine("Empty input");     
    }
    else
    {
        for (int i = 0; i < text.Length / 2; i++)
        {
            if (text[i] != text[text.Length - 1 - i]) 
            {
                Console.WriteLine($"{text} -> It's NOT a palindrome");
                
                Environment.Exit(0);
            }
        }

        Console.WriteLine($"{text} -> It's a palindrome");
    }
}