using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LightSwitch : MonoBehaviour
{
    private MeshRenderer mesh;
    private UiManger manger;
    [SerializeField] private UnityEngine.UI.Image img;
    [SerializeField] private Sprite sprite;
    private void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        manger = GetComponent<UiManger>();
    }
    private void OnMouseDown()
    {
        img.sprite = sprite;
        mesh.enabled = false;
        manger.switch_check();
    }
}
