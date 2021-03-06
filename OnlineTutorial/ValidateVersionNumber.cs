﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace OnlineTutorial
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ValidateVersionNumber recording.
    /// </summary>
    [TestModule("a495a69e-5013-4414-8502-601694dce42a", ModuleType.Recording, 1)]
    public partial class ValidateVersionNumber : ITestModule
    {
        /// <summary>
        /// Holds an instance of the OnlineTutorialRepository repository.
        /// </summary>
        public static OnlineTutorialRepository repo = OnlineTutorialRepository.Instance;

        static ValidateVersionNumber instance = new ValidateVersionNumber();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateVersionNumber()
        {
            verCurrentKeePassVersion = "2.20.1";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateVersionNumber Instance
        {
            get { return instance; }
        }

#region Variables

        string _verCurrentKeePassVersion;

        /// <summary>
        /// Gets or sets the value of variable verCurrentKeePassVersion.
        /// </summary>
        [TestVariable("1ab0ab52-a39b-4fb3-adb8-701554a84cd5")]
        public string verCurrentKeePassVersion
        {
            get { return _verCurrentKeePassVersion; }
            set { _verCurrentKeePassVersion = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainForm.MMenuMain' at 193;9.", repo.MainForm.MMenuMainInfo, new RecordItemIndex(0));
            repo.MainForm.MMenuMain.Click("193;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'KeePass.AboutKeePass' at 73;8.", repo.KeePass.AboutKeePassInfo, new RecordItemIndex(1));
            repo.KeePass.AboutKeePass.Click("73;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$verCurrentKeePassVersion) on item 'AboutForm.KeePassVersion'.", repo.AboutForm.KeePassVersionInfo, new RecordItemIndex(2));
            Validate.Attribute(repo.AboutForm.KeePassVersionInfo, "Text", verCurrentKeePassVersion);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'AboutForm.MBtnOK' at 36;11.", repo.AboutForm.MBtnOKInfo, new RecordItemIndex(3));
            repo.AboutForm.MBtnOK.Click("36;11");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
