
// Strings

string recipitentName;
string yourName;
string Subject;
string Task;
string Date;

// Inital Questions

Console.WriteLine("Enter the Recipient's Full Name:");
recipitentName = Console.ReadLine();
Console.WriteLine("Enter Your Full Name (Sender):");
yourName = Console.ReadLine();
Console.WriteLine("nter the Subject of the Letter:");
Subject = Console.ReadLine();
Console.WriteLine("Enter a specific project or task you are discussing:");
Task = Console.ReadLine();
Console.WriteLine("Enter a follow-up date");
Date = Console.ReadLine();

// Letter

Console.WriteLine();
Console.WriteLine("Generating your Letter...");
Console.WriteLine();
Console.WriteLine("8/6/2025");
Console.WriteLine();
Console.WriteLine("To: " + recipitentName);
Console.WriteLine();
Console.WriteLine("Dear " + recipitentName + ",");
Console.WriteLine();
Console.WriteLine("Subject: " + Subject);
Console.WriteLine();
Console.WriteLine("I am writing to you today regarding the " + Task + " that we discussed.");
Console.WriteLine("I wanted to provide a quick update on its progress.");
Console.WriteLine();
Console.WriteLine("We anticipate completing the initial phase by " + Date);
Console.WriteLine("Please let me know if you have any questions or require further information.");
Console.WriteLine();
Console.WriteLine("Sincerly,");
Console.WriteLine();
Console.WriteLine(yourName);
Console.WriteLine();
Console.WriteLine("--------------------------------------");
Console.WriteLine("Letter generated successfully. Press any key to exit.");