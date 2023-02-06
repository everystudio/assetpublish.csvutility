using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoScript : MonoBehaviour
{
    [SerializeField] private TextAsset localCsvFile;

    [SerializeField] private string saveFilename = "test_file";

    public void LoadFromLocalCsvFile()
    {
        if (localCsvFile != null)
        {
            SampleModel sampleModel = new SampleModel();
            if (sampleModel.Load(localCsvFile))
            {
                sampleModel.CheckDebugLog();
            }
        }
        else
        {
            Debug.LogWarning("not set csv file!!");
        }
    }

    public void SaveToPersistentDataPath()
    {
        SampleModel sampleModel = new SampleModel();
        sampleModel.List.Add(new SampleModelParam() { test_int = 10, test_float = 10.0f });
        sampleModel.List.Add(new SampleModelParam() { test_int = 12, test_float = 12.0f });

        sampleModel.Save(saveFilename);
        Debug.Log("Check your directroy");
        Debug.Log($"{System.IO.Path.Combine(Application.persistentDataPath, saveFilename) }");
    }

    public void LoadFromPersistentDataPath()
    {
        SampleModel sampleModel = new SampleModel();
        if (sampleModel.Load(saveFilename))
        {
            sampleModel.CheckDebugLog();
        }
        else
        {
            Debug.LogError("not found saved csv file");
            Debug.LogError($"{System.IO.Path.Combine(Application.persistentDataPath, saveFilename) }");
        }
    }

}
