using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorYellow : MonoBehaviour {

	public void Change1()
	{
        gameObject.GetComponent<Renderer>().material.color = new Color(1,1,1);
    }
    public void Change2()
    {
        gameObject.GetComponent<Renderer>().material.color = new Color(1, 1, 0);
    }
}
