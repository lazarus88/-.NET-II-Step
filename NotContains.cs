int NotContains(int[] array)
{
    int cnt = 0;
    while (true)
    {
        cnt++;
        if (!array.Contains(cnt)) return cnt;
    }
}
int[] array={ -1,1,2,3,4,6,0 ,235, 31, 14, 5 };
Console.WriteLine(NotContains(array));