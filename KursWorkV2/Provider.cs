using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DialogModel;
using System.IO;
using Newtonsoft.Json;
using LogMove;
namespace Provider
{
    public interface IProvider
    {
        static void Save(string path, DialogClass dialog);
        static DialogClass Open(string path);
    }
    class DialogProvider:IProvider
    {
        public static void Save(string path, DialogClass dialog)
        {
            StreamWriter sw = new StreamWriter(path);
            sw.Write(JsonConvert.SerializeObject(dialog));
            sw.Flush();
            sw.Close();
        }
        public static DialogClass Open(string path)
        {
            StreamReader sr = new StreamReader(path);
            return JsonConvert.DeserializeObject<DialogClass>(sr.ReadToEnd());
        }
    }
    class LogProvider 
    {
        public static void Save(string path, LogDialog dialog)
        {
            StreamWriter sw = new StreamWriter(path);
            sw.Write(JsonConvert.SerializeObject(dialog));
            sw.Flush();
            sw.Close();
        }
        public static LogDialog Open(string path)
        {
            StreamReader sr = new StreamReader(path);
            return JsonConvert.DeserializeObject<LogDialog>(sr.ReadToEnd());
        }
    }
}
