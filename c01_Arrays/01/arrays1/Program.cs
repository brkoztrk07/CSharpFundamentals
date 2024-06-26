#region How to Create Array 
//int[] arr = new int[arr.Length];
// There are limitations in arrays, it is necessary to specify the number of elements first.
int[] arr1 = new int[10]; // >> like here.
#region 2. variation
var number2 = new[] { 1, 2, 3, 4 };
//var is assigned when array's members defined..
#endregion
#region Create Array With CreateInstance MEthod
int[] values = new int[3]; //This is also calls on background CreateInstance Method.
Array values1 = Array.CreateInstance(typeof(int), 3); // We can also use this method.
#endregion
#endregion
#region How to call Array element and assign a value.
int[] yaslar = new int[] { 1, 3, 5, 7 };
yaslar[3] = 5; // Its not have to be in order when assigning value.
yaslar[2] = 16;
yaslar[0] = 27;
Console.WriteLine(yaslar); // You can not use array's name when calling them. Because Console.WriteLine 
//calls ToString() method. Then Tostring method shows you a array's type and location on RAM.
foreach (int i in yaslar) // This shows how you print the members arrays. You can use loops also.
    Console.WriteLine(i);
#endregion
#region Substring MEthod
int[] values5 = new int[] { 2, 3, 5, 6, 7, 8 };

#endregion
#region IndexOf Method on Arrays..
//The IndexOf method is a query whether an element exists in the array or not.
string[] words = new string[3] { "Ali", "Jason", "Burak" };
int index2 = Array.IndexOf(words, "Burak", 0, 3); // first parameter for ArrayName, Second is Start index, third one is count.
//This method returns a index of element if its exists. If not, returned -1.
Console.WriteLine(index2);
#endregion
#region Reverse MEthod
for (int i = 0; i < words.Length; i++)
{
    Console.WriteLine(words.GetValue(i));
}
Array.Reverse(words);
for (int i = 0; i < words.Length; i++)
{
    Console.WriteLine(words.GetValue(i));
}
#endregion
