using System;
using Deploy.Runtime;
using TMPro;
using UnityEngine;

namespace DefaultNamespace
{
    public class VariableDisplayer : MonoBehaviour
    {
        [SerializeField] private StringVariable _stringVariable;
        [SerializeField] private TextMeshProUGUI _text;

        private void Start()
        {
            _text.text = _stringVariable.Value;
        }
    }
}