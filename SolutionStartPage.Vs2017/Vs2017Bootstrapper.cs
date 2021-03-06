﻿namespace SolutionStartPage.Vs2017
{
    using Models;
    using Shared;
    using Shared.Models;
    using Shared.Views.BasicPart;
    using Shared.Views.PageRootView;
    using Shared.Views.SolutionPageView;
    using Unity;
    using Unity.Lifetime;
    using Views.BasicPart;
    using Views.PageRootView;
    using Views.SolutionPageView;

    public class Vs2017Bootstrapper : IBootstrapper
    {
        public void Configure(IUnityContainer container)
        {
            container
                // Register Models
                .RegisterType<IIdeModel, IdeModel>(new ContainerControlledLifetimeManager())
                .RegisterType<IIde, VsIde>(new ContainerControlledLifetimeManager())

                // Register Views & their components
                // Root View
                .RegisterType<IPageRootView, PageRootControl>()
                // Basic Part
                .RegisterType<IVsoPageView, VsoPageControl>()
                .RegisterType<IVsoPageViewModel, VsoPageViewModel>()
                // Solution Page
                .RegisterType<ISolutionPageView, SolutionPageControl>()
                .RegisterType<ISolutionGroupControl, SolutionGroupControl>()
                .RegisterType<ISolutionControl, SolutionControl>()
                .RegisterType<ISolutionPageModel, SolutionPageModel>()
                .RegisterType<ISolutionPageViewModel, SolutionPageViewModel>()
                ;
        }
    }
}