using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireStart : MonoBehaviour
{
    public FireStart() { }
    public Obi.ObiEmitter chemichal;
    public GameObject Fire;
    bool isFlameSpawned = false;

    [SerializeField]
    private ReturnMenu returnMenu;




    // Update is called once per frame
  public  void Update()
    {
        if (!chemichal.isEmitting && !isFlameSpawned && returnMenu.experimentStarted)
        {
            Instantiate(Fire, this.transform.position, Quaternion.identity);
            isFlameSpawned = true;
            
        }
       
    }
}
