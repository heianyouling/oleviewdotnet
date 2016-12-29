﻿namespace OleViewDotNet
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.menuFile = new System.Windows.Forms.MenuItem();
            this.menuFilePythonConsole = new System.Windows.Forms.MenuItem();
            this.menuFileOpenViewer = new System.Windows.Forms.MenuItem();
            this.menuFileOpenDatabase = new System.Windows.Forms.MenuItem();
            this.menuFileSaveDatabase = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuFileOpenMachineOnly = new System.Windows.Forms.MenuItem();
            this.menuFileOpenUserOnly = new System.Windows.Forms.MenuItem();
            this.menuFileDiff = new System.Windows.Forms.MenuItem();
            this.menuFileQueryAllInterfaces = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuFileOpenTypeLib = new System.Windows.Forms.MenuItem();
            this.menuFileOpenProxyDll = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuFileExit = new System.Windows.Forms.MenuItem();
            this.menuRegistry = new System.Windows.Forms.MenuItem();
            this.menuViewCLSIDs = new System.Windows.Forms.MenuItem();
            this.menuViewCLSIDsByName = new System.Windows.Forms.MenuItem();
            this.menuViewCLSIDsByServer = new System.Windows.Forms.MenuItem();
            this.menuViewCLSIDsByLocalServer = new System.Windows.Forms.MenuItem();
            this.menuViewCLSIDsWithSurrogate = new System.Windows.Forms.MenuItem();
            this.menuViewProgIDs = new System.Windows.Forms.MenuItem();
            this.menuRegistryMimeTypes = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuViewPreApproved = new System.Windows.Forms.MenuItem();
            this.menuViewImplementedCategories = new System.Windows.Forms.MenuItem();
            this.menuViewIELowRights = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuViewAppIDs = new System.Windows.Forms.MenuItem();
            this.menuRegistryAppIDsIL = new System.Windows.Forms.MenuItem();
            this.menuRegistryAppIDsWithAC = new System.Windows.Forms.MenuItem();
            this.menuViewLocalServices = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuViewInterfaces = new System.Windows.Forms.MenuItem();
            this.menuViewInterfacesByName = new System.Windows.Forms.MenuItem();
            this.menuRegistryTypeLibraries = new System.Windows.Forms.MenuItem();
            this.menuRegistryInterfaceProxies = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuRegistryProperties = new System.Windows.Forms.MenuItem();
            this.menuObject = new System.Windows.Forms.MenuItem();
            this.menuObjectROT = new System.Windows.Forms.MenuItem();
            this.menuObjectCreateInstanceFromCLSID = new System.Windows.Forms.MenuItem();
            this.menuObjectFromMarshalledStream = new System.Windows.Forms.MenuItem();
            this.menuObjectFromSerializedStream = new System.Windows.Forms.MenuItem();
            this.menuObjectFromFile = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuObjectParseMoniker = new System.Windows.Forms.MenuItem();
            this.menuObjectBindMoniker = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuHexEditor = new System.Windows.Forms.MenuItem();
            this.menuHexEditorFromFile = new System.Windows.Forms.MenuItem();
            this.menuHexEditorEmpty = new System.Windows.Forms.MenuItem();
            this.menuSecurity = new System.Windows.Forms.MenuItem();
            this.menuSecurityDefaultAccess = new System.Windows.Forms.MenuItem();
            this.menuSecurityDefaultAccessRestriction = new System.Windows.Forms.MenuItem();
            this.menuSecurityDefaultLaunch = new System.Windows.Forms.MenuItem();
            this.menuSecurityDefaultLaunchRestriction = new System.Windows.Forms.MenuItem();
            this.menuHelp = new System.Windows.Forms.MenuItem();
            this.menuHelpAbout = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuFile,
            this.menuRegistry,
            this.menuObject,
            this.menuSecurity,
            this.menuHelp});
            // 
            // menuFile
            // 
            this.menuFile.Index = 0;
            this.menuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuFilePythonConsole,
            this.menuFileOpenViewer,
            this.menuFileOpenDatabase,
            this.menuFileSaveDatabase,
            this.menuItem7,
            this.menuFileOpenMachineOnly,
            this.menuFileOpenUserOnly,
            this.menuFileDiff,
            this.menuFileQueryAllInterfaces,
            this.menuItem8,
            this.menuFileOpenTypeLib,
            this.menuFileOpenProxyDll,
            this.menuItem2,
            this.menuFileExit});
            this.menuFile.Text = "&File";
            // 
            // menuFilePythonConsole
            // 
            this.menuFilePythonConsole.Index = 0;
            this.menuFilePythonConsole.Text = "Python Console";
            this.menuFilePythonConsole.Click += new System.EventHandler(this.menuFilePythonConsole_Click);
            // 
            // menuFileOpenViewer
            // 
            this.menuFileOpenViewer.Index = 1;
            this.menuFileOpenViewer.Text = "Open 32 Bit Viewer";
            this.menuFileOpenViewer.Click += new System.EventHandler(this.menuFileOpenViewer_Click);
            // 
            // menuFileOpenDatabase
            // 
            this.menuFileOpenDatabase.Index = 2;
            this.menuFileOpenDatabase.Text = "Open Database File";
            this.menuFileOpenDatabase.Click += new System.EventHandler(this.menuFileOpenDatabase_Click);
            // 
            // menuFileSaveDatabase
            // 
            this.menuFileSaveDatabase.Index = 3;
            this.menuFileSaveDatabase.Text = "Save Database File";
            this.menuFileSaveDatabase.Click += new System.EventHandler(this.menuFileSaveDatabase_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 4;
            this.menuItem7.Text = "-";
            // 
            // menuFileOpenMachineOnly
            // 
            this.menuFileOpenMachineOnly.Index = 5;
            this.menuFileOpenMachineOnly.Text = "Open Machine Only";
            this.menuFileOpenMachineOnly.Click += new System.EventHandler(this.menuFileOpenMachineOnly_Click);
            // 
            // menuFileOpenUserOnly
            // 
            this.menuFileOpenUserOnly.Index = 6;
            this.menuFileOpenUserOnly.Text = "Open User Only";
            this.menuFileOpenUserOnly.Click += new System.EventHandler(this.menuFileOpenUserOnly_Click);
            // 
            // menuFileDiff
            // 
            this.menuFileDiff.Index = 7;
            this.menuFileDiff.Text = "Diff Registries";
            this.menuFileDiff.Click += new System.EventHandler(this.menuFileDiff_Click);
            // 
            // menuFileQueryAllInterfaces
            // 
            this.menuFileQueryAllInterfaces.Index = 8;
            this.menuFileQueryAllInterfaces.Text = "Query All Interfaces";
            this.menuFileQueryAllInterfaces.Click += new System.EventHandler(this.menuFileQueryAllInterfaces_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 9;
            this.menuItem8.Text = "-";
            // 
            // menuFileOpenTypeLib
            // 
            this.menuFileOpenTypeLib.Index = 10;
            this.menuFileOpenTypeLib.Text = "Open TypeLib";
            this.menuFileOpenTypeLib.Click += new System.EventHandler(this.menuFileOpenTypeLib_Click);
            // 
            // menuFileOpenProxyDll
            // 
            this.menuFileOpenProxyDll.Index = 11;
            this.menuFileOpenProxyDll.Text = "Open Proxy DLL";
            this.menuFileOpenProxyDll.Click += new System.EventHandler(this.menuFileOpenProxyDll_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 12;
            this.menuItem2.Text = "-";
            // 
            // menuFileExit
            // 
            this.menuFileExit.Index = 13;
            this.menuFileExit.Shortcut = System.Windows.Forms.Shortcut.AltF4;
            this.menuFileExit.Text = "E&xit";
            this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
            // 
            // menuRegistry
            // 
            this.menuRegistry.Index = 1;
            this.menuRegistry.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuViewCLSIDs,
            this.menuViewCLSIDsByName,
            this.menuViewCLSIDsByServer,
            this.menuViewCLSIDsByLocalServer,
            this.menuViewCLSIDsWithSurrogate,
            this.menuViewProgIDs,
            this.menuRegistryMimeTypes,
            this.menuItem4,
            this.menuViewPreApproved,
            this.menuViewImplementedCategories,
            this.menuViewIELowRights,
            this.menuItem5,
            this.menuViewAppIDs,
            this.menuRegistryAppIDsIL,
            this.menuRegistryAppIDsWithAC,
            this.menuViewLocalServices,
            this.menuItem1,
            this.menuViewInterfaces,
            this.menuViewInterfacesByName,
            this.menuRegistryTypeLibraries,
            this.menuRegistryInterfaceProxies,
            this.menuItem6,
            this.menuRegistryProperties});
            this.menuRegistry.Text = "&Registry";
            // 
            // menuViewCLSIDs
            // 
            this.menuViewCLSIDs.Index = 0;
            this.menuViewCLSIDs.Text = "CLSIDs";
            this.menuViewCLSIDs.Click += new System.EventHandler(this.menuViewCLSIDs_Click);
            // 
            // menuViewCLSIDsByName
            // 
            this.menuViewCLSIDsByName.Index = 1;
            this.menuViewCLSIDsByName.Text = "CLSIDs By Name";
            this.menuViewCLSIDsByName.Click += new System.EventHandler(this.menuViewCLSIDsByName_Click);
            // 
            // menuViewCLSIDsByServer
            // 
            this.menuViewCLSIDsByServer.Index = 2;
            this.menuViewCLSIDsByServer.Text = "CLSIDs By Server";
            this.menuViewCLSIDsByServer.Click += new System.EventHandler(this.menuViewCLSIDsByServer_Click);
            // 
            // menuViewCLSIDsByLocalServer
            // 
            this.menuViewCLSIDsByLocalServer.Index = 3;
            this.menuViewCLSIDsByLocalServer.Text = "CLSIDs By Local Server";
            this.menuViewCLSIDsByLocalServer.Click += new System.EventHandler(this.menuViewCLSIDsByLocalServer_Click);
            // 
            // menuViewCLSIDsWithSurrogate
            // 
            this.menuViewCLSIDsWithSurrogate.Index = 4;
            this.menuViewCLSIDsWithSurrogate.Text = "CLSIDs with DLL Surrogate";
            this.menuViewCLSIDsWithSurrogate.Click += new System.EventHandler(this.menuViewCLSIDsWithSurrogate_Click);
            // 
            // menuViewProgIDs
            // 
            this.menuViewProgIDs.Index = 5;
            this.menuViewProgIDs.Text = "ProgIDs";
            this.menuViewProgIDs.Click += new System.EventHandler(this.menuViewProgIDs_Click);
            // 
            // menuRegistryMimeTypes
            // 
            this.menuRegistryMimeTypes.Index = 6;
            this.menuRegistryMimeTypes.Text = "MIME Types";
            this.menuRegistryMimeTypes.Click += new System.EventHandler(this.menuRegistryMimeTypes_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 7;
            this.menuItem4.Text = "-";
            // 
            // menuViewPreApproved
            // 
            this.menuViewPreApproved.Index = 8;
            this.menuViewPreApproved.Text = "Explorer PreApproved";
            this.menuViewPreApproved.Click += new System.EventHandler(this.menuViewPreApproved_Click);
            // 
            // menuViewImplementedCategories
            // 
            this.menuViewImplementedCategories.Index = 9;
            this.menuViewImplementedCategories.Text = "Implemented Categories";
            this.menuViewImplementedCategories.Click += new System.EventHandler(this.menuViewImplementedCategories_Click);
            // 
            // menuViewIELowRights
            // 
            this.menuViewIELowRights.Index = 10;
            this.menuViewIELowRights.Text = "IE Low Rights Elevation Policy";
            this.menuViewIELowRights.Click += new System.EventHandler(this.menuViewIELowRights_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 11;
            this.menuItem5.Text = "-";
            // 
            // menuViewAppIDs
            // 
            this.menuViewAppIDs.Index = 12;
            this.menuViewAppIDs.Text = "App IDs";
            this.menuViewAppIDs.Click += new System.EventHandler(this.menuViewAppIDs_Click);
            // 
            // menuRegistryAppIDsIL
            // 
            this.menuRegistryAppIDsIL.Index = 13;
            this.menuRegistryAppIDsIL.Text = "App IDs With IL";
            this.menuRegistryAppIDsIL.Click += new System.EventHandler(this.menuRegistryAppIDsIL_Click);
            // 
            // menuRegistryAppIDsWithAC
            // 
            this.menuRegistryAppIDsWithAC.Index = 14;
            this.menuRegistryAppIDsWithAC.Text = "App IDs with AppContainer";
            this.menuRegistryAppIDsWithAC.Click += new System.EventHandler(this.menuRegistryAppIDsWithAC_Click);
            // 
            // menuViewLocalServices
            // 
            this.menuViewLocalServices.Index = 15;
            this.menuViewLocalServices.Text = "Local Services";
            this.menuViewLocalServices.Click += new System.EventHandler(this.menuViewLocalServices_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 16;
            this.menuItem1.Text = "-";
            // 
            // menuViewInterfaces
            // 
            this.menuViewInterfaces.Index = 17;
            this.menuViewInterfaces.Text = "Interfaces";
            this.menuViewInterfaces.Click += new System.EventHandler(this.menuViewInterfaces_Click);
            // 
            // menuViewInterfacesByName
            // 
            this.menuViewInterfacesByName.Index = 18;
            this.menuViewInterfacesByName.Text = "Interfaces By Name";
            this.menuViewInterfacesByName.Click += new System.EventHandler(this.menuViewInterfacesByName_Click);
            // 
            // menuRegistryTypeLibraries
            // 
            this.menuRegistryTypeLibraries.Index = 19;
            this.menuRegistryTypeLibraries.Text = "Type Libraries";
            this.menuRegistryTypeLibraries.Click += new System.EventHandler(this.menuRegistryTypeLibs_Click);
            // 
            // menuRegistryInterfaceProxies
            // 
            this.menuRegistryInterfaceProxies.Index = 20;
            this.menuRegistryInterfaceProxies.Text = "Interface Proxies";
            this.menuRegistryInterfaceProxies.Click += new System.EventHandler(this.menuRegistryInterfaceProxies_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 21;
            this.menuItem6.Text = "-";
            // 
            // menuRegistryProperties
            // 
            this.menuRegistryProperties.Index = 22;
            this.menuRegistryProperties.Text = "Properties";
            this.menuRegistryProperties.Click += new System.EventHandler(this.menuRegistryProperties_Click);
            // 
            // menuObject
            // 
            this.menuObject.Index = 2;
            this.menuObject.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuObjectROT,
            this.menuObjectCreateInstanceFromCLSID,
            this.menuObjectFromMarshalledStream,
            this.menuObjectFromSerializedStream,
            this.menuObjectFromFile,
            this.menuItem3,
            this.menuObjectParseMoniker,
            this.menuObjectBindMoniker,
            this.menuItem9,
            this.menuHexEditor});
            this.menuObject.Text = "&Object";
            // 
            // menuObjectROT
            // 
            this.menuObjectROT.Index = 0;
            this.menuObjectROT.Text = "Running Object Table";
            this.menuObjectROT.Click += new System.EventHandler(this.menuViewROT_Click);
            // 
            // menuObjectCreateInstanceFromCLSID
            // 
            this.menuObjectCreateInstanceFromCLSID.Index = 1;
            this.menuObjectCreateInstanceFromCLSID.Text = "Create Instance from CLSID";
            this.menuObjectCreateInstanceFromCLSID.Click += new System.EventHandler(this.menuViewCreateInstanceFromCLSID_Click);
            // 
            // menuObjectFromMarshalledStream
            // 
            this.menuObjectFromMarshalledStream.Index = 2;
            this.menuObjectFromMarshalledStream.Text = "From Marshalled Stream";
            this.menuObjectFromMarshalledStream.Click += new System.EventHandler(this.menuObjectFromMarshalledStream_Click);
            // 
            // menuObjectFromSerializedStream
            // 
            this.menuObjectFromSerializedStream.Index = 3;
            this.menuObjectFromSerializedStream.Text = "From Serialized Stream";
            this.menuObjectFromSerializedStream.Click += new System.EventHandler(this.menuObjectFromSerializedStream_Click);
            // 
            // menuObjectFromFile
            // 
            this.menuObjectFromFile.Index = 4;
            this.menuObjectFromFile.Text = "From File";
            this.menuObjectFromFile.Click += new System.EventHandler(this.menuObjectFromFile_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 5;
            this.menuItem3.Text = "-";
            // 
            // menuObjectParseMoniker
            // 
            this.menuObjectParseMoniker.Index = 6;
            this.menuObjectParseMoniker.Text = "Parse Moniker";
            this.menuObjectParseMoniker.Click += new System.EventHandler(this.menuObjectParseMoniker_Click);
            // 
            // menuObjectBindMoniker
            // 
            this.menuObjectBindMoniker.Index = 7;
            this.menuObjectBindMoniker.Text = "Bind Moniker";
            this.menuObjectBindMoniker.Click += new System.EventHandler(this.menuObjectBindMoniker_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 8;
            this.menuItem9.Text = "-";
            // 
            // menuHexEditor
            // 
            this.menuHexEditor.Index = 9;
            this.menuHexEditor.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuHexEditorFromFile,
            this.menuHexEditorEmpty});
            this.menuHexEditor.Text = "Hex Editor";
            // 
            // menuHexEditorFromFile
            // 
            this.menuHexEditorFromFile.Index = 0;
            this.menuHexEditorFromFile.Text = "From File";
            this.menuHexEditorFromFile.Click += new System.EventHandler(this.menuHexEditorFromFile_Click);
            // 
            // menuHexEditorEmpty
            // 
            this.menuHexEditorEmpty.Index = 1;
            this.menuHexEditorEmpty.Text = "Empty";
            this.menuHexEditorEmpty.Click += new System.EventHandler(this.menuHexEditorEmpty_Click);
            // 
            // menuSecurity
            // 
            this.menuSecurity.Index = 3;
            this.menuSecurity.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuSecurityDefaultAccess,
            this.menuSecurityDefaultAccessRestriction,
            this.menuSecurityDefaultLaunch,
            this.menuSecurityDefaultLaunchRestriction});
            this.menuSecurity.Text = "&Security";
            // 
            // menuSecurityDefaultAccess
            // 
            this.menuSecurityDefaultAccess.Index = 0;
            this.menuSecurityDefaultAccess.Text = "View Default Access";
            this.menuSecurityDefaultAccess.Click += new System.EventHandler(this.menuSecurityDefaultAccess_Click);
            // 
            // menuSecurityDefaultAccessRestriction
            // 
            this.menuSecurityDefaultAccessRestriction.Index = 1;
            this.menuSecurityDefaultAccessRestriction.Text = "View Default Access Restriction";
            this.menuSecurityDefaultAccessRestriction.Click += new System.EventHandler(this.menuSecurityDefaultAccessRestriction_Click);
            // 
            // menuSecurityDefaultLaunch
            // 
            this.menuSecurityDefaultLaunch.Index = 2;
            this.menuSecurityDefaultLaunch.Text = "View Default Launch";
            this.menuSecurityDefaultLaunch.Click += new System.EventHandler(this.menuSecurityDefaultLaunch_Click);
            // 
            // menuSecurityDefaultLaunchRestriction
            // 
            this.menuSecurityDefaultLaunchRestriction.Index = 3;
            this.menuSecurityDefaultLaunchRestriction.Text = "View Default Launch Restriction";
            this.menuSecurityDefaultLaunchRestriction.Click += new System.EventHandler(this.menuSecurityDefaultLaunchRestriction_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.Index = 4;
            this.menuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuHelpAbout});
            this.menuHelp.Text = "&Help";
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Index = 0;
            this.menuHelpAbout.Text = "&About";
            this.menuHelpAbout.Click += new System.EventHandler(this.menuHelpAbout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 448);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Menu = this.mainMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OleView .NET";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem menuFile;
        private System.Windows.Forms.MenuItem menuFileExit;
        private System.Windows.Forms.MenuItem menuRegistry;
        private System.Windows.Forms.MenuItem menuViewCLSIDs;
        private System.Windows.Forms.MenuItem menuViewCLSIDsByName;
        private System.Windows.Forms.MenuItem menuViewProgIDs;
        private System.Windows.Forms.MenuItem menuViewCLSIDsByServer;
        private System.Windows.Forms.MenuItem menuViewInterfaces;
        private System.Windows.Forms.MenuItem menuViewInterfacesByName;
        private System.Windows.Forms.MenuItem menuObjectROT;
        private System.Windows.Forms.MenuItem menuViewImplementedCategories;
        private System.Windows.Forms.MenuItem menuViewPreApproved;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuObjectCreateInstanceFromCLSID;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuObject;
        private System.Windows.Forms.MenuItem menuViewCLSIDsByLocalServer;
        private System.Windows.Forms.MenuItem menuViewIELowRights;
        private System.Windows.Forms.MenuItem menuViewLocalServices;
        private System.Windows.Forms.MenuItem menuViewAppIDs;
        private System.Windows.Forms.MenuItem menuFilePythonConsole;
        private System.Windows.Forms.MenuItem menuObjectFromMarshalledStream;
        private System.Windows.Forms.MenuItem menuObjectFromSerializedStream;
        private System.Windows.Forms.MenuItem menuHelp;
        private System.Windows.Forms.MenuItem menuHelpAbout;
        private System.Windows.Forms.MenuItem menuRegistryTypeLibraries;
        private System.Windows.Forms.MenuItem menuRegistryAppIDsIL;
        private System.Windows.Forms.MenuItem menuViewCLSIDsWithSurrogate;
        private System.Windows.Forms.MenuItem menuFileOpenViewer;
        private System.Windows.Forms.MenuItem menuObjectBindMoniker;
        private System.Windows.Forms.MenuItem menuFileOpenDatabase;
        private System.Windows.Forms.MenuItem menuFileSaveDatabase;
        private System.Windows.Forms.MenuItem menuRegistryMimeTypes;
        private System.Windows.Forms.MenuItem menuRegistryAppIDsWithAC;
        private System.Windows.Forms.MenuItem menuSecurity;
        private System.Windows.Forms.MenuItem menuSecurityDefaultAccess;
        private System.Windows.Forms.MenuItem menuSecurityDefaultAccessRestriction;
        private System.Windows.Forms.MenuItem menuSecurityDefaultLaunch;
        private System.Windows.Forms.MenuItem menuSecurityDefaultLaunchRestriction;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuRegistryProperties;
        private System.Windows.Forms.MenuItem menuFileOpenMachineOnly;
        private System.Windows.Forms.MenuItem menuFileOpenUserOnly;
        private System.Windows.Forms.MenuItem menuFileDiff;
        private System.Windows.Forms.MenuItem menuObjectFromFile;
        private System.Windows.Forms.MenuItem menuObjectParseMoniker;
        private System.Windows.Forms.MenuItem menuHexEditor;
        private System.Windows.Forms.MenuItem menuHexEditorFromFile;
        private System.Windows.Forms.MenuItem menuHexEditorEmpty;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.MenuItem menuFileOpenTypeLib;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.MenuItem menuRegistryInterfaceProxies;
        private System.Windows.Forms.MenuItem menuFileOpenProxyDll;
        private System.Windows.Forms.MenuItem menuFileQueryAllInterfaces;
    }
}

