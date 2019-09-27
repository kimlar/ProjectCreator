﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCreator.Projects.Library
{
    public partial class LibraryProject
    {
        // Generate the test project file (.vcxproj)
        public void CreateTestProjectFile()
        {
            Print("Creating the test project file: ");

            // Create the project file (*.vcxproj)
            using (StreamWriter sw = new StreamWriter(RootDir + @"\Source\Tester\" + TestName + @"\Source\Project\" + TestName + ".vcxproj"))
            {
                sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                sw.WriteLine("<Project DefaultTargets=\"Build\" ToolsVersion=\"14.0\" xmlns=\"http://schemas.microsoft.com/developer/msbuild/2003\">");
                sw.WriteLine("  <ItemGroup Label=\"ProjectConfigurations\">");
                sw.WriteLine("    <ProjectConfiguration Include=\"Debug|x64\">");
                sw.WriteLine("      <Configuration>Debug</Configuration>");
                sw.WriteLine("      <Platform>x64</Platform>");
                sw.WriteLine("    </ProjectConfiguration>");
                sw.WriteLine("    <ProjectConfiguration Include=\"Release|x64\">");
                sw.WriteLine("      <Configuration>Release</Configuration>");
                sw.WriteLine("      <Platform>x64</Platform>");
                sw.WriteLine("    </ProjectConfiguration>");
                sw.WriteLine("  </ItemGroup>");
                sw.WriteLine("  <PropertyGroup Label=\"Globals\">");
                sw.WriteLine("    <ProjectGuid>{" + Project_GUID + "}</ProjectGuid>");
                sw.WriteLine("    <RootNamespace>" + ProjectName + "</RootNamespace>");
                sw.WriteLine("    <WindowsTargetPlatformVersion>8.1</WindowsTargetPlatformVersion>");
                sw.WriteLine("  </PropertyGroup>");
                sw.WriteLine("  <Import Project=\"$(VCTargetsPath)\\Microsoft.Cpp.Default.props\" />");
                sw.WriteLine("  <PropertyGroup Condition=\"'$(Configuration)|$(Platform)'=='Debug|x64'\" Label=\"Configuration\">");
                sw.WriteLine("    <ConfigurationType>Application</ConfigurationType>");
                sw.WriteLine("    <UseDebugLibraries>true</UseDebugLibraries>");
                sw.WriteLine("    <PlatformToolset>v140</PlatformToolset>");
                sw.WriteLine("    <CharacterSet>Unicode</CharacterSet>");
                sw.WriteLine("  </PropertyGroup>");
                sw.WriteLine("  <PropertyGroup Condition=\"'$(Configuration)|$(Platform)'=='Release|x64'\" Label=\"Configuration\">");
                sw.WriteLine("    <ConfigurationType>Application</ConfigurationType>");
                sw.WriteLine("    <UseDebugLibraries>false</UseDebugLibraries>");
                sw.WriteLine("    <PlatformToolset>v140</PlatformToolset>");
                sw.WriteLine("    <WholeProgramOptimization>true</WholeProgramOptimization>");
                sw.WriteLine("    <CharacterSet>Unicode</CharacterSet>");
                sw.WriteLine("  </PropertyGroup>");
                sw.WriteLine("  <Import Project=\"$(VCTargetsPath)\\Microsoft.Cpp.props\" />");
                sw.WriteLine("  <ImportGroup Label=\"ExtensionSettings\">");
                sw.WriteLine("  </ImportGroup>");
                sw.WriteLine("  <ImportGroup Label=\"Shared\">");
                sw.WriteLine("  </ImportGroup>");
                sw.WriteLine("  <ImportGroup Label=\"PropertySheets\" Condition=\"'$(Configuration)|$(Platform)'=='Debug|x64'\">");
                sw.WriteLine("    <Import Project=\"$(UserRootDir)\\Microsoft.Cpp.$(Platform).user.props\" Condition=\"exists('$(UserRootDir)\\Microsoft.Cpp.$(Platform).user.props')\" Label=\"LocalAppDataPlatform\" />");
                sw.WriteLine("  </ImportGroup>");
                sw.WriteLine("  <ImportGroup Label=\"PropertySheets\" Condition=\"'$(Configuration)|$(Platform)'=='Release|x64'\">");
                sw.WriteLine("    <Import Project=\"$(UserRootDir)\\Microsoft.Cpp.$(Platform).user.props\" Condition=\"exists('$(UserRootDir)\\Microsoft.Cpp.$(Platform).user.props')\" Label=\"LocalAppDataPlatform\" />");
                sw.WriteLine("  </ImportGroup>");
                sw.WriteLine("  <PropertyGroup Label=\"UserMacros\" />");
                sw.WriteLine("  <PropertyGroup Condition=\"'$(Configuration)|$(Platform)'=='Debug|x64'\">");
                sw.WriteLine("    <SourcePath>$(ProjectDir)..;$(VC_SourcePath);</SourcePath>");
                sw.WriteLine("    <OutDir>$(ProjectDir)..\\..\\App\\</OutDir>");
                sw.WriteLine("    <IntDir>$(ProjectDir)..\\..\\..\\..\\..\\Temp\\Tester\\</IntDir>");
                sw.WriteLine("    <TargetName>$(ProjectName)_d</TargetName>");
                sw.WriteLine("  </PropertyGroup>");
                sw.WriteLine("  <PropertyGroup Condition=\"'$(Configuration)|$(Platform)'=='Release|x64'\">");
                sw.WriteLine("    <SourcePath>$(ProjectDir)..;$(VC_SourcePath);</SourcePath>");
                sw.WriteLine("    <OutDir>$(ProjectDir)..\\..\\App\\</OutDir>");
                sw.WriteLine("    <IntDir>$(ProjectDir)..\\..\\..\\..\\..\\Temp\\Tester\\</IntDir>");
                sw.WriteLine("  </PropertyGroup>");
                sw.WriteLine("  <ItemDefinitionGroup Condition=\"'$(Configuration)|$(Platform)'=='Debug|x64'\">");
                sw.WriteLine("    <ClCompile>");
                sw.WriteLine("      <WarningLevel>Level3</WarningLevel>");
                sw.WriteLine("      <Optimization>Disabled</Optimization>");
                sw.WriteLine("      <SDLCheck>true</SDLCheck>");
                sw.WriteLine("      <PrecompiledHeader>Use</PrecompiledHeader>");
                sw.WriteLine("      <PrecompiledHeaderFile>pch.h</PrecompiledHeaderFile>");
                sw.WriteLine("      <ForcedIncludeFiles>pch.h</ForcedIncludeFiles>");
                sw.WriteLine("      <PrecompiledHeaderOutputFile>$(IntDir)$(TargetName).pch</PrecompiledHeaderOutputFile>");
                sw.WriteLine("      <AdditionalIncludeDirectories>$(SolutionDir)..;%(AdditionalIncludeDirectories)</AdditionalIncludeDirectories>");
                sw.WriteLine("    </ClCompile>");
                sw.WriteLine("    <Link>");
                sw.WriteLine("      <ProgramDatabaseFile>$(IntDir)$(TargetName).pdb</ProgramDatabaseFile>");
                sw.WriteLine("      <ProfileGuidedDatabase>$(IntDir)$(TargetName).pgd</ProfileGuidedDatabase>");
                sw.WriteLine("      <AdditionalDependencies>" + ProjectName + "_d.lib;kernel32.lib;user32.lib;gdi32.lib;winspool.lib;comdlg32.lib;advapi32.lib;shell32.lib;ole32.lib;oleaut32.lib;uuid.lib;odbc32.lib;odbccp32.lib;%(AdditionalDependencies)</AdditionalDependencies>");
                sw.WriteLine("      <AdditionalLibraryDirectories>$(SolutionDir)..\\..\\Lib;%(AdditionalLibraryDirectories)</AdditionalLibraryDirectories>");
                sw.WriteLine("    </Link>");
                sw.WriteLine("    <Xdcmake>");
                sw.WriteLine("      <OutputFile>$(IntDir)$(TargetName).xml</OutputFile>");
                sw.WriteLine("    </Xdcmake>");
                sw.WriteLine("    <Bscmake>");
                sw.WriteLine("      <OutputFile>$(IntDir)$(TargetName).bsc</OutputFile>");
                sw.WriteLine("    </Bscmake>");
                sw.WriteLine("  </ItemDefinitionGroup>");
                sw.WriteLine("  <ItemDefinitionGroup Condition=\"'$(Configuration)|$(Platform)'=='Release|x64'\">");
                sw.WriteLine("    <ClCompile>");
                sw.WriteLine("      <WarningLevel>Level3</WarningLevel>");
                sw.WriteLine("      <Optimization>MaxSpeed</Optimization>");
                sw.WriteLine("      <FunctionLevelLinking>true</FunctionLevelLinking>");
                sw.WriteLine("      <IntrinsicFunctions>true</IntrinsicFunctions>");
                sw.WriteLine("      <SDLCheck>true</SDLCheck>");
                sw.WriteLine("      <PrecompiledHeader>Use</PrecompiledHeader>");
                sw.WriteLine("      <PrecompiledHeaderFile>pch.h</PrecompiledHeaderFile>");
                sw.WriteLine("      <ForcedIncludeFiles>pch.h</ForcedIncludeFiles>");
                sw.WriteLine("      <PrecompiledHeaderOutputFile>$(IntDir)$(TargetName).pch</PrecompiledHeaderOutputFile>");
                sw.WriteLine("      <AdditionalIncludeDirectories>$(SolutionDir)..;%(AdditionalIncludeDirectories)</AdditionalIncludeDirectories>");
                sw.WriteLine("    </ClCompile>");
                sw.WriteLine("    <Link>");
                sw.WriteLine("      <EnableCOMDATFolding>true</EnableCOMDATFolding>");
                sw.WriteLine("      <OptimizeReferences>true</OptimizeReferences>");
                sw.WriteLine("      <ProgramDatabaseFile>$(IntDir)$(TargetName).pdb</ProgramDatabaseFile>");
                sw.WriteLine("      <ProfileGuidedDatabase>$(IntDir)$(TargetName).pgd</ProfileGuidedDatabase>");
                sw.WriteLine("      <AdditionalDependencies>" + ProjectName + ".lib;kernel32.lib;user32.lib;gdi32.lib;winspool.lib;comdlg32.lib;advapi32.lib;shell32.lib;ole32.lib;oleaut32.lib;uuid.lib;odbc32.lib;odbccp32.lib;%(AdditionalDependencies)</AdditionalDependencies>");
                sw.WriteLine("      <AdditionalLibraryDirectories>$(SolutionDir)..\\..\\Lib;%(AdditionalLibraryDirectories)</AdditionalLibraryDirectories>");
                sw.WriteLine("    </Link>");
                sw.WriteLine("    <Xdcmake>");
                sw.WriteLine("      <OutputFile>$(IntDir)$(TargetName).xml</OutputFile>");
                sw.WriteLine("    </Xdcmake>");
                sw.WriteLine("    <Bscmake>");
                sw.WriteLine("      <OutputFile>$(IntDir)$(TargetName).bsc</OutputFile>");
                sw.WriteLine("    </Bscmake>");
                sw.WriteLine("  </ItemDefinitionGroup>");
                sw.WriteLine("  <ItemGroup>");
                sw.WriteLine("    <ClCompile Include=\"..\\Main.cpp\" />");
                sw.WriteLine("    <ClCompile Include=\"..\\pch.cpp\">");
                sw.WriteLine("      <PrecompiledHeader Condition=\"'$(Configuration)|$(Platform)'=='Debug|x64'\">Create</PrecompiledHeader>");
                sw.WriteLine("      <PrecompiledHeader Condition=\"'$(Configuration)|$(Platform)'=='Release|x64'\">Create</PrecompiledHeader>");
                sw.WriteLine("    </ClCompile>");
                sw.WriteLine("  </ItemGroup>");
                sw.WriteLine("  <ItemGroup>");
                sw.WriteLine("    <ClInclude Include=\"..\\pch.h\" />");
                sw.WriteLine("  </ItemGroup>");
                sw.WriteLine("  <Import Project=\"$(VCTargetsPath)\\Microsoft.Cpp.targets\" />");
                sw.WriteLine("  <ImportGroup Label=\"ExtensionTargets\">");
                sw.WriteLine("  </ImportGroup>");
                sw.WriteLine("</Project>");
            }

            Print("Done" + Environment.NewLine);
        }
    }
}
