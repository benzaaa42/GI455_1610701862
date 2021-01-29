using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Text_GM : MonoBehaviour
{
    public Text _GI455;
    public Text _GI355;
    public Text _GI476;
    public Text _GI499;
    public Text _GIC19;
    string _print;
    public GameObject inputField;
   
    public Text _pipat;
    // Start is called before the first frame update
    void Start()
    {
        _GI355.text = "GI355";
        _GI455.text = "GI455";
        _GI476.text = "GI476";
        _GI499.text = "GI499";
        _GIC19.text = "GIC19";
    }
    // Update is called once per frame
    void Update()
    {
      
    }
    public void _MyText()
    {
       
      
        //_print = inputField.GetComponent<Text>().text;
        if (inputField.GetComponent<Text>().text == _GI355.text|| inputField.GetComponent<Text>().text == _GI455.text|| inputField.GetComponent<Text>().text == _GI476.text|| inputField.GetComponent<Text>().text == _GI499.text || inputField.GetComponent<Text>().text == _GIC19.text) 
        {
           
             _print   = $"[ <color=green>{inputField.GetComponent<Text>().text}</color> ] is found.";
            _pipat.text = _print;
        }
        else 
        {
            _print = $"[ <color=red>{inputField.GetComponent<Text>().text}</color> ] is not found.";
            _pipat.text = _print;
        }
    }
 
}

