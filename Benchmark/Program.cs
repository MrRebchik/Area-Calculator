using Area_Calculator;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Attributes;

BenchmarkRunner.Run<CompileTimeTest>();

public class CompileTimeTest
{

    [Benchmark]
    public void ComputeUnknownType()
    {
        var fig1 = new Circle(1);
        var area1 = GetFigureArea(fig1);
        var fig2 = new Triangle(new Vector2(0, 0), new Vector2(1,2), new Vector2(0,3));
        var area2 = GetFigureArea(fig2);
    }
    [Benchmark]
    public void ComputeKnownType()
    {
        var fig1 = new Circle(1);
        var area1 = GetCircleArea(fig1);
        var fig2 = new Triangle(new Vector2(0, 0), new Vector2(1, 2), new Vector2(0, 3));
        var area2 = GetTriangleArea(fig2);
    }
    double GetFigureArea(FigureBase figure)
    {
        return figure.GetArea();
    }
    double GetCircleArea(Circle figure)
    {
        return figure.GetArea();
    }
    double GetTriangleArea(Triangle figure)
    {
        return figure.GetArea();
    }
    
}
