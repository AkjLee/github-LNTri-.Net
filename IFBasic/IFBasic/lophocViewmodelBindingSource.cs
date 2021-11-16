using IFBasic.Viewmodel;
using System;
using System.Collections.Generic;

namespace IFBasic
{
    internal class lophocViewmodelBindingSource
    {
        internal static List<LophocViewmodel> DataSource;

        public static LophocViewmodel Current { get; internal set; }

        internal static void RemoveCurrent()
        {
            throw new NotImplementedException();
        }
    }
}