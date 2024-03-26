﻿namespace Sitecore.Demo.Foundation.SitecoreExtensions.Repositories
{
    using Sitecore.Mvc.Presentation;

    public interface IRenderingPropertiesRepository
  {
    T Get<T>(Rendering rendering);
  }
}