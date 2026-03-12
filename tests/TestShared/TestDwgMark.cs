namespace IFoxTest;

public class TestDwgMark
{
    [CommandMethod(nameof(Test_DwgMarktest))]
    public void Test_DwgMarktest()
    {
        FileInfo file = new FileInfo(@"D:\TEST\1.dwg");
        DwgMark.AddMark(file, 0x4D);
        DwgMark.RemoveMark(file);
        int a = DwgMark.GetMark(file);
    }
}
