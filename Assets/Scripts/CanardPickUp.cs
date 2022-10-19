using UnityEngine;

public class CanardPickUp : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            CanardInventory.instance.AddCanard(1);
            Destroy(gameObject);
        }
    }
}
