using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] CinemachineVirtualCamera thirdPerson;
    [SerializeField] CinemachineVirtualCamera truckView;
    [SerializeField] CinemachineVirtualCamera rotationCam;

    private void OnEnable()
    {
        CameraSwitcher.Register(thirdPerson);
        CameraSwitcher.Register(truckView);
        CameraSwitcher.Register(rotationCam);
        CameraSwitcher.SwitchCamera(rotationCam);
    }

    private void OnDisable()
    {
        CameraSwitcher.Unregister(thirdPerson);
        CameraSwitcher.Unregister(truckView);
        CameraSwitcher.Unregister(rotationCam);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (CameraSwitcher.IsActiveCamera(rotationCam))
            {
                CameraSwitcher.SwitchCamera(truckView);
            }
            else if (CameraSwitcher.IsActiveCamera(truckView))
            {
                CameraSwitcher.SwitchCamera(rotationCam);
            }
        }

    }
}
