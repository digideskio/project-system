﻿using System;

using Microsoft.VisualStudio.LanguageServices.ProjectSystem;

using Xunit;

namespace Microsoft.VisualStudio.ProjectSystem.LanguageServices.Handlers
{
    [Trait("UnitTest", "ProjectSystem")]
    public class ProjectPropertiesItemHandlerTests : EvaluationHandlerTestBase
    {
        [Fact]
        public void Constructor_NullAsProject_ThrowsArgumentNull()
        {
            var context = IWorkspaceProjectContextFactory.Create();

            Assert.Throws<ArgumentNullException>("project", () =>
            {
                new ProjectPropertiesItemHandler((UnconfiguredProject)null);
            });
        }

        internal override IEvaluationHandler CreateInstance()
        {
            return CreateInstance(null, null);
        }

        private ProjectPropertiesItemHandler CreateInstance(UnconfiguredProject project = null, IWorkspaceProjectContext context = null)
        {
            project = project ?? UnconfiguredProjectFactory.Create();

            var handler = new ProjectPropertiesItemHandler(project);
            if (context != null)
                handler.Initialize(context);

            return handler;
        }
    }
}
