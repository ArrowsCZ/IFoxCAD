namespace TestAcad2025;

public static class TestBubbleWindow
{
    [CommandMethod(nameof(Test_BubbleWindow))]
    public static void Test_BubbleWindow()
    {
        IFoxUtils.ShowBubbleWindow(5, "测试", "测试");
    }
}
