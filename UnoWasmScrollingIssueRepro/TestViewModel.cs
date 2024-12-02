namespace UnoWasmScrollingIssueRepro;

public class TestViewModel
{
    private static int Index = 0;
    public string TestText { get; set; } = "Test" + Index++;
}
