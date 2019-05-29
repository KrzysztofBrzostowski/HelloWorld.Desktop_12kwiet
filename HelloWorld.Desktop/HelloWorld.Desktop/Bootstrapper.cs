//===================================================================================
// Microsoft patterns & practices
// Composite Application Guidance for Windows Presentation Foundation and Silverlight
//===================================================================================
// Copyright (c) Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===================================================================================
// The example companies, organizations, products, domain names,
// e-mail addresses, logos, people, places, and events depicted
// herein are fictitious.  No association with any real company,
// organization, product, domain name, email address, logo, person,
// places, or events is intended or should be inferred.
//===================================================================================
using System.Windows;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Prism.UnityExtensions;

namespace HelloWorld
{
	class Bootstrapper : UnityBootstrapper
	{
		protected override DependencyObject CreateShell()
		{
            return new Shell();
		}

		protected override void InitializeShell()
		{
			base.InitializeShell();


            //bootstraper dba o to aby instancja zwrocona przez create shell stala sie glownym oknem aplikacji
			App.Current.MainWindow = (Window)this.Shell;
			App.Current.MainWindow.Show();
		}

        protected override IModuleCatalog CreateModuleCatalog()
        {

           
            //wer oryg
            return base.CreateModuleCatalog();
          
            
            /*
             * //wersja z katalogu
            return new DirectoryModuleCatalog();
             */
        }

        //Laduje zewnetrzne moduly
		protected override void ConfigureModuleCatalog()
		{


			base.ConfigureModuleCatalog();

            /*
            //wer nowa, z katalogiem
            DirectoryModuleCatalog moduleCatalog = (DirectoryModuleCatalog)this.ModuleCatalog;
            moduleCatalog.ModulePath = "c:\\ddddd";
            */


            
            //  wersja domyslna
            ModuleCatalog moduleCatalog = (ModuleCatalog)this.ModuleCatalog;
			moduleCatalog.AddModule(typeof(HelloWorldModule.HelloWorldModule));
           // konic wersji domyslej
            
		}


	}
}
