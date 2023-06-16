//TASK A

//Console.Write("Please enter a value:");

//int score = Convert.ToInt32(Console.ReadLine());

//if (score > 60 && score < 67)
//{
//    Console.WriteLine("Success - CC");
//}

//else if (score > 67 && score <74 )
//{
//    Console.WriteLine("Success - CB");
//}

//else if (score > 74 && score < 81)
//{
//    Console.WriteLine("Success - BB");
//}

//else if (score > 81 && score < 88)
//{
//    Console.WriteLine("Success - BA");
//}

//else if (score >= 88 && score <= 100)
//{
//    Console.WriteLine("Success - AA");
//}

//else
//{
//    Console.WriteLine("Fail - FF");
//}

//TASK B

//using System;

//Console.Write("Please enter command:");

//string command = Console.ReadLine();

//switch (command)
//{
//    case "start":
//        Console.WriteLine("Game is starting");
//        break;
//    case "stop":
//        Console.WriteLine("Game was stopped");
//        break;
//    case "wait":
//        Console.WriteLine("Game was paused");
//        break;
//    default:
//        Console.WriteLine("Game over");
//        break;
//}

//TASK C

//Console.Write("Please enter a value:");

//int value = Convert.ToInt32(Console.ReadLine());
//int count = 1;
//int sum = 0;

//while (count<value)
//{
//    sum += count;
//    count++;
//}

//Console.WriteLine(sum);


//TASK D

int count = 1;

while (count < 100)
{
    if (count % 3 == 0 || count % 5 == 0)
    {
        Console.WriteLine(count);
    }

    count++;
}