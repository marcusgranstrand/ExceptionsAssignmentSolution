
using ExceptionsAssignment;
using System.ComponentModel;

string commaSeperatedNumberString = File.ReadAllText("D:\\Programmering\\C#\\C# Course\\ExceptionsAssignmentSolution\\ExceptionsAssignment\\Some Numbers.txt");
string[] numberString = commaSeperatedNumberString.Split(',', StringSplitOptions.RemoveEmptyEntries);

for (int i = 0; i < numberString.Length; i++)
{
    Console.WriteLine(numberString[i]);
}

Console.ReadKey();

OrderedNumbersList(numberString);

List<int> OrderedNumbersList(string[] numberString)
{
	List<int> unOrderedList = new List<int>();
	try
	{
		for (int i = 0; i < numberString.Length; i++)
		{
			unOrderedList.Add(int.Parse(numberString[i]));
		}		
	}
	catch (FormatException)
	{
        Console.WriteLine("Entry discarded");
    }
	
	List<int> orderedList = unOrderedList
		.OrderByDescending(unOrderedList => unOrderedList)
		.ToList();

	// A little loop to see the results
	foreach (int item in orderedList)
	{  
		Console.WriteLine(item); 
	}

	return orderedList;
}

Console.ReadKey();

string wordsDTOFilePath = "D:\\Programmering\\C#\\C# Course\\ExceptionsAssignmentSolution\\ExceptionsAssignment\\wordsDTO.txt";

MyMetodForObject(wordsDTOFilePath);

WordsDTO MyMetodForObject(string wordsDTOFilePath)
{
	WordsDTO myObj = new WordsDTO(wordsDTOFilePath);
	
	try
	{
		string temp = File.ReadAllText(wordsDTOFilePath);
		myObj.WordArray = temp.Split(',', StringSplitOptions.RemoveEmptyEntries);
		foreach (var word in myObj.WordArray)
		{
			Console.WriteLine(word);
		}
	}
	catch (Exception e)
	{
		myObj.IsFileFound = false;
		myObj.MyOwnMessage = "File not found";
        Console.WriteLine(myObj.MyOwnMessage);
    }

	myObj.IsFileFound = true;
	myObj.MyOwnMessage = "Success";

	Console.ReadKey();
	return myObj;
}

Console.ReadKey();
