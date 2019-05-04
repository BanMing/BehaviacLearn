﻿// -------------------------------------------------------------------------------
// THIS FILE IS ORIGINALLY GENERATED BY THE DESIGNER.
// YOU ARE ONLY ALLOWED TO MODIFY CODE BETWEEN '///<<< BEGIN' AND '///<<< END'.
// PLEASE MODIFY AND REGENERETE IT IN THE DESIGNER FOR CLASS/MEMBERS/METHODS, ETC.
// -------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;

///<<< BEGIN WRITING YOUR CODE FILE_INIT
using UnityEngine;
///<<< END WRITING YOUR CODE

public class FirstAgent : behaviac.Agent
///<<< BEGIN WRITING YOUR CODE FirstAgent
///<<< END WRITING YOUR CODE
{
	private int p1 = 0;
	public void _set_p1(int value)
	{
		p1 = value;
	}
	public int _get_p1()
	{
		return p1;
	}

	private SecondAgent pInstance = null;
	public void _set_pInstance(SecondAgent value)
	{
		pInstance = value;
	}
	public SecondAgent _get_pInstance()
	{
		return pInstance;
	}

	public void SayHello()
	{
///<<< BEGIN WRITING YOUR CODE SayHello
        behaviac.Debug.LogWarning("Hello Behaviac");
        // behaviac.Debug.LogWarning("p1:" + p1);
        ///<<< END WRITING YOUR CODE
	}

///<<< BEGIN WRITING YOUR CODE CLASS_PART
    private static string FilePath
    {
        get
        {
            string relativePath = "/Resources/behaviac/exported";
            if (Application.platform == RuntimePlatform.WindowsEditor)
            {
                return Application.dataPath + relativePath;
            }
            else if (Application.platform == RuntimePlatform.WindowsPlayer)
            {
                return Application.dataPath + relativePath;
            }
            else
            {
                return "Assets" + relativePath;
            }
        }
    }

    private bool InitBehavic()
    {
        behaviac.Debug.LogWarning("InitBehavic");

        behaviac.Workspace.Instance.FilePath = FirstAgent.FilePath;
        behaviac.Workspace.Instance.FileFormat = behaviac.Workspace.EFileFormat.EFF_xml;

        return true;
    }

    // 加载指定的行为树，这里的行为树名字为“FirstBT”
    private bool InitPlayer()
    {
        behaviac.Debug.LogWarning("InitPlayer");

        bool bRet = this.btload("Firstbt");
        if (bRet)
        {
            this.btsetcurrent("Firstbt");
        }

        return bRet;
    }

    // 加载指定的行为树，这里的行为树名字为“SequenceBT”
    private bool InitSequencePlayer()
    {
        behaviac.Debug.LogWarning("InitPlayer");

        bool bRet = this.btload("SequenceBT");
        if (bRet)
        {
            this.btsetcurrent("SequenceBT");
        }

        return bRet;
    }

    // 加载指定的行为树，这里的行为树名字为“SelectBT”
    private bool InitSelectPlayer()
    {
        behaviac.Debug.LogWarning("InitPlayer");

        bool bRet = this.btload("SelectBT");
        if (bRet)
        {
            this.btsetcurrent("SelectBT");
        }

        return bRet;
    }
    // void Awake()
    // {
    //     InitBehavic();

    //     // InitPlayer();

    //     InitSelectPlayer();
    // }

    behaviac.EBTStatus _status = behaviac.EBTStatus.BT_RUNNING;

    void Update()
    {
        if (_status == behaviac.EBTStatus.BT_RUNNING)
        {
            behaviac.Debug.LogWarning("Update");

            _status = this.btexec();
        }
    }
    ///<<< END WRITING YOUR CODE

}

///<<< BEGIN WRITING YOUR CODE FILE_UNINIT

///<<< END WRITING YOUR CODE

