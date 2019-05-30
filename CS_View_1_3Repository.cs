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
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace CS_View_1_3
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the CS_View_1_3Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("3159e577-c985-4041-b71f-a71f4a43e824")]
    public partial class CS_View_1_3Repository : RepoGenBaseFolder
    {
        static CS_View_1_3Repository instance = new CS_View_1_3Repository();
        CS_View_1_3RepositoryFolders.VIEWForClusterStorAppFolder _viewforclusterstor;
        CS_View_1_3RepositoryFolders.VIEWForClusterStor1AppFolder _viewforclusterstor1;

        /// <summary>
        /// Gets the singleton class instance representing the CS_View_1_3Repository element repository.
        /// </summary>
        [RepositoryFolder("3159e577-c985-4041-b71f-a71f4a43e824")]
        public static CS_View_1_3Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public CS_View_1_3Repository() 
            : base("CS_View_1_3Repository", "/", null, 0, false, "3159e577-c985-4041-b71f-a71f4a43e824", ".\\RepositoryImages\\CS_View_1_3Repository3159e577.rximgres")
        {
            _viewforclusterstor = new CS_View_1_3RepositoryFolders.VIEWForClusterStorAppFolder(this);
            _viewforclusterstor1 = new CS_View_1_3RepositoryFolders.VIEWForClusterStor1AppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("3159e577-c985-4041-b71f-a71f4a43e824")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The VIEWForClusterStor folder.
        /// </summary>
        [RepositoryFolder("931d6100-e667-44f5-880b-0faa259f387d")]
        public virtual CS_View_1_3RepositoryFolders.VIEWForClusterStorAppFolder VIEWForClusterStor
        {
            get { return _viewforclusterstor; }
        }

        /// <summary>
        /// The VIEWForClusterStor1 folder.
        /// </summary>
        [RepositoryFolder("843bc3d5-28d5-4c07-adfd-3a7780d9aa2d")]
        public virtual CS_View_1_3RepositoryFolders.VIEWForClusterStor1AppFolder VIEWForClusterStor1
        {
            get { return _viewforclusterstor1; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class CS_View_1_3RepositoryFolders
    {
        /// <summary>
        /// The VIEWForClusterStorAppFolder folder.
        /// </summary>
        [RepositoryFolder("931d6100-e667-44f5-880b-0faa259f387d")]
        public partial class VIEWForClusterStorAppFolder : RepoGenBaseFolder
        {
            CS_View_1_3RepositoryFolders.LoginShowFolder _loginshow;

            /// <summary>
            /// Creates a new VIEWForClusterStor  folder.
            /// </summary>
            public VIEWForClusterStorAppFolder(RepoGenBaseFolder parentFolder) :
                    base("VIEWForClusterStor", "/dom[@caption='VIEW for ClusterStor™' and @page='auth' and @path='/auth' and @browsername='Firefox']", parentFolder, 30000, null, false, "931d6100-e667-44f5-880b-0faa259f387d", "")
            {
                _loginshow = new CS_View_1_3RepositoryFolders.LoginShowFolder(this);
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("931d6100-e667-44f5-880b-0faa259f387d")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("931d6100-e667-44f5-880b-0faa259f387d")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The LoginShow folder.
            /// </summary>
            [RepositoryFolder("496dc1b9-d077-48cd-baa6-f678b668383b")]
            public virtual CS_View_1_3RepositoryFolders.LoginShowFolder LoginShow
            {
                get { return _loginshow; }
            }
        }

        /// <summary>
        /// The LoginShowFolder folder.
        /// </summary>
        [RepositoryFolder("496dc1b9-d077-48cd-baa6-f678b668383b")]
        public partial class LoginShowFolder : RepoGenBaseFolder
        {
            RepoItemInfo _loginInfo;
            RepoItemInfo _textInfo;
            RepoItemInfo _passwordInfo;
            RepoItemInfo _logoInfo;

            /// <summary>
            /// Creates a new LoginShow  folder.
            /// </summary>
            public LoginShowFolder(RepoGenBaseFolder parentFolder) :
                    base("LoginShow", ".//div[#'root']/div/div/div/div[1]", parentFolder, 30000, null, false, "496dc1b9-d077-48cd-baa6-f678b668383b", "")
            {
                _loginInfo = new RepoItemInfo(this, "Login", "?/?/div[@innertext='Login']", 30000, null, "a179c5e0-1edb-4b44-a328-425980605252");
                _textInfo = new RepoItemInfo(this, "Text", "div/div[2]/div[1]/?/?/input[@type='text']", 30000, null, "136b7d07-f786-4b59-81d1-495eabf0a592");
                _passwordInfo = new RepoItemInfo(this, "Password", "div/div[2]/div[2]/?/?/input[@type='password']", 30000, null, "ccebbc85-0438-4526-b34f-609f23ce0387");
                _logoInfo = new RepoItemInfo(this, "Logo", "div/div[1]", 30000, null, "0f49b894-8894-42a1-9c5f-60834f9217a3");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("496dc1b9-d077-48cd-baa6-f678b668383b")]
            public virtual Ranorex.DivTag Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("496dc1b9-d077-48cd-baa6-f678b668383b")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Login item.
            /// </summary>
            [RepositoryItem("a179c5e0-1edb-4b44-a328-425980605252")]
            public virtual Ranorex.DivTag Login
            {
                get
                {
                    return _loginInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The Login item info.
            /// </summary>
            [RepositoryItemInfo("a179c5e0-1edb-4b44-a328-425980605252")]
            public virtual RepoItemInfo LoginInfo
            {
                get
                {
                    return _loginInfo;
                }
            }

            /// <summary>
            /// The Text item.
            /// </summary>
            [RepositoryItem("136b7d07-f786-4b59-81d1-495eabf0a592")]
            public virtual Ranorex.InputTag Text
            {
                get
                {
                    return _textInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Text item info.
            /// </summary>
            [RepositoryItemInfo("136b7d07-f786-4b59-81d1-495eabf0a592")]
            public virtual RepoItemInfo TextInfo
            {
                get
                {
                    return _textInfo;
                }
            }

            /// <summary>
            /// The Password item.
            /// </summary>
            [RepositoryItem("ccebbc85-0438-4526-b34f-609f23ce0387")]
            public virtual Ranorex.InputTag Password
            {
                get
                {
                    return _passwordInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Password item info.
            /// </summary>
            [RepositoryItemInfo("ccebbc85-0438-4526-b34f-609f23ce0387")]
            public virtual RepoItemInfo PasswordInfo
            {
                get
                {
                    return _passwordInfo;
                }
            }

            /// <summary>
            /// The Logo item.
            /// </summary>
            [RepositoryItem("0f49b894-8894-42a1-9c5f-60834f9217a3")]
            public virtual Ranorex.DivTag Logo
            {
                get
                {
                    return _logoInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The Logo item info.
            /// </summary>
            [RepositoryItemInfo("0f49b894-8894-42a1-9c5f-60834f9217a3")]
            public virtual RepoItemInfo LogoInfo
            {
                get
                {
                    return _logoInfo;
                }
            }
        }

        /// <summary>
        /// The VIEWForClusterStor1AppFolder folder.
        /// </summary>
        [RepositoryFolder("843bc3d5-28d5-4c07-adfd-3a7780d9aa2d")]
        public partial class VIEWForClusterStor1AppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _logoInfo;
            RepoItemInfo _automationInfo;
            RepoItemInfo _logoutInfo;

            /// <summary>
            /// Creates a new VIEWForClusterStor1  folder.
            /// </summary>
            public VIEWForClusterStor1AppFolder(RepoGenBaseFolder parentFolder) :
                    base("VIEWForClusterStor1", "/dom[@caption='VIEW for ClusterStor™' and @page='overview']", parentFolder, 30000, null, false, "843bc3d5-28d5-4c07-adfd-3a7780d9aa2d", "")
            {
                _logoInfo = new RepoItemInfo(this, "Logo", ".//div[#'root']/div/div[1]/div[1]/div", 30000, null, "9d9cb535-bbe9-4999-860e-843489d7cb24");
                _automationInfo = new RepoItemInfo(this, "Automation", ".//div[#'root']/div/div[1]/div[2]/div[2]/div[1]/div[@innertext='automation']", 30000, null, "eae5002f-0ff0-414c-918e-dada5be9895f");
                _logoutInfo = new RepoItemInfo(this, "Logout", ".//div[#'root']/div/div[1]/div[2]/div[2]/div[3]/div[@innertext='Logout']", 30000, null, "386b7682-2ab8-49f6-836d-aff9553927e3");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("843bc3d5-28d5-4c07-adfd-3a7780d9aa2d")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("843bc3d5-28d5-4c07-adfd-3a7780d9aa2d")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Logo item.
            /// </summary>
            [RepositoryItem("9d9cb535-bbe9-4999-860e-843489d7cb24")]
            public virtual Ranorex.DivTag Logo
            {
                get
                {
                    return _logoInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The Logo item info.
            /// </summary>
            [RepositoryItemInfo("9d9cb535-bbe9-4999-860e-843489d7cb24")]
            public virtual RepoItemInfo LogoInfo
            {
                get
                {
                    return _logoInfo;
                }
            }

            /// <summary>
            /// The Automation item.
            /// </summary>
            [RepositoryItem("eae5002f-0ff0-414c-918e-dada5be9895f")]
            public virtual Ranorex.DivTag Automation
            {
                get
                {
                    return _automationInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The Automation item info.
            /// </summary>
            [RepositoryItemInfo("eae5002f-0ff0-414c-918e-dada5be9895f")]
            public virtual RepoItemInfo AutomationInfo
            {
                get
                {
                    return _automationInfo;
                }
            }

            /// <summary>
            /// The Logout item.
            /// </summary>
            [RepositoryItem("386b7682-2ab8-49f6-836d-aff9553927e3")]
            public virtual Ranorex.DivTag Logout
            {
                get
                {
                    return _logoutInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The Logout item info.
            /// </summary>
            [RepositoryItemInfo("386b7682-2ab8-49f6-836d-aff9553927e3")]
            public virtual RepoItemInfo LogoutInfo
            {
                get
                {
                    return _logoutInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
