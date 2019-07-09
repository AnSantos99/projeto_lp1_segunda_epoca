using System;
using System.Collections.Generic;
using System.Text;

namespace lp1_projetoFinal
{
    internal class UserInputArgs
    {
        //Dictionary<string, int> argPairs = new Dictionary<string, int>();


        /// <summary>
        /// Set Dictionary to defualt value to choose after in args
        /// </summary>
        /// <param name="myDictionary"></param>
        public static void ArgsDicReader(Dictionary<string, int> myDictionary)
        {
            myDictionary.Add("-r", default(int));
            myDictionary.Add("-c", default(int));
            myDictionary.Add("-d", default(int));
        }
    }
}
