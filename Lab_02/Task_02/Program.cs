using System;

namespace lessons
{
	class Program
	{
		static bool checkUp(string input)
        {
			if (!double.TryParse(input, out double result))
			{
				Console.WriteLine("invalid value, try again");
				return false;
			}
			else
			{
				return true;
			}
		}

		static bool secCheck(string choice)
		{
			if (choice.Length != 1) return false;
			if (choice[0] == 'Y' || choice[0] == 'N') return true;
			return false;
		}

		static bool inArea(double x, double y)
        {
			if (Math.Abs(x) > Math.Abs(y)) return false;
			else if (Math.Pow(x, 2) + Math.Pow(y, 2) <= 625) return true;
			else return false;
        }

		static double getNum(string phrase)
        {
			bool checkX = false;
			while (!checkX)
			{
				Console.WriteLine(phrase);
				string inputX = Console.ReadLine();

				checkX = checkUp(inputX);
				if (checkX) return double.Parse(inputX);
			}
			return 0;
		}

		static void result()
        {
			bool checkX = false;
			bool checkY = false;
			double x, y;
			x = getNum("Enter coordinates. x: ");
			y = getNum("y: ");

			if (inArea(x, y))
			{
				if (y == -Math.Abs(x) || Math.Pow(x, 2) + Math.Pow(y, 2) == 625)
				{
					Console.WriteLine("The pount is on the border of the sector.");
				}
				else Console.WriteLine("The pount is located inside the sector.");
			}
			else Console.WriteLine("The pount is loccated otside the sector.");

		}

		static void Main(string[] args)
		{
			result();
			bool contin = true;
			while (contin)
			{
				Console.WriteLine("Do you wish to proceed? (Y/N): ");
				string choice = Console.ReadLine();

				while (!secCheck(choice))
				{
					Console.WriteLine("invalid value, please, try again");
					choice = Console.ReadLine();
				}
				switch (choice[0])
				{
					case 'Y':
						result();
						break;
					case 'N':
						contin = false;
						break;
					default:
						return;
				}
			}
		}
	}
}