﻿using System.Threading.Tasks;
using FloydPink.Flickr.Downloadr.Model.Enums;

namespace FloydPink.Flickr.Downloadr.Presentation
{
  public interface IBrowserPresenter
  {
    Task InitializePhotoset();
    Task NavigateTo(PhotoOrAlbumPage page);
    Task NavigateTo(int page);
    void CancelDownload();
    Task DownloadSelection();
    Task DownloadThisPage();
    Task DownloadAllPages();
  }
}
