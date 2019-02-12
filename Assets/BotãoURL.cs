using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotãoURL : MonoBehaviour
{
    // Start is called before the first frame update
    public void Botão()
    {
            Application.OpenURL("http://rereal.com.br/");
            Debug.Log("Abrindo URL");  
    }
}
