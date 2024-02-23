using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Damageable : MonoBehaviour
{

    public Slider slider;

    public void getDamage()
    {
        slider.value -= 10;
    }   
}
