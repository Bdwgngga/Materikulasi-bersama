using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    public static DontDestroy instance;
    public float score;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this);
        }
    }
}
