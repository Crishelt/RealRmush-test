using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIGoldText : MonoBehaviour
{
    Bank bank;
    TextMeshPro goldText;
    // Start is called before the first frame update
    void Start()
    {
        bank = FindObjectOfType<Bank>();
        goldText = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void UpdateGoldText()
    {
        goldText.text = $"Gold: {bank.CurrentBalance}";
    }
}
