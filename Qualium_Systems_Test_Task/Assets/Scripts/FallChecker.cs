using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallChecker : MonoBehaviour
{    
    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<GameSession>().EndGame();
    }
}
