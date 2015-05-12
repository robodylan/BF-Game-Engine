using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using SFML;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
class Program
{

    public static Sprite s = new Sprite(new Texture("img.bmp"), new IntRect(-1,-1,16,16));
    public static RenderWindow window = new RenderWindow(new VideoMode(800U, 600U), "Brainf*ck Game Engine By Dylan Dunn");
    public static byte[] L = new byte[1026];
    static void Main(string[] args)
    {
        int Pointer = 0;
        int CurPo = 0;
        Stack<int> Tabs = new Stack<int>();
        byte[] D = File.ReadAllBytes("src.dbs");
        while(CurPo < D.Length && Pointer < L.Length)
        {
            //Console.WriteLine(Tabs);
            switch (D[CurPo])
            {
                //Check for [
                case (byte)91:
                    Tabs.Push(CurPo);
                    CurPo++;
                    break;
                //Check for ]
                case (byte)93:
                    if (L[Pointer] != 0) CurPo = Tabs.Pop();
                    else { CurPo++; }
                    break;
                //Check for <
                case (byte)60:
                    Pointer--;
                    CurPo++;
                    break;
                //Check for >
                case (byte)62:
                    Pointer++;
                    CurPo++;
                    break;
                //Check for .
                case (byte)46:
                    Console.Write(Convert.ToChar(L[Pointer]));
                    CurPo++;
                    break;
                //Check for + 
                case (byte)43:
                    L[Pointer]++;
                    CurPo++;
                    break;
                //Check for -
                case (byte)45:
                    L[Pointer]--;
                    CurPo++;
                    break;
                //Check for ,
                case (byte)44:
                    L[Pointer] = (byte)Convert.ToChar(Console.ReadKey().KeyChar);
                    CurPo++;
                    break;
                //Check for *
                case (byte)42:
                    Draw();
                    CurPo++;
                    break;
            }
        }
        Console.WriteLine("Execution Finished");
        Console.Read();
    }
    static void Draw()
    {

        window.DispatchEvents();
        int Scale = 16;
        int X = 0;
        int Y = 0;
        window.Clear();
        foreach (byte a in L)
        {
            if(X >= 32 * Scale)
            {
                X = 0;
                Y += Scale;
            }
            X += Scale;
            s.Position = new Vector2f(X, Y);
            s.Color = new Color((byte)(a),0,0);
            window.Draw(s);
        }
        window.Display();
    }
}
