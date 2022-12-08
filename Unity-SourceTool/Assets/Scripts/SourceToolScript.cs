using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SourceToolScript : MonoBehaviour
{
    [Header("UI")]
    public InputField url;       // Alkuperäinen osoite
    public InputField year;      // Vuosi
    public InputField author;    // Kirjoittaja
    public InputField date;      // Haettu
    public InputField title;     // Otsikko
    public Text preview;         // Esikatseluteksti
    public Button copyButton;    // Kopiointi

    [Header("String Variables")]
    public string urlText;
    public string yearText;
    public string authorText;
    public string dateText;
    public string titleText;

    [Header("Final")]
    public string previewText;

    public Animator success;


    private string newSourceString;
    public void MakeNewSource()
    {
        urlText = url.text;
        yearText = year.text;
        authorText = author.text;
        dateText = date.text;
        titleText = title.text;

        if (year.text == "") { yearText = "n.d";}
        
        if (author.text == "")
        {
            newSourceString = titleText + ". " + "[Internet]. " + yearText + " " + "[viitattu " + dateText + "]. " + "Saatavilla: " + urlText;
        }
        else
        {
            newSourceString = authorText + ". " + titleText + ". " + "[Internet]. " + yearText + " " + "[viitattu " + dateText + "]. " + "Saatavilla: "  + urlText;
        }

        previewText = newSourceString;
        preview.text = previewText;
    }

    public void successAnimation()
    {
        success.SetTrigger("Copy");
    }

    public string GetSomeString()
    {
        return previewText;
    }

    public void TestCopyToClipboard()
    {
        GetSomeString().CopyToClipboard();
    }
}