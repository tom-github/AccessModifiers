using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class AccessModifierCode
    {
        public void UsingModifiers()
        {
            AccessModifier accessModifier = new AccessModifier();
            accessModifier.PublicModifier = "Public";
            accessModifier.IntenalModifier = "Internal";

        }
    }

    class AccessModifierCodeInheritor : AccessModifier
    {
        public void UsingModifiers()
        {
            base.PublicModifier = "Public";
            base.ProtectedModifier = "Protected";
            base.IntenalModifier = "Internal";

        }
    }
}

