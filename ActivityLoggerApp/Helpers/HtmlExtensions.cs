using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Text;
using System.Collections.Generic;
using System.Linq.Expressions;
using System;

public static class HtmlExtensions
{
    public static MvcHtmlString RadioButtonListFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> ex, IEnumerable<SelectListItem> values)
    {
        var sb = new StringBuilder();
        foreach (var item in values)
        {
            
            //sb.Append(htmlHelper.RadioButtonFor(ex, "BikeType" + item.Value.ToString(),(item.Selected ? new { Checked = "" } : null)));
            sb.Append(htmlHelper.RadioButton("BikeType" + item.Value.ToString(), item.Value, false, "id=""BikeType""" + item.Value.ToString()));
            var span = new TagBuilder("label");
            span.Attributes.Add("for", "BikeType" + item.Value.ToString());
            span.SetInnerText(item.Text);
            sb.Append(span.ToString());
        }
        return MvcHtmlString.Create(sb.ToString());
    }
}



//<input type='radio' id='biketype1' />
//<label for='biketype1'>Road</label>