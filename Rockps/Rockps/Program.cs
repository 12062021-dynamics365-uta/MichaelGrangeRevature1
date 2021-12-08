using System;

namespace Rock_Paper_Scissors_Demo1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, I am God. Humanity is sure to perish at the hands of A.I. unless I intervene. Win this simple game of chance to redeem Mankind.");

			int rounds = 0;
			int botScore = 0;
			int userScore = 0;

			while (rounds < 3)
			{
				int convertedNumber = -1;
				bool conversionBool = false;
				Console.WriteLine("Please type 1 for ROCK, 2 for PAPER, 3 for SCISSORS, then hit the enter key to submit your answer.");
				string userInput = Console.ReadLine();
				conversionBool = Int32.TryParse(userInput, out convertedNumber);

				if (conversionBool && convertedNumber > 0 && convertedNumber < 4)
				{
					Random randNum = new Random();
					int botNum = randNum.Next(1, 4);
					String botMove;
					String userMove;

					switch (convertedNumber)
					{
						case 1:
							userMove = "Rock";
							break;
						case 2:
							userMove = "Paper";
							break;
						default:
							userMove = "Scissors";
							break;
					}

					Console.WriteLine($"You say {userMove}.");

					switch (botNum)
					{
						case 1:
							botMove = "Rock";
							break;
						case 2:
							botMove = "Paper";
							break;
						default:
							botMove = "Scissors";
							break;
					}

					Console.WriteLine($"bot says {botMove}.");

					switch (convertedNumber)
					{
						case 1:
							switch (botNum)
							{
								case 1:
									Console.WriteLine("You tied this round, because you both said Rock.");
									rounds++;
									break;
								case 2:
									Console.WriteLine("You lost this round, because you said Rock and the bot said Paper. ");
									rounds++;
									botScore++;
									break;
								default:
									Console.WriteLine("You won this round, because you said Rock and the bot said Scissors.");
									rounds++;
									userScore++;
									break;
							}
							break;
						case 2:
							switch (botNum)
							{
								case 1:
									Console.WriteLine("You won this round, because you said Paper and the bot said Rock");
									rounds++;
									userScore++;
									break;
								case 2:
									Console.WriteLine("You tied this round, because you both said Paper");
									rounds++;
									break;
								default:
									Console.WriteLine("You lost this round, because you said Paper and the bot said Scissors.");
									rounds++;
									botScore++;
									break;
							}
							break;
						case 3:
							switch (botNum)
							{
								case 1:
									Console.WriteLine("You lost this round, because you said Scissors and the bot said Rock");
									rounds++;
									botScore++;
									break;
								case 2:
									Console.WriteLine("You won this round, because you said Scissors and the bot said Paper");
									rounds++;
									userScore++;
									break;
								default:
									Console.WriteLine("You tied this round because you both said Scissors");
									rounds++;
									break;

							}
							break;
					}


				}
				else
				{
					Console.WriteLine("You test my patience mortal... that wasn't a 1 or 2 or 3!");
				}
			}

			if (botScore > userScore)
			{
				Console.WriteLine($"The bot has won {botScore} to {userScore}....Abandon All Hope.");
			}
			if (userScore > botScore)
			{
				Console.WriteLine($"You have won {userScore} to {botScore}...Mankind is saved, Blessed be MY name.");
			}
			if (userScore == botScore)
			{
				Console.WriteLine("You have tied the game, but lost everything... Remember? I said you must WIN.");
			}

			return;

		}
	}
}