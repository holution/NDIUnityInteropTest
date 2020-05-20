static class Config
{
#if UNITY_EDITOR_OSX || UNITY_STANDALONE_OSX
    public const string DllName = "libndi.4";
#elif UNITY_EDITOR_WIN || UNITY_STANDALONE_WIN
    public const string DllName = "Processing.NDI.Lib.x64";
#else
    public const string DllName = "__Internal";
#endif
}
