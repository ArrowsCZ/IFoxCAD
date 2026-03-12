namespace IFoxTest;
public class TestLoop
{
    [CommandMethod(nameof(Test_LoopList))]
    public void Test_LoopList()
    {
        var loop = new LoopList<int>
        {
            0,
            1,
            2,
            3,
            4,
            5
        };

        loop.Print();

        loop.SetFirst(loop.Last!);
        loop.Print();
        loop.Min().Print();
        loop.SetFirst(new LoopListNode<int>(loop.Min(), loop));
        loop.Print();
    }
}