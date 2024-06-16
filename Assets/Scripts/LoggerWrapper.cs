using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LoggerWrapper : MonoBehaviour
{
    private const KeyCode StartLinq = KeyCode.Z;

    private UnityLogger _logger = new();

    public UnityLogger Logger => _logger;

    private void Update()
    {
        if (Input.GetKeyDown(StartLinq))
        {
            List<string> stringsList = new() { "str", "stringtwo", "stringthree" };
            string[] stringsArray = new[] { "strarr", "stringarrtwo" };

            IEnumerable<string> onlyUpperCase = stringsList.Where(str => str.All(ch => char.IsUpper(ch))); // выбираем те строки, где символы в uppercase

            _logger.LogCollection(stringsList);
            _logger.LogCollection(stringsArray);
            _logger.LogCollection(onlyUpperCase);
        }
    }
}