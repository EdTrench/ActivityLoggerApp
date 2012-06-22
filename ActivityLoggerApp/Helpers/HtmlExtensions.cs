using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Text;
using System.Collections.Generic;
using System.Linq.Expressions;
using System;
using System.Web.Security;

public static class HtmlExtensions
{
    public static MvcHtmlString RadioButtonListFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> ex, IEnumerable<SelectListItem> values)
    {
        var sb = new StringBuilder();
        foreach (var item in values)
        {
            sb.Append(htmlHelper.RadioButtonFor(ex, item.Value.ToString(), item.Selected ? (object) new { @Id = item.Value.ToString(), @checked = "checked" } : new { @Id = item.Value.ToString() }));
            var span = new TagBuilder("label");
            span.Attributes.Add("for", item.Value.ToString());
            span.SetInnerText(item.Text);
            sb.Append(span.ToString());
        }
        return MvcHtmlString.Create(sb.ToString());
    }

    public static Guid GetUserId()
    {
        return (Guid)Membership.GetUser().ProviderUserKey;
    }
}