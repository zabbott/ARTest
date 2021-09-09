using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TextReceiver : MonoBehaviour
{
    public TMP_Text mytext;
    public Transform[] trackables;
    public Light mainLight; 
    private void Start()
    {
    }

    private void Update()
    {
        string example = ""; 
        //foreach(var item in trackables)
        //{
        //    example = example + item.name + "Pos" + item.position;
        //}

        //example = mainLight.intensity + " " + mainLight.colorTemperature + " " + mainLight.color;


    }
}
