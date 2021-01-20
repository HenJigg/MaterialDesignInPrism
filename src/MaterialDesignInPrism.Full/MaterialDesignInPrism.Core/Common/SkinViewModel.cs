using MaterialDesignColors;
using MaterialDesignInPrism.Core.Extensions;
using MaterialDesignThemes.Wpf;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;

namespace MaterialDesignInPrism.Core.Common
{
    /// <summary>
    /// 系统样式设置
    /// </summary>
    public class SkinViewModel : BindableBase
    {
        private readonly static PaletteHelper _paletteHelper = new PaletteHelper();

        public string SelectPageTitle { get; } = "个性化设置";

        //可选颜色集合-分组
        public IEnumerable<ISwatch> Swatches { get; } = SwatchHelper.Swatches;

        //改变颜色
        public DelegateCommand<object> ChangeHueCommand { get; } = new DelegateCommand<object>((t) => ChangeHue(t));

        //改变主题
        public DelegateCommand<object> ToggleBaseCommand { get; } = new DelegateCommand<object>(o => ApplyBase((bool)o));

        private static void ApplyBase(bool isDark)
        {
            ModifyTheme(theme => theme.SetBaseTheme(isDark ? Theme.Dark : Theme.Light));
        }

        private static void ModifyTheme(Action<ITheme> modificationAction)
        {
            PaletteHelper paletteHelper = new PaletteHelper();
            ITheme theme = paletteHelper.GetTheme();
            modificationAction?.Invoke(theme);
            paletteHelper.SetTheme(theme);
        }

        private static void ChangeHue(object obj)
        {
            var hue = (Color)obj;
            _paletteHelper.ChangePrimaryColor(hue);
        }
    }
}
