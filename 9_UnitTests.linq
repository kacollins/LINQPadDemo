<Query Kind="Program" />

void Main()
{
	Truncate(123.4567M, 0).Dump("123");
	Truncate(123.4567M, 1).Dump("123.4");
	Truncate(123.4567M, 2).Dump("123.45");
	Truncate(123.4567M, 3).Dump("123.456");
}

public static decimal Truncate(decimal value, int digits)
{
	value *= (decimal)Math.Pow(10, digits); //Move the decimal point to the right by the specified number of digits
	value = Math.Truncate(value);
	value /= (decimal)Math.Pow(10, digits); //Move the decimal point back to where it was
	return value;
}