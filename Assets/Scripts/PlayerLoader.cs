using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLoader : MonoBehaviour
{
    private void Awake()
    {
        if (PlayerPrefs.HasKey("playerPosX"))
            Load();
    }

    public void Load()
    {
        GetComponent<CharacterController>().enabled = false;
        transform.position = new Vector3(PlayerPrefs.GetFloat("playerPosX"),
            PlayerPrefs.GetFloat("PlayerPosY"), PlayerPrefs.GetFloat("playerPosX"));
        transform.rotation = Quaternion.Euler(new Vector3(PlayerPrefs.GetFloat("playerRotX"),
            PlayerPrefs.GetFloat("playerRorY"), PlayerPrefs.GetFloat("playrRotZ")));
    }

    private IEnumerator WaitNextFrame()
    {
        yield return new WaitForEndOfFrame();
        GetComponent<CharacterController>().enabled = true;
    }
}
