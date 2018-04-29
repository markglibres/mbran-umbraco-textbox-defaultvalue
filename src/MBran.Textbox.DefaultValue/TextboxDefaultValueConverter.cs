using System;
using Umbraco.Core;
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
            return source as string;
        }

        public object ConvertSourceToObject(PublishedPropertyType propertyType, object source, bool preview)
        {
            var dataTypeService = ApplicationContext.Current.Services.DataTypeService;
            var preValues = dataTypeService
                .GetPreValuesCollectionByDataTypeId(propertyType.DataTypeId)
                .PreValuesAsDictionary;

            var txtValue = source as string;

            return string.IsNullOrWhiteSpace(txtValue) 
                ? preValues["defaultValue"].Value
                : txtValue;
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