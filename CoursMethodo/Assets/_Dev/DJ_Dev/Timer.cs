using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI TimeText;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(System.DateTime.Now);
    }

    // Update is called once per frame
    void Update()
    {
        //Display date & hours on screen
        TimeText.text = System.DateTime.Now.ToString();;
    }
}
