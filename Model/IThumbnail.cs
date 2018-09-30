namespace Foxpict.Service.Infra.Model
{
    public interface IThumbnail : Foxpict.Common.Model.IThumbnail
    {
        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        byte[] BitmapBytes { get; set; }
    }
}
