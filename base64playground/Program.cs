// See https://aka.ms/new-console-template for more information

string str = "hao";

Console.WriteLine($"char {str[0]} - {Convert.ToString(str[0], 2).PadLeft(8, '0')}");
Console.WriteLine($"char {str[0]} & 0xff - {(str[0] & 0xff)}");
Console.WriteLine($"char {str[0]} >> 2 - {Convert.ToString((str[0] >> 2), 2)}");

Console.WriteLine($"char {str[0]} & 0x3 - {(str[0] & 0x3)}");
var letterOne = str[0];

Console.WriteLine($"String {str} first letter is \"{letterOne}\", binary is {Convert.ToString(letterOne, 2).PadLeft(8, '0')}, decimal is {letterOne & 0xff} ");
Console.WriteLine($"String {str} first letter right shift 2 >> 2, binary is {Convert.ToString(letterOne >> 2, 2).PadLeft(8, '0')}, decimal is {letterOne >> 2}");
Console.WriteLine($"String {str} first letter & 0x3, binary is {Convert.ToString((letterOne & 0x3), 2)}");
Console.WriteLine(0b_01101000 & 0b_00000011);

var letterTwo = str[1];
Console.WriteLine($"String {str} second letter is \"{letterTwo}\", binary is {Convert.ToString(letterTwo, 2).PadLeft(8, '0')}, decimal is {letterTwo & 0xff} ");



var letterThree = str[2];
Console.WriteLine($"String {str} third letter is \"{letterThree}\", binary is {Convert.ToString(letterThree, 2).PadLeft(8, '0')} ");


Console.WriteLine($"============== Convert \"{str}\" to base64 end ==============");

Console.WriteLine($"1 << 1 - {Convert.ToString(1 << 1, 2)}");
Console.WriteLine($"1 << 2 - {Convert.ToString(1 << 2, 2)}");

Console.WriteLine("============== 0xff to bin and dec ==============");
Console.WriteLine($"0xff to binary {ConvertFromNBaseToAnother("0xff", 16, 2,true)}");
Console.WriteLine($"0xff to decimal {ConvertFromNBaseToAnother("0xff", 16, 10)}");

Console.WriteLine("============== 0x3 to bin and dec ==============");
Console.WriteLine($"0x3 to binary {ConvertFromNBaseToAnother("0x3", 16, 2,true)}");
Console.WriteLine($"0x3 to decimal {ConvertFromNBaseToAnother("0x3", 16, 10)}");

Console.WriteLine("============== 0x30 to bin and dec ==============");
Console.WriteLine($"0x30 to binary {ConvertFromNBaseToAnother("0x30", 16, 2,true)}");
Console.WriteLine($"0x30 to decimal {ConvertFromNBaseToAnother("0x30", 16, 10)}");

Console.WriteLine("============== 0x3c to bin and dec ==============");
Console.WriteLine($"0x3c to binary {ConvertFromNBaseToAnother("0x3c", 16, 2,true)}");
Console.WriteLine($"0x3c to decimal {ConvertFromNBaseToAnother("0x3c", 16, 10)}");


Console.WriteLine("============== 0xf to bin and dec ==============");

Console.WriteLine($"0xf to binary {ConvertFromNBaseToAnother("0xf", 16, 2,true)}");
Console.WriteLine($"0xf to decimal {ConvertFromNBaseToAnother("0xf", 16, 10)}");

Console.WriteLine("============== 0xf0 to bin and dec ==============");


Console.WriteLine($"0xf0 to binary {ConvertFromNBaseToAnother("0xf0", 16, 2,true)}");
Console.WriteLine($"0xf0 to decimal {ConvertFromNBaseToAnother("0xf0", 16, 10)}");

Console.WriteLine("============== 0xc0 to bin and dec ==============");


Console.WriteLine($"0xc0 to binary {ConvertFromNBaseToAnother("0xc0", 16, 2,true)}");
Console.WriteLine($"0xc0 to decimal {ConvertFromNBaseToAnother("0xc0", 16, 10)}");

Console.WriteLine("============== 0x3f to bin and dec ==============");


Console.WriteLine($"0x3f to binary {ConvertFromNBaseToAnother("0x3f", 16, 2,true)}");
Console.WriteLine($"0x3f to decimal {ConvertFromNBaseToAnother("0x3f", 16, 10)}");


string ConvertFromNBaseToAnother(string val, int fromBase, int toBase, bool padding = false)
{
    // string number = "0xff";
    // int fromBase = 16;
    // int toBase = 2;

    var result = Convert.ToString(Convert.ToInt32(val, fromBase), toBase);

    if (padding)
    {
        result = result.PadLeft(8, '0');
    }
    return result;
}