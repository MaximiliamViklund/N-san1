Console.WriteLine("Hello, welcome to this number guesing game");
Random gen=new();
int right=gen.Next(1,11);
bool guessRight=false;
int guess;
Console.WriteLine("Please enter a number between 1 and 10");

while(!guessRight){
    string resp=Console.ReadLine();
    bool weGood=int.TryParse(resp,out guess);
    if(weGood&&1<=guess&&guess<=10){
        if(guess==right){
            Console.WriteLine("Good job, you guessed right!!");
            Console.ReadLine();
            guessRight=true;
        }
        else if(guess<right){
            Console.WriteLine("Your guess is less than the correct answer");
        }
        else if(right<guess){
            Console.WriteLine("Your guess is more than the correct answer");
        }

    }
    else if(!weGood||guess<1||10<guess){
        Console.WriteLine("Please enter a valid NUMBER between 1 and 10");
    }
    weGood=false;
}