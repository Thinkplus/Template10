using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template10.MSBUILD
{
    internal class Constants
    {
        internal const string HELPURL = "$helpurl";

        internal const string TEMPLATE10PROJECTJSON = @"    ""Template10"": ""1.1.12""";

        internal const string NEWTONSOFT_PROJECTJSON = @"""Newtonsoft.Json"": ""7.0.1""";

        internal const string TEMPLATE10 = "Template10";

        internal const string PROJECTJSON = "project.json";

        internal const string HELPHTML = "Help.htm";

        internal const string TEMPFOLDER = "Temp";

        internal const string PROJECTNODE = "$projectNode";

        internal const string TEMPLATENAME = "$templateName";

        internal const string TEMPLATEDESCRIPTION = "$templateDescription";

        internal const string PREVIEWIMAGEFILE = "$previewImageFile";

        internal const string VSTEMPLATENAME = "MyTemplate.vstemplate";

        //TODO: move this to a separate file... or embedded resource?
        internal const string VSTEMPLATETEXT = @"<VSTemplate Version=""3.0.0"" xmlns=""http://schemas.microsoft.com/developer/vstemplate/2005"" Type=""Project"">
  <TemplateData>
    <Name Package=""{2581426E-BF4F-4A49-A42A-20EF9D51EF49}"" ID=""1100"">$templateName</Name>
    <Description Package = ""{2581426E-BF4F-4A49-A42A-20EF9D51EF49}"" ID=""1101"">$templateDescription</Description>
    <Icon Package = ""{2581426E-BF4F-4A49-A42A-20EF9D51EF49}"" ID=""4001"">__TemplateIcon.png</Icon>
    <TemplateID>Microsoft.CS.WinRT.UAP.Template10Application</TemplateID>
    <TemplateGroupID>WinRT-Managed</TemplateGroupID>
    <ProjectType>CSharp</ProjectType>
    <SortOrder>1</SortOrder>
    <CreateNewFolder>true</CreateNewFolder>
    <DefaultName>App</DefaultName>
    <ProvideDefaultName>true</ProvideDefaultName>
    <LocationField>Enabled</LocationField>
    <EnableLocationBrowseButton>true</EnableLocationBrowseButton>
    <NumberOfParentCategoriesToRollUp>2</NumberOfParentCategoriesToRollUp>
    <TargetPlatformName>Windows</TargetPlatformName>
    <RequiredPlatformVersion>6.1.0</RequiredPlatformVersion>
    <CreateInPlace>true</CreateInPlace>
    <PreviewImage>$previewImageFile</PreviewImage>
    <AppIdFilter>blend</AppIdFilter>
    <PromptForSaveOnCreation>true</PromptForSaveOnCreation>
  </TemplateData>

  <TemplateContent PreferedSolutionConfiguration=""Debug|x64"">
    $projectNode
  </TemplateContent>

  <WizardData>
    <packages forceDesignTimeBuild=""true"">
      <package id = ""Microsoft.Xaml.Behaviors.Uwp.Managed"" version=""1.1.0""/>
      <package id = ""Newtonsoft.Json"" version=""9.0.1""/>
      <package id = ""Template10"" version=""1.1.12""/>
    </packages>
  </WizardData>

  <WizardExtension>
    <Assembly>Microsoft.VisualStudio.WinRT.TemplateWizards, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a</Assembly>
    <FullClassName>Microsoft.VisualStudio.WinRT.TemplateWizards.CreateProjectCertificate.Wizard</FullClassName>
  </WizardExtension>
  <WizardExtension>
    <Assembly>NuGet.VisualStudio.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a</Assembly>
    <FullClassName>NuGet.VisualStudio.TemplateWizard</FullClassName>
  </WizardExtension>
  <WizardExtension>
    <Assembly>Microsoft.VisualStudio.Universal.TemplateWizards, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a</Assembly>
    <FullClassName>Microsoft.VisualStudio.Universal.TemplateWizards.PlatformVersion.Wizard</FullClassName>
  </WizardExtension>
  <WizardData>
    <packages repository=""registry"" keyName=""NETCoreSDK"" isPreunzipped=""true"">
      <package id = ""Microsoft.NETCore.UniversalWindowsPlatform"" version=""5.3.1"" skipAssemblyReferences=""false"" />
    </packages>
  </WizardData>

</VSTemplate>";

    }
}
