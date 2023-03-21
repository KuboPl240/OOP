// See https://aka.ms/new-console-template for more information
using cviko4;

Console.WriteLine("Hello, World!");
string testovaciText = "Toto je retezec predstavovany nekolika radky,\n"
 + "ktere jsou od sebe oddeleny znakem LF (Line Feed).\n"
 + "Je tu i nejaky ten vykricnik! Pro ucely testovani i otaznik?\n"
 + "Toto je jen zkratka zkr. ale ne konec vety. A toto je\n"
 + "posledni veta!";
StringStatistics teststr = new StringStatistics(testovaciText);
Console.WriteLine(testovaciText);
Console.WriteLine("Word count: "+teststr.wordCount());
Console.WriteLine("Row count: " + teststr.rowCount());
Console.WriteLine("Sentences: " + teststr.sentenceCount());
Console.WriteLine("Most counted word: " + teststr.mostWord());
Console.Write("Longest words: ");
foreach (string str in teststr.longestWords()) Console.Write(str + ", ");
Console.Write("\nShortest words: ");
foreach (string str in teststr.shortestWords()) Console.Write(str + ", ");
Console.Write("\nAlphabetical ordered words: ");
foreach (string str in teststr.getWords())Console.Write(str+", ");
