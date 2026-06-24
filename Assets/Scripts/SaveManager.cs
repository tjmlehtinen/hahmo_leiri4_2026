using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public PartSelector hair;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        LoadCharacter();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void SavePart(PartSelector part, string id)
    {
        PlayerPrefs.SetInt(id + "sprite", part.GetIndex());
    }

    private void LoadPart(PartSelector part, string id)
    {
        int loadedIndex = PlayerPrefs.GetInt(id + "sprite", 0);
        part.SetIndex(loadedIndex);
    }

    public void SaveCharacter()
    {
        SavePart(hair, "hair");
    }

    public void LoadCharacter()
    {
        LoadPart(hair, "hair");
    }
}
