using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewerScriptObject : ScriptableObject
{
    public bool ProcessMessage(string jsonRequest, object clbk)
    {
        Debug.Log(jsonRequest);

        return true;
    }

    public bool processMessage(string jsonRequest, object clbk)
    {
        return this.ProcessMessage(jsonRequest, clbk);
    }
}
