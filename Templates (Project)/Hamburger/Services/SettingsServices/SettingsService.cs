using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Template10.Common;
using Template10.Services.SettingsService;
using Template10.Utils;
using Windows.UI.Xaml;

namespace Sample.Services.SettingsServices
{
    public class SettingsService
    {
        public static SettingsService Instance { get; } = new SettingsService();

        public enum BackButtonLocations { AppChrome, AppTitle }

        public BackButtonLocations BackButtonLocation
        {
            get
            {
                var setting = Read(BackButtonLocations.AppChrome.ToString());
                return setting.ToEnum<BackButtonLocations>();
            }
            set
            {
                Write(value.ToString());
                DispatcherWrapper.Current().Dispatch(() =>
                {
                    var setting = value == BackButtonLocations.AppChrome ? true : false;
                    BootStrapper.Current.ShowShellBackButton = setting;
                    BootStrapper.Current.UpdateShellBackButton();
                });
            }
        }

        public ApplicationTheme AppTheme
        {
            get
            {
                var setting = Read(ApplicationTheme.Dark.ToString());
                return setting.ToEnum<ApplicationTheme>();
            }
            set
            {
                Write(value.ToString());
                DispatcherWrapper.Current().Dispatch(() =>
                {
                    var setting = value.ToElementTheme();
                    (Window.Current.Content as FrameworkElement).RequestedTheme = setting;
                    Views.Shell.HamburgerMenu.RefreshStyles(value, true);
                });
            }
        }

        public TimeSpan CacheMaxDuration
        {
            get
            {
                var setting = Read(TimeSpan.FromDays(2).ToString());
                return setting.ToTimeSpan();
            }
            set
            {
                Write(value.ToString());
                DispatcherWrapper.Current().Dispatch(() =>
                {
                    BootStrapper.Current.CacheMaxDuration = value;
                });
            }
        }

        public enum HamburgerButtonVisibilities { Visible, Collapsed }

        public HamburgerButtonVisibilities HamburgerButtonVisibility
        {
            get
            {
                var setting = Read(HamburgerButtonVisibilities.Visible.ToString());
                return setting.ToEnum<HamburgerButtonVisibilities>();
            }
            set
            {
                Write(value.ToString());
                DispatcherWrapper.Current().Dispatch(() =>
                {
                    var visible = value == HamburgerButtonVisibilities.Visible;
                    var setting = visible ? Visibility.Visible : Visibility.Collapsed;
                    Views.Shell.HamburgerMenu.HamburgerButtonVisibility = setting;
                });
            }
        }

        public enum FullScreenModes { FullScreen, PartialScreen }

        public FullScreenModes FullScreenMode
        {
            get
            {
                var setting = Read(FullScreenModes.PartialScreen.ToString());
                return setting.ToEnum<FullScreenModes>();
            }
            set
            {
                Write(value.ToString());
                DispatcherWrapper.Current().Dispatch(() =>
                {
                    var setting = value == FullScreenModes.FullScreen ? true : false;
                    Views.Shell.HamburgerMenu.IsFullScreen = setting;
                });
            }
        }

        #region private logic

        private ISettingsHelper _helper;

        private SettingsService()
        {
            _helper = new SettingsHelper();
        }

        private string Read(string otherwise, [CallerMemberName]string key = null)
        {
            return _helper.Read(key, otherwise ?? string.Empty);
        }

        private void Write(string value, [CallerMemberName]string key = null)
        {
            _helper.Write(key, value);
        }

        #endregion
    }
}
