<Query Kind="Statements" />

int output;
string input = Console.ReadLine();
input.Dump(nameof(input));
Int32.TryParse(input, out output).Dump("TryParse");
output.Dump(nameof(output));