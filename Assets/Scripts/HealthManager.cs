using System;
using UnityEngine;
using UnityEngine.UI;
public class HealthManager : MonoBehaviour
{

    public Image healthBar;
    public float healthAmountMax = 10f;
    private float healthAmount;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthAmount = healthAmountMax;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)){
            TakeDamage(3);
        }

        if (Input.GetKeyDown(KeyCode.Space)){
            Heal(1);
        }
    }

    public void TakeDamage(float damage)
    {
        healthAmount -= damage;
        healthAmount = Mathf.Clamp(healthAmount, 0, healthAmountMax);
        healthBar.fillAmount = healthAmount/healthAmountMax;
    }

    public void Heal(float pv)
    {
        healthAmount += pv;
        healthAmount = Mathf.Clamp(healthAmount, 0, healthAmountMax);
        healthBar.fillAmount = healthAmount/healthAmountMax;
    }
}
