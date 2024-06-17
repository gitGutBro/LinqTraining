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

        IEnumerable<string> onlyUpperCase = stringsList.Where(str => str.All(ch => char.IsUpper(ch))); // выбираем те строки, где символы в uppercase

        LogCollection(stringsList);
        LogCollection(stringsArray);
        LogCollection(onlyUpperCase);
    }

    public void LogCollection(IEnumerable objs)
    {
        foreach (object obj in objs)
            Log(obj);
    }

    private void Log(object message) => 
        Debug.Log(message);
}