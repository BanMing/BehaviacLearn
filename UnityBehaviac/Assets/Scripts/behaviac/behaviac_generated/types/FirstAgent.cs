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

	private FirstStruct p2 = new FirstStruct();
	public void _set_p2(FirstStruct value)
	{
		p2 = value;
	}
	public FirstStruct _get_p2()
	{
		return p2;
	}

	private FirstEnum p3 = FirstEnum.e1;
	public void _set_p3(FirstEnum value)
	{
		p3 = value;
	}
	public FirstEnum _get_p3()
	{
		return p3;
	}

	private System.Object pInstance = null;
	public void _set_pInstance(System.Object value)
	{
		pInstance = value;
	}
	public System.Object _get_pInstance()
	{
		return pInstance;
	}

	public void Say(ref string param0)
	{
///<<< BEGIN WRITING YOUR CODE Say
        behaviac.Debug.LogWarning("Say: " + param0);
        ///<<< END WRITING YOUR CODE
	}

	public void SayHello()
	{
///<<< BEGIN WRITING YOUR CODE SayHello
        behaviac.Debug.LogWarning("Hello Behaviac");
        // behaviac.Debug.LogWarning("p1:" + p1);
        ///<<< END WRITING YOUR CODE
	}

	public behaviac.EBTStatus Says(string value, bool isLatent)
	{
///<<< BEGIN WRITING YOUR CODE Says
        if (isLatent && behaviac.Workspace.Instance.FrameSinceStartup < 3)
        {
            behaviac.Debug.LogWarning("[Running]" + value);
            return behaviac.EBTStatus.BT_RUNNING;
        }
        behaviac.Debug.LogWarning("[Success]" + value);
        return behaviac.EBTStatus.BT_SUCCESS;
        ///<<< END WRITING YOUR CODE
	}

	public behaviac.EBTStatus Start()
	{
///<<< BEGIN WRITING YOUR CODE Start
        count = 0;
        return behaviac.EBTStatus.BT_RUNNING;
        ///<<< END WRITING YOUR CODE
	}

	public behaviac.EBTStatus Wait()
	{
///<<< BEGIN WRITING YOUR CODE Wait
        count++;
        behaviac.Debug.LogWarning("p1 = " + p1);
        if (count == 10000)
        {
            return behaviac.EBTStatus.BT_SUCCESS;
        }
        return behaviac.EBTStatus.BT_RUNNING;
        ///<<< END WRITING YOUR CODE
	}

///<<< BEGIN WRITING YOUR CODE CLASS_PART
    int count;
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
        // behaviac.Config.IsSocketBlocking = true;
        // Debug.LogWarning("Time.time:" + DateTime.Now.ToFileTimeUtc().ToString());
        // 添加时间种子
        behaviac.RandomGenerator.GetInstance().SetSeed((uint)DateTime.Now.ToFileTimeUtc());
        behaviac.Workspace.Instance.FilePath = FirstAgent.FilePath;
        behaviac.Workspace.Instance.FileFormat = behaviac.Workspace.EFileFormat.EFF_xml;
        return true;
    }

    // 加载指定的行为树
    private bool InitPlayer(string btName)
    {
        behaviac.Debug.LogWarning("InitPlayer");

        bool bRet = this.btload(btName);
        if (bRet)
        {
            this.btsetcurrent(btName);
        }

        return bRet;
    }


    void Awake()
    {
        InitBehavic();

        InitPlayer("selectorprobabilityBT");
    }

    behaviac.EBTStatus _status = behaviac.EBTStatus.BT_RUNNING;

    void Update()
    {
        if (_status == behaviac.EBTStatus.BT_RUNNING)
        {
            behaviac.Debug.LogWarning("Update");
            behaviac.Workspace.Instance.FrameSinceStartup = behaviac.Workspace.Instance.FrameSinceStartup + 1;
            _status = this.btexec();
            // FireEvent("event_task", 2);
            // behaviac.Workspace.Instance.DebugUpdate();
        }
    }
    ///<<< END WRITING YOUR CODE

}

///<<< BEGIN WRITING YOUR CODE FILE_UNINIT

///<<< END WRITING YOUR CODE

