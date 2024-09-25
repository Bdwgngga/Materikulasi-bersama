using UnityEngine;

public class SceneBController : MonoBehaviour
{
    void Start()
    {
        LoadData();
    }
    void LoadData()
    {
        Debug.Log(PlayerData.Nickname);
        Debug.Log(DontDestroy.instance.score);
    }
}
