using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneUITextSaver : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
		if (this.gameObject.activeInHierarchy == true)
		{
			string name = this.gameObject.name;
			PlayerPrefs.SetInt(this.gameObject.name, 1);
			Debug.Log("Text is saved");
			if (PlayerPrefs.GetInt(this.gameObject.name) == 1) {
				Debug.Log("Something");
				Debug.Log(this.gameObject.name);
			}
		}
	}
}
