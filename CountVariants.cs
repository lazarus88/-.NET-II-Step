int CountVariants(int stairCount)
{
    if (stairCount == 2) return 2;
    if (stairCount == 1) return 1;
    if (stairCount <= 0) return 0;
    return CountVariants(stairCount - 1)+CountVariants(stairCount-2);
}
Console.WriteLine(CountVariants(4));