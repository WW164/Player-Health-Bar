using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;

[CreateAssetMenu]
public class PlayerHealth : ScriptableObject
{
    public int maxHealth;
    public int currentHealth;
}
