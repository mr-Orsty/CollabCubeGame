using UnityEngine;
using UnityEngine.UI;

public class SkinSelectionMenu : MonoBehaviour
{
    public int selectedSkinIndex;

    public void SelectSkin()
    {
        PlayerPrefs.SetInt("SelectedSkin", selectedSkinIndex);
    }
}
