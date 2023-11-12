using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        GraphicsEditor editor = new GraphicsEditor();
        Group group = new Group();

        group.AddPrimitive();
        group.Scale(10);
        group.Scale(10, 10);
        group.Move(10, 10);

        editor.AddPrimitive();
        editor.ChangeScale(10);
        editor.DrawFigure();
    }
}