using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MenuMain : MonoBehaviour
{
    [SerializeField]

    public TextMeshProUGUI message;
    public string defaultText;

    public void Start()
    {
        defaultText = message.text;
    }

    public void InfRamka()
    {
        message.text = "Рамка - используется для закрепления тела для вращения.";
    }


    public void InfMagnit()
    {
        message.text = "Магнит - приьягивает рамку для создания инерции.";
    }


    public void InfFotoelDatchik()
    {
        message.text = "Фотоэлектрический датчик - подсчитывает колебательные вращения.";
    }


    public void InfPodvijnajaBalka()
    {
        message.text = "Подвижная балка - для закрепления исследуемого тела.";
    }


    public void InfKronshtein()
    {
        message.text = "Кронщтейн - держат рамку на весу.";
    }
    
    public void InfCifrovoiShetchik()
    {
        message.text = "Цифровой счетчик - выводит на экран время и количество колебательных вращений.";
    }

    public void InfSecundomer()
    {
        message.text = "Cекундомер - cчитает время колебаний.";
    }
    public void InfIssledTelo()
    {
        message.text = "Исследуемое тело - тело чьи моменты инерции изучаем";
    }


    public void OnExit()
    {
        message.text = defaultText;
    }

   
}
