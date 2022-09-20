using System;

namespace PasswordMaker
{
    class Utility
    {
        /// <summary>Path of application(used for reading and writing files)</summary>
        static public string AppPath;

        static public void Initialize()
        {
            AppPath = AppDomain.CurrentDomain.BaseDirectory;
        }
    }
}
