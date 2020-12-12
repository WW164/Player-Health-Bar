using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHealthText : MonoBehaviour
{
    [SerializeField] private PlayerHealth playerHealth;

    private Text text;

    private void Awake()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        text.text = playerHealth.currentHealth.ToString();
    }
}
