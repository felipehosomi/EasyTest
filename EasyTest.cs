
using System.Linq;
using System;

public class Solution
{
    public bool DetectCapitalUse(string word)
    {
        try
        {
            if (word.Length == 0 || word.Length > 100)
            {
                throw new ArgumentException("Invalid size", "word");
            }

            if (word.All(char.IsUpper) || word.All(char.IsLower) || char.IsUpper(word[0]) && word.Substring(1).All(char.IsLower))
            {
                return true;
            }
            return false;
        }
        catch (Exception ex)
        {
            throw;
        }
    }
}