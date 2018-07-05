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

namespace RxDatabase.Database_functions
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The InsertName recording.
    /// </summary>
    [TestModule("de7d1aca-629f-455d-ba2d-22b0da2e79bc", ModuleType.Recording, 1)]
    public partial class InsertName : ITestModule
    {
        /// <summary>
        /// Holds an instance of the RxDatabase.RxDatabaseRepository repository.
        /// </summary>
        public static RxDatabase.RxDatabaseRepository repo = RxDatabase.RxDatabaseRepository.Instance;

        static InsertName instance = new InsertName();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InsertName()
        {
            Name = "John";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InsertName Instance
        {
            get { return instance; }
        }

#region Variables

        string _Name;

        /// <summary>
        /// Gets or sets the value of variable Name.
        /// </summary>
        [TestVariable("61289c9e-050f-4717-bdfc-2fc52b948381")]
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 0;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 0.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DemoApplication.DatabaseTab.FirstName' at 61;9.", repo.DemoApplication.DatabaseTab.FirstNameInfo, new RecordItemIndex(0));
            repo.DemoApplication.DatabaseTab.FirstName.Click("61;9");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Name' with focus on 'DemoApplication.DatabaseTab.FirstName'.", repo.DemoApplication.DatabaseTab.FirstNameInfo, new RecordItemIndex(1));
            repo.DemoApplication.DatabaseTab.FirstName.PressKeys(Name);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DemoApplication.DatabaseTab.LastName' at 20;2.", repo.DemoApplication.DatabaseTab.LastNameInfo, new RecordItemIndex(2));
            repo.DemoApplication.DatabaseTab.LastName.Click("20;2");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Public' with focus on 'DemoApplication.DatabaseTab.LastName'.", repo.DemoApplication.DatabaseTab.LastNameInfo, new RecordItemIndex(3));
            repo.DemoApplication.DatabaseTab.LastName.PressKeys("Public");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
