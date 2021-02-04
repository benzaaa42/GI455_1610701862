using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebSocketSharp;
using UnityEngine.UI;

namespace week2
{
    public class PluginsWS : MonoBehaviour
    {
        string _print1;
        string _print2;
       

        public InputField _inputField;
        int _Server;

        public Text _printText1;
        public Text _printText2;
       

        private WebSocket websocket;
        // Start is called before the first frame update
        void Start()
        {
            print("Start");

            websocket = new WebSocket("ws://127.0.0.1:58962/");
            websocket.OnMessage += OnMassage;
            websocket.Connect();
            _Server = 0;
        }

        // Update is called once per frame
        void Update()
        {
          
        } 
        private void OnDestroy()
        {
            if (websocket != null)
            {
                websocket.Close();
            }
        }
        public void OnMassage(object sender, MessageEventArgs messageEventArgs)
        {
            Debug.Log("Receive nsg : " + messageEventArgs.Data);

            _printText2.text +=  messageEventArgs.Data + "\n";
            //_printText1.transform.position += new Vector3(0.0f, 0.5f, 0.0f);
            _printText1.text += "\n"  ;

        }
        public void StartMassage()
        {
            websocket.Send(_inputField.text);
            //_print1 = _inputField.text;

            _printText1.text = _inputField.text + "\n";
            //_printText2.transform.position += new Vector3(0.0f, 0.5f, 0.0f);

            _printText2.text += "\n"  ;

            _inputField.text = "";

        }



    }

}

