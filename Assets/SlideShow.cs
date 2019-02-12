using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideShow : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Slide;
    public GameObject CartaoCostas;

    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (isActiveAndEnabled)
        {
            transform.parent = null;
        }
    }
    public void Fechar()
    {
    Slide.transform.parent = CartaoCostas.transform;
            
    }
}
