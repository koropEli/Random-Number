using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class random : MonoBehaviour
{
    public GameObject txtRandom1;    
    public GameObject txtRandom2;
    public GameObject txtRandom3;
    public GameObject txtRandom4;

    public int NumRandom1;
    public int NumRandom2;
    public int NumRandom3;
    public int NumRandom4;

    public void RandomGenerator()
    {
        NumRandom1 = Random.Range(1, 1000);
        txtRandom1.GetComponent<Text>().text = "" + NumRandom1;

        NumRandom2 = Random.Range(1, 1000);
        txtRandom2.GetComponent<Text>().text = "" + NumRandom2;

        NumRandom3 = Random.Range(1, 1000);
        txtRandom3.GetComponent<Text>().text = "" + NumRandom3;

        NumRandom4 = Random.Range(1, 1000);
        txtRandom4.GetComponent<Text>().text = "" + NumRandom4;
    }
}
