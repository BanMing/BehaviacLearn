using UnityEngine;
using System;
public class turtorial_3 : MonoBehaviour
{
    FirstAgent g_FirstAgent;
    SecondAgent g_SecondAgent;
    SecondAgent g_ThirdAgent;


    private bool InitBehavic()
    {
        behaviac.Debug.LogWarning("InitBehavic");

        behaviac.Workspace.Instance.FilePath = PathConst.FilePath;
        behaviac.Workspace.Instance.FileFormat = behaviac.Workspace.EFileFormat.EFF_xml;

        return true;
    }

    private bool InitPlayer()
    {
        behaviac.Debug.LogWarning("InitPlayer");
        g_FirstAgent = new GameObject("FirstAgent").AddComponent<FirstAgent>();
        var bRet = g_FirstAgent.btload("InstanceBT");
        // if (bRet)
        // {
        g_FirstAgent.btsetcurrent("InstanceBT");
        g_SecondAgent = new GameObject("SecondAgent").AddComponent<SecondAgent>();
        g_FirstAgent._set_pInstance(g_SecondAgent);

        // }
        g_ThirdAgent = new GameObject("ThirdAgent").AddComponent<SecondAgent>();
        behaviac.Agent.BindInstance(g_ThirdAgent, "SecondAgentInstance");
        return bRet;
    }

    private void CleanupPlayer()
    {
        behaviac.Debug.LogWarning("CleanupPlayer");

        g_FirstAgent = null;
    }

    private void CleanupBehaviac()
    {
        behaviac.Debug.LogWarning("CleanupBehaviac");

        behaviac.Workspace.Instance.Cleanup();
    }

    private void Awake()
    {
        InitBehavic();

        InitPlayer();
    }
    behaviac.EBTStatus _status = behaviac.EBTStatus.BT_RUNNING;

    private void Update()
    {
        if (_status == behaviac.EBTStatus.BT_RUNNING)
        {
            behaviac.Debug.LogWarning("Update");

            _status = g_FirstAgent.btexec();
        }
    }
    private void OnDestroy()
    {
        CleanupPlayer();

        CleanupBehaviac();
    }
}