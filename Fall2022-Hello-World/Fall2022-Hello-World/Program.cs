// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Variables and Objects
// Variable and Declaration
// Variable declaration is stating we have a variable and giving it a name
// If you are just doing declaration, you must state variable type 

// variableType variableName;
string Instructor;

//Variable Assignment  - us giving the variable value
// variableName = value;
Instructor = "Gavin";

Console.WriteLine(Instructor);

// Variable reassignment
Instructor = "Davis";

// All together now!
int Age = 24;
//Variable declaration and assignment at the same time
// can do var Age = 24; and C# will automatically understand that Age is an Integer based on the value of 24

Console.WriteLine(Age);
Console.WriteLine(Instructor);

DateTime currentDateTime = DateTime.Now;
Console.WriteLine(currentDateTime);

//Opperators - in general will peroform some kind basic of operation on some values
// ex. 5 + 13 -> 18

// Arithmetic- Addition: + , Subtraction: - , Multiplication: * , Division: / , Exponents: Math.Pow(), Modulo: %
// Modulo returns the remainder after dividing by a particular number
// Singe "=" is assignment operator
var StudentCount = 5 + 13;
Console.WriteLine(StudentCount);
// Division works weird
var averageClassSize = StudentCount / 4f; //if you have a decimal make sure to lable it as a float -> 18/4 = 4 but 18/4f = 4.5
Console.WriteLine(averageClassSize);
//Modulo example - we divide 13 by 12 and take the remainder - for example this will convert military time to normal time
var time = 13 % 12;
Console.WriteLine(time);

//Equality - checks to see if the value of 'Instructor' is the same as the value "Davis"
var isDavis = Instructor == "Davis";

// Comparison - greater than, less than, etc.

//Incrament

// Variable Types
// String - words/text. A string of charachters
// Int - integers, whole numbers
int monkey = 42;
var monkey2 = 43;
Console.WriteLine(monkey);
Console.WriteLine(monkey2);

// bools - true or false
// Booleans - is a data type where the only value types are 'true' or 'false'
var isSunny = true;
// Boolean Operators - specific operators defined for actions between two boolean values
// OR operator - || - returns 'true' if the left OR right is true
// AND operator - && - returns if left and right values are true
var isRainy = true;
var isCold = true;
var willNotDrive = isRainy && isCold; // true & true -> true
// NOT operator - !
// Not operator switches a true value to false and a false value to true - Returns opposite of a given boolean value
// !true -> false and !false -> true
var willDrive = !willNotDrive;
// Exclusifve OR (XOR)operator ^
// Only returns true when the left or right are true - false when both are true
// true ^ false -> true
//true ^ true -> false

// Excersise 
// bool one = true
// bool two = false
// bool three = true
// 1. (one &&!two) = true
// 2. (three || (two&& three)) = true - the right is false but the left is true
// 3. !two && (!three &&(one || two)) || three -> true
// 4. one && two && three -> false
// 5. one || two || three -> true