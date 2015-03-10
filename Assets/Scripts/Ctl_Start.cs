using UnityEngine;
using System.Collections;

public class Ctl_Start : MonoBehaviour
{
    PhotonView photonView;
    void Start()
    {
        photonView = GetComponent<PhotonView>();
    }
    public void Click_VaoNhanh()
    {
        //Application.LoadLevel("ready");
        
    }
}
