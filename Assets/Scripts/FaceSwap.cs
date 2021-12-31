using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class FaceSwap : MonoBehaviour
{
    private ARFaceManager faceManager;
    public List<Material> faceMaterials;
    private int faceMaterialIndex = 0;
    private void Start()
    {
        faceManager = GetComponent<ARFaceManager>();
    }
    public void SwitchCheek_Freckle()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[1];
        }
        //faceMaterialIndex++;
        //if (faceMaterialIndex == faceMaterials.Count)
        //{
        //    faceMaterialIndex = 0;
        //}
    }
    public void SwitchCheek_Coral()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[2];
        }
    }
    public void SwitchCheek_Crimson()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[3];
        }
    }
    public void SwitchCheek_Lavender()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[4];
        }
    }
    public void SwitchCheek_LightPink()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[5];
        }
    }
    public void SwitchEyeshadow_SnowWhite()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[6];
        }
    }
    public void SwitchEyeliner_CatEyes()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[7];
        }
    }
    public void SwitchEyeliner_SmokeyEyes()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[8];
        }
    }
    public void SwitchLip_DarkRose()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[9];
        }
    }
    public void SwitchLip_PinkGlitter()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[10];
        }
    }
    public void SwitchLip_LightRose()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[11];
        }
    }
    public void SwitchLip_WhiteGlitter()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[12];
        }
    }
    public void SwitchTattoo_Carnival()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[13];
        }
    }
    public void SwitchTattoo_LoveFreckle()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[14];
        }
    }
    public void SwitchTattoo_Gothic()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[15];
        }
    }
    public void SwitchTattoo_Mustache()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[16];
        }
    }
    public void SwitchTattoo_CarnivalForehead()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[17];
        }
    }
    public void SwitchEyeshadow_Smokey()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[18];
        }
    }
    public void SwitchEyeshadow_Glittering()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[19];
        }
    }
    public void SwitchEyeshadow_Pink()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[20];
        }
    }
    public void SwitchEyeshadow_RockRoll()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[21];
        }
    }
    public void SwitchEyeliner_SnowWhite()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[22];
        }
    }
    public void SwitchFullMakeup_SmokeyFreckle()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[23];
        }
    }
    public void SwitchFullMakeup_Mature()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[24];
        }
    }
}
