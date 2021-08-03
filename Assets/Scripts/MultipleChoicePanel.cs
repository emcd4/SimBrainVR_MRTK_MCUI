using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MultipleChoicePanel : MonoBehaviour
{
    public TextMesh[] checkboxLabels;
    public TextMeshPro questionText;

    // Test question data
    private string questionString = "What are two symptoms that increase your index of suspicion of an opthalmic emergency?";
    private string[] options = { "Decreased vision", "Pain", "Photophobia", "Watering eye", "Foreign body sensation" };
    
    // Start is called before the first frame update
    void Start()
    {
        questionText.text = questionString;
        for (int i=0; i<checkboxLabels.Length; i++)
        {
            checkboxLabels[i].text = options[i];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
