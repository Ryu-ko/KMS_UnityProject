using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelTableOpen : MonoBehaviour
{
    public Canvas TableSHow;
    private bool isCanvasVisible;

    void Start()
    {
        isCanvasVisible = false;
        TableSHow.gameObject.SetActive(false);

        Button button = GetComponent<Button>();
        button.onClick.AddListener(ToggleHelpCanvas);
    }

    public void ToggleHelpCanvas()
    {
        isCanvasVisible = !isCanvasVisible;
        TableSHow.gameObject.SetActive(isCanvasVisible);
    }
}
