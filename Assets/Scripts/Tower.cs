using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] int cost = 75;

    public bool CreateTower(Tower towerPrefab, Vector3 position)
    {
        Bank bank = FindObjectOfType<Bank>();
        if (bank && bank.CurrentBalance >= cost)
        {
            bank.Withdraw(cost);
            Instantiate(towerPrefab, position, Quaternion.identity);
            return true;
        }
        return false;
    }
}
