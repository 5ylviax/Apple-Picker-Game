using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RottenApple : MonoBehaviour
{
    public static float bottomY = -20f; // Move this OUTSIDE Update, at class level

    void Update()
    {
        if (transform.position.y < bottomY)
        {
            Destroy(this.gameObject);
            ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();
            apScript.RottenAppleMissed();
        }
    }
}
