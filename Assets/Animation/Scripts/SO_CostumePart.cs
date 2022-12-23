using UnityEngine;

[CreateAssetMenu(fileName = "New Costume", menuName = "Costume Part")]
public class SO_CostumePart : ScriptableObject
{
    [Header("Costume Info")]
    public string costumeName;
    public int costumePrice;

    [Header("Animator")]
    public Animator costumeAnimator;
}