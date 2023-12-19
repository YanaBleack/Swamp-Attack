using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarProgres : Bar
{
    [SerializeField] private Spawner _spawner;

    private void OnEnable()
    {
        _spawner.EnemyCountChaged += OnValueChanged;
        Slider.value = 0;
    }

    private void OnDisable()
    {
        _spawner.EnemyCountChaged -= OnValueChanged;
    }
}