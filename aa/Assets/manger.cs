
using UnityEngine;
using UnityEngine.SceneManagement;

public class manger : MonoBehaviour {
    bool gamend = false;
    public float del = 1f;

	public void EndGame ()
    {
        if (gamend == false)
            gamend = true;
        Invoke("restart", del);

    }
    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
