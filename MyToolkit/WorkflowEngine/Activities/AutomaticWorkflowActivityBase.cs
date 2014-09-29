//-----------------------------------------------------------------------
// <copyright file="AutomaticWorkflowActivityBase.cs" company="MyToolkit">
//     Copyright (c) Rico Suter. All rights reserved.
// </copyright>
// <license>http://mytoolkit.codeplex.com/license</license>
// <author>Rico Suter, mail@rsuter.com</author>
//-----------------------------------------------------------------------

using System.Threading.Tasks;

namespace MyToolkit.WorkflowEngine.Activities
{
    /// <summary>An abstract class for an activity which is automatically completed: 
    /// The <see cref="WorkflowActivityBase.CompleteAsync"/> method gets directly called after <see cref="PrepareAsync"/>. </summary>
    public abstract class AutomaticWorkflowActivityBase : WorkflowActivityBase
    {
        /// <summary>Called when the previous activity has been executed. 
        /// The method may be called multiple times when there are multiple incoming transitions. </summary>
        /// <param name="instance">The workflow instance. </param>
        /// <returns>True when the activity should be automatically and immediately executed (with no args). </returns>
        public sealed override async Task<bool> PrepareAsync(WorkflowInstance instance)
        {
            return true;
        }
    }
}