// for and foreach loop practices
// Examples
/*
for (int i = 0; i < 3; i++)
{
    Console.Write(i);
}
// Output:
// 012
*/
/*
// increase by 2
for (int i = 0; i < 30; i+=2)
{
    Console.Write(i + " ");
}
// Output:
// 024681012...
*/
/*
int i;
int j = 3;
for (i = 0, Console.WriteLine($"Start: i={i}, j={j}"); i < j; i++, j--, Console.WriteLine($"Step: i={i}, j={j}"))
{
    //...
}
// Output:
// Start: i=0, j=3
// Step: i=1, j=2
// STep i=2, j=1
*/


//**************FOREACH***************
//example 1
/*
var fibNumbers = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13};
foreach (int element in fibNumbers)
{
    Console.Write($"{element} ");
}
*/

//example 2
/*
Span<int> numbers = new int[] { 3, 14, 15, 92, 6};
foreach (int number in numbers)
{
    Console.Write($"{number} ");
}
*/

//example 3
/*
Span<int> storage = stackalloc int[10];
int num = 0;
foreach (ref int item in storage)
{
    item = num++;
}
foreach (ref readonly var item in storage)
{
    Console.Write($"{item} ");
}
*/

//example 4 - awaite foreach
/*
//error error CS0103: The name 'GenerateSequenceAsync' does not exist in the current context
//note for later to learn more
await foreach (var item in GenerateSequenceAsync())
{
    Console.WriteLine(item);
}
*/

//***************************DO/WHILE**************************