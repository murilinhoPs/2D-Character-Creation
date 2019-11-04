using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppereanceManager : MonoBehaviour
{

    public SpriteRenderer piece;
    public Text typeText;
    public string[] type;
    public Sprite[] sprites;

    private int spriteIndex;

    void Update()
    {

        for (int i = 0; i < sprites.Length; i++)
        {
            if(i == spriteIndex)
            {
                piece.sprite = sprites[i];
                typeText.text = type[i];
            }
        }
    }

    public void ChangeSprite()
    {
        if(spriteIndex < sprites.Length - 1)
        {
            spriteIndex++;
        }
        else
        {
            spriteIndex = 0;
        }
    }
}
