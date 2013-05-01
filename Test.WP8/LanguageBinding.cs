using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Cirrious.CrossCore;
using Cirrious.CrossCore.Converters;
using Cirrious.MvvmCross.Binding.Binders;
using Cirrious.MvvmCross.Localization;

namespace Test.WP8
{
    public class LanguageBinding : Binding
    {
        private const string DefaultPath = "TextSource";

        public LanguageBinding(string propertyName)
        {
            Path = new PropertyPath(DefaultPath);
            Converter = new MvxNativeValueConverter<MvxLanguageConverter>((MvxLanguageConverter) Mvx.Resolve<IMvxValueConverterLookup>().Find("Language"));
            ConverterParameter = propertyName;
        }
    }

    public class MvxNativeValueConverter<T>
        : IValueConverter
        where T : IMvxValueConverter, new()
    {


        public MvxNativeValueConverter(T converter)
        {
            _wrapped = converter;
        }

        private readonly T _wrapped = new T();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return _wrapped.Convert(value, targetType, parameter, culture);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return _wrapped.ConvertBack(value, targetType, parameter, culture);
        }
    }
}
