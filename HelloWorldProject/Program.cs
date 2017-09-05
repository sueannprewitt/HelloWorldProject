using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldProject {
	class Program {
		//properties (variables) go first
		static int Age;
		int Counter = 0;
		//methods (functions) go last


		int IncrementNumber (int nbr) {
			int incrementValue = 7;
			return nbr + incrementValue;
		}

		string ToFullName (string P1, string P2) {
			return P1 + " " + P2; //or $"{P1} {P2}";
		}

		int AddNumbers(int parameter1, int parameter2) {
			return parameter1 + parameter2;
		}
		int AddNumbers(int parameter1, int parameter2, int parameter3) {
			return parameter1 + parameter2 + parameter3;
		}

		double AddNumbers(double parameter1, double parameter2) {
			return parameter1 + parameter2;
		}
		int SubtractTwoNumbers(int parameter1, int parameter2) {
			return parameter1 - parameter2;
		}

		void Print(string message) {
			Console.WriteLine(message);
		}


		static void Main(string[] args) {
			new Program().Run();
		}
		void Run() {


			var fullname = ToFullName("SueAnn", "Prewitt");
			Print(fullname); //Another option: Print (ToFullName("SueAnn", "Prewitt"));
			Print(IncrementNumber(6).ToString());
			Print(AddNumbers(2, 3, 4).ToString());
			Print(AddNumbers(2.2, 3.3).ToString());
			var sum = AddNumbers(2, 3);
			Print(sum.ToString());

			var diff = SubtractTwoNumbers(5, 3);
			Print(diff.ToString());
			Print("Hello, World!");
			Age = 0;
			Print(Age.ToString());
			int Counter = 1;
			Console.WriteLine("Value of counter is " + Counter);
			var aLong = 0L; // initialize a long variable type
			double pi = 3.1419;
			double r = 1.0;
			double two = 2.0;
			double answer;
			answer = two * pi * r;
			Console.WriteLine(answer);

			double a = 3;
			double b = 4;
			var c = Math.Sqrt(a * a + b * b);
			Console.WriteLine("c equals " + c);

			string s = "This is a string";
			Console.WriteLine(s);
			var sUppercase = s.ToUpper();
			Console.WriteLine(sUppercase);
			var sLowercase = sUppercase.ToLower();
			Console.WriteLine(sLowercase);

			var FirstName = "Greg";
			var LastName = "Doud";
			var FullName = FirstName + " " + LastName;
			Console.WriteLine("Full name is " + FullName);

			string aNullValue = null;


			string ANewFullName = $"{FirstName} {LastName}";
			Console.WriteLine(ANewFullName);

			string AreaCode = "513";
			string Exchange = "555";
			string Number = "1212";
			string Phone = $"({AreaCode}) {Exchange}-{Number}";
			Console.WriteLine(Phone);

			Console.WriteLine($"{FirstName} {LastName} phone number is {AreaCode}-{Exchange}-{Number}");

			var message = $"{FirstName} {LastName} phone number is {AreaCode}-{Exchange}-{Number}";
			Console.WriteLine(message); //same as line above just different way of doing it



			//booleans
			bool TrueValue = true; // or false;
			bool HasBlondHair = false;
			Print($"The value of the TrueValue variable is {TrueValue}");







		}
	}
}
