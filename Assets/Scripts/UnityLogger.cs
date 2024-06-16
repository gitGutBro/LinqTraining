using System.Collections;
using UnityEngine;

public class UnityLogger
{
    public void Log(string message) => 
        Debug.Log(message);

    public void LogCollection(IEnumerable strs)
    {
        foreach (string str in strs)
            Log(str);
    }
}