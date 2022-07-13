using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AbobuttonSim : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI text;


    public void Pressed()
    {
            text.text = "Aboniert";
    }
}
