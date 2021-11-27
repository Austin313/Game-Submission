using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory : MonoBehaviour
{
    GameObject text; 
   void won()
    {
        if (Enemy.currentHealth <= 0)
        {
            text.SetActive(true);
        }
    }
        
}
