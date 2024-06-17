using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LoggerWrapper : MonoBehaviour
{
    private bool _isParsed;
    private UnityLogger _logger;
    private Parser _parser;

    private int[] _randomNumbers;
    IEnumerable<int> _parsingResult;
    
    private void OnEnable() => 
        _parser.ParsingStateChanged += OnSwitchedStateLog;

    private void Awake() =>
        Init();

    private void OnDisable() =>
        _parser.ParsingStateChanged -= OnSwitchedStateLog;

    private void Update()
    {
        if (Input.GetKeyDown(LogKeyCodes.IEnumerable))
            _logger.LogCollections();

        if (Input.GetKeyDown(LogKeyCodes.MoreThanTen))
            _logger.LogNumbersMoreThanTen(_randomNumbers);

        if (Input.GetKeyDown(LogKeyCodes.HasFiveDivisible))
            print(HasFiveDivisible());

        if (Input.GetKeyDown(LogKeyCodes.AreAllPositive))
            print(AreAllPositive());

        if (Input.GetKeyDown(LogKeyCodes.ParseToList))
        {
            _parsingResult = Parse();
            Debug.Log(_parsingResult);
        }
    }

    private bool HasFiveDivisible() => 
        _randomNumbers.Any(n => n % 5 == 0);

    private bool AreAllPositive() =>
        _randomNumbers.All(n => n > 0);

    private IEnumerable<int> Parse()
    {
        if (_isParsed == false)
             return _parser.ParseToList(_randomNumbers);
        else
            return _parser.Unparse(_randomNumbers);
    }

    private void OnSwitchedStateLog()
    {
        _isParsed = !_isParsed;
        print(_isParsed);
    }

    private void Init()
    {
        _isParsed = false;

        _logger = new();
        _parser = new();

        _randomNumbers = new int[100];

        for (int i = 0; i < _randomNumbers.Length; i++)
            _randomNumbers[i] = Tools.GetRandomNumber(_randomNumbers.Length + 1);
    }
}