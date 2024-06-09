using microondas;

Console.WriteLine("     1 2 3" + "\n" + "     4 5 6" + "\n" + "     7 8 9" + "\n" + "       0" + "\n");
Console.WriteLine("Descongelar");
Console.WriteLine("Palomitas");
Console.WriteLine("Pizza");
Console.WriteLine("Calentado rapido");


var input = Console.ReadLine();

switch (int.TryParse(input, out int result))
{
	case true:
		Console.WriteLine(TimerMicroondas.SetFormat(TimerMicroondas.ConvertInputTimer(result.ToString())));
		TimerMicroondas.GoTime(input);
		Console.ReadKey();
		break;
	default:
		switch (input)
		{
			case "Descongelar":
				Console.WriteLine(TimerMicroondas.SetFormat(TimerMicroondas.ConvertInputTimer("120")));
				TimerMicroondas.GoTime("120");
				Console.ReadKey();
				break;
			case "Palomitas":
				Console.WriteLine(TimerMicroondas.SetFormat(TimerMicroondas.ConvertInputTimer("180")));
				TimerMicroondas.GoTime("180");
				Console.ReadKey();
				break;
			case "Pizza":
				Console.WriteLine(TimerMicroondas.SetFormat(TimerMicroondas.ConvertInputTimer("240")));
				TimerMicroondas.GoTime("240");
				Console.ReadKey();
				break;
			case "Calentado rapido":
				Console.WriteLine(TimerMicroondas.SetFormat(TimerMicroondas.ConvertInputTimer("60")));
				TimerMicroondas.GoTime("60");
				Console.ReadKey();
				break;
			default:
				Console.WriteLine("Invalid input");
				break;
		}
		break;
}


