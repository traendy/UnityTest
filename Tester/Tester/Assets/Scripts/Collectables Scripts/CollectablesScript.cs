using UnityEngine;
using System.Collections;

public class CollectablesScript : MonoBehaviour {


    void OnEnable()
    {
        Invoke("DestroyCollectable", 6f );
    }

	void DestroyCollectable()
    {
        gameObject.SetActive(false);
    }
}
