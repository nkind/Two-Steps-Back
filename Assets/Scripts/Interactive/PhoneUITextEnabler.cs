using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneUITextEnabler : MonoBehaviour
{
	public GameObject Text1;
	public GameObject Text2;
	public GameObject Text3;
	public GameObject Text4;
	public GameObject Text5;
	public GameObject Text6;
	public GameObject Text7;
	public GameObject Text8;
	public GameObject Text9;
	public GameObject Text10;
	public GameObject Text11;
	public GameObject Text12;

    // Update is called once per frame
    void Update()
    {
        int var1 = PlayerPrefs.GetInt("Text1");
        if (var1 == 1)
        {
            Text1.SetActive(true);
			Debug.Log("First Text Reloaded");
        }
		else
		{
			Debug.Log("NO");
		}

		int var2 = PlayerPrefs.GetInt("Text2");
        if (var2 == 1)
        {
            Text2.SetActive(true);
			Debug.Log("Second Text Reloaded");
        }

    }
}
