using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.UI;

public class Boutons : MonoBehaviour
{
    public GameObject shop, boutonShop, boutonFermerShop;
    public Poireaux prx;
    public float prixBronze, prixArgent, prixOr, prixDiamant, achatBronze, achatArgent, achatOr, achatDiamant;
    public TextMeshProUGUI textBronze, textArgent, textOr, textDiamant, miniTextBronze, miniTextArgent, miniTextOr, miniTextDiamant;
    void Start()
    {
        shop.SetActive(false);
        textBronze.text = "" + prixBronze;
        textArgent.text = "" + prixArgent;
        textOr.text = "" + prixOr;
        textDiamant.text = "" + prixDiamant;
        miniTextBronze.text = "" + achatBronze;
        miniTextArgent.text = "" + achatArgent;
        miniTextOr.text = "" + achatOr;
        miniTextDiamant.text = "" + achatDiamant;
    }
    public void OuvrirShop()
    {
        boutonShop.SetActive(false);
        shop.SetActive(true);
    }

    public void FermerShop()
    {
        shop.SetActive(false);
        boutonShop.SetActive(true);
    }

    public void ArrosoirBronze()
    {
        if(prx.poireaux >= prixBronze)
        {
            prx.forcePelle += 1;
            prx.poireaux -= prixBronze;
            prixBronze += 10;
            achatBronze += 1;
            prx.textPoireaux.text = "" + prx.poireaux;
            textBronze.text = "" + prixBronze;
            miniTextBronze.text = "" + achatBronze;
        }
    }
    public void ArrosoirArgent()
    {
        if (prx.poireaux >= prixArgent)
        {
            prx.clickAuto *= 2;
            prx.poireaux -= prixArgent;
            prixArgent *= 2f;
            achatArgent += 1;
            prx.textPoireaux.text = "" + prx.poireaux;
            textArgent.text = "" + prixArgent;
            miniTextArgent.text = "" + achatArgent;
        }
    }
    public void ArrosoirOr()
    {
        if (prx.poireaux >= prixOr)
        {
            prx.rapiditePelle *= 0.85f;
            prx.poireaux -= prixOr;
            prixOr *= 2;
            achatOr += 1;
            prx.textPoireaux.text = "" + prx.poireaux;
            textOr.text = "" + prixOr;
            miniTextOr.text = "" + achatOr;
        }
    }
    public void ArrosoirDiamant()
    {
        if (prx.poireaux >= prixDiamant)
        {
            prx.forcePelle *= 2;
            prx.rapiditePelle *= 0.70f;
            prx.clickAuto *= 3;
            prx.poireaux -= prixDiamant;
            prixDiamant *=4;
            achatDiamant += 1;
            prx.textPoireaux.text = "" + prx.poireaux;
            textDiamant.text = "" + prixDiamant;
            miniTextDiamant.text = "" + achatDiamant;
        }
    }
}
