using System;
using System.Collections.Generic;

Dictionary<int, string> MooseAnswers =
        new Dictionary<int, string>(){
        {0, "As I see it, yes."},
        {1, "Ask again later."},
        {2, "Better not tell you now."},
        {3, "Cannot predict now."},
        {4, "Concentrate and ask again."},
        {5, "Don’t count on it."},
        {6, "It is certain."},
        {7, "It is decidedly so."},
        {8, "Most likely."},
        {9, "My reply is no."},
        {10, "My sources say no."},
        {11, "Outlook not so good."},
        {12, "Outlook good."},
        {13, "Reply hazy, try again."},
        {14, "Signs point to yes."},
        {15, "Very doubtful."},
        {16, "Without a doubt."},
        {17, "Yes."},
        {18, "Yes – definitely."},
        {19, "You may rely on it."}
};
main();
void main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine(MooseAnswers[0]);
    MooseSays("HI, I'M ENTHUSIASTIC!");
    MooseSays("Iam really enthusiastic!");
    CanadaQuestion();
    LoveCSharpQuestion();
    EnthusiasticQuestion();
    SecretQuestion();
}
string AskIt(string question)
{
    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }
    return answer;

}
string MooseAsks(string answer)
{
    Random rnd = new Random();
    int num = rnd.Next(0, 19);  
    return MooseAnswers[num];
}
void EnthusiasticQuestion()
{
    MooseSays(MooseAsks(AskIt("Are you enthusiastic?")));
}

void LoveCSharpQuestion()
{
    MooseSays(MooseAsks(AskIt("Do you love C# yet?")));
}

void SecretQuestion()
{
    MooseSays(MooseAsks(AskIt("Do you want to know a secret?")));
}
void CanadaQuestion()
{
    MooseSays(MooseAsks(AskIt("Is Canada real?")));
}

void MooseSays(string message)
{
    Console.WriteLine($@"
                                      _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}
string GenerateRandomAnswer(){
    return"No";
}









