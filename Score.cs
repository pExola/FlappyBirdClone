using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D _other)
    {
        if (_other.CompareTag("Player"))
        {
            GameManager.instance.AddScore();
        }
    }
}
