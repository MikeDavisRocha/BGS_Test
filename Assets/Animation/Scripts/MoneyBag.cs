using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyBag : MonoBehaviour
{
    [SerializeField] private int value;

    public int Value
    {
        get { return value; }
    }    
}
