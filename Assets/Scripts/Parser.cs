using System;
using System.Collections.Generic;
using System.Linq;

public class Parser
{
    public event Action ParsingStateChanged;

    public List<int> ParseToList(int[] randomNumbers)
    {
        ParsingStateChanged?.Invoke();
        return randomNumbers.ToList();
    }

    public int[] Unparse(IEnumerable<int> randomNumbers)
    {
        ParsingStateChanged?.Invoke();
        return randomNumbers.ToArray();
    }
}