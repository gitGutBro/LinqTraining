using System;
using System.Collections.Generic;
using System.Linq;

public class Parser
{
    public event Action ParsingStateChanged;

    public void ParseToList(int[] randomNumbers)
    {
        randomNumbers.ToList();
        ParsingStateChanged?.Invoke();
    }

    public void Unparse(IEnumerable<int> randomNumbers)
    {
        randomNumbers.ToArray();
        ParsingStateChanged?.Invoke();
    }
}