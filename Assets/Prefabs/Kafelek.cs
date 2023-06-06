using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kafelek : MonoBehaviour
{
    public PUNK PozycjaSiatka { get; set; }
    public void Setup(PUNK pozycja)
    {
        this.PozycjaSiatka = pozycja;
    }
    private void OnMouseOver()
    {
        print("Kafelek" + PozycjaSiatka.X + "," + PozycjaSiatka.Y);
        this.GetComponent<SpriteRenderer>().color = Color.red;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
