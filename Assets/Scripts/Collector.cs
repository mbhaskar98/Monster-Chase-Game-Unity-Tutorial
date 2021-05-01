using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    // Start is called before the first frame update
    private string ENEMY_TAG = "Enemy";

    private string PLAYER_TAG = "Player";
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(ENEMY_TAG) || other.CompareTag(PLAYER_TAG))
        {
            Destroy(other.gameObject);
        }
    }
}
