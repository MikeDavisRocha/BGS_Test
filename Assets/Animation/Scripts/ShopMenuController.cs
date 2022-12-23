using UnityEngine;

public class ShopMenuController : MonoBehaviour
{
    public GameObject ShopMenuUI;
    private CanvasGroup shopMenuUICanvasGroup;
    public int SetCanvasGroupAlpha { set { shopMenuUICanvasGroup.alpha = value; } }

    private void Awake()
    {
        shopMenuUICanvasGroup = ShopMenuUI.GetComponent<CanvasGroup>();
    }

    public void ShowShopMenuUI()
    {
        FindObjectOfType<DialogBox>().ShowDialog();        
    }

    public void HideShopMenuUI()
    {
        shopMenuUICanvasGroup.alpha = 0;
        FindObjectOfType<DialogBox>().HideDialog();
    }
}
