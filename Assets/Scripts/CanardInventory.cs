using UnityEngine;
using UnityEngine.UI;

public class CanardInventory : MonoBehaviour
{
    public int CanardCount;
    public Text CanardCountText;
    public Text CanardCountEnd;

    public static CanardInventory instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de Inventory dans la scène");
            return;
        }
        instance = this;
    }
    public void AddCanard(int count)
    {
        CanardCount += count;
        CanardCountText.text = CanardCount.ToString();
        CanardCountEnd.text = CanardCount.ToString();
    }

}
