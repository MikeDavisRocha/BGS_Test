using UnityEngine;

public class ShopMenuController : MonoBehaviour
{
    public GameObject ShopMenuUI;
    private CanvasGroup shopMenuUICanvasGroup;

    private void Awake()
    {
        shopMenuUICanvasGroup = ShopMenuUI.GetComponent<CanvasGroup>();
    }

    public void ShowShopMenuUI()
    {
        shopMenuUICanvasGroup.alpha = 1;
    }

    public void HideShopMenuUI()
    {
        shopMenuUICanvasGroup.alpha = 0;
    }
}
