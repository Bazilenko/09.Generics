using System;
public class Program
{
    public static void Main()
    {
        Menu7();
    }
    static void Menu7()
    {
        CustomList<string> customList = new CustomList<string>();

        string command;
        while ((command = Console.ReadLine()) != "END")
        {
            string[] commandParts = command.Split();
            string action = commandParts[0];

            switch (action)
            {
                case "Add":
                    customList.Add(commandParts[1]);
                    break;

                case "Remove":
                    int removeIndex = int.Parse(commandParts[1]);
                    customList.Remove(removeIndex);
                    break;

                case "Contains":
                    Console.WriteLine(customList.Contains(commandParts[1]));
                    break;

                case "Swap":
                    int index1 = int.Parse(commandParts[1]);
                    int index2 = int.Parse(commandParts[2]);
                    customList.Swap(index1, index2);
                    break;

                case "Greater":
                    Console.WriteLine(customList.CountGreaterThan(commandParts[1]));
                    break;

                case "Max":
                    Console.WriteLine(customList.Max());
                    break;

                case "Min":
                    Console.WriteLine(customList.Min());
                    break;

                case "Print":
                    customList.Print();
                    break;

                case "Sort":
                    customList.Sort();
                    customList.Print();
                    break;

                default:
                    throw new InvalidOperationException("Invalid command.");
            }
        }
    }
}