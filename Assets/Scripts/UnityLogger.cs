using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class UnityLogger
{
    public void LogNumbersMoreThanTen(int[] randomNumbers)
    {
        const int MaxNumber = 10;

        var filteredNumbers = randomNumbers
            .Where(n => n > MaxNumber)
            .OrderBy(n => n);

        LogCollection(filteredNumbers);
    }

    public void LogCollections()
    {
        List<string> stringsList = new() { "str", "stringtwo", "stringthree" };
        string[] stringsArray = new[] { "strarr", "stringarrtwo" };

        IEnumerable<string> onlyUpperCase = stringsList.Where(str => str.All(ch => char.IsUpper(ch))); // �������� �� ������, ��� ������� � uppercase

        LogCollection(stringsList);
        LogCollection(stringsArray);
        LogCollection(onlyUpperCase);
    }

    public void LogCollection(IEnumerable strs)
    {
        foreach (var str in strs)
            Log(str);
    }

    private void Log<T>(T message) => 
        Debug.Log(message);
}