using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class BlinkText : MonoBehaviour
{
    private TextMeshProUGUI text;
    public float Blink = 0;
    private void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {


        Blink+=Time.deltaTime;
        int blink = Mathf.RoundToInt(Blink);

        if (Blink > 1)
        {
            Blink = 0;
        }
        if(blink == 0)
        {
            text.color = Color.black;
        }else if (blink == 1)
        {
            text.color = Color.white;
        }
      


    }
}

