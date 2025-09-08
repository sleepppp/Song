int[,] bingo = new int[5, 5];

//빙고판을 1~9 값 채우기
//섞어야겠죠??

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write($"{bingo[i, j]} ");
    }
    Console.WriteLine();
}

//게임 시작

//숫자 입력
//해당 숫자 찾아서 X로 변경
//한 줄 완성되면 1빙고