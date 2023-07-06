float premiereTemperature = 0; // Variable to store the temperature entered by the user
float resultat = 0; // Variable to store the conversion result

Console.WriteLine("Press 1 to convert from Celsius to Fahrenheit. Press 2 to do the reverse.");

ConsoleKeyInfo keyInfo; // Variable to store the user's keyboard input

do
{
    keyInfo = Console.ReadKey(); // Read the key pressed by the user
    Console.WriteLine();

    if (keyInfo.KeyChar == '1')
    {
        Console.WriteLine("Enter a temperature in degrees Celsius to convert:");
        premiereTemperature = Convert.ToSingle(Console.ReadLine()); // Convert the input to float
        resultat = ((premiereTemperature * 9 / 5) + 32); // Perform the Celsius to Fahrenheit conversion
        Console.WriteLine(premiereTemperature + "°C is equivalent to " + resultat + "°F.");
    }

    if (keyInfo.KeyChar == '2')
    {
        Console.WriteLine("Enter a temperature in degrees Fahrenheit to convert:");
        premiereTemperature = Convert.ToSingle(Console.ReadLine()); // Convert the input to float
        resultat = (premiereTemperature - 32) * 5 / 9; // Perform the Fahrenheit to Celsius conversion
        Console.WriteLine(premiereTemperature + "°F is equivalent to " + resultat + "°C.");
        Console.WriteLine("You can press 1 or 2 to perform another conversion, or press the Escape key to exit the program.");
    }

} while (keyInfo.Key != ConsoleKey.Escape); // Continue until the user presses the Escape key
