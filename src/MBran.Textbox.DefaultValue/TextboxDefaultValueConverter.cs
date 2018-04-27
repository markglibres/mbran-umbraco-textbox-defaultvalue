using System;
using Newtonsoft.Json;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Core.PropertyEditors;

namespace MBran.Textbox.DefaultValue
{
    [PropertyValueType(typeof(string))]
    [PropertyValueCache(PropertyCacheValue.All, PropertyCacheLevel.Content)]
    public class TextboxDefaultValueConverter : IPropertyValueConverter
    {
        public object ConvertDataToSource(PublishedPropertyType propertyType, object source, bool preview)
        {
            return JsonConvert.DeserializeObject<TextboxDefaultValue>(source as string);
        }

        public object ConvertSourceToObject(PublishedPropertyType propertyType, object source, bool preview)
        {
            var data = source as TextboxDefaultValue;
            return string.IsNullOrWhiteSpace(data?.Value) ? data?.Default : data.Value;
        }

        public object ConvertSourceToXPath(PublishedPropertyType propertyType, object source, bool preview)
        {
            throw new NotImplementedException();
        }

        public bool IsConverter(PublishedPropertyType propertyType)
        {
            return propertyType.PropertyEditorAlias.Equals("MBran.Textbox.DefaultValue",
                StringComparison.InvariantCultureIgnoreCase);
        }
    }
}