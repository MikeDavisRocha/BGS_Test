using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpManager : MonoBehaviour
{
    public static PopUpManager Instance;
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
    IEnumerator HideCoroutine()
    {
        yield return new WaitForSeconds(2f);
        GetComponent<CanvasGroup>().alpha = 0;
    }

    public void ShowPopUp()
    {
        GetComponent<CanvasGroup>().alpha = 1;
        StartCoroutine("HideCoroutine");
    }
}
