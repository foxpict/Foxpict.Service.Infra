namespace Foxpict.Service.Infra.Model
{
    public interface IContent : Foxpict.Common.Model.IContent
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="category"></param>
        void SetCategory(ICategory category);

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        ICategory GetCategory();

        void SetFileMappingInfo(IFileMappingInfo fileMappingInfo);

        IFileMappingInfo GetFileMappingInfo();
    }
}
