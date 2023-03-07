// Peyman Rasouli --- Practice_5_Student_grade

string msg = "";
string input;
int grade;

// etebar sanji
do
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("_____________________________________________________________________");
    Console.WriteLine("Enter your grade: ");
    grade = Int32.Parse(Console.ReadLine());

    if (grade >= 0 && grade <= 20)
    {
        grade_type();
        percent_type(grade);
    }
    else
    {
        continue_YN();
    }

} while (true);



// tabe mohasebe darsad
void percent_type(int num)
{
    num = (num * 100) / 20;
    Console.WriteLine("{0}% of 20", num);

}
// tabe mohasebe type nomre
void grade_type()
{
    switch (grade)
    {
        case < 10: msg = "False"; break;
        case < 15: msg = "C"; break;
        case < 17: msg = "B"; break;
        case <= 20: msg = "A"; break;
        default: msg = "None"; break;
    }
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("     grade type: {0}    |   ", msg);
}
// tabe javab karbar baraye edame dadan ya nadadan
void continue_YN()
{
    Console.WriteLine("Clear And Continue[Y / N] ");
    do
    {
        input = Console.ReadKey(true).KeyChar.ToString();
        Console.Clear();
        Console.WriteLine("Closed!!");
        Console.WriteLine("Press Y to continue...");
    } while (input.ToLower() != "y");
    Console.Clear();
}