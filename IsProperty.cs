bool IsProperly(string sequence)
{
    Stack<char> conteiner = new Stack<char>();
    if (sequence.Length == 0) return true;
    if (sequence[0] == ')') return false;
    conteiner.Push(sequence[0]);
    int cnt = 1;
    while (cnt!=sequence.Length-1)
    {
        if (sequence[cnt] == ')')
            if (conteiner.Count == 0) return false;
        else conteiner.Pop();
        cnt++;
    }
    return true;
}
Console.WriteLine(IsProperly("()()()(())())()"));