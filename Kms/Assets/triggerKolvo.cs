using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerKolvo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter( Collider col )
    {
        
        if (col.name == "Prikosnov")
        {
            if (BtnStartTimeAnim.work)
            {
                BtnStartTimeAnim.kolvo++;
            }
        }
    }

    private void OnTriggerExit( Collider col )
    {

    }
}
