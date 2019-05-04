using UnityEngine;
public class PathConst
{
    public static string FilePath
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
}