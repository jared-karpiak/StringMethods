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

            /***** Formatting *****/

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

            // With strings, white spaces count as a character, but that may be undesireable in some cases
            // especially if they are at the beginning or end of a string.
            // Using the Trim() method, we can remove all 'leading' and 'trailing' white space.
            string lotsOfSpace = "     Hello!     ";
            Console.WriteLine($"Not trimmed: {lotsOfSpace}");
            Console.WriteLine($"Trimmed: {lotsOfSpace.Trim()}");

            

            /***** COMPARISON *****/

            // Contains() will tell us if a character or substring exists in the string.
            // It returns a boolean (true/false)

            Console.WriteLine($"Does {name} contain 'T'? {name.Contains('T')}.");
            Console.WriteLine($"Does {name} contain \"ggff\"? {name.Contains("ggff")}.");

            // Equals() will compare the string with another string. If they are an exact match, it will return
            // true, if not it will return false.

            string secondName = "Taylor Swift";
            string thirdName = "Ed Sheeran";

            Console.WriteLine($"Does {secondName} match {name}? {name.Equals(secondName)}");
            Console.WriteLine($"Does {thirdName} match {name}? {name.Equals(thirdName)}");

            // CompareTo() will compare the positions of two strings based on its SORTING order (more on sorting later in the course).
            // It takes in a second string and will compare where there are in sorting order.
            // It will return an integer:
            //    - If the integer is negative, it means the original string precedes the second string
            //    - If the integer is 0, it means the strings appear in the same position (ie. identical string)
            //    - If the integer is positive, it means the original string follows the second string.
            // Here are some examples:

            string strFirst = "Goodbye";
            string strSecond = "Hello";
            string strThird = "a small string";
            string strFourth = "goodbye";

            // this will us give 0 because the strings are identical
            Console.WriteLine($"Comparing \"{strFirst}\" to \"{strFirst}\" gives us: {strFirst.CompareTo(strFirst)}");

            // this will give us a negative number because "Goodbye" precedes "Hello" in sorting order.
            Console.WriteLine($"Comparing \"{strFirst}\" to \"{strSecond}\" gives us: {strFirst.CompareTo(strSecond)}");

            // this will give us a positive number "Goodbye" follows "a small string" in sorting order.
            Console.WriteLine($"Comparing \"{strFirst}\" to  \"{strThird}\" gives us: {strFirst.CompareTo(strThird)}");

            // this will give us a positive number "Goodbye" follows "goodbye" in sorting order.
            Console.WriteLine($"Comparing \"{strFirst}\" to  \"{strFourth}\" gives us: {strFirst.CompareTo(strFourth)}");

            /***** INDEXING  ******/

            // IndexOf() is going to give the number of the first occurrence of a given character or string
            // It returns an integer, the index of string.
            Console.WriteLine($"The space in {name} is located at {name.IndexOf(' ')}.");

            // We can pass in a full string as well, and it will give us the index of the first character
            string subString = "lor";
            Console.WriteLine($"The substring '{subString}' in {name} is located at index {name.IndexOf(subString)}.");

            // If IndexOf() cannot find the string or substring, it will return a -1.
            Console.WriteLine($"The Z in {name} is located at index {name.IndexOf('Z')}.");

            // To select a specific character inside of a string, we can identify it using its index.
            // To choose the character using its index, we provide the name of the string variable,
            // followed immediately by square brackets [] that contain inside of them the index.
            // For example:

            Console.WriteLine($"The first character of {name} is {name[0]}.");

            // In C#, arrays are 0-indexed, meaning that in order to select the first character, we use
            // the number 0, to get the second character we use the number 1, etc.
            // If we want to get the fifth character in the string:

            Console.WriteLine($"The fifth character of {name} is {name[4]}.");

            // To get the last character in a string, we can combine the .Length method with -1 to get us the last index.
            // ALWAYS make sure to include the -1 here, if you just use .Length, you will get an
            // "Index Out Of Range" error, which is very bad.

            //                                                string     .Length   -1
            //                                                    |         |       |
            //                                                    v         v       v
            Console.WriteLine($"The last character of {name} is {name[name.Length - 1]}");

            // The above case would be the same as doing name[11], but with name.Length - 1, we can
            // can avoid the Out of Range error in case the string changes elsewhere in our code.


            // To get a "sub string" (a small string inside of the big string) we can use the Substring method.
            // Substring() takes two integers.
            // The first int is the starting index, which is INCLUSIVE.
            // The second int is the number of characters to include (the length).

            //                                                 index of first char      index of space (6, ie. length of 6)
            //                                                              |                |
            //                                                              v                v
            Console.WriteLine($"The first name of {name} is {name.Substring(0, name.IndexOf(' '))}");



        }
    }
}
