using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //Guardala posicion del Player al hazer colision con el checkPoint.
        LoadPlayerPosition(new Vector3(other.GetComponent<Transform>().position.x, other.GetComponent<Transform>().position.y, other.GetComponent<Transform>().position.z), Quaternion.Euler(new Vector3(other.GetComponent<Transform>().rotation.x, other.GetComponent<Transform>().rotation.y, other.GetComponent<Transform>().rotation.z)));
    }

    public void LoadPlayerPosition(Vector3 p, Quaternion Q)
    {
        //Guarda la posicion de "PlayerPos".
        PlayerPrefs.SetFloat("playerPosX", p.x);
        PlayerPrefs.SetFloat("playerPosY", p.y);
        PlayerPrefs.SetFloat("playerPosZ", p.z);

        //Guarda la posicion de "PlayerRot".
        PlayerPrefs.SetFloat("playerRotX", p.x);
        PlayerPrefs.SetFloat("playerRoty", p.y);
        PlayerPrefs.SetFloat("playerRotz", p.z);
    }
}
