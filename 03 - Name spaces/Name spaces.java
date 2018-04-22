System.Security.Cryptography.AsymmetricAlgorithm aa;
//may be replaced:
import System.Security.Crypography; 
class xxx { ...
AsymmetricAlgorithm aa;

/* There is no alias for packages.
 * You have to use import statement 
 * or fully-qualified name to 
 * mention the specific type. */

/*****************************************/
           
pacakge N1.N2;
    class A {}
    class B {}
//or
package N1.N2;
   class A {}

//another source file
package N1.N2;
   class B {}
   
/* package cannot be nested.
 * One source file can only 
 * have one package statement. */
