using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace SharpUpdater
{
    public interface ISharpUpdatable
    {
        string ApplicationName { get; }
        string ApplicationID { get; }
        Assembly ApplicationAssembly { get; }
        Icon ApplicationIcon { get; }
        Uri UpdateXmlLocation { get; }
        Form Context { get; }
    }
}
