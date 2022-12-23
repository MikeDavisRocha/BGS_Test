using System.Collections;
using UnityEngine;
using TMPro;

public class DialogBox : MonoBehaviour
{
    [SerializeField] int letterPerSeconds;
    [SerializeField] TMP_Text dialogText;
    private CanvasGroup canvasGroup;

    [TextArea]
    [SerializeField] string Text;

    private void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void ShowDialog()
    {
        canvasGroup.alpha = 1;
        StartCoroutine(TypeDialog(Text));
    }

    public void HideDialog()
    {
        StopAllCoroutines();
        canvasGroup.alpha = 0;
    }

    public IEnumerator TypeDialog(string dialog)
    {
        dialogText.text = "";
        foreach (var letter in dialog.ToCharArray())
        {
            dialogText.text += letter;
            yield return new WaitForSeconds(1f / letterPerSeconds);
        }
        Invoke("ShowShopMenu", 1f);        
    }

    private void ShowShopMenu()
    {
        HideDialog();
        FindObjectOfType<ShopMenuController>().SetCanvasGroupAlpha = 1;
    }
}
