using UnityEngine;
using System.Collections;

public static class MyCoroutine{

	public static IEnumerator WaitforRealSeconds(float time)
    {
        float start = Time.realtimeSinceStartup;

        while (Time.realtimeSinceStartup < (start+time))
        {
            yield return null;
        }
    }
}
