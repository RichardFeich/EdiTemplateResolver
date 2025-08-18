using System.Reflection;

namespace CPDI.EdiFabric.Utilities.Interfaces
{
    public interface IEdiTemplateResolver
    {
        Type Resolve(string partnerId, string versionRaw, string st01);
        TypeInfo ResolveTypeInfo(string partnerId, string versionRaw, string st01);
    }
}
