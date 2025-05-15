using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClonaCubos : MonoBehaviour
{
    public GameObject cuboPrefabGO;
    // Start is called before the first frame update
    public void ClonarCubos()
    {
        Instantiate(cuboPrefabGO);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
