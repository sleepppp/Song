
string[,] arr = new string[9, 9];
for (int y = 0; y < arr.GetLength(0); y++)
{
    for (int x = 0; x < arr.GetLength(1); x++)
    {
        arr[y, x] = "x";
    }
}

for (int y = 1; y < arr.GetLength(0) - 1; y++)
{
    for (int x = 1; x < arr.GetLength(1) - 1; x++)
    {
        arr[y, x] = "o";
    }
}

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

Searching.DFS(ref arr, new DimensionIndex() { X = 4, Y = 4 });

//탐색 알고리즘
//Queue를 쓰면 BFS(너비 우선 탐색)
//Stack을 쓰면 DFS(깊이 우선 탐색)(재귀함수 쓰면 깊이 우선 탐색)

//Queue<DimensionIndex> searchingIndexContainer = new Queue<DimensionIndex>();
//searchingIndexContainer.Enqueue(new DimensionIndex() { X = 4, Y = 4 });
//
//while (searchingIndexContainer.Count != 0)
//{
//    //탐색
//    DimensionIndex popData = searchingIndexContainer.Dequeue();
//    if (popData.X < 0 || popData.X >= 9)
//    {
//        continue;
//    }
//    if (popData.Y < 0 || popData.Y >= 9)
//    {
//        continue;
//    }
//    if (arr[popData.Y, popData.X] == "x")
//    {
//        continue;
//    }
//    arr[popData.Y, popData.X] = "x";
//
//    searchingIndexContainer.Enqueue(new DimensionIndex() { X = popData.X - 1, Y = popData.Y });
//    searchingIndexContainer.Enqueue(new DimensionIndex() { X = popData.X + 1, Y = popData.Y });
//    searchingIndexContainer.Enqueue(new DimensionIndex() { X = popData.X, Y = popData.Y - 1 });
//    searchingIndexContainer.Enqueue(new DimensionIndex() { X = popData.X, Y = popData.Y + 1 });
//
//    //출력
//    for (int y = 0; y < arr.GetLength(0); y++)
//    {
//        for (int x = 0; x < arr.GetLength(1); x++)
//        {
//            Console.Write($"{arr[y, x]} ");
//        }
//        Console.WriteLine();
//    }
//    Console.WriteLine("===============================================");
//    Console.ReadLine();
//}