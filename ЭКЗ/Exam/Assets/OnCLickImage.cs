using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCLickImage : MonoBehaviour
{
    GameObject sphera;
    // Start is called before the first frame update
    void Start()
    {
        CloseWin();
    }

    public void OpenWin() {
        gameObject.SetActive(true);
    }

    public void CloseWin()
    {
        gameObject.SetActive(false);

    }
}
