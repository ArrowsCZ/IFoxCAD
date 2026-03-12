namespace IFoxTest;

/**************************************************************
*作者：Leon
*创建时间：2022/2/11 9:55:32
**************************************************************/

public class TestFileDatabase
{
    [CommandMethod(nameof(Test_FileDatabaseInit))]
    public void Test_FileDatabaseInit()
    {
        try
        {
            const string fileName = @"C:\Users\Administrator\Desktop\合并详图测试BUG.dwg";
            using DBTrans trans = new(fileName);
            trans.ModelSpace.AddEntity(new Line(new Point3d(0, 0, 0), new Point3d(1000, 1000, 0)));
            if (trans.Document is not null && trans.Document.IsActive)
                trans.Document.SendStringToExecute("_qsave\n", false, true, true);
            else
                trans.Database.SaveAs(fileName, (DwgVersion)27);
        }
        catch (Exception e)
        {
            System.Windows.MessageBox.Show(e.Message);
        }
    }
}
