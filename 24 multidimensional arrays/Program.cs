namespace _24_multidimensional_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array of arrays, useful for grids or matrixes
            String[] ford = { "Mustang", "F-150", "Transit" };
            String[] chevy = { "Corvette", "Camara", "Silverado" };
            String[] toyota = { "Corolla", "Camry", "Rav4" };

            //add comma within the square brackets
            String[,] parkingLot = { { "Mustang", "F-150", "Transit" },
                { "Corvette", "Camara", "Silverado" }, 
                { "Corolla", "Camry", "Rav4" } };

            //now you dont need the top ones anymore

            //accessing

            //INDEX FOR ROW, INDEX FOR COLUMN

            int row = 0; //always start at 0
            int column = 2;

            //change the explorer

            parkingLot[row, column] = "Fusion";

            //print as a list

            foreach(string car in parkingLot)
            {
                Console.WriteLine(car);
            }

            parkingLot[2, 0] = "Tacoma";

            //print as a grid

            for (int i = 0; i < parkingLot.GetLength(0); i++) //0 is the dimension
            {
                for (int j = 0; j < parkingLot.GetLength(1); j++)
                {
                    Console.Write(parkingLot[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
