using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.UI;

public class Poireaux : MonoBehaviour
{
    public float poireaux, clickAuto, forcePelle, rapiditePelle;
    public TextMeshProUGUI textPoireaux;


    void Start()
    {
        StartCoroutine(AutoClic());
    }

    public void OnMouseDown()
    {
        poireaux += forcePelle;
        textPoireaux.text = "" + poireaux;
    }


    public IEnumerator AutoClic()
    {
        while (true)
        {
            poireaux += clickAuto;
            textPoireaux.text = "" + poireaux;
            yield return new WaitForSeconds(rapiditePelle);
        }
    }
}
