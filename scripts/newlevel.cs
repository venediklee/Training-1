using UnityEngine;
using UnityEngine.SceneManagement;

public class newlevel : MonoBehaviour {

    public void Loadnextlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
