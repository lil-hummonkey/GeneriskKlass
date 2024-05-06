// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

bool shouldplay = true;
while(true){


Stack<string> myStack = new Stack<string>();
Console.WriteLine("write a name");
string words = Console.ReadLine();

myStack.Push(words);

Console.WriteLine("write a name");
string word2 = Console.ReadLine();

myStack.Push(word2);


Console.WriteLine(myStack.Peek());

Console.WriteLine("Do you like the first or second name more?");
Console.WriteLine("Write FIRST if first");
string Choice = Console.ReadLine();

if(Choice == "FIRST")
{
    
myStack.Pop();
Console.WriteLine(myStack.Peek());
}

else Console.WriteLine(myStack.Peek());

// Precis som för queue, peekar "nästa värde". Det som ligger högst upp – 665.

// Tar bort det som ligger högst upp i högen och returnerar det.
// Så nu är bara 5 och 42 kvar i högen.

Console.ReadLine();
}