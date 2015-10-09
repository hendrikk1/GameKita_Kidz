using UnityEngine;
using System.Collections;

public class ButtonGoto : MonoBehaviour {
    public string scenes;

    public void Play() {
        Application.LoadLevel(scenes);
    }
}
