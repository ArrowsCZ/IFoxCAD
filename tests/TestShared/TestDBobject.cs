namespace TestShared
{
    public static class TestDbObject
    {
        [CommandMethod(nameof(Test_ForWrite))]
        public static void Test_ForWrite()
        {
            using var tr = new DBTrans();
            var ent = Env.Editor.GetEntity("\npick entity");
            if (ent.Status is not PromptStatus.OK)
                return;
            var entId = ent.ObjectId.GetObject<Entity>()!;
            Tools.TestTimes3(
                100000,
                "using:",
                i =>
                {
                    using (entId.ForWrite())
                        entId.ColorIndex = i % 7;
                }
            );
            Tools.TestTimes3(100000, "action:", i => entId.ForWrite(e => e.ColorIndex = i % 7));
        }
    }
}
