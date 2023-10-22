using UnityEngine;

public class CharacterSkinController : MonoBehaviour
{
    public Sprite[] skins;

    private void Start()
    {
        int selectedSkinIndex = PlayerPrefs.GetInt("SelectedSkin", 0);
        ChangeSkin(selectedSkinIndex);
    }

    public void ChangeSkin(int skinIndex)
    {
        if (skinIndex >= 0 && skinIndex < skins.Length)
        {
            GetComponent<SpriteRenderer>().sprite = skins[skinIndex];
        }
    }
}
