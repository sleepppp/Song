public static class Searching
{
    public static void DFS(ref string[,] arr, DimensionIndex index)
    {
        if (index.X < 0 || index.X >= 9)
        {
            return;
        }
        if (index.Y < 0 || index.Y >= 9)
        {
            return;
        }
        if (arr[index.Y, index.X] == "x")
        {
            return;
        }

        arr[index.Y, index.X] = "x";

        //출력
        for (int y = 0; y < arr.GetLength(0); y++)
        {
            for (int x = 0; x < arr.GetLength(1); x++)
            {
                Console.Write($"{arr[y, x]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("===============================================");
        Console.ReadLine();

        DFS(ref arr, new DimensionIndex() { X = index.X + 1, Y = index.Y });
        DFS(ref arr, new DimensionIndex() { X = index.X - 1, Y = index.Y });
        DFS(ref arr, new DimensionIndex() { X = index.X, Y = index.Y + 1 });
        DFS(ref arr, new DimensionIndex() { X = index.X, Y = index.Y - 1 });
    }
}