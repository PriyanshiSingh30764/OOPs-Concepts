//Arrays
int[] numbersArray = new int[5];
numbersArray[0] = 1;
numbersArray[1] = 2;
numbersArray[2] = 3;
numbersArray[3] = 4;
numbersArray[4] = 5;

// Accessing an element
int firstNumber = numbersArray[0];
Console.WriteLine(firstNumber);

//List:
List<string> namesList = new List<string>();
namesList.Add("Alice");
namesList.Add("Bob");
namesList.Add("Charlie");

// Accessing an element
string firstPerson = namesList[0];
Console.WriteLine(firstPerson);


//Dictionary:
Dictionary<string, int> agesDictionary = new Dictionary<string, int>();
agesDictionary.Add("Alice", 25);
agesDictionary.Add("Bob", 30);
agesDictionary.Add("Charlie", 35);

// Accessing an element
int aliceAge = agesDictionary["Alice"];
Console.WriteLine(aliceAge);

//HashSet:
HashSet<int> uniqueNumbersSet = new HashSet<int>();
uniqueNumbersSet.Add(1);
uniqueNumbersSet.Add(2);
uniqueNumbersSet.Add(3);
uniqueNumbersSet.Add(1); // This will not be added as it's a duplicate

// Checking if an element exists
bool containsTwo = uniqueNumbersSet.Contains(2);
Console.WriteLine(containsTwo);


//Queue:
Queue<string> lineQueue = new Queue<string>();
lineQueue.Enqueue("Alice");
lineQueue.Enqueue("Bob");
lineQueue.Enqueue("Charlie");

// Dequeue an element
string firstPersonInLine = lineQueue.Dequeue();
Console.WriteLine(firstPersonInLine);

//Stack:
Stack<string> booksStack = new Stack<string>();
booksStack.Push("Book1");
booksStack.Push("Book2");
booksStack.Push("Book3");

// Pop an element
string lastAddedBook = booksStack.Pop();
Console.WriteLine(lastAddedBook);