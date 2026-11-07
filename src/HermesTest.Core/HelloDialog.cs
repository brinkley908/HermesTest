namespace HermesTest.Core;

/// <summary>
/// The message shown by the dialog when the form's button is clicked.
/// Kept in a platform-neutral assembly so the contract is unit-testable
/// on non-Windows build hosts.
/// </summary>
public static class HelloDialog
{
    public const string Message = "Hello";
}
