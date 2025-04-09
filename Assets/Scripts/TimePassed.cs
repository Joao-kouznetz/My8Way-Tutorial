using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class TimePassed : MonoBehaviour
{
    public static TimePassed instance;
    public TMP_Text timeText;
    // private Text leastTimeText;

    public float timePassed = 0.0f;
    float leastTimePasset = 10.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        instance = this;
    }
    public void Start()
    {
        timeText.text = timePassed.ToString() + " seconds";

    }
    public void TimePassedMethod()
    {
        timePassed += Time.deltaTime;
        timeText.text = timePassed.ToString("F2") + " seconds";
    }



}