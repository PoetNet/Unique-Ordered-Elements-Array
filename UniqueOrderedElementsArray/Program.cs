using UniqueOrderedElementsArray;

var result1 = UniqueElementsGetter.GetUniqueElementsInOrder("XBBHhLM");
var result2 = UniqueElementsGetter.GetUniqueElementsInOrder([1, 1, 5, 5, 7, 8, 8, 8]);

var resultString1 = string.Join(' ', result1);
var resultString2 = string.Join(' ', result2);

Console.WriteLine(resultString1);
Console.WriteLine(resultString2);

Console.ReadLine();