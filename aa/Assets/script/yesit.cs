
using UnityEngine;

public class yesit : MonoBehaviour
{
    public cubeMovement yeah;
    private void OnCollisionEnter(Collision info)
    {

        if(info.collider.tag == "obs")
        {
            yeah.enabled = false;
            FindObjectOfType<manger>().EndGame();
        }
    }
}

