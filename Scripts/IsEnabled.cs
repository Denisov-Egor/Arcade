using UnityEngine;

public class IsEnabls : MonoBehaviour
{
    public int needToUnlock;
    public Material bleckMaterial;

    private void Start()
    {
        if (PlayerPrefs.GetInt("score") < needToUnlock)
                GetComponent<MeshRenderer>().material = bleckMaterial;
    }
}
