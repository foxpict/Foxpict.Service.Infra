using System.IO;
using Foxpict.Service.Infra.Model;

namespace Foxpict.Service.Infra {
  /// <summary>
  /// 仮想ファイルを操作するサービス
  /// </summary>
  public interface IVirtualFileSystemService {
    /// <summary>
    /// ファイルをシステムに登録し、ACLファイルを作成します。
    /// /// </summary>
    /// <param name="file">対象ファイル（仮想領域内のファイルを指定します）</param>
    /// <param name="workspace"></param>
    /// <param name="temporaryFile">テンポラリファイル</param>
    /// <returns></returns>
    IFileMappingInfo RegisterFile (FileInfo file, IWorkspace workspace);

  }
}
