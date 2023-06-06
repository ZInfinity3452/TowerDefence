using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kf : MonoBehaviour
{
    public Punkt PS { get; set; }
    public void Setup(Punkt pozycja)
    {
        this.PS = pozycja;
    }

    private void OnMouseOver()
    {
        print(PS.X+","+PS.Y);
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
