

namespace System.Web.Mvc.Html
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Text;

    public static class ImageSelectExtensions
    {
        #region DropDownList

        public static MvcHtmlString DropDownList(this HtmlHelper htmlHelper, string name)
        {
            return DropDownList(htmlHelper, name, null /* imagePath */, null /* selectList */, null /* optionLabel */, null /* htmlAttributes */ );
        }

        public static MvcHtmlString DropDownList(this HtmlHelper htmlHelper, string name, string optionLabel)
        {
            return DropDownList(htmlHelper, name, null /* imagePath */, null /* selectList */, optionLabel, null /* htmlAttributes */ );
        }

        public static MvcHtmlString DropDownList(this HtmlHelper htmlHelper, string name, string imagePath, IEnumerable<ImageSelectListItem> selectList)
        {
            return DropDownList(htmlHelper, name, imagePath, selectList, null /* optionLabel */, null /* htmlAttributes */ );
        }

        public static MvcHtmlString DropDownList(this HtmlHelper htmlHelper, string name, string imagePath, IEnumerable<ImageSelectListItem> selectList, object htmlAttributes)
        {
            return DropDownList(htmlHelper, name, imagePath, selectList, null /* optionLabel */ , htmlAttributes);
        }

        public static MvcHtmlString DropDownList(this HtmlHelper htmlHelper, string name, string imagePath, IEnumerable<ImageSelectListItem> selectList, IDictionary<string, object> htmlAttributes)
        {
            return DropDownList(htmlHelper, name, imagePath, selectList, null /* optionLabel */, htmlAttributes);
        }

        public static MvcHtmlString DropDownList(this HtmlHelper htmlHelper, string name, string imagePath, IEnumerable<ImageSelectListItem> selectList, string optionLabel)
        {
            return DropDownList(htmlHelper, name, imagePath, selectList, optionLabel, null /* htmlAttributes */);
        }

        public static MvcHtmlString DropDownList(this HtmlHelper htmlHelper, string name, string imagePath, IEnumerable<ImageSelectListItem> selectList, string optionLabel, object htmlAttributes)
        {
            return DropDownList(htmlHelper, name, imagePath, selectList, optionLabel, HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        public static MvcHtmlString DropDownList(this HtmlHelper htmlHelper, string name, string imagePath, IEnumerable<ImageSelectListItem> selectList, string optionLabel, IDictionary<string, object> htmlAttributes)
        {
            return DropDownListHelper(htmlHelper, name, imagePath, selectList, optionLabel, htmlAttributes);
        }

        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "This is an appropriate nesting of generic types")]
        public static MvcHtmlString DropDownListFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, string imagePath, IEnumerable<ImageSelectListItem> selectList)
        {
            return DropDownListFor(htmlHelper, expression, imagePath, selectList, null /* optionLabel */, null /* htmlAttributes */ );
        }

        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "This is an appropriate nesting of generic types")]
        public static MvcHtmlString DropDownListFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, string imagePath, IEnumerable<ImageSelectListItem> selectList, object htmlAttributes, Expression<Func<TModel, TProperty>> childExpression, string url)
        {
            return DropDownListFor(htmlHelper, expression, imagePath, selectList, null /* optionLabel */, HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "This is an appropriate nesting of generic types")]
        public static MvcHtmlString DropDownListFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, string imagePath, IEnumerable<ImageSelectListItem> selectList, string optionLabel, Expression<Func<TModel, TProperty>> childExpression, string childOptionLabel, string url)
        {
            return DropDownListFor(htmlHelper, expression, imagePath, selectList, optionLabel, null /* htmlAttributes */);
        }

        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "This is an appropriate nesting of generic types")]
        public static MvcHtmlString DropDownListFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, string imagePath, IEnumerable<ImageSelectListItem> selectList, object htmlAttributes)
        {
            return DropDownListFor(htmlHelper, expression, imagePath, selectList, null /* optionLabel */, HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "This is an appropriate nesting of generic types")]
        public static MvcHtmlString DropDownListFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, string imagePath, IEnumerable<ImageSelectListItem> selectList, IDictionary<string, object> htmlAttributes)
        {
            return DropDownListFor(htmlHelper, expression, imagePath, selectList, null /* optionLabel */, htmlAttributes);
        }

        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "This is an appropriate nesting of generic types")]
        public static MvcHtmlString DropDownListFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, string imagePath, IEnumerable<ImageSelectListItem> selectList, string optionLabel)
        {
            return DropDownListFor(htmlHelper, expression, imagePath, selectList, optionLabel, null /* htmlAttributes */);
        }

        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "This is an appropriate nesting of generic types")]
        public static MvcHtmlString DropDownListFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, string imagePath, IEnumerable<ImageSelectListItem> selectList, string optionLabel, object htmlAttributes)
        {
            return DropDownListFor(htmlHelper, expression, imagePath, selectList, optionLabel, HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Justification = "Users cannot use anonymous methods with the LambdaExpression type")]
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "This is an appropriate nesting of generic types")]
        public static MvcHtmlString DropDownListFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, string imagePath, IEnumerable<ImageSelectListItem> selectList, string optionLabel, IDictionary<string, object> htmlAttributes)
        {
            if (expression == null)
            {
                throw new ArgumentNullException("expression");
            }

            return DropDownListHelper(htmlHelper, ExpressionHelper.GetExpressionText(expression), imagePath, selectList, optionLabel, htmlAttributes);
        }


        private static MvcHtmlString DropDownListHelper(HtmlHelper htmlHelper, string expression, string imagePath, IEnumerable<ImageSelectListItem> selectList, string optionLabel, IDictionary<string, object> htmlAttributes)
        {
            return SelectInternal(htmlHelper, optionLabel, expression, imagePath, selectList, false /* allowMultiple */, htmlAttributes);
        }
        #endregion

        #region Helper methods

        private static IEnumerable<ImageSelectListItem> GetSelectData(this HtmlHelper htmlHelper, string name)
        {
            object o = null;
            if (htmlHelper.ViewData != null)
            {
                o = htmlHelper.ViewData.Eval(name);
            }
            if (o == null)
            {
                throw new InvalidOperationException(
                    String.Format(
                        CultureInfo.CurrentCulture,
                        "There is no ViewData item of type '{1}' that has the key '{0}'.", /*MvcResources.HtmlHelper_MissingSelectData*/
                        name,
                        "IDictionary<string , IEnumerable<ImageSelectListItem>>"));
            }
            IEnumerable<ImageSelectListItem> selectList = o as IEnumerable<ImageSelectListItem>;
            if (selectList == null)
            {
                throw new InvalidOperationException(
                    String.Format(
                        CultureInfo.CurrentCulture,
                        "The ViewData item that has the key '{0}' is of type '{1}' but must be of type '{2}'." /*MvcResources.HtmlHelper_WrongSelectDataType*/ ,
                        name,
                        o.GetType().FullName,
                        "IEnumerable<ImageSelectListItem>"));
            }
            return selectList;
        }

        internal static string ListItemToOption(IEnumerable<ImageSelectListItem> items, string imagePath)
        {
            StringBuilder listItemBuilder = new StringBuilder();
            foreach (ImageSelectListItem selectItem in items)
            {
                listItemBuilder.AppendLine(ListItemToOption(selectItem, imagePath));
            }

            return listItemBuilder.ToString();
        }

        internal static string ListItemToOption(ImageSelectListItem item, string imagePath = "")
        {
            //if (!(item is ImageSelectListItem))
            //{
            //    throw new InvalidCastException(string.Format("Cannot cast {0} to System.Web.Mvc.Html.ImageImageSelectListItem.", item.GetType()));   
            //}

            //ImageSelectListItem imageImageSelectListItem = item as ImageSelectListItem;

            TagBuilder builder = new TagBuilder("option")
            {
                InnerHtml = HttpUtility.HtmlEncode(item.Text)
            };

            if (item.Value != null)
            {
                builder.Attributes["value"] = item.Value;
            }

            if (!string.IsNullOrEmpty(imagePath))
            {
                builder.Attributes["title"] = BuildFullImagePath(imagePath, item.ImageFileName);
            }

            if (item.Selected)
            {
                builder.Attributes["selected"] = "selected";
            }

            return builder.ToString(TagRenderMode.Normal);
        }

        private static string BuildFullImagePath(string path, string fileName)
        {
            if (string.IsNullOrEmpty(path))
            {
                return fileName;
            }

            path = path.EndsWith("/") ? path : string.Format("{0}/", path);

            return string.Format("{0}{1}", path, fileName);
        }

        private static MvcHtmlString SelectInternal(this HtmlHelper htmlHelper, string optionLabel, string name, string imagePath, IEnumerable<ImageSelectListItem> selectList, bool allowMultiple, IDictionary<string, object> htmlAttributes)
        {
            string fullName = htmlHelper.ViewContext.ViewData.TemplateInfo.GetFullHtmlFieldName(name);
            if (String.IsNullOrEmpty(fullName))
            {
                throw new ArgumentException("Value cannot be null or empty." /*MvcResources.Common_NullOrEmpty*/ , "name");
            }

            bool usedViewData = false;

            // If we got a null selectList, try to use ViewData to get the list of items.
            if (selectList == null)
            {
                selectList = htmlHelper.GetSelectData(fullName);
                usedViewData = true;
            }

            object defaultValue = (allowMultiple) ? GetModelStateValue(htmlHelper, fullName, typeof(string[])) : GetModelStateValue(htmlHelper, fullName, typeof(string));

            // If we haven't already used ViewData to get the entire list of items then we need to
            // use the ViewData-supplied value before using the parameter-supplied value.
            if (!usedViewData)
            {
                if (defaultValue == null)
                {
                    defaultValue = htmlHelper.ViewData.Eval(fullName);
                }
            }

            // Convert each ListItem to an <option> tag
            StringBuilder listItemBuilder = new StringBuilder();

            if (defaultValue != null)
            {
                IEnumerable defaultValues = (allowMultiple) ? defaultValue as IEnumerable : new[] { defaultValue };
                IEnumerable<string> values = from object value in defaultValues select Convert.ToString(value, CultureInfo.CurrentCulture);
                HashSet<string> selectedValues = new HashSet<string>(values, StringComparer.OrdinalIgnoreCase);

                List<ImageSelectListItem> newSelectList = new List<ImageSelectListItem>();

                foreach (ImageSelectListItem item in selectList)
                {
                    item.Selected = (item.Value != null) ?
                        selectedValues.Contains(item.Value) :
                        selectedValues.Contains(item.Text);
                    newSelectList.Add(item);
                }
            }

            // Make optionLabel the first item that gets rendered.
            if (optionLabel != null)
            {
                listItemBuilder.AppendLine(ListItemToOption(new ImageSelectListItem() { Text = optionLabel, Value = String.Empty, Selected = false }));
            }

            listItemBuilder.AppendLine(ListItemToOption(selectList, imagePath));

            TagBuilder tagBuilder = new TagBuilder("select")
            {
                InnerHtml = listItemBuilder.ToString()
            };

            tagBuilder.MergeAttributes(htmlAttributes);
            tagBuilder.MergeAttribute("name", fullName, true /* replaceExisting */);
            tagBuilder.GenerateId(fullName);

            if (allowMultiple)
            {
                tagBuilder.MergeAttribute("multiple", "multiple");
            }

            // If there are any errors for a named field, we add the css attribute.
            ModelState modelState;
            if (htmlHelper.ViewData.ModelState.TryGetValue(fullName, out modelState))
            {
                if (modelState.Errors.Count > 0)
                {
                    tagBuilder.AddCssClass(HtmlHelper.ValidationInputCssClassName);
                }
            }

            tagBuilder.MergeAttributes(htmlHelper.GetUnobtrusiveValidationAttributes(name));

            return MvcHtmlString.Create(tagBuilder.ToString(TagRenderMode.Normal));
        }

        internal static object GetModelStateValue(HtmlHelper htmlHelper, string key, Type destinationType)
        {
            ModelState modelState;
            if (htmlHelper.ViewData.ModelState.TryGetValue(key, out modelState))
            {
                if (modelState.Value != null)
                {
                    return modelState.Value.ConvertTo(destinationType, null /* culture */);
                }
            }
            return null;
        }
        #endregion
    }
}