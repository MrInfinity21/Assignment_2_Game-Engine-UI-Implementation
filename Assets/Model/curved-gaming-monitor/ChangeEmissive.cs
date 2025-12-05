using UnityEngine;
using UnityEngine.Events;

public class ChangeEmissive : MonoBehaviour
{
    public GameObject textMesh;
    public MeshRenderer screenRenderer;
    public Material normalMaterial;
    public Material emissiveMaterial;
    public int screenMaterialIndex = 2;

    private bool isOn = false;


    private void Start()
    {
        TurnOffComputer();
    }

    private void OnMouseDown()
    {
        if (isOn)
            TurnOffComputer();
        else
            TurnOnComputer();
    }


    //To change an emissive material, we copy the materials array, change it, and set it again 

    private void TurnOnComputer()
    {
        ChangeScreenMaterial(emissiveMaterial);
        if (textMesh != null) textMesh.SetActive(true);
        isOn = true;

    }

    private void TurnOffComputer()
    {
        ChangeScreenMaterial(normalMaterial);
        if (textMesh != null) textMesh.SetActive(false);
        isOn = false;

    }

    private void ChangeScreenMaterial(Material mat)
    {
        if (screenRenderer != null && mat != null)
        {
            Material[] mats = screenRenderer.materials;
            if(screenMaterialIndex >= 0 && screenMaterialIndex < mats.Length)
            {
                mats[0] = mat;
                screenRenderer.materials = mats;
            }
            else
            {
                Debug.LogWarning("Screen material index out of range!");
            }
        }
    }

    public void ChangeEmissiveTo(Material emissiveMaterial, Color color)
    {
        if(emissiveMaterial != null)
        {
            emissiveMaterial.SetColor("_EmissionColor", color);
        }
    }

}

