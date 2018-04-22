System.Security.Cryptography.AsymmetricAlgorithm aa;
//may be replaced:
using System.Security.Crypography; 
AsymmetricAlgorithm aa;

//Alternatively, one could specify an alias 
//for the the namespace, eg 

using myAlias = System.Security.Crypography; 
//and then refer to the class with 

myAlias.AsymmetricAlgorithm 

/*****************************************/

namespace N1.N2
{
    class A {}
    class B {}
}
//or
namespace N1
{
    namespace N2
    {
        class A {}
        class B {}
    }
}
