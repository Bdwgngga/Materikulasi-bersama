using UnityEngine;

public class SceneAController : MonoBehaviour
{
    void Start()
    {
        //LOAD DATA DARI SERVER/PLAYER PREFS
        //DATA READY
        SetData("Bagas Dewangga");
    }

    void SetData(string nickname)
    {
        Debug.Log(PlayerData.Nickname);
        PlayerData.Nickname = nickname;
        Debug.Log(DontDestroy.instance.score);
        DontDestroy.instance.score = 100f;
    }
}