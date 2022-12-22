using System.Collections.Generic;
using UnityEngine;

public class CostumeSelector : MonoBehaviour
{
    [Header("Hat")]
    [SerializeField] private List<Animator> hatsAnimatorList;

    [Header("Scarf")]
    [SerializeField] private List<Animator> scarfsAnimatorList;

    [Header("Boots")]
    [SerializeField] private List<Animator> bootsAnimatorList;


    [Header("Player Hat")]
    [SerializeField] private Animator playerHatAnimator;

    [Header("Player Scarf")]
    [SerializeField] private Animator playerScarfAnimator;

    [Header("Player Boots")]
    [SerializeField] private Animator playerBootsAnimator;
    

    private void Start()
    {
        playerHatAnimator.gameObject.SetActive(true);
        playerHatAnimator.runtimeAnimatorController = hatsAnimatorList[0].runtimeAnimatorController;        
    }

    public void Click()
    {
        Debug.Log("BUTTON CLICKED");
    }
}
