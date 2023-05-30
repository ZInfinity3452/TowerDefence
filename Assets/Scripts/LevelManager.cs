using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] GameObject[] kafelek;
    public float rozmiarKafelka;
    
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
        string[] Mapa = new string[]
        {
            "0010300",
            "2222451",
            "0100372",
            "0018610",
            "1103100"

        };
        int mapX = Mapa[0].ToCharArray().Length;
        int mapY = Mapa.Length;
        rozmiarKafelka = kafelek[0].GetComponent<SpriteRenderer>().sprite.bounds.size.x;
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
        Instantiate(kafelek[number], new Vector2(LewyKamery.x + rozmiarKafelka * x, LewyKamery.y + rozmiarKafelka * y), Quaternion.identity);
    }
}