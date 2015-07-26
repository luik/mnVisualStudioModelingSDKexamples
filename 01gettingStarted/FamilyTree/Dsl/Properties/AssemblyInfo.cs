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
[assembly: AssemblyProduct(@"FamilyTree")]
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
[assembly: InternalsVisibleTo(@"Milkneko.FamilyTree.DslPackage, PublicKey=0024000004800000940000000602000000240000525341310004000001000100DB1F92E4EAF90DDB63404F69C7E65ADB5CF4DD3E56D945A64AE91F58094F1D7A77CD0A88B9317C4DBA84150F66561AAB090EB5EA9BB2B72A8E45267ECD9AC62BD4983C6B78C83C37775915AE008C305EACE986B13EC781A24F97E0D2FEFB4FEBDC6D101815A24DE11AA92CBBD479C6DE2ED10EB937DF5471A973707ECAA7C4AB")]