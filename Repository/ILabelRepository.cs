using System.Collections.Generic;
using System.Linq;
using Foxpict.Service.Infra.Model;

namespace Foxpict.Service.Infra.Repository
{
    public interface ILabelRepository : IRepositoryBase
    {
        ILabel New();

        ILabel Load(long id);

        ILabel LoadByName(string name);

        /// <summary>
        /// ラベル名に一致するラベル情報を取得する
        /// </summary>
        /// <param name="name">ラベル名</param>
        /// <param name="ownerType">一致するオーナータイプの検索文字列</param>
        /// <returns></returns>
        ILabel LoadByName(string name, string ownerType);

        /// <summary>
        ///
        /// </summary>
        /// <param name="parentLabelId"></param>
        /// <returns></returns>
        IQueryable<ILabel> FindChildren(long parentLabelId);

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        IQueryable<ILabel> FindRoot();

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        IEnumerable<ILabel> GetAll();
    }
}
