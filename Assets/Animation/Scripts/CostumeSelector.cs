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

    [Header("Icons UI")]
    [SerializeField] private List<GameObject> hatsToBuyList;
    [SerializeField] private List<GameObject> scarfsToBuyList;
    [SerializeField] private List<GameObject> bootsToBuyList;

    [SerializeField] private List<GameObject> hatsToSellList;
    [SerializeField] private List<GameObject> scarfsToSellList;
    [SerializeField] private List<GameObject> bootsToSellList;

    private void Start()
    {
        ChangeHatIconsState();
        ChangeScarfIconsState();
        ChangeBootsIconsState();
    }

    private void ChangeHatIconsState()
    {
        for (int i = 0; i < hatsList.Count; i++)
        {
            hatsToBuyList[i].SetActive(!hatsList[i].hasPlayerBought);
            hatsToSellList[i].SetActive(hatsList[i].hasPlayerBought);
        }
    }

    private void ChangeScarfIconsState()
    {
        for (int i = 0; i < scarfsList.Count; i++)
        {
            scarfsToBuyList[i].SetActive(!scarfsList[i].hasPlayerBought);
            scarfsToSellList[i].SetActive(scarfsList[i].hasPlayerBought);
        }
    }

    private void ChangeBootsIconsState()
    {
        for (int i = 0; i < bootsList.Count; i++)
        {
            bootsToBuyList[i].SetActive(!bootsList[i].hasPlayerBought);
            bootsToSellList[i].SetActive(bootsList[i].hasPlayerBought);
        }
    }

    public void BuyHat(int costumeIndex)
    {
        if (hatsList[costumeIndex].costumePrice <= MoneyController.Instance.TotalMoney && !hatsList[costumeIndex].hasPlayerBought)
        {
            playerHatAnimator.gameObject.SetActive(true);
            playerHatAnimator.runtimeAnimatorController = hatsList[costumeIndex].costumeAnimator.runtimeAnimatorController;
            hatsList[costumeIndex].hasPlayerBought = true;
            hatsToBuyList[costumeIndex].SetActive(!hatsList[costumeIndex].hasPlayerBought);
            hatsToSellList[costumeIndex].SetActive(hatsList[costumeIndex].hasPlayerBought);
            MoneyController.Instance.DecreaseMoney(hatsList[costumeIndex].costumePrice);
        }
        else
        {
            PopUpManager.Instance.ShowPopUp();
        }
    }

    public void BuyScarf(int costumeIndex)
    {
        if (scarfsList[costumeIndex].costumePrice <= MoneyController.Instance.TotalMoney && !scarfsList[costumeIndex].hasPlayerBought)
        { 
            playerScarfAnimator.gameObject.SetActive(true);
            playerScarfAnimator.runtimeAnimatorController = scarfsList[costumeIndex].costumeAnimator.runtimeAnimatorController;
            scarfsList[costumeIndex].hasPlayerBought = true;
            scarfsToBuyList[costumeIndex].SetActive(!scarfsList[costumeIndex].hasPlayerBought);
            scarfsToSellList[costumeIndex].SetActive(scarfsList[costumeIndex].hasPlayerBought);
            MoneyController.Instance.DecreaseMoney(scarfsList[costumeIndex].costumePrice);
        }
        else
        {
            PopUpManager.Instance.ShowPopUp();
        }
    }

    public void BuyBoots(int costumeIndex)
    {
        if (bootsList[costumeIndex].costumePrice <= MoneyController.Instance.TotalMoney && !bootsList[costumeIndex].hasPlayerBought)
        { 
            playerBootsAnimator.gameObject.SetActive(true);
            playerBootsAnimator.runtimeAnimatorController = bootsList[costumeIndex].costumeAnimator.runtimeAnimatorController;
            bootsList[costumeIndex].hasPlayerBought = true;
            bootsToBuyList[costumeIndex].SetActive(!bootsList[costumeIndex].hasPlayerBought);
            bootsToSellList[costumeIndex].SetActive(bootsList[costumeIndex].hasPlayerBought);
            MoneyController.Instance.DecreaseMoney(bootsList[costumeIndex].costumePrice);
        }
        else
        {
            PopUpManager.Instance.ShowPopUp();
        }
    }

    public void SellHat(int costumeIndex)
    {
        playerHatAnimator.gameObject.SetActive(false);
        hatsList[costumeIndex].hasPlayerBought = false;
        hatsToBuyList[costumeIndex].SetActive(!hatsList[costumeIndex].hasPlayerBought);
        hatsToSellList[costumeIndex].SetActive(hatsList[costumeIndex].hasPlayerBought);
        MoneyController.Instance.IncreaseMoney(hatsList[costumeIndex].costumePrice * 0.5f);
    }

    public void SellScarf(int costumeIndex)
    {
        playerScarfAnimator.gameObject.SetActive(false);
        scarfsList[costumeIndex].hasPlayerBought = false;
        scarfsToBuyList[costumeIndex].SetActive(!scarfsList[costumeIndex].hasPlayerBought);
        scarfsToSellList[costumeIndex].SetActive(scarfsList[costumeIndex].hasPlayerBought);
        MoneyController.Instance.IncreaseMoney(scarfsList[costumeIndex].costumePrice * 0.5f);
    }

    public void SellBoots(int costumeIndex)
    {
        playerBootsAnimator.gameObject.SetActive(false);
        bootsList[costumeIndex].hasPlayerBought = false;
        bootsToBuyList[costumeIndex].SetActive(!bootsList[costumeIndex].hasPlayerBought);
        bootsToSellList[costumeIndex].SetActive(bootsList[costumeIndex].hasPlayerBought);
        MoneyController.Instance.IncreaseMoney(bootsList[costumeIndex].costumePrice * 0.5f);
    }
}
