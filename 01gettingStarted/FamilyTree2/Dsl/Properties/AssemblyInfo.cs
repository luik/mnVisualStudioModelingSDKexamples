#region Using directives

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.ConstrainedExecution;

#endregion

//
// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
//
[assembly: AssemblyTitle(@"")]
[assembly: AssemblyDescription(@"")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(@"Milkneko")]
[assembly: AssemblyProduct(@"FamilyTree2")]
[assembly: AssemblyCopyright("")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: System.Resources.NeutralResourcesLanguage("en")]

//
// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers 
// by using the '*' as shown below:

[assembly: AssemblyVersion(@"1.0.0.0")]
[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]
[assembly: ReliabilityContract(Consistency.MayCorruptProcess, Cer.None)]

//
// Make the Dsl project internally visible to the DslPackage assembly
//
[assembly: InternalsVisibleTo(@"com.milkneko.FamilyTree2.DslPackage, PublicKey=0024000004800000940000000602000000240000525341310004000001000100F54CF7A58F2930DBAF51EFE8B42FA6063F65F5895E32A7D9209826068F7D7048410970DCAAB3B290C3E1272B82AF4F4D6E234EED68ECF60B175FA86565456B08493AD7BF035DABF80E53ED49DE0499C85CA64727E2445D35F7EC1765A5DFFE9C9251E64625269478FB6F2A31BDAD97EF1FAEE17D3B976F4F7B915043614D4DDD")]