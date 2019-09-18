using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    [SerializeField]
    private TextAsset textFile;
    [SerializeField]
    private string[] Lines;
    [SerializeField]
    private int lineEnd;

    private int currentLine;
    
    public GameObject textBox;
    public Text Text;

    // Start is called before the first frame update
    void Start()
    {
        textBox.SetActive(false);
     if (textFile != null)
        {
            //Put the text file from textFile into textLines, then split it. 
            //NOTE: The file only gets imported once the scene starts.
            Lines = (textFile.text.Split('\n'));
        }   

     if(lineEnd == 0)
        {
            lineEnd = Lines.Length - 1;
        }
    }

     void Update()
    {
        Text.text = Lines[currentLine];

        //Allows the player to switch from line to line.
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            currentLine += 1;
           
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentLine -= 1;
        }

        //Closes the textbox once the last given line has shown.
        if(currentLine > lineEnd)
        {
            textBox.SetActive(false);
            currentLine = 0;

        }
    }

}
