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

// Arithmetic- Addition: + , Subtraction: - , Multiplication: * , Division: / , Exponents: ^ , Modulo: % 
// Modulo returns the remainder after dividing by a particular number
var StudentCount = 5 + 13;
Console.WriteLine(StudentCount);
// Division works weird
var averageClassSize = StudentCount / 4f; //if you have a decimal make sure to lable it as a float -> 18/4 = 4 but 18/4f = 4.5
Console.WriteLine(averageClassSize);
//Modulo example - we divide 13 by 12 and take the remainder - for example this will convert military time to normal time
var time = 13 % 12;
Console.WriteLine(time);

//Equality
    
// Comparison

//Incrament
