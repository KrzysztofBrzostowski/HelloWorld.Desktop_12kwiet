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
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;

namespace HelloWorldModule
{
	public class HelloWorldModule : IModule
	{
		//private readonly IRegionViewRegistry regionViewRegistry;
		IRegionManager m_RegionManager;

		public HelloWorldModule(IRegionViewRegistry registry, IRegionManager regionManager, IUnityContainer container)
		{
			m_RegionManager = regionManager;
		}


        //inicjalizacja modulu, wstrzeliwujemy dwa widoki
		public void Initialize()
		{
			//dodanie okreslonego widoku w okreslonym miejscu
            //Modul Tworzy widok, i prosi infrastrukture o umieszczenie widoku w okreslonym regionie
            m_RegionManager.AddToRegion("MainRegion", new Views.HelloWorldView());
            m_RegionManager.AddToRegion("RightRegion", new Views.ProbkaKontrolki_SampleControl());
            

		}

    }
}
