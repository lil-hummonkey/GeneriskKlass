// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string name;
bool shouldplay = true;


while(shouldplay == true){

//skapa lista för att hålla namn i sig
List<string> myList = new List<string>();
Console.WriteLine("write a name");
string words = Console.ReadLine();

myList.Add(words);

Console.WriteLine("write a name");
string word2 = Console.ReadLine();

myList.Add(word2);

Console.WriteLine("Do you want to delete the first or second name??");
Console.WriteLine("Write 1 if first");
string Choice = Console.ReadLine();

//i denna fall skapar en queue av listan som dequeuar efteråt (tar bort första stringen i queuen)
if(Choice == "1")
{
    Queue<string> myQueue = new(myList);
    myQueue.Dequeue();
foreach (var d in myQueue) Console.WriteLine(d);
}
//i andra fall skapar en stack av listan som poppar efteråt (tar bort andra stringen i stacken)
else 
{
Stack<string> myStack = new(myList);
myStack.Pop();
foreach (var p in myStack) Console.WriteLine(p);
}
//frågar om man vill spela igen

Console.WriteLine("Do you want to try again?");
 string restart = Console.ReadLine();
 if (restart == "no") shouldplay = false;
 else shouldplay = true;
}