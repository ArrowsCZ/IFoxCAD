namespace IFoxTest;

public class TestHatchInfoTest
{
    [CommandMethod(nameof(TestHatchInfo))]
    public void TestHatchInfo()
    {
        using var tr = new DBTrans();
        var sf = new SelectionFilter([new TypedValue(0, "*line,circle,arc")]);
        var ids = Env.Editor.SSGet(null, sf).Value?.GetObjectIds();
        if (ids is not { Length: > 0 })
            return;

        var hf = new HatchInfo(ids, false).Mode2UserDefined();
        hf.Build(tr.CurrentSpace);
    }
}
