using System;
using System.IO;
using Nancy.Testing;
using Nancy.Testing.Fakes;
using NancyKickStart.Web.Configuration;

namespace NancyKickStart.Acceptance.Tests
{
    public class TestBootstrapper : Bootstrapper
    {
        protected override Type RootPathProvider
        {
            get
            {
                const string webAppDirectoryName = @"NancyKickStart.Web";

                FakeRootPathProvider.RootPath = CalculateRootPath(webAppDirectoryName);
                return typeof(FakeRootPathProvider);
            }
        }

        private static string CalculateRootPath(string webAppDirectoryName)
        {
            var assemblyPath = Path.GetDirectoryName(typeof (Bootstrapper).Assembly.CodeBase).Replace(@"file:\", string.Empty);
            var rootPath = PathHelper.GetParent(assemblyPath, 3);
            rootPath = Path.Combine(rootPath, webAppDirectoryName);
            return rootPath;
        }
    }
}
