using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowsUp : MonoBehaviour {

    void Start()
    {
        Close(); //  ЗАКРЫТЬ ВСПЛЫВАЮЩЕЕ ОКНО ПРИ ЗАПУСКЕ ПРОГРАММЫ  
    }

    public void Open()
    {
        gameObject.SetActive(true); //   АКТИВИРОВАТЬ ОБЪЕКТ, ЧТОБЫ ОТКРЫТЬ ОКНО.  

    }

    public void Close()
    {
        gameObject.SetActive(false); // ДЕАКТИВИРОВАТЬ ОБЪЕКТ, ЧТОБЫ ЗАКРЫТЬ ОКНО.  
    }

}
