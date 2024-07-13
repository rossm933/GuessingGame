// See https://aka.ms/new-console-template for more information
Random random = new Random();
int secretNumber = random.Next(1, 101);
int guessesMade = 0;
int guessesAllowed = 0;
bool isCorrect = false;
string greeting = "Welcome to the Guessing Game! Try to get guess the secret number!";
    
Console.WriteLine(greeting);
Console.WriteLine("Choose a difficulty level by entering number:  1. Easy, 2. Medium, 3. Hard, 4. Cheater");
int difficulty = int.Parse(Console.ReadLine().Trim());

if (difficulty == 1)
{
    Easy();
}
else if (difficulty == 2)
{
    Medium();
}
else if (difficulty == 3)
{
    Hard();
}
else if (difficulty == 4)
{
    Cheater();
}
else
{
    Console.WriteLine("Please Choose 1, 2, 3, or 4");
}

while (isCorrect == false && guessesMade < guessesAllowed)
{
    Console.WriteLine($"{(guessesMade == 0 ? $"You have {guessesAllowed} guesses" : $"You have {guessesAllowed - guessesMade} {(guessesAllowed == 1 ? "guess" : "guesses")} left")} ");
    UserGuessPrompt();
}

UserGuessPrompt();
void UserGuessPrompt()
{

    Console.WriteLine("Enter a number between 1 and 100");
        int guess = int.Parse(Console.ReadLine().Trim());
        guessesMade++;

    if (guess == secretNumber)
    {
        isCorrect = true;
        Console.WriteLine("You guessed correctly!");
        Environment.Exit(0);


    }
    else
    {
        if (guess > secretNumber)
        {
            Console.WriteLine("Your guess is too high");
        }
        else
        {
            Console.WriteLine("Your guess is too low");
        }
    }
    
}

void Easy()
{
    guessesAllowed = 8;
}

void Medium()
{
    guessesAllowed = 6;
}

void Hard()
{
    guessesAllowed = 4;
}

void Cheater()
{
    while (isCorrect == false)
    {
        UserGuessPrompt();
    }
}
