using UnityEngine;

public class ender : MonoBehaviour {

    public gamemanager Endmanager;


    private void OnTriggerEnter()
    {
        Endmanager.levelended();
    }
}
