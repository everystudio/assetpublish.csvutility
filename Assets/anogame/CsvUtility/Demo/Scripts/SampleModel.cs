using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using anogamelib;

public class SampleModelParam : CsvModelParam
{
    public int test_int;
    public float test_float;

    public override string ToString()
    {
        return $"test_int={test_int} test_float={test_float}";
    }
}

public class SampleModel : CsvModel<SampleModelParam>
{
}
