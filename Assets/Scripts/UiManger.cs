using UnityEngine;
using UnityEngine.SceneManagement;
public class UiManger : MonoBehaviour
{
    [SerializeField] private UnityEngine.UI.Image img;
    [SerializeField] private Sprite sprite;
    [SerializeField] private Canvas canvas;
    [SerializeField] private MeshRenderer mesh;
    [SerializeField] private int indx;
    static private int[] c = {0, 0, 0};
    public void correct_btn()
    {
        canvas.enabled = false;
        img.sprite = sprite;
        c[indx] = 1;
        if (c[0] == 1 && c[1] == 1 && c[2] == 1 && mesh.enabled == false)
        {
            Invoke("win", 5);
        }
    }
    private void win()
    {
        SceneManager.LoadScene("WinningScene");
    }
    public void wrong_btn()
    {
        canvas.enabled = false;
        SceneManager.LoadScene("LosingScene");
    }
    public void switch_check()
    {
        if (c[0] == 1 && c[1] == 1 && c[2] == 1)
        {
            Invoke("win", 5);
        }
    }
}
