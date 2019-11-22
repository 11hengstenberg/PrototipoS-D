using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaEnemigo1 : MonoBehaviour
{
    public float vida = 100f;
    public void TakeDamage (float amount)
    {
        vida -= amount;
        if (vida <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(this.gameObject);
    }
}
