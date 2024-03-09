using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar1 : MonoBehaviour
{
    public Slider healthslider;
    public Slider easeHealthSlider;

    public float maxhealth = 100f;
    public float health;
    private float lerpSpeed = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        health = maxhealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(healthslider.value != health)
        {
            healthslider.value = health;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            takeDamage(20);
        }

        if(healthslider.value != easeHealthSlider.value)
        {
            easeHealthSlider.value = Mathf.Lerp(easeHealthSlider.value, health, lerpSpeed);
        }
    }

    void takeDamage(float damage)
    {
        health -= damage;
    }
}
