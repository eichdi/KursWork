using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DialogModel;

namespace Saver
{
    class UnitS
    {
        string name;
        object obj;
        public UnitS(string name, object obj)
        {
            this.name = name;
            this.obj = obj;
        }
        public string ConstructorValue()
        {
            return "{" + name + "=" + obj.ToString() + "}";
        }
    }
    class ObjectS
    {
        private UnitS[] unitS;
        private string type;
        public static string ConstructObject(UnitS[] unitS,string type)
        {
            string result= "";
            for (int i = 0; i < unitS.Length - 1; i++)
            {
                result += unitS[i].ToString()+";";
            }
            result+=unitS[unitS.Length - 1].ToString();
            return "{" + type + "|" + result + "|}";
        }
        public ObjectS(string type, UnitS[] unitS)
        {
            this.unitS = unitS;
            this.type = type;
        }
        
    }
    
}
