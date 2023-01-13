// Copyright (c) 2022 Ubisoft Entertainment
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Sharpmake
{
    public static partial class Options
    {
        public static class Agde
        {
            public static class General
            {
                /// <summary>
                /// Name of the gradle app folder/module
                /// </summary>
                public class AndroidApplicationModule : StringOption
                {
                    public AndroidApplicationModule(string androidApplicationModule) : base(androidApplicationModule) { }
                }

                /// <summary>
                /// The full path to the directory containing the top-level build.gradle file.
                /// </summary>
                public class AndroidGradleBuildDir : PathOption
                {
                    public AndroidGradleBuildDir(string androidGradleBuildDir)
                       : base(androidGradleBuildDir) { }
                }

                /// <summary>
                /// Intermediate directory of the gradle build process
                /// </summary>
                public class AndroidGradleBuildIntermediateDir : PathOption
                {
                    public AndroidGradleBuildIntermediateDir(string androidGradleBuildIntermediateDir)
                       : base(androidGradleBuildIntermediateDir) { }
                }

                /// <summary>
                /// Output Extra Gradle Arguments for AGDE project which can be set per configuration.
                /// </summary>
                public class AndroidExtraGradleArgs : StringOption
                {
                    public AndroidExtraGradleArgs(string androidExtraGradleArgs)
                       : base(androidExtraGradleArgs) { }
                }

                /// <summary>
                /// Output Apk name for AGDE project which can be set per configuration.
                /// </summary>
                public class AndroidApkName : StringOption
                {
                    public AndroidApkName(string androidApkName)
                       : base(androidApkName) { }
                }

                /// <summary>
                /// The apk file used for debugging which can be set per configuration, is usually for FastBuild configuration.
                /// </summary>
                public class AndroidApkLocation : PathOption
                {
                    public AndroidApkLocation(string androidApkLocation) : base(androidApkLocation) { }
                }

                /// <summary>
                /// Debug Information Format
                /// </summary>
                /// <remarks>
                /// Specifies the type of debugging information generated by the compiler.
                /// </remarks>
                public enum ClangDebugInformationFormat
                {
                    /// <summary>
                    /// Produces no debugging information, so compilation may be faster.
                    /// </summary>
                    None,

                    /// <summary>
                    /// Full Debug Information
                    /// </summary>
                    /// <remarks>
                    /// Generate debug information.
                    /// </remarks>
                    [Default]
                    FullDebug,

                    /// <summary>
                    /// Line Number Information
                    /// </summary>
                    /// <remarks>
                    /// Generate line number information only.
                    /// </remarks>
                    LineNumber
                }

                /// <summary>
                /// Limit Debug Information Size
                /// </summary>
                /// <remarks>
                /// Limits the amount of debug information clang will produce.
                /// </remarks>
                public enum LimitDebugInfo
                {
                    Enable,
                    [Default]
                    Disable
                }


                /// <summary>
                /// Thumb Mode
                /// </summary>
                /// <remarks>
                /// Generate code that executes for thumb microarchitecture. This is applicable for arm architecture only.
                /// </remarks>
                public enum ThumbMode
                {
                    /// <summary>
                    /// Generate Thumb code.
                    /// </summary>
                    Thumb,

                    /// <summary>
                    /// Generate Arm code.
                    /// </summary>
                    ARM,

                    /// <summary>
                    /// Option not applicable for chosen platform.
                    /// </summary>
                    [Default]
                    Disabled
                }

                public enum UseOfStl
                {
                    GnuStl_Static,
                    GnuStl_Shared,
                    LibCpp_Static,
                    [Default]
                    LibCpp_Shared
                }

                /// <summary>
                /// Link Time Optimization
                /// </summary>
                /// <remarks>
                /// Enables link time optimization. May also be required for some sanitizers.
                /// </remarks>
                public enum LinkTimeOptimization
                {
                    /// <summary>
                    /// No link time optimization is performed.
                    /// </summary>
                    [Default]
                    None,

                    /// <summary>
                    /// Link Time Optimization
                    /// </summary>
                    /// <remarks>
                    /// Enable link time optimization.
                    /// </remarks>
                    LinkTimeOptimization,

                    /// <summary>
                    /// Thin Link Time Optimization
                    /// </summary>
                    /// <remarks>
                    /// A model of link time optimization that may scale better in larger projects.
                    /// </remarks>
                    ThinLinkTimeOptimization
                }

                // Set the flag '-fuse-ld=' which specifies which linker to use.
                public enum ClangLinkType
                {
                    DeferToNdk,
                    gold,
                    [Default]
                    lld,
                    bfd
                }

                /// <summary>
                /// Warning Level
                /// </summary>
                /// <remarks>
                /// Select how strict you want the compiler to be about warnings. Other flags should be added directly to Additional Options.
                /// </remarks>
                public enum WarningLevel
                {
                    /// <summary>
                    /// Use clang's default.
                    /// </summary>
                    Default,

                    /// <summary>
                    /// Disable All Warnings
                    /// </summary>
                    /// <remarks>
                    /// Disables all compiler warnings.
                    /// </remarks>
                    TurnOffAllWarnings,

                    /// <summary>
                    /// Format Warnings
                    /// </summary>
                    /// <remarks>
                    /// Enables warnings related to formatting in printf, scanf, etc.
                    /// </remarks>
                    [Default]
                    EnableFormatWarnings,

                    /// <summary>
                    /// Format and Security Warnings
                    /// </summary>
                    /// <remarks>
                    /// Enables warnings related to formatting and to security.
                    /// </remarks>
                    EnableFormatAndSecurityWarnings,

                    /// <summary>
                    /// Most Warnings
                    /// </summary>
                    /// <remarks>
                    /// Enables a large set of useful warnings.
                    /// </remarks>
                    EnableWarnings,

                    /// <summary>
                    /// Extra Warnings
                    /// </summary>
                    /// <remarks>
                    /// Enables a larger set of warnings.
                    /// </remarks>
                    EnableExtraWarnings,

                    /// <summary>
                    /// Exhaustive Warnings
                    /// </summary>
                    /// <remarks>
                    /// Enables all warnings, including some that are not typically useful and some that contradict each other.
                    /// </remarks>
                    EnableAllWarnings
                }
            }

            public static class Compiler
            {
                /// <summary>
                /// Multi-processor Compilation
                /// </summary>
                public enum MultiProcessorCompilation
                {
                    [Default]
                    Enable,
                    Disable
                }

                /// <summary>
                /// C Language Standard
                /// </summary>
                /// <remarks>
                /// Determines the C language standard.
                /// </remarks>
                public enum CLanguageStandard
                {
                    /// <summary>
                    /// Use clang's default.
                    /// </summary>
                    Default,

                    /// <summary>
                    /// C89 Language Standard.
                    /// </summary>
                    C89,

                    /// <summary>
                    /// C99 Language Standard.
                    /// </summary>
                    C99,

                    /// <summary>
                    /// C11 Language Standard.
                    /// </summary>
                    [Default]
                    C11,

                    /// <summary>
                    /// C17 Language Standard.
                    /// </summary>
                    C17,

                    /// <summary>
                    /// C99 (GNU Dialect)
                    /// </summary>
                    /// <remarks>
                    /// C99 (GNU Dialect) Language Standard.
                    /// </remarks>
                    Gnu99,

                    /// <summary>
                    /// C11 (GNU Dialect)
                    /// </summary>
                    /// <remarks>
                    /// C11 (GNU Dialect) Language Standard.
                    /// </remarks>
                    Gnu11,

                    /// <summary>
                    /// C17 (GNU Dialect)
                    /// </summary>
                    /// <remarks>
                    /// C17 (GNU Dialect) Language Standard.
                    /// </remarks>
                    Gnu17
                }

                /// <summary>
                /// C++ Language Standard
                /// </summary>
                /// <remarks>
                /// Determines the C++ language standard.
                /// </remarks>
                public enum CppLanguageStandard
                {
                    /// <summary>
                    /// Use clang's default.
                    /// </summary>
                    Default,

                    /// <summary>
                    /// C++98
                    /// </summary>
                    /// <remarks>
                    /// C++98 Language Standard.
                    /// </remarks>
                    Cpp98,

                    /// <summary>
                    /// C++03
                    /// </summary>
                    /// <remarks>
                    /// C++03 Language Standard.
                    /// </remarks>
                    Cpp03,

                    /// <summary>
                    /// C++11
                    /// </summary>
                    /// <remarks>
                    /// C++11 Language Standard.
                    /// </remarks>
                    [Default]
                    Cpp11,

                    /// <summary>
                    /// C++14
                    /// </summary>
                    /// <remarks>
                    /// C++14 Language Standard.
                    /// </remarks>
                    Cpp14,

                    /// <summary>
                    /// C++1z
                    /// </summary>
                    /// <remarks>
                    /// C++1z Language Standard.
                    /// </remarks>
                    Cpp1z,

                    /// <summary>
                    /// C++17
                    /// </summary>
                    /// <remarks>
                    /// C++17 Language Standard.
                    /// </remarks>
                    Cpp17,

                    /// <summary>
                    /// C++98 (GNU Dialect)
                    /// </summary>
                    /// <remarks>
                    /// C++98 (GNU Dialect) Language Standard.
                    /// </remarks>
                    Gnupp98,

                    /// <summary>
                    /// C++03 (GNU Dialect)
                    /// </summary>
                    /// <remarks>
                    /// C++03 (GNU Dialect) Language Standard.
                    /// </remarks>
                    Gnupp03,

                    /// <summary>
                    /// C++11 (GNU Dialect)
                    /// </summary>
                    /// <remarks>
                    /// C++11 (GNU Dialect) Language Standard.
                    /// </remarks>
                    Gnupp11,

                    /// <summary>
                    /// C++14 (GNU Dialect)
                    /// </summary>
                    /// <remarks>
                    /// C++14 (GNU Dialect) Language Standard.
                    /// </remarks>
                    Gnupp14,

                    /// <summary>
                    /// C++1z (GNU Dialect)
                    /// </summary>
                    /// <remarks>
                    /// C++1z (GNU Dialect) Language Standard.
                    /// </remarks>
                    Gnupp1z,

                    /// <summary>
                    /// C++17 (GNU Dialect)
                    /// </summary>
                    /// <remarks>
                    /// C++17 (GNU Dialect) Language Standard.
                    /// </remarks>
                    Gnupp17
                }

                /// <summary>
                /// Enable Data-Level Linking
                /// </summary>
                /// <remarks>
                /// Enables linker optimizations to remove unused data by emitting each data item in a separate section.
                /// </remarks>
                public enum DataLevelLinking
                {
                    Disable,
                    [Default]
                    Enable
                }

                /// <summary>
                /// Enable C++ Exceptions
                /// </summary>
                /// <remarks>
                /// Specifies the model of exception handling to be used by the compiler.
                /// </remarks>
                public enum ExceptionHandling
                {
                    /// <summary>
                    /// No
                    /// </summary>
                    /// <remarks>
                    /// Disable exception handling.
                    /// </remarks>
                    [Default]
                    Disable,

                    /// <summary>
                    /// Yes
                    /// </summary>
                    /// <remarks>
                    /// Enable exception handling.
                    /// </remarks>
                    Enable
                }

                /// <summary>
                /// Unwind Tables
                /// </summary>
                /// <remarks>
                /// Generates any needed static data for unwind table, but does not affect the code generated.
                /// </remarks>
                public enum UnwindTables
                {
                    [Default]
                    Enable,
                    Disable
                }

                /// <summary>
                /// Enable Address Significance Table
                /// </summary>
                /// <remarks>
                /// Emit an address-significance table.
                /// </remarks>
                public enum AddressSignificanceTable
                {
                    Enable,
                    [Default]
                    Disable
                }

                /// <summary>
                /// Format of Errors and Warnings
                /// </summary>
                /// <remarks>
                /// Set the format for errors and warnings
                /// </remarks>
                public enum ClangDiagnosticsFormat
                {
                    /// <summary>
                    /// Use clang's default (warning, Visual Studio may not recognize errors in this format)
                    /// </summary>
                    Default,

                    /// <summary>
                    /// Microsoft Visual Studio Format
                    /// </summary>
                    /// <remarks>
                    /// Report errors which Visual Studio can use to parse for file and line information.
                    /// </remarks>
                    [Default]
                    MSVC
                }

                /// <summary>
                /// Stack Protection Level
                /// </summary>
                /// <remarks>
                /// Enable stack protectors for functions vulnerable to stack smashing. Stack smashing protectors take the  form of a �canary� � a random value placed on the stack before the local variables that�s checked upon  return from the function to see if it has been overwritten.
                /// </remarks>
                public enum StackProtectionLevel
                {
                    /// <summary>
                    /// No stack protection.
                    /// </summary>
                    None,

                    /// <summary>
                    /// Protects functions with character arrays larger than ssp-buffer-size (default 8) and functions that calls alloca() with variable sizes or constant sizes greater than ssp-buffer-size.
                    /// </summary>
                    Basic,

                    /// <summary>
                    /// Protects functions with arrays of any size, functions with any call to alloca(), functions with local variables that have their address taken.
                    /// </summary>
                    [Default]
                    Strong,

                    /// <summary>
                    /// Protects all functions.
                    /// </summary>
                    All,

                    /// <summary>
                    /// Let clang decide which stack protection level to use.
                    /// </summary>
                    Default
                }

                /// <summary>
                /// Floating-point ABI
                /// </summary>
                /// <remarks>
                /// Selection option to choose the floating point ABI.
                /// </remarks>
                public enum FloatABI
                {
                    /// <summary>
                    /// Use clang's default.
                    /// </summary>
                    [Default]
                    Default,

                    /// <summary>
                    /// Causes compiler to generate output containing library calls for floating-point operations.
                    /// </summary>
                    Soft,

                    /// <summary>
                    /// Allows the generation of code using hardware floating-point instructions, but still uses the soft-float calling conventions.
                    /// </summary>
                    Softfp,

                    /// <summary>
                    /// Allows generation of floating-point instructions and uses FPU-specific calling conventions.
                    /// </summary>
                    Hard
                }

                /// <summary>
                /// Enable Function-Level Linking
                /// </summary>
                /// <remarks>
                /// Allows the compiler to package individual functions in the form of packaged functions (COMDATs). Required for edit and continue to work.
                /// </remarks>
                public enum FunctionLevelLinking
                {
                    Disable,
                    [Default]
                    Enable,
                }

                /// <summary>
                /// Omit Frame Pointers
                /// </summary>
                /// <remarks>
                /// Suppresses creation of frame pointers on the call stack.
                /// </remarks>
                public enum OmitFramePointers
                {
                    [Default]
                    Disable,
                    Enable
                }

                /// <summary>
                /// Optimization Level
                /// </summary>
                /// <remarks>
                /// Specifies the optimization level for the application.
                /// </remarks>
                public enum Optimization
                {
                    /// <summary>
                    /// Custom optimization. No flag is set.
                    /// </summary>
                    Custom,

                    /// <summary>
                    /// Disable optimization.
                    /// </summary>
                    [Default(DefaultTarget.Debug)]
                    Disabled,

                    /// <summary>
                    /// Minimize Size
                    /// </summary>
                    /// <remarks>
                    /// Optimize for size.
                    /// </remarks>
                    MinSize,

                    /// <summary>
                    /// Maximize Speed
                    /// </summary>
                    /// <remarks>
                    /// Optimize for speed.
                    /// </remarks>
                    [Default(DefaultTarget.Release)]
                    MaxSpeed,

                    /// <summary>
                    /// Full Optimization
                    /// </summary>
                    /// <remarks>
                    /// Expensive Optimizations.
                    /// </remarks>
                    Full
                }

                /// <summary>
                /// Position Independent Code
                /// </summary>
                /// <remarks>
                /// Generate Position Independent Code (PIC) for use in a shared library.
                /// </remarks>
                public enum PositionIndependentCode
                {
                    [Default]
                    Enable,
                    Disable
                }
            }

            public static class Linker
            {
                public enum DebuggerSymbolInformation
                {
                    [Default]
                    IncludeAll,
                    OmitUnneededSymbolInformation,
                    OmitDebuggerSymbolInformation,
                    OmitAllSymbolInformation
                }

                public enum EnableImmediateFunctionBinding
                {
                    [Default]
                    Yes,
                    No
                }

                public enum ExecutableStackRequired
                {
                    Yes,
                    [Default]
                    No
                }

                public enum ReportUnresolvedSymbolReference
                {
                    [Default]
                    Yes,
                    No
                }

                public enum VariableReadOnlyAfterRelocation
                {
                    [Default]
                    Yes,
                    No
                }

                public enum UseThinArchives
                {
                    Enable,
                    [Default]
                    Disable
                }

                /// <summary>
                /// Enable Incremental Linking
                /// </summary>
                public enum Incremental
                {
                    [Default]
                    Disable,
                    Enable,
                }

                /// <summary>
                /// Tag the shared object with a build id.
                ///
                /// This is typically necessary to match debug symbols with a stripped executable.
                /// </summary>
                public enum BuildId
                {
                    [Default]
                    None,
                    Fast,
                    Md5,
                    Sha1,
                    Uuid,
                }
            }
        }
    }
}
