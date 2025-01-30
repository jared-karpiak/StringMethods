namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Taylor Swift";

            // Strings are technically an "array" of char types.
            // An array is a type of collection that can be "indexed"
            // Here the name "Taylor Swift" is a collection of 12 char elements (the white space is included).

            // Each item in an array is given an "index", basically an 'id' of sorts.
            // In C# arrays are 0-indexed (the first item is 0, the second is 1, etc.)
            // For the string "Taylor Swift", the 0th character is 'T', the 7th character is 'S', and so on.

            // 'T' + 'a' + 'y' + 'l' + 'o' + 'r' + ' ' + 'S' + 'w' + 'i' + 'f' + 't'
            //  0     1     2     3     4     5     6     7     8     9     10    11

            // the Length method will return the number of characters in the string.
            Console.WriteLine($"The length of {name} is {name.Length}.");

            // The ToUpper() method will convert all characters in the string to uppercase
            // However it will not permanently change the variable to be uppercase
            // To permanently change it we would have to reassign the variable, like this:
            // name = name.ToUpper();
            Console.WriteLine($"{name} in upper case is {name.ToUpper()}.");
            Console.WriteLine($"This is {name} after the ToUpper() call.");

            // There is also a ToLower() method, which is used the same way as ToUpper(),
            // but instead makes all characters lower case.
            Console.WriteLine($"{name} in lower case is {name.ToLower()}.");

            // IndexOf() is going to give the number of the first occurrence of a given character or string
            // It returns an integer, the index of string.
            Console.WriteLine($"The space in {name} is located at {name.IndexOf(' ')}.");
            Console.WriteLine($"The S in {name} is located at index {name.IndexOf('S')}.");

            // We can pass in a full string as well, and it will give us the index of the first character
            string subString = "lor";
            Console.WriteLine($"The substring '{subString}' in {name} is located at index {name.IndexOf(subString)}.");
            
        }
    }
}
