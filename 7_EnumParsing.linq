<Query Kind="Program" />

void Main()
{
	ParseColor(6);
	//ParseColor(16);
}

public void ParseColor(int input)
{
	input.Dump(nameof(input));

	Colors selectedColor;
	Enum.TryParse(input.ToString(), out selectedColor).Dump("TryParse");
	selectedColor.Dump(nameof(selectedColor));

	Enum.IsDefined(typeof(Colors), input).Dump("IsDefined");
}

public enum Colors
{
	Black,
	Brown,
	Red,
	Orange,
	Yellow,
	Green,
	Blue,
	Violet,
	Gray,
	White
}
