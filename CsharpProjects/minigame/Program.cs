//Minigame made for a c# certifications
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// Extra points for doubles
if((roll1 == roll2)||(roll1 == roll3) || (roll2 == roll3)){
    //Extra points for triples
    if((roll1 == roll2) && (roll2==roll3)){
        Console.WriteLine("6 Extra points for triples!!!");
        total += 6;
    }else{
        Console.WriteLine("You rolles doubles! +2 bonus to total!");
        total += 2;
    }
}

// Win or lose
if(total >= 16){
    Console.WriteLine("You win a car!!!, congratulations!");
    Console.WriteLine($"Total points: {total}");
}else if(total >= 10){
    Console.WriteLine("You win a laptop!, congratulations");
    Console.WriteLine($"Total points: {total}");
}else if(total == 7){
    Console.WriteLine("you win a trip for two!");
    Console.WriteLine($"Total points: {total}");
}else{
    Console.WriteLine("you win a kitten :)");
    Console.WriteLine($"Total points: {total}");
    }