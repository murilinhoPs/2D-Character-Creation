using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorsManager : MonoBehaviour
{
    //alan zucconi
    public SpriteRenderer parte;
    public Image colorQuad;
    public Color[] cores;

    public bool alpha;

    private int colorIndex;

    void Update()
    {
        if (alpha)
        {
            colorQuad.color = parte.color;
        }
            

        for (int i = 0; i < cores.Length; i++)
        {
            if (i == colorIndex)
            {
                parte.color = cores[i];
            }
        }
    }

    public void ChangeColor(int index)
    {
        colorIndex = index;
    }
}
