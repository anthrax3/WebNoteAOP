//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Data.Objects;

namespace WebNoteAOP.Models.WebNoteCategory
{
    /// <summary>
    /// The interface for the specialised object context. This contains all of
    /// the <code>ObjectSet</code> properties that are implemented in both the
    /// functional context class and the mock context class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("ADO.NET Unit Testable Repository Generator", "0.5")]
    public interface IWebNoteCategory
    {
        IObjectSet<Category> Categories { get; }
        IObjectSet<CategoryToNode> CategoryToNodes { get; }
    
        /// <summary>
        /// Persists all updates to the store.
        /// </summary>
        /// <returns>The number of saved objects</returns>
        int SaveChanges();
    
    }
}
