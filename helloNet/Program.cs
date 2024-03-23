using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data
{


class HelloCsharp
{
static void Main(string[] args)
{
        // Console.WriteLine("    /|");
        // Console.WriteLine("   / |");
        // Console.WriteLine("  /  |");
        // Console.WriteLine(" /___|");
        // Console.ReadLine();
        // var m = Csharp();
//          Console.WriteLine("please type your name here ");
//        string name =Console.ReadLine();
//        Console.WriteLine("please type your age ");

//        int age = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("whats your email address");

//        string email =Console.ReadLine();
//        string details = $"thanks for sharing your info\n firstname : {name.ToUpper()} and you are {age} years old, your email address is   {email}";

//         Console.WriteLine( details);

        // lets do basic maths with csharp 
        // Console.WriteLine("To calculate the simple interest of a given value we use PRT/100");
        // Console.WriteLine("please type the value of P here ");
        // int P = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("please type the value of R here ");
        //  int R = Convert.ToInt32(Console.ReadLine());
        //  Console.WriteLine("please type the value of T here ");
        // int T = Convert.ToInt32(Console.ReadLine());
        // int h = 100;

        // double interest = P*R*T/ h;
        // //string Result = Console.WriteLine($" your interest is {interest}");


        // string phrase = "Giraffe Academy";

        // Console.WriteLine(phrase.Length);
        // Console.WriteLine(phrase.ToUpper());
        // Console.WriteLine(phrase.Contains("Academy"));
        // Console.WriteLine(phrase[2]);
        // Console.WriteLine(Math.Round(4.5));
        // Console.WriteLine(Math.);
        //
        //
        // int[] luckyNumbers = {4,5,6,7,8,56,78,23};
        // luckyNumbers[1] = 900;
        // string[] friends = new string[5];
        // friends[0] = "Jim";
        // friends[1] ="kelly";

        // //Console.WriteLine(luckyNumbers[1]);
        // Console.WriteLine(friends[1]);
        // lets talk about methods 

        
        // SayHi();
        // SayBye("Tunde");
        // SayBye("Bami");
        // SayBye("Ifedayo");
        // int cubedNumber = Cube(25);
        // Console.WriteLine(cubedNumber);
        //IfState();
        // Console.WriteLine(GetMax(10,300));
        // Console.WriteLine(MaxNum(27,5,6));

        //Cal();



        // talking about a simple arithmetic calculation 



        // Console.WriteLine("Enter a number ");
        //     double num1 = Convert.ToDouble(Console.ReadLine());

        //     Console.Write("Enter Operator: ");
        //     string op = Console.ReadLine();

        //     Console.WriteLine("Enter a number ");
        //     double num2 = Convert.ToDouble(Console.ReadLine());

        //     if (op == "+")
        //     {
        //         Console.WriteLine(num1 + num2);
        //     }
        //     else if (op == "-")
        //     {
        //         Console.WriteLine(num1 - num2);
        //     }
        //     else if (op == "*")
        //     {
        //         Console.WriteLine(num1 * num2);
        //     }
        //     else if (op == "/")
        //     {
        //         if (num2 != 0)
        //             Console.WriteLine(num1 / num2);
        //         else
        //             Console.WriteLine("Cannot divide by zero");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Invalid Operator");
        //     }

        // Console.ReadLine();
        GetDay(2);
        Console.ReadLine();

        

}
// lets talk about methods
// static void SayHi() {
//         Console.WriteLine("Hello user 2");
// }

// static void SayBye(string name){
//         Console.WriteLine($"Goodbye {name}");
// }
// static double[] Cube(int num){
//         int result = num * num * num ;
//         return result;
// }
// lets talk about if statements;
// static void IfState(){
//         bool isMale = false;
//         bool isTall = true;
//         // we have (and statement) &&, (or statement) ||,
//         if (isMale && isTall) {
//                 Console.WriteLine("You are Tall Male");


//         } else if (isMale && !isTall){

//                 Console.WriteLine("You are a short male");
//         } else if( !isMale && isTall){
//                 Console.WriteLine("You are not a male but you are tall ");

//         }
//         else {
//                 Console.WriteLine(" You are not a male and you are not tall ");
//         }

// }
// // lets talk about comparison operators  =, <=,>=,==, ===, !=, , if true or false
// static int GetMax( int num1, int num2 ){
//         int result;
//         if(num1 > num2){
//                         result = num1;
//         } else {
//                 result = num2;
//         }
//         return result;

// }
// static int MaxNum(int num1, int num2, int num3){
//         int result;
//                 if(num1 >= num2 && num1 >= num3){
//                         result= num1;

//                 } else if (num2 >= num1 && num2 >= num3){
//                         result = num2;
//                 }else{
//                         result = num3;
//                 }

//         return result;
// }

// using switch statement in c#

static string GetDay(int dayNum){
        string dayName;




        switch(dayNum){
                case 0:
                dayName = "Sunday";
                Console.WriteLine(dayName);
                break;
                case 1:
                dayName = "Monday";
                Console.WriteLine(dayName);
                break;
                case 2:
                dayName = "Tuesday";
                Console.WriteLine(dayName);
                break;
                default:
                dayName= "Invalid day NUmber";
                Console.WriteLine(dayName);
                break;


}




        return dayName;

}



}



};