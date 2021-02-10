using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateText : MonoBehaviour
{
    [SerializeField] private TMPro.TextMeshProUGUI _baseText;
    [SerializeField] private string _baseTextVal;
    void Start()
    {
        _baseText.text = _baseTextVal;
    }
}
