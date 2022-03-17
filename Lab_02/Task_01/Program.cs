using System;

namespace lessons
{
	class Program
    {
		static bool check(string num)
		{
			for (int i = 0; i < num.Length; ++i) 
			{
				char element = num[i];
				if (char.IsLetter(element) || Char.IsPunctuation(element))
				{
					return false;
				}
			}
			return true;
		}

		static bool secCheck(string choice)
        {
			if (choice.Length != 1) return false;
			if (choice[0] == 'Y' || choice[0] == 'N') return true;
			return false;
        }

		static void cont()
        {
			Console.WriteLine("Enter the number (integer): ");
			string number = Console.ReadLine();

			while (!check(number))
			{
				Console.WriteLine("invalid value, please, try again\n");
				number = Console.ReadLine();
			}
			if (number[number.Length - 1] == '7')
			{
				Console.WriteLine("the number ends with 7");
			}
			else
            {
				Console.WriteLine("the number doesn't ends with 7, it ends with " + number[number.Length - 1] + '\n');
            }
		}

			static void Main(string[] args)
		{
			cont();
			bool contin = true;
			while (contin) {
				Console.WriteLine("Do you wish to proceed? (Y/N): ");
				string choice = Console.ReadLine();

				while (!secCheck(choice))
				{
					Console.WriteLine("invalid value, please, try again");
					choice = Console.ReadLine();
				}
				switch (choice[0]){
					case 'Y':
						cont();
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

