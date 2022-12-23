using UnityEngine;
using TMPro;

public class MoneyController : MonoBehaviour
{
    public TMP_Text totalMoneyText;
    [SerializeField] private int totalMoney;

    public static MoneyController Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public int TotalMoney
    {
        get { return totalMoney; }
    }

    private void Start()
    {
        totalMoneyText.text = totalMoney.ToString();
    }

    public void IncreaseMoney(float value)
    {
        totalMoney += (int)value;
        totalMoneyText.text = totalMoney.ToString();
    }

    public void DecreaseMoney(int value)
    {
        totalMoney -= value;
        totalMoneyText.text = totalMoney.ToString();
    }
}
