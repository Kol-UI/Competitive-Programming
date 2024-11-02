namespace CompetitiveProgramming.Algorithms;

/*
A sentence is circular if:

The last character of a word is equal to the first character of the next word.
The last character of the last word is equal to the first character of the first word.
*/
public class CircularSentence
{
    #region LC2490
    public bool IsCircularSentence(string sentence)
    {
        var words = sentence.Split(" ");
        if(words.Length < 1)
            return false;

        else if(!words[words.Length - 1].EndsWith(words[0][0]))
            return false;

        for(int i = 0; i < words.Length - 1; i++)
        {
            if(words[i+1][0] != (words[i][words[i].Length-1]))
            {
                return false;
            }
        }
        return true;
    }
    #endregion
}