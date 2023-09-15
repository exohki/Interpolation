using ConsoleTables;
using System;


class Program
{
    static void Main()
    {
        DateTime today = DateTime.Now;
        double pi = Math.PI;

        // 1. January 22, 2019 (right aligned in a 40 character field)
        Console.WriteLine($"{today:MMMM dd, yyyy}".PadLeft(40));

        // 2. 2019.01.22
        Console.WriteLine($"{today:yyyy.MM.dd}");

        // 3. Day 22 of January, 2019
        Console.WriteLine($"Day {today:dd} of {today:MMMM}, {today:yyyy}");

        // 4. Year: 2019, Month: 01, Day: 22
        Console.WriteLine($"Year: {today:yyyy}, Month: {today:MM}, Day: {today:dd}");

        // 5. Tuesday (10 spaces total, right aligned)
        Console.WriteLine($"{today:dddd}".PadLeft(10));

        // 6. 11:01 PM Tuesday (10 spaces total for each including the day-of-week, both right-aligned)
        Console.WriteLine($"{today:hh:mm tt dddd}".PadLeft(10));

        // 7. h:11, m:01, s:27
        Console.WriteLine($"h:{today:hh}, m:{today:mm}, s:{today:ss}");

        // 8. 2019.01.22.11.01.27
        Console.WriteLine($"{today:yyyy.MM.dd.hh.mm.ss}");

        // 1. Output as currency
        Console.WriteLine($"{pi:C}");

        // 2. Output as right-aligned (10 spaces), number with 3 decimal places
        Console.WriteLine($"{pi,10:N3}");
    }
}