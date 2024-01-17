using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HavaDurumu : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI HavaDurumuText;

    // Start is called before the first frame update
    void Start()
    {
        HavaDurumuYazma();
    }

    public void HavaDurumuYazma()
    {
        string Konum = "antalya";
        string api = "e86898ef207616cc629b5d71165ac375";
        string connection = "https://api.openweathermap.org/data/2.5/weather?q=" + Konum + "&mode=xml&lang=tr&units=metric&appid=" + api;
        XDocument weather = XDocument.Load(connection);
        var temp = weather.Descendants("temperature").ElementAt(0).Attribute("value").Value;
        string inf ="Antalya sýcaklýk " temp + "°C";
        HavaDurumuText.text = inf;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
