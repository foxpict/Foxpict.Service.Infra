using System.Collections.Generic;

namespace Foxpict.Service.Infra.Model {
  public interface ILabel : Foxpict.Common.Model.ILabel {

    void SetParentLabel(ILabel label);

    ILabel GetParentLabel ();

    List<ICategory> GetCategoryList ();

    List<IContent> GetContentList ();
  }
}
