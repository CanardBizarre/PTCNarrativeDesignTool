using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTCNarrativeDesignTool
{
    public class Singleton<T1> where T1 : class , new()
    {
        private static T1 instance;
        public static T1 GetInstance()
        {
            if (instance == null)
            {
                instance = new T1();
            }
            return instance;
        }
    }
}
