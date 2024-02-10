using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneyView : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TMP_Text _moneyBalance;

    private void OnEnable()
    {
       _moneyBalance.text = _player.Money.ToString();
        _player.MonyChanged += OnMoneyChaged;
    }

    private void OnDisable()
    {
        _player.MonyChanged -= OnMoneyChaged;
    }

    private void OnMoneyChaged(int money)
    {
        _moneyBalance.text = money.ToString();
    }
}