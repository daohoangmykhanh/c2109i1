namespace OopEncapulation;
internal class Plant
{
    //encapulation thể hiện ở 2 chỗ
    // a) access modify b) property
    // a) access modify
    private void Private() => Console.WriteLine("Private");
    public void Public() => Console.WriteLine("Public");
    internal void Internal() => Console.WriteLine("Interal");
    protected void Protected() => Console.WriteLine("Protected");
    private protected void PrivateProtected() => Console.WriteLine("Private Protected");
    protected void ProtectedInternal() => Console.WriteLine("Protected Internal");
}
