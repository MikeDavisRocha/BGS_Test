using System.Collections.Generic;
using UnityEngine;

public class CostumeSelector : MonoBehaviour
{
    [Header("Costumes List")]
    [SerializeField] private List<SO_CostumePart> hatsList;
    [SerializeField] private List<SO_CostumePart> scarfsList;
    [SerializeField] private List<SO_CostumePart> bootsList;


    [Header("Player Costumes")]
    [SerializeField] private Animator playerHatAnimator;
    [SerializeField] private Animator playerScarfAnimator;
    [SerializeField] private Animator playerBootsAnimator;

    public void BuyHat(int costumeIndex)
    {
        if (hatsList[costumeIndex].costumePrice <= MoneyController.Instance.TotalMoney)
        {
            playerHatAnimator.gameObject.SetActive(true);
            playerHatAnimator.runtimeAnimatorController = hatsList[costumeIndex].costumeAnimator.runtimeAnimatorController;
            MoneyController.Instance.DecreaseMoney(hatsList[costumeIndex].costumePrice);
        }
        else
        {
            PopUpManager.Instance.ShowPopUp();
        }
    }

    public void BuyScarf(int costumeIndex)
    {
        if (scarfsList[costumeIndex].costumePrice <= MoneyController.Instance.TotalMoney)
        { 
            playerScarfAnimator.gameObject.SetActive(true);
            playerScarfAnimator.runtimeAnimatorController = scarfsList[costumeIndex].costumeAnimator.runtimeAnimatorController;
            MoneyController.Instance.DecreaseMoney(scarfsList[costumeIndex].costumePrice);
        }
        else
        {
            PopUpManager.Instance.ShowPopUp();
        }
    }

    public void BuyBoots(int costumeIndex)
    {
        if (bootsList[costumeIndex].costumePrice <= MoneyController.Instance.TotalMoney)
        { 
            playerBootsAnimator.gameObject.SetActive(true);
            playerBootsAnimator.runtimeAnimatorController = bootsList[costumeIndex].costumeAnimator.runtimeAnimatorController;
            MoneyController.Instance.DecreaseMoney(bootsList[costumeIndex].costumePrice);
        }
        else
        {
            PopUpManager.Instance.ShowPopUp();
        }
    }
}
