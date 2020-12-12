using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private PlayerHealth playerHealth;

    public HealthBar healthBar;

    private void Start()
    {
        healthBar.SetMaxHealth(playerHealth.maxHealth);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            playerHealth.currentHealth--;
            healthBar.SetHealth(playerHealth.currentHealth);
        }
            
    }
}
