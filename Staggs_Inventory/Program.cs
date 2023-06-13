// Colton Staggs
// IT112 
// NOTES: 
// BEHAVIORS NOT IMPLEMENTED AND WHY: 
namespace Staggs_Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool activeProgram = true;
            string mainUserInput = string.Empty;
            char parsedInput;
            Shipper shipper = new Shipper();
            do
            {
                mainUserInput = Console.ReadLine();
                char.TryParse(mainUserInput, out parsedInput);
                switch (parsedInput)
                {
                    case'1' or '2' or '3' or '4':
                        shipper.add(parsedInput);
                        break;
                    case '5':
                        Console.WriteLine(shipper.list());
                        break;
                    case '6':
                        shipper.compute();
                        break;
                }
            }
            while (activeProgram);
            
        }
    }
}