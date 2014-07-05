using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
   
    public class AccessModifier
    {

        #region Properties

        //The type or member can be accessed by any other code in the same assembly or another assembly that references it.
        public string PublicModifier { get; set; }

        //The type or member can be accessed only by code in the same class or struct.
        private string PrivateModifier { get; set; }

        //The type or member can be accessed only by code in the same class or struct, or in a class that is derived from that class.
        protected string ProtectedModifier { get; set; }

        //The type or member can be accessed by any code in the same assembly, but not from another assembly.
        //Internal is the default, in the absence of a specified modifier. 
        internal string IntenalModifier { get; set; }
        
        #endregion

        #region Methods

        private void UsingModifiers()
        {
            this.PublicModifier = "Public";
            this.PrivateModifier = "Private";
            this.ProtectedModifier = "Protected";
            this.IntenalModifier = "Internal";
        }

        #endregion
    }
}
