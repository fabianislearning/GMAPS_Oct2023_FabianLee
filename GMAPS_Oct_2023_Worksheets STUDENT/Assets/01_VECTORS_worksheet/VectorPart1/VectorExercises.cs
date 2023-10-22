using UnityEngine;

public class VectorExercises : MonoBehaviour
{
    //The LineFactory is responsible for creating and getting the lines
    [SerializeField] LineFactory lineFactory;
    [SerializeField] bool Q2a, Q2b, Q2d, Q2e;
    [SerializeField] bool Q3a, Q3b, Q3c, projection;

    private Line drawnLine;

    private Vector2 startPt;
    private Vector2 endPt;

    public float GameWidth, GameHeight;
    private float minX, minY, maxX, maxY;

    private void Start()
    {
        if (Q2a)
            Question2a();
        if (Q2b)
            Question2b(20);
        if (Q2d)
            Question2d();
        if (Q2e)
            Question2e(20);
        if (Q3a)
            Question3a();
        if (Q3b)
            Question3b();
        if (Q3c)
            Question3c();
        if (projection)
            Projection();
    }

    public void CalculateGameDimensions()
    {
        GameHeight = Camera.main.orthographicSize * 2f;
        GameWidth = Camera.main.aspect * GameHeight;

        maxX = GameWidth / 2;
        maxY = GameHeight / 2;
        minX = -maxX;
        minY = -maxY;
    }

    void Question2a()
    {
        //Define the lines starting position
        startPt = new Vector2(0, 0);
        //Define the lines ending position
        endPt = new Vector2(2, 3);

        //The order of the properties: Vector2 start, Vector2 end, float width, Color color)
        //Width is representing how thick the line is
        drawnLine = lineFactory.GetLine(startPt, endPt, 0.02f, Color.black);
        drawnLine.EnableDrawing(true);

        Vector2 vec2 = endPt - startPt;
        Debug.Log("Magnitude = " + vec2.magnitude);
    }

    void Question2b(int n)
    {
        CalculateGameDimensions();
        minX = 5; minY = 5; maxX = 5; maxY = 5;
        for (int i = 0; i < n; i++)
        {
            startPt = new Vector2(Random.Range(-minX, maxX), Random.Range(-minY, maxY));
            endPt = new Vector2(Random.Range(-minX, maxX), Random.Range(-minY, maxY));
            drawnLine = lineFactory.GetLine(startPt, endPt, 0.02f, Color.black);

            drawnLine.EnableDrawing(true);
            Debug.Log("startpt: " + startPt);
            Debug.Log("endpt: " + endPt);
        }
    }

    void Question2d()
    {
        DebugExtension.DebugArrow(new Vector3(0, 0, 0), new Vector3(5, 5, 0), Color.red, 60f);
    }

    void Question2e(int n)
    {
        CalculateGameDimensions();
        minX = 5; minY = 5; maxX = 5; maxY = 5;
        for (int i = 0; i < n; i++)
        {
            DebugExtension.DebugArrow(new Vector3(0, 0, 0), 
                new Vector3(Random.Range(-minX, maxX), 
                Random.Range(-minY, maxY), 0), Color.white, 60f);
        }  
    }

    public void Question3a()
    {
        HVector2D a = new HVector2D(3, 5);
        HVector2D b = new HVector2D(-4, 2);
        HVector2D c = new HVector2D(a.x + b.x, a.y + b.y);

        DebugExtension.DebugArrow(Vector3.zero, a.ToUnityVector3(), Color.red, 60f);
        DebugExtension.DebugArrow(Vector3.zero, b.ToUnityVector3(), Color.green, 60f);
        DebugExtension.DebugArrow(Vector3.zero, c.ToUnityVector3(), Color.white, 60f);
        DebugExtension.DebugArrow(new Vector3(3, 5, 0), b.ToUnityVector3(), Color.green, 60f);
        // Your code here
        // ...

        // Your code here

        //Debug.Log("Magnitude of a = " + // Your code here.ToString("F2"));
        // Your code here
        // ...
    }

    public void Question3b()
    {
        // Your code here
        // ...

        //DebugExtension.DebugArrow(Vector3.zero, a.ToUnityVector3(), Color.red, 60f);
        // Your code here
    }

    public void Question3c()
    {

    }

    public void Projection()
    {
        HVector2D a = new HVector2D(0, 0);
        HVector2D b = new HVector2D(6, 0);
        HVector2D c = new HVector2D(2, 2);

        //HVector2D v1 = b - a;
        // Your code here

        //HVector2D proj = // Your code here

        //DebugExtension.DebugArrow(a.ToUnityVector3(), b.ToUnityVector3(), Color.red, 60f);
        //DebugExtension.DebugArrow(a.ToUnityVector3(), c.ToUnityVector3(), Color.yellow, 60f);
        //DebugExtension.DebugArrow(a.ToUnityVector3(), proj.ToUnityVector3(), Color.white, 60f);
    }
}
