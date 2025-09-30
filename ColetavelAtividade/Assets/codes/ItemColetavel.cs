using UnityEngine;

public class ItemColetavel : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.pontuacao += 5;
            Destroy(gameObject);
        }
    }
}