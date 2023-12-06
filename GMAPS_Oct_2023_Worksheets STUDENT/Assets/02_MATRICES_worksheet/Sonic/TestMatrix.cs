using System.Collections;
using System.Collections.Generic;
using System.Drawing.Text;
using UnityEngine;

public class TestMatrix : MonoBehaviour
{
    private HMatrix2D mat = new HMatrix2D();
    private HMatrix2D mat1 = new HMatrix2D(2, 2, 1, 0, 3, 1, 2, 3, 4);
    private HMatrix2D mat2 = new HMatrix2D(2, 5, 1, 6, 7, 1, 2, 1, 1);
    private HMatrix2D resultMat = new HMatrix2D();
    private HVector2D vec1 = new HVector2D();

    void Start()
    {
        //mat.SetIdentity();
        //mat.Print();
        Question2();
    }

    void Question2()
    {
        resultMat = mat1 * mat2;
        resultMat.Print();
    }
}
