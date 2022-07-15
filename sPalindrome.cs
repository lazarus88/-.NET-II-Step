bool sPalindrome(string text)
{
    for(int i = 0; i < text.Length/2; i++)
    {
        if (text[i] != text[text.Length - i - 1]) return false;
    }
    return true;
}
Console.WriteLine(sPalindrome("abba"));