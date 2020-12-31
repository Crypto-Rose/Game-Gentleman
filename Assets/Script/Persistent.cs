using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Persistent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        NoDestroy();
    }

    private void NoDestroy()
    {
        DontDestroyOnLoad(this);
    }
}
