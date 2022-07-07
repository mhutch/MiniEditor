using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Language.Intellisense;

namespace Microsoft.VisualStudio.Language.Intellisense.Implementation
{
    [Export(typeof(ISuggestedActionCategoryRegistryService))]
    sealed class MockSuggestedActionCategoryRegistryService : ISuggestedActionCategoryRegistryService
    {
        public IEnumerable<ISuggestedActionCategory> Categories => throw new NotImplementedException();

        public ISuggestedActionCategorySet Any => throw new NotImplementedException();

        public ISuggestedActionCategorySet AllCodeFixes => throw new NotImplementedException();

        public ISuggestedActionCategorySet AllRefactorings => throw new NotImplementedException();

        public ISuggestedActionCategorySet AllCodeFixesAndRefactorings => throw new NotImplementedException();

        public ISuggestedActionCategorySet CreateSuggestedActionCategorySet(IEnumerable<string> categories)
        {
            throw new NotImplementedException();
        }

        public ISuggestedActionCategorySet CreateSuggestedActionCategorySet(params string[] categories)
        {
            throw new NotImplementedException();
        }

        public ISuggestedActionCategory GetCategory(string categoryName)
        {
            throw new NotImplementedException();
        }
    }
}
