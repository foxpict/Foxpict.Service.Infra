using System;

namespace Foxpict.Service.Infra.Model
{
    public interface IFileMappingInfo : Foxpict.Common.Model.IFileMappingInfo
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="workspace"></param>
        void SetWorkspace(IWorkspace workspace);

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        IWorkspace GetWorkspace();
    }
}
