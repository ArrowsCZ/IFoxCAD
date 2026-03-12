namespace TestShared;

public class TestJson
{
    /*
     * 需要引入:
     * <ItemGroup>
     *     <Reference Include="System.Web" />
     *     <Reference Include="System.Web.Extensions" />
     * </ItemGroup>
     */
    [CommandMethod(nameof(JavaScriptSerializer))]
    public void JavaScriptSerializer()
    {
        List<int> registeredUsers = [0, 1, 2, 3];

        var serializedResult = System.Text.Json.JsonSerializer.Serialize(registeredUsers);
        var deserializedResult = System.Text.Json.JsonSerializer.Deserialize<List<int>>(
            serializedResult
        );
    }
}
