using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LiteNetLib;

public class ClientManager : MonoBehaviour
{

    EventBasedNetListener listener = new EventBasedNetListener();
    // Start is called before the first frame update
    void Start()
    {
        NetManager client = new NetManager(listener);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
