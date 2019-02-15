using System.Reflection;
using System.Text;
using BinaryTools.Internal.Native.Classes;

namespace BinaryTools.IO
{
    public class IniFile
    {
        private readonly string Path;

#if NETSTANDARD1_3
        private readonly string ExecutingAssemblyName = "NetStandard13";
#else
        private readonly string ExecutingAssemblyName = Assembly.GetExecutingAssembly().GetName().Name;
#endif

        public IniFile(string IniPath = null)
        {
            Path = new System.IO.FileInfo(IniPath ?? ExecutingAssemblyName + ".ini").FullName.ToString();
        }


        public string Read(string Key, string Section = null, string Default = "")
        {
            StringBuilder RetVal = new StringBuilder(255);
            Kernel32.GetPrivateProfileString(Section ?? ExecutingAssemblyName, Key, Default, RetVal, 255, Path);
            return RetVal.ToString();
        }

        public void Write(string Key, string Value, string Section = null)
        {
            Kernel32.WritePrivateProfileString(Section ?? ExecutingAssemblyName, Key, Value, Path);
        }

        public void DeleteKey(string Key, string Section = null)
        {
            Write(Key, null, Section ?? ExecutingAssemblyName);
        }

        public void DeleteSection(string Section = null)
        {
            Write(null, null, Section ?? ExecutingAssemblyName);
        }

        public bool KeyExists(string Key, string Section = null)
        {
            return Read(Key, Section).Length > 0;
        }
    }
}
