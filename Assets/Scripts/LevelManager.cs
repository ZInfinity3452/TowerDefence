using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class LevelManager : MonoBehaviour
{
    [SerializeField] GameObject[] kafelek;
    public float rozmiarKafelka;

    public GameObject[] Kafelek1 { get => Kafelek2; set => Kafelek2 = value; }
    public GameObject[] Kafelek2 { get => Kafelek3; set => Kafelek3 = value; }
    public GameObject[] Kafelek3 { get => Kafelek4; set => Kafelek4 = value; }
    public GameObject[] Kafelek4 { get => Kafelek6; set => Kafelek6 = value; }
    public GameObject[] Kafelek5 { get => Kafelek6; set => Kafelek6 = value; }
    public GameObject[] Kafelek6 { get => Kafelek7; set => Kafelek7 = value; }
    public GameObject[] Kafelek7 { get => kafelek; set => kafelek = value; }

    // Start is called before the first frame update
    void Start()
    {
        StworzPoziom();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void StworzPoziom()
    {
        string[] Mapa = InsertLevel();
        int mapX = Mapa[0].ToCharArray().Length;
        int mapY = Mapa.Length;
        rozmiarKafelka = Kafelek1[0].GetComponent<SpriteRenderer>().sprite.bounds.size.x;
        Vector2 LewyKamery = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        for (int y = 0; y < mapY; y++)
        {
            char[] jeszczekafle = Mapa[y].ToCharArray();
            for (int x = 0; x < mapX; x++)
            {


                Kafelek(jeszczekafle[x], rozmiarKafelka, LewyKamery, x, y);
            }
        }
    }
    private void Kafelek(char jakikafel, float rozmiarKafelka, Vector2 LewyKamery, int x, int y)
    {
        int number = (int)System.Char.GetNumericValue(jakikafel);
        GameObject nowyKafelek = Instantiate(Kafelek1[number],
            new Vector2(LewyKamery.x + rozmiarKafelka * x, LewyKamery.y + rozmiarKafelka * y), Quaternion.identity);
        nowyKafelek.GetComponent<Kafelek>().Setup(new PUNK(x, y));
    }
    private string[] InsertLevel()
    {
        TextAsset dane = Resources.Load("Level") as TextAsset;
        string dane2 = dane.text.Replace(Environment.NewLine, string.Empty);
        return dane2.Split('-');
    }
}