void Shplit(int amount,int current, int counter,ref int ind)
{
    if (ind > 0) return;
    if (current > amount) return;
    if(current==amount)
    {
        ind = counter;
        return;
    }
    Shplit(amount, current + 50, counter + 1, ref ind);
    Shplit(amount, current + 20, counter + 1, ref ind);
    Shplit(amount, current + 10, counter + 1, ref ind);
    Shplit(amount, current + 5, counter + 1, ref ind);
    Shplit(amount, current + 1, counter + 1, ref ind);
}
int MinSplit(int amount)
{
    int ind = 0;
    Shplit(amount, 0, 0,ref ind);
    return ind;
}
Console.WriteLine(MinSplit(13));
