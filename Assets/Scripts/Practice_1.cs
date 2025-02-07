using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Practice_1 : MonoBehaviour 
{
    public struct s_aa
    {
        public float x;
    }
    List<int> asd;

    List<char> aa;
    s_aa s;


    private void Start()
    {
        s_aa aa;
        aa.x = 1;
        Debug.Log("aa.x : " + aa.x);
    }

}
