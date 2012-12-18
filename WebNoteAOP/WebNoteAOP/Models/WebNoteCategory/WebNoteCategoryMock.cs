//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Data.Objects;

namespace WebNoteAOP.Models.WebNoteCategory.WebNoteCategoryUnitTest
{
    /// <summary>
    /// The concrete mock context object that implements the context's interface.
    /// Provide an instance of this mock context class to client logic when testing, 
    /// instead of providing a functional context object.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("ADO.NET Unit Testable Repository Generator", "0.5")]
    public partial class WebNoteCategoryMock : IWebNoteCategory
    {
        public IObjectSet<Category> Categories
        {
            get { return _categories  ?? (_categories = new MockObjectSet<Category>()); }
            set { _categories  = value; }
        }
        private IObjectSet<Category> _categories;
        
        
        public IObjectSet<CategoryToNode> CategoryToNodes
        {
            get { return _categoryToNodes  ?? (_categoryToNodes = new MockObjectSet<CategoryToNode>()); }
            set { _categoryToNodes  = value; }
        }
        private IObjectSet<CategoryToNode> _categoryToNodes;
        
        
        
         /// <summary>
        /// Will be true if SaveChanges was called
        /// </summary>	
        public bool SavesChanged { get; set; }
    
        /// <summary>
        /// Would persist all updates to the store.
        /// </summary>
        /// <returns>would return the number of saved objects, here: always '1'</returns>
        public int SaveChanges()
        {
            this.SavesChanged = true;
            return 1; // of course, this is not always the correct number, don't test for that!
        }
    }
}